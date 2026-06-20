using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class RoomBrowseForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        private readonly int _userId;
        private readonly string _username;

        public RoomBrowseForm(int userId, string username)
        {
            InitializeComponent();
            _userId = userId;
            _username = username;
            lblWelcome.Text = "Welcome, " + username + "!";
        }

        private void RoomBrowseForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id AS 'ID', room_number AS 'Room #', room_type AS 'Type', " +
                                   "description AS 'Description', price_per_night AS 'Price/Night', " +
                                   "capacity AS 'Capacity' FROM rooms WHERE is_available = 1 ORDER BY room_number";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewRooms.DataSource = table;
                    if (dataGridViewRooms.Columns.Contains("ID"))
                        dataGridViewRooms.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewRooms.SelectedRows[0];
            int roomId = Convert.ToInt32(row.Cells["ID"].Value);
            string roomNumber = row.Cells["Room #"].Value.ToString();
            string roomType = row.Cells["Type"].Value.ToString();
            decimal pricePerNight = Convert.ToDecimal(row.Cells["Price/Night"].Value);

            BookRoomForm bookForm = new BookRoomForm(_userId, roomId, roomNumber, roomType, pricePerNight);
            bookForm.ShowDialog();
            LoadRooms();
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            new MyBookingsForm(_userId, _username).ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
