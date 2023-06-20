namespace DA_DBMS
{
    partial class FrmNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.donHang1 = new DA_DBMS.UserControls.DonHang();
            this.cart1 = new DA_DBMS.UserControls.Cart();
            this.store1 = new DA_DBMS.UserControls.Store();
            this.profile1 = new DA_DBMS.UserControls.Profile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.myDonHang1 = new DA_DBMS.UserControls.MyDonHang();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // donHang1
            // 
            this.donHang1.Location = new System.Drawing.Point(315, 0);
            this.donHang1.Margin = new System.Windows.Forms.Padding(6);
            this.donHang1.Name = "donHang1";
            this.donHang1.Size = new System.Drawing.Size(1185, 922);
            this.donHang1.TabIndex = 4;
            this.donHang1.Visible = false;
            // 
            // cart1
            // 
            this.cart1.Location = new System.Drawing.Point(315, 0);
            this.cart1.Margin = new System.Windows.Forms.Padding(6);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(1185, 922);
            this.cart1.TabIndex = 3;
            this.cart1.Visible = false;
            // 
            // store1
            // 
            this.store1.Location = new System.Drawing.Point(315, 0);
            this.store1.Margin = new System.Windows.Forms.Padding(6);
            this.store1.Name = "store1";
            this.store1.Size = new System.Drawing.Size(1185, 922);
            this.store1.TabIndex = 2;
            this.store1.Visible = false;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.profile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.profile1.Location = new System.Drawing.Point(315, 0);
            this.profile1.Margin = new System.Windows.Forms.Padding(6);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(1185, 922);
            this.profile1.TabIndex = 1;
            this.profile1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDangxuat);
            this.panel2.Controls.Add(this.btnDonHang);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.btnGioHang);
            this.panel2.Controls.Add(this.btnStore);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 922);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 59);
            this.label1.TabIndex = 23;
            this.label1.Text = "Menu";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangxuat.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.Location = new System.Drawing.Point(0, 522);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(309, 82);
            this.btnDangxuat.TabIndex = 5;
            this.btnDangxuat.Text = "Đăng Xuất";
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.BtnDangxuat_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDonHang.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(0, 432);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(309, 82);
            this.btnDonHang.TabIndex = 4;
            this.btnDonHang.Text = "Đơn Hàng";
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.BtnDonHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(0, 342);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(309, 82);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGioHang.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGioHang.FlatAppearance.BorderSize = 0;
            this.btnGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(0, 252);
            this.btnGioHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(309, 82);
            this.btnGioHang.TabIndex = 2;
            this.btnGioHang.Text = "Giỏ Hàng";
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.BtnGioHang_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Location = new System.Drawing.Point(0, 162);
            this.btnStore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(309, 82);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Cửa Hàng";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 74);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(309, 82);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Cá Nhân";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(1459, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // myDonHang1
            // 
            this.myDonHang1.BackColor = System.Drawing.Color.Transparent;
            this.myDonHang1.Location = new System.Drawing.Point(324, 0);
            this.myDonHang1.Margin = new System.Windows.Forms.Padding(6);
            this.myDonHang1.Name = "myDonHang1";
            this.myDonHang1.Size = new System.Drawing.Size(1176, 907);
            this.myDonHang1.TabIndex = 17;
            this.myDonHang1.Visible = false;
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1500, 922);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.myDonHang1);
            this.Controls.Add(this.donHang1);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.store1);
            this.Controls.Add(this.profile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNguoiDung";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.DonHang donHang1;
        private UserControls.Cart cart1;
        private UserControls.Store store1;
        private UserControls.Profile profile1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label label1;
        private UserControls.MyDonHang myDonHang1;
    }
}