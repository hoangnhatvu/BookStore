namespace DA_DBMS.UserControls
{
    partial class MyDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyDH = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTinhtrang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbngaydat = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbMadh = new System.Windows.Forms.Label();
            this.dgvLSdonhang = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSdonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnHuyDH);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTinhtrang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbPhi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbngaydat);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lbMadh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 494);
            this.panel1.TabIndex = 4;
            // 
            // btnHuyDH
            // 
            this.btnHuyDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDH.Location = new System.Drawing.Point(932, 397);
            this.btnHuyDH.Name = "btnHuyDH";
            this.btnHuyDH.Size = new System.Drawing.Size(224, 68);
            this.btnHuyDH.TabIndex = 60;
            this.btnHuyDH.Text = "Hủy đơn hàng";
            this.btnHuyDH.UseVisualStyleBackColor = true;
            this.btnHuyDH.Click += new System.EventHandler(this.BtnHuyDH_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = global::DA_DBMS.Properties.Resources.refresh;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(27, 16);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(67, 67);
            this.btnReload.TabIndex = 59;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(66, 380);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 25);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Xem Chi tiết...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 32);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tình trạng Đơn hàng:";
            // 
            // lbTinhtrang
            // 
            this.lbTinhtrang.AutoSize = true;
            this.lbTinhtrang.BackColor = System.Drawing.Color.Transparent;
            this.lbTinhtrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhtrang.Location = new System.Drawing.Point(844, 240);
            this.lbTinhtrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTinhtrang.Name = "lbTinhtrang";
            this.lbTinhtrang.Size = new System.Drawing.Size(134, 32);
            this.lbTinhtrang.TabIndex = 52;
            this.lbTinhtrang.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Phí giao dịch:";
            // 
            // lbPhi
            // 
            this.lbPhi.AutoSize = true;
            this.lbPhi.BackColor = System.Drawing.Color.Transparent;
            this.lbPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhi.Location = new System.Drawing.Point(254, 240);
            this.lbPhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhi.Name = "lbPhi";
            this.lbPhi.Size = new System.Drawing.Size(51, 32);
            this.lbPhi.TabIndex = 50;
            this.lbPhi.Text = "Phí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngày đặt hàng:";
            // 
            // lbngaydat
            // 
            this.lbngaydat.AutoSize = true;
            this.lbngaydat.BackColor = System.Drawing.Color.Transparent;
            this.lbngaydat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaydat.Location = new System.Drawing.Point(844, 106);
            this.lbngaydat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbngaydat.Name = "lbngaydat";
            this.lbngaydat.Size = new System.Drawing.Size(119, 32);
            this.lbngaydat.TabIndex = 48;
            this.lbngaydat.Text = "Ngày đặt";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(64, 106);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(167, 32);
            this.label.TabIndex = 47;
            this.label.Text = "Mã Đơn hàng:";
            // 
            // lbMadh
            // 
            this.lbMadh.AutoSize = true;
            this.lbMadh.BackColor = System.Drawing.Color.Transparent;
            this.lbMadh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMadh.Location = new System.Drawing.Point(254, 106);
            this.lbMadh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMadh.Name = "lbMadh";
            this.lbMadh.Size = new System.Drawing.Size(94, 32);
            this.lbMadh.TabIndex = 46;
            this.lbMadh.Text = "Mã ĐH";
            // 
            // dgvLSdonhang
            // 
            this.dgvLSdonhang.AllowUserToAddRows = false;
            this.dgvLSdonhang.AllowUserToResizeRows = false;
            this.dgvLSdonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSdonhang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLSdonhang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLSdonhang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLSdonhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLSdonhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLSdonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLSdonhang.ColumnHeadersHeight = 39;
            this.dgvLSdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLSdonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.PhiGiaoDich,
            this.NgayDat,
            this.TinhTrangDH});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLSdonhang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLSdonhang.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLSdonhang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvLSdonhang.Location = new System.Drawing.Point(3, 526);
            this.dgvLSdonhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLSdonhang.Name = "dgvLSdonhang";
            this.dgvLSdonhang.ReadOnly = true;
            this.dgvLSdonhang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLSdonhang.RowHeadersVisible = false;
            this.dgvLSdonhang.RowHeadersWidth = 51;
            this.dgvLSdonhang.RowTemplate.Height = 24;
            this.dgvLSdonhang.RowTemplate.ReadOnly = true;
            this.dgvLSdonhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLSdonhang.Size = new System.Drawing.Size(1177, 368);
            this.dgvLSdonhang.TabIndex = 60;
            this.dgvLSdonhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLSdonhang_CellContentClick);
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã ĐH";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            // 
            // PhiGiaoDich
            // 
            this.PhiGiaoDich.DataPropertyName = "PhiGiaoDich";
            this.PhiGiaoDich.HeaderText = "Phí giao dịch";
            this.PhiGiaoDich.MinimumWidth = 6;
            this.PhiGiaoDich.Name = "PhiGiaoDich";
            this.PhiGiaoDich.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // TinhTrangDH
            // 
            this.TinhTrangDH.DataPropertyName = "TinhTrangDH";
            this.TinhTrangDH.HeaderText = "Tình trạng";
            this.TinhTrangDH.MinimumWidth = 6;
            this.TinhTrangDH.Name = "TinhTrangDH";
            this.TinhTrangDH.ReadOnly = true;
            // 
            // MyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLSdonhang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyDonHang";
            this.Size = new System.Drawing.Size(1190, 923);
            this.Load += new System.EventHandler(this.MyDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSdonhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbMadh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTinhtrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbngaydat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvLSdonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangDH;
        private System.Windows.Forms.Button btnHuyDH;
    }
}
