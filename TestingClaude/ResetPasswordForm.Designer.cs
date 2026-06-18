namespace TestingClaude
{
    partial class ResetPasswordForm
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
            this.lblEmailLabel      = new System.Windows.Forms.Label();
            this.lblEmailDisplay    = new System.Windows.Forms.Label();
            this.lblOTP             = new System.Windows.Forms.Label();
            this.txtOTP             = new System.Windows.Forms.TextBox();
            this.lblNewPassword     = new System.Windows.Forms.Label();
            this.txtNewPassword     = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnReset           = new System.Windows.Forms.Button();
            this.btnCancel          = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font     = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(95, 25);
            this.lblTitle.Name     = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text     = "Reset Password";

            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailLabel.Location = new System.Drawing.Point(50, 80);
            this.lblEmailLabel.Name     = "lblEmailLabel";
            this.lblEmailLabel.TabIndex = 1;
            this.lblEmailLabel.Text     = "Sending to:";

            this.lblEmailDisplay.AutoSize  = true;
            this.lblEmailDisplay.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailDisplay.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmailDisplay.Location  = new System.Drawing.Point(155, 80);
            this.lblEmailDisplay.Name      = "lblEmailDisplay";
            this.lblEmailDisplay.TabIndex  = 2;
            this.lblEmailDisplay.Text      = "";

            this.lblOTP.AutoSize = true;
            this.lblOTP.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOTP.Location = new System.Drawing.Point(50, 125);
            this.lblOTP.Name     = "lblOTP";
            this.lblOTP.TabIndex = 3;
            this.lblOTP.Text     = "Reset Code:";

            this.txtOTP.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOTP.Location  = new System.Drawing.Point(185, 122);
            this.txtOTP.Name      = "txtOTP";
            this.txtOTP.Size      = new System.Drawing.Size(190, 25);
            this.txtOTP.TabIndex  = 4;
            this.txtOTP.MaxLength = 6;

            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPassword.Location = new System.Drawing.Point(50, 170);
            this.lblNewPassword.Name     = "lblNewPassword";
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text     = "New Password:";

            this.txtNewPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location     = new System.Drawing.Point(185, 167);
            this.txtNewPassword.Name         = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size         = new System.Drawing.Size(190, 25);
            this.txtNewPassword.TabIndex     = 6;

            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(50, 215);
            this.lblConfirmPassword.Name     = "lblConfirmPassword";
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text     = "Confirm Password:";

            this.txtConfirmPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location     = new System.Drawing.Point(185, 212);
            this.txtConfirmPassword.Name         = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size         = new System.Drawing.Size(190, 25);
            this.txtConfirmPassword.TabIndex     = 8;

            this.btnReset.Font                   = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location               = new System.Drawing.Point(105, 265);
            this.btnReset.Name                   = "btnReset";
            this.btnReset.Size                   = new System.Drawing.Size(200, 36);
            this.btnReset.TabIndex               = 9;
            this.btnReset.Text                   = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click                 += new System.EventHandler(this.btnReset_Click);

            this.btnCancel.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location               = new System.Drawing.Point(155, 315);
            this.btnCancel.Name                   = "btnCancel";
            this.btnCancel.Size                   = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex               = 10;
            this.btnCancel.Text                   = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click                 += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmailLabel);
            this.Controls.Add(this.lblEmailDisplay);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "ResetPasswordForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Reset Password - TestingClaude";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblEmailLabel;
        private System.Windows.Forms.Label   lblEmailDisplay;
        private System.Windows.Forms.Label   lblOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label   lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label   lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button  btnReset;
        private System.Windows.Forms.Button  btnCancel;
    }
}
