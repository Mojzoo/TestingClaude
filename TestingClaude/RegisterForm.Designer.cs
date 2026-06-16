namespace TestingClaude
{
    partial class RegisterForm
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
            this.lblEmail           = new System.Windows.Forms.Label();
            this.txtEmail           = new System.Windows.Forms.TextBox();
            this.lblPassword        = new System.Windows.Forms.Label();
            this.txtPassword        = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister        = new System.Windows.Forms.Button();
            this.btnBackToLogin     = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font     = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 25);
            this.lblTitle.Name     = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text     = "Register";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(50, 95);
            this.lblUsername.Name     = "lblUsername";
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text     = "Username:";

            // txtUsername
            this.txtUsername.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(190, 92);
            this.txtUsername.Name     = "txtUsername";
            this.txtUsername.Size     = new System.Drawing.Size(190, 25);
            this.txtUsername.TabIndex = 2;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(50, 140);
            this.lblEmail.Name     = "lblEmail";
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text     = "Email:";

            // txtEmail
            this.txtEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(190, 137);
            this.txtEmail.Name     = "txtEmail";
            this.txtEmail.Size     = new System.Drawing.Size(190, 25);
            this.txtEmail.TabIndex = 4;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(50, 185);
            this.lblPassword.Name     = "lblPassword";
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text     = "Password:";

            // txtPassword
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location     = new System.Drawing.Point(190, 182);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size         = new System.Drawing.Size(190, 25);
            this.txtPassword.TabIndex     = 6;

            // lblConfirmPassword
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(50, 230);
            this.lblConfirmPassword.Name     = "lblConfirmPassword";
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text     = "Confirm Password:";

            // txtConfirmPassword
            this.txtConfirmPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location     = new System.Drawing.Point(190, 227);
            this.txtConfirmPassword.Name         = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size         = new System.Drawing.Size(190, 25);
            this.txtConfirmPassword.TabIndex     = 8;

            // btnRegister
            this.btnRegister.Font                  = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location              = new System.Drawing.Point(120, 282);
            this.btnRegister.Name                  = "btnRegister";
            this.btnRegister.Size                  = new System.Drawing.Size(160, 36);
            this.btnRegister.TabIndex              = 9;
            this.btnRegister.Text                  = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click                += new System.EventHandler(this.btnRegister_Click);

            // btnBackToLogin
            this.btnBackToLogin.Font                  = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackToLogin.Location              = new System.Drawing.Point(120, 332);
            this.btnBackToLogin.Name                  = "btnBackToLogin";
            this.btnBackToLogin.Size                  = new System.Drawing.Size(160, 28);
            this.btnBackToLogin.TabIndex              = 10;
            this.btnBackToLogin.Text                  = "Back to Login";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click                += new System.EventHandler(this.btnBackToLogin_Click);

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(430, 390);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBackToLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "RegisterForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Register — TestingClaude";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label   lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label   lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label   lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button  btnRegister;
        private System.Windows.Forms.Button  btnBackToLogin;
    }
}
