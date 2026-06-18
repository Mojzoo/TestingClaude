namespace TestingClaude
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle           = new System.Windows.Forms.Label();
            this.lblUsername        = new System.Windows.Forms.Label();
            this.txtUsername        = new System.Windows.Forms.TextBox();
            this.lblPassword        = new System.Windows.Forms.Label();
            this.txtPassword        = new System.Windows.Forms.TextBox();
            this.btnLogin           = new System.Windows.Forms.Button();
            this.lblNoAccount       = new System.Windows.Forms.Label();
            this.btnGoRegister      = new System.Windows.Forms.Button();
            this.btnForgotPassword  = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font     = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 28);
            this.lblTitle.Name     = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text     = "Login";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(55, 100);
            this.lblUsername.Name     = "lblUsername";
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text     = "Username:";

            this.txtUsername.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(165, 97);
            this.txtUsername.Name     = "txtUsername";
            this.txtUsername.Size     = new System.Drawing.Size(190, 25);
            this.txtUsername.TabIndex = 2;

            this.lblPassword.AutoSize = true;
            this.lblPassword.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(55, 148);
            this.lblPassword.Name     = "lblPassword";
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text     = "Password:";

            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location     = new System.Drawing.Point(165, 145);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size         = new System.Drawing.Size(190, 25);
            this.txtPassword.TabIndex     = 4;

            this.btnLogin.Font                   = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location               = new System.Drawing.Point(140, 200);
            this.btnLogin.Name                   = "btnLogin";
            this.btnLogin.Size                   = new System.Drawing.Size(130, 36);
            this.btnLogin.TabIndex               = 5;
            this.btnLogin.Text                   = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click                 += new System.EventHandler(this.btnLogin_Click);

            this.btnForgotPassword.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnForgotPassword.ForeColor              = System.Drawing.Color.SteelBlue;
            this.btnForgotPassword.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.Location               = new System.Drawing.Point(140, 245);
            this.btnForgotPassword.Name                   = "btnForgotPassword";
            this.btnForgotPassword.Size                   = new System.Drawing.Size(130, 22);
            this.btnForgotPassword.TabIndex               = 6;
            this.btnForgotPassword.Text                   = "Forgot Password?";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click                 += new System.EventHandler(this.btnForgotPassword_Click);

            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoAccount.Location = new System.Drawing.Point(55, 290);
            this.lblNoAccount.Name     = "lblNoAccount";
            this.lblNoAccount.TabIndex = 7;
            this.lblNoAccount.Text     = "Don't have an account?";

            this.btnGoRegister.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGoRegister.Location               = new System.Drawing.Point(218, 286);
            this.btnGoRegister.Name                   = "btnGoRegister";
            this.btnGoRegister.Size                   = new System.Drawing.Size(100, 26);
            this.btnGoRegister.TabIndex               = 8;
            this.btnGoRegister.Text                   = "Register";
            this.btnGoRegister.UseVisualStyleBackColor = true;
            this.btnGoRegister.Click                 += new System.EventHandler(this.btnGoRegister_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(410, 345);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.btnGoRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "LoginForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Login - TestingClaude";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label   lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button  btnLogin;
        private System.Windows.Forms.Button  btnForgotPassword;
        private System.Windows.Forms.Label   lblNoAccount;
        private System.Windows.Forms.Button  btnGoRegister;
    }
}
