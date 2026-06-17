using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private string GenerateOTP()
        {
            return new Random().Next(100000, 999999).ToString();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Only @gmail.com addresses are accepted.", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Check the email exists
                    string check = "SELECT COUNT(*) FROM users WHERE email=@email";
                    MySqlCommand chkCmd = new MySqlCommand(check, conn);
                    chkCmd.Parameters.AddWithValue("@email", email);
                    int exists = Convert.ToInt32(chkCmd.ExecuteScalar());

                    if (exists == 0)
                    {
                        MessageBox.Show("No account found with that email.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string otp = GenerateOTP();

                    // Invalidate old codes for this email
                    string invalidate = "UPDATE password_resets SET used=1 WHERE email=@email AND used=0";
                    new MySqlCommand(invalidate, conn) { Parameters = { new MySqlParameter("@email", email) } }
                        .ExecuteNonQuery();

                    // Insert new OTP
                    string insert = "INSERT INTO password_resets (email, otp_code) VALUES (@email, @otp)";
                    MySqlCommand insCmd = new MySqlCommand(insert, conn);
                    insCmd.Parameters.AddWithValue("@email", email);
                    insCmd.Parameters.AddWithValue("@otp",   otp);
                    insCmd.ExecuteNonQuery();

                    // Send email
                    EmailHelper.SendResetEmail(email, otp);

                    MessageBox.Show("A 6-digit reset code has been sent to your Gmail.", "Code Sent",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the reset form
                    new ResetPasswordForm(email).Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
