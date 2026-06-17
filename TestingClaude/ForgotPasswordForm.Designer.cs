namespace TestingClaude
{
    partial class ForgotPasswordForm
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
            this.lblTitle   = new System.Windows.Forms.Label();
            this.lblInfo    = new System.Windows.Forms.Label();
            this.lblEmail   = new System.Windows.Forms.Label();
            this.txtEmail   = new System.Windows.Forms.TextBox();
            this.btnSendOTP = new System.Windows.Forms.Button();
            this.btnBack    = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font     = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 28);
            this.lblTitle.Name     = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text     = "Forgot Password";

            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(50, 75);
            this.lblInfo.Name     = "lblInfo";
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text     = "Enter your @gmail.com address and we'll send a 6-digit reset code.";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(50, 120);
            this.lblEmail.Name     = "lblEmail";
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text     = "Gmail Address:";

            // txtEmail
            this.txtEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(185, 117);
            this.txtEmail.Name     = "txtEmail";
            this.txtEmail.Size     = new System.Drawing.Size(190, 25);
            this.txtEmail.TabIndex = 3;

            // btnSendOTP
            this.btnSendOTP.Font                  = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSendOTP.Location              = new System.Drawing.Point(105, 175);
            this.btnSendOTP.Name                  = "btnSendOTP";
            this.btnSendOTP.Size                  = new System.Drawing.Size(200, 36);
            this.btnSendOTP.TabIndex              = 4;
            this.btnSendOTP.Text                  = "Send Reset Code";
            this.btnSendOTP.UseVisualStyleBackColor = true;
            this.btnSendOTP.Click                += new System.EventHandler(this.btnSendOTP_Click);

            // btnBack
            this.btnBack.Font                  = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.Location              = new System.Drawing.Point(155, 225);
            this.btnBack.Name                  = "btnBack";
            this.btnBack.Size                  = new System.Drawing.Size(100, 26);
            this.btnBack.TabIndex              = 5;
            this.btnBack.Text                  = "Back to Login";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click                += new System.EventHandler(this.btnBack_Click);

            // ForgotPasswordForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(430, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSendOTP);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "ForgotPasswordForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Forgot Password — TestingClaude";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblInfo;
        private System.Windows.Forms.Label   lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button  btnSendOTP;
        private System.Windows.Forms.Button  btnBack;
    }
}
