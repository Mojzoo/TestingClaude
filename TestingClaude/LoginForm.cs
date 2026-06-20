using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingClaude
{
    public partial class LoginForm : Form
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = HashPassword(password);

            try
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, role FROM users WHERE username=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32("id");
                            string role = reader.GetString("role");
                            reader.Close();

                            MessageBox.Show("loged in successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            if (role == "admin")
                                new AdminDashboardForm(userId, username).Show();
                            else
                                new RoomBrowseForm(userId, username).Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            new ForgotPasswordForm().Show();
            this.Hide();
        }
    }
}
