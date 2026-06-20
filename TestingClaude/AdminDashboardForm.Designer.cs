namespace TestingClaude
{
    partial class AdminDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.dataGridViewAllBookings = new System.Windows.Forms.DataGridView();
            this.btnCancelAnyBooking = new System.Windows.Forms.Button();
            this.btnRefreshBookings = new System.Windows.Forms.Button();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.dataGridViewRoomsAdmin = new System.Windows.Forms.DataGridView();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.tabRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomsAdmin)).BeginInit();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Admin Dashboard";

            // btnLogout
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.Location = new System.Drawing.Point(650, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // tabControl
            this.tabControl.Controls.Add(this.tabBookings);
            this.tabControl.Controls.Add(this.tabRooms);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(740, 470);
            this.tabControl.TabIndex = 2;

            // tabBookings
            this.tabBookings.Controls.Add(this.dataGridViewAllBookings);
            this.tabBookings.Controls.Add(this.btnCancelAnyBooking);
            this.tabBookings.Controls.Add(this.btnRefreshBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 24);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(10);
            this.tabBookings.Size = new System.Drawing.Size(732, 442);
            this.tabBookings.TabIndex = 0;
            this.tabBookings.Text = "All Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;

            // dataGridViewAllBookings
            this.dataGridViewAllBookings.AllowUserToAddRows = false;
            this.dataGridViewAllBookings.AllowUserToDeleteRows = false;
            this.dataGridViewAllBookings.ReadOnly = true;
            this.dataGridViewAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllBookings.MultiSelect = false;
            this.dataGridViewAllBookings.RowHeadersVisible = false;
            this.dataGridViewAllBookings.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewAllBookings.Name = "dataGridViewAllBookings";
            this.dataGridViewAllBookings.Size = new System.Drawing.Size(700, 360);
            this.dataGridViewAllBookings.TabIndex = 0;
            this.dataGridViewAllBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnCancelAnyBooking
            this.btnCancelAnyBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelAnyBooking.Location = new System.Drawing.Point(15, 390);
            this.btnCancelAnyBooking.Name = "btnCancelAnyBooking";
            this.btnCancelAnyBooking.Size = new System.Drawing.Size(160, 36);
            this.btnCancelAnyBooking.TabIndex = 1;
            this.btnCancelAnyBooking.Text = "Cancel Booking";
            this.btnCancelAnyBooking.UseVisualStyleBackColor = true;
            this.btnCancelAnyBooking.Click += new System.EventHandler(this.btnCancelAnyBooking_Click);

            // btnRefreshBookings
            this.btnRefreshBookings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshBookings.Location = new System.Drawing.Point(595, 390);
            this.btnRefreshBookings.Name = "btnRefreshBookings";
            this.btnRefreshBookings.Size = new System.Drawing.Size(120, 32);
            this.btnRefreshBookings.TabIndex = 2;
            this.btnRefreshBookings.Text = "Refresh";
            this.btnRefreshBookings.UseVisualStyleBackColor = true;
            this.btnRefreshBookings.Click += new System.EventHandler(this.btnRefreshBookings_Click);

            // tabRooms
            this.tabRooms.Controls.Add(this.dataGridViewRoomsAdmin);
            this.tabRooms.Controls.Add(this.lblRoomNumber);
            this.tabRooms.Controls.Add(this.txtRoomNumber);
            this.tabRooms.Controls.Add(this.lblRoomType);
            this.tabRooms.Controls.Add(this.txtRoomType);
            this.tabRooms.Controls.Add(this.lblPrice);
            this.tabRooms.Controls.Add(this.txtPrice);
            this.tabRooms.Controls.Add(this.lblCapacity);
            this.tabRooms.Controls.Add(this.txtCapacity);
            this.tabRooms.Controls.Add(this.lblDescription);
            this.tabRooms.Controls.Add(this.txtDescription);
            this.tabRooms.Controls.Add(this.btnAddRoom);
            this.tabRooms.Controls.Add(this.btnDeleteRoom);
            this.tabRooms.Location = new System.Drawing.Point(4, 24);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(10);
            this.tabRooms.Size = new System.Drawing.Size(732, 442);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "Manage Rooms";
            this.tabRooms.UseVisualStyleBackColor = true;

            // dataGridViewRoomsAdmin
            this.dataGridViewRoomsAdmin.AllowUserToAddRows = false;
            this.dataGridViewRoomsAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewRoomsAdmin.ReadOnly = true;
            this.dataGridViewRoomsAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomsAdmin.MultiSelect = false;
            this.dataGridViewRoomsAdmin.RowHeadersVisible = false;
            this.dataGridViewRoomsAdmin.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewRoomsAdmin.Name = "dataGridViewRoomsAdmin";
            this.dataGridViewRoomsAdmin.Size = new System.Drawing.Size(700, 230);
            this.dataGridViewRoomsAdmin.TabIndex = 0;
            this.dataGridViewRoomsAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // lblRoomNumber
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomNumber.Location = new System.Drawing.Point(15, 260);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.TabIndex = 1;
            this.lblRoomNumber.Text = "Room #:";

            // txtRoomNumber
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomNumber.Location = new System.Drawing.Point(85, 257);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(90, 23);
            this.txtRoomNumber.TabIndex = 2;

            // lblRoomType
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomType.Location = new System.Drawing.Point(195, 260);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "Type:";

            // txtRoomType
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomType.Location = new System.Drawing.Point(245, 257);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(110, 23);
            this.txtRoomType.TabIndex = 4;

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.Location = new System.Drawing.Point(375, 260);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price/Night:";

            // txtPrice
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(460, 257);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 23);
            this.txtPrice.TabIndex = 6;

            // lblCapacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCapacity.Location = new System.Drawing.Point(550, 260);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.TabIndex = 7;
            this.lblCapacity.Text = "Capacity:";

            // txtCapacity
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCapacity.Location = new System.Drawing.Point(625, 257);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(50, 23);
            this.txtCapacity.TabIndex = 8;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.Location = new System.Drawing.Point(15, 295);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";

            // txtDescription
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(105, 292);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 23);
            this.txtDescription.TabIndex = 10;

            // btnAddRoom
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.Location = new System.Drawing.Point(15, 335);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(140, 32);
            this.btnAddRoom.TabIndex = 11;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);

            // btnDeleteRoom
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRoom.Location = new System.Drawing.Point(165, 335);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(140, 32);
            this.btnDeleteRoom.TabIndex = 12;
            this.btnDeleteRoom.Text = "Delete Selected";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);

            // AdminDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 550);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - TestingClaude";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);

            this.tabBookings.ResumeLayout(false);
            this.tabRooms.ResumeLayout(false);
            this.tabRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomsAdmin)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.DataGridView dataGridViewAllBookings;
        private System.Windows.Forms.Button btnCancelAnyBooking;
        private System.Windows.Forms.Button btnRefreshBookings;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.DataGridView dataGridViewRoomsAdmin;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
    }
}
