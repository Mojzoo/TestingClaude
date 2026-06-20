using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class BookRoomForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        private readonly int _userId;
        private readonly int _roomId;
        private readonly decimal _pricePerNight;

        public BookRoomForm(int userId, int roomId, string roomNumber, string roomType, decimal pricePerNight)
        {
            InitializeComponent();
            _userId = userId;
            _roomId = roomId;
            _pricePerNight = pricePerNight;

            lblRoomInfo.Text = string.Format("Room {0} - {1} (${2:0.00}/night)", roomNumber, roomType, pricePerNight);

            dtpCheckIn.MinDate = DateTime.Today;
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.MinDate = DateTime.Today.AddDays(1);
            dtpCheckOut.Value = DateTime.Today.AddDays(1);

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            if (nights <= 0)
            {
                lblTotal.Text = "Total: invalid date range";
                return;
            }
            decimal total = nights * _pricePerNight;
            lblTotal.Text = string.Format("Total: {0} night(s) x ${1:0.00} = ${2:0.00}", nights, _pricePerNight, total);
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1);
            if (dtpCheckOut.Value <= dtpCheckIn.Value)
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            UpdateTotal();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;
            int nights = (checkOut - checkIn).Days;

            if (nights <= 0)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = nights * _pricePerNight;

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Reject overlapping confirmed bookings for the same room
                    string overlapCheck =
                        "SELECT COUNT(*) FROM bookings WHERE room_id=@roomId AND status='Confirmed' " +
                        "AND NOT (@checkOut <= check_in OR @checkIn >= check_out)";
                    MySqlCommand overlapCmd = new MySqlCommand(overlapCheck, conn);
                    overlapCmd.Parameters.AddWithValue("@roomId", _roomId);
                    overlapCmd.Parameters.AddWithValue("@checkIn", checkIn);
                    overlapCmd.Parameters.AddWithValue("@checkOut", checkOut);
                    int overlapCount = Convert.ToInt32(overlapCmd.ExecuteScalar());

                    if (overlapCount > 0)
                    {
                        MessageBox.Show("This room is already booked for the selected dates.", "Unavailable",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string insert = "INSERT INTO bookings (user_id, room_id, check_in, check_out, total_price, status) " +
                                     "VALUES (@userId, @roomId, @checkIn, @checkOut, @total, 'Confirmed')";
                    MySqlCommand insCmd = new MySqlCommand(insert, conn);
                    insCmd.Parameters.AddWithValue("@userId", _userId);
                    insCmd.Parameters.AddWithValue("@roomId", _roomId);
                    insCmd.Parameters.AddWithValue("@checkIn", checkIn);
                    insCmd.Parameters.AddWithValue("@checkOut", checkOut);
                    insCmd.Parameters.AddWithValue("@total", total);
                    insCmd.ExecuteNonQuery();

                    MessageBox.Show("Room booked successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
