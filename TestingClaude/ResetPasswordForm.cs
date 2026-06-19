 using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class ResetPasswordForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        private readonly string         _email;

        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            _email = email;
            lblEmailDisplay.Text = email;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string otp             = txtOTP.Text.Trim();
            string newPassword     = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(otp) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Validate OTP (must be unused and within 10 minutes)
                    string validate =
                        "SELECT id FROM password_resets " +
                        "WHERE email=@email AND otp_code=@otp AND used=0 " +
                        "AND created_at >= DATE_SUB(NOW(), INTERVAL 10 MINUTE)";
                    MySqlCommand valCmd = new MySqlCommand(validate, conn);
                    valCmd.Parameters.AddWithValue("@email", _email);
                    valCmd.Parameters.AddWithValue("@otp",   otp);

                    object result = valCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Invalid or expired code. Please request a new one.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int resetId = Convert.ToInt32(result);

                    // Update the password
                    string updatePw = "UPDATE users SET password=@password WHERE email=@email";
                    MySqlCommand updCmd = new MySqlCommand(updatePw, conn);
                    updCmd.Parameters.AddWithValue("@password", HashPassword(newPassword));
                    updCmd.Parameters.AddWithValue("@email",    _email);
                    updCmd.ExecuteNonQuery();

                    // Mark OTP as used
                    string markUsed = "UPDATE password_resets SET used=1 WHERE id=@id";
                    MySqlCommand markCmd = new MySqlCommand(markUsed, conn);
                    markCmd.Parameters.AddWithValue("@id", resetId);
                    markCmd.ExecuteNonQuery();

                    MessageBox.Show("Password reset successfully! Please log in.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new LoginForm().Show();
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
            new LoginForm().Show();
            this.Close();
        }
    }
}
