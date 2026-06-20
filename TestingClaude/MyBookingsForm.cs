using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class MyBookingsForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        private readonly int _userId;

        public MyBookingsForm(int userId, string username)
        {
            InitializeComponent();
            _userId = userId;
            lblTitle.Text = "My Bookings - " + username;
        }

        private void MyBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query =
                        "SELECT b.id AS 'ID', r.room_number AS 'Room #', r.room_type AS 'Type', " +
                        "b.check_in AS 'Check-in', b.check_out AS 'Check-out', " +
                        "b.total_price AS 'Total', b.status AS 'Status' " +
                        "FROM bookings b JOIN rooms r ON b.room_id = r.id " +
                        "WHERE b.user_id=@userId ORDER BY b.created_at DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", _userId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewBookings.DataSource = table;
                    if (dataGridViewBookings.Columns.Contains("ID"))
                        dataGridViewBookings.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewBookings.SelectedRows[0];
            int bookingId = Convert.ToInt32(row.Cells["ID"].Value);
            string status = row.Cells["Status"].Value.ToString();

            if (status == "Cancelled")
            {
                MessageBox.Show("This booking is already cancelled.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("Cancel this booking?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string update = "UPDATE bookings SET status='Cancelled' WHERE id=@id AND user_id=@userId";
                    MySqlCommand cmd = new MySqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Booking cancelled.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
