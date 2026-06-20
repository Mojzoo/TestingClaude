using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class AdminDashboardForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public AdminDashboardForm(int userId, string username)
        {
            InitializeComponent();
            lblWelcome.Text = "Admin: " + username;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadAllBookings();
            LoadRooms();
        }

        // ---------- Bookings Tab ----------
        private void LoadAllBookings()
        {
            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query =
                        "SELECT b.id AS 'ID', u.username AS 'User', r.room_number AS 'Room #', " +
                        "b.check_in AS 'Check-in', b.check_out AS 'Check-out', " +
                        "b.total_price AS 'Total', b.status AS 'Status' " +
                        "FROM bookings b " +
                        "JOIN users u ON b.user_id = u.id " +
                        "JOIN rooms r ON b.room_id = r.id " +
                        "ORDER BY b.created_at DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewAllBookings.DataSource = table;
                    if (dataGridViewAllBookings.Columns.Contains("ID"))
                        dataGridViewAllBookings.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAnyBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingId = Convert.ToInt32(dataGridViewAllBookings.SelectedRows[0].Cells["ID"].Value);

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string update = "UPDATE bookings SET status='Cancelled' WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Booking cancelled.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshBookings_Click(object sender, EventArgs e)
        {
            LoadAllBookings();
        }

        // ---------- Rooms Tab ----------
        private void LoadRooms()
        {
            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query =
                        "SELECT id AS 'ID', room_number AS 'Room #', room_type AS 'Type', " +
                        "description AS 'Description', price_per_night AS 'Price/Night', " +
                        "capacity AS 'Capacity', is_available AS 'Available' FROM rooms ORDER BY room_number";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewRoomsAdmin.DataSource = table;
                    if (dataGridViewRoomsAdmin.Columns.Contains("ID"))
                        dataGridViewRoomsAdmin.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text.Trim();
            string roomType = txtRoomType.Text.Trim();
            string description = txtDescription.Text.Trim();

            decimal price;
            int capacity;
            bool priceOk = decimal.TryParse(txtPrice.Text.Trim(), out price);
            bool capacityOk = int.TryParse(txtCapacity.Text.Trim(), out capacity);

            if (string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(roomType) || !priceOk || !capacityOk)
            {
                MessageBox.Show("Please fill in all room fields correctly.\n(Price and Capacity must be numbers.)",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string insert = "INSERT INTO rooms (room_number, room_type, description, price_per_night, capacity) " +
                                     "VALUES (@roomNumber, @roomType, @description, @price, @capacity)";
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Room added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRoomNumber.Clear();
                txtRoomType.Clear();
                txtDescription.Clear();
                txtPrice.Clear();
                txtCapacity.Clear();
                LoadRooms();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("A room with that number already exists.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoomsAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = Convert.ToInt32(dataGridViewRoomsAdmin.SelectedRows[0].Cells["ID"].Value);

            DialogResult confirm = MessageBox.Show("Delete this room? This cannot be undone.", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string delete = "DELETE FROM rooms WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@id", roomId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Room deleted.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
