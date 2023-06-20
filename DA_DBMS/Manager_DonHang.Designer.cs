namespace DA_DBMS
{
    partial class Manager_DonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMadh = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.GroupBox();
            this.cbbTinhtrang = new System.Windows.Forms.ComboBox();
            this.txtNgaydat = new System.Windows.Forms.TextBox();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonhang = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.txt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Location = new System.Drawing.Point(567, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 82);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(6, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 64);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(6, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 64);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // txtMadh
            // 
            this.txtMadh.Location = new System.Drawing.Point(6, 367);
            this.txtMadh.Name = "txtMadh";
            this.txtMadh.Size = new System.Drawing.Size(10, 20);
            this.txtMadh.TabIndex = 50;
            this.txtMadh.Visible = false;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt.Controls.Add(this.cbbTinhtrang);
            this.txt.Controls.Add(this.txtNgaydat);
            this.txt.Controls.Add(this.txtPhi);
            this.txt.Controls.Add(this.txtTenKH);
            this.txt.Controls.Add(this.groupBox1);
            this.txt.Controls.Add(this.txtMadh);
            this.txt.Controls.Add(this.label4);
            this.txt.Controls.Add(this.label3);
            this.txt.Controls.Add(this.label2);
            this.txt.Controls.Add(this.label1);
            this.txt.Location = new System.Drawing.Point(14, 14);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(816, 286);
            this.txt.TabIndex = 53;
            this.txt.TabStop = false;
            this.txt.Text = "Thông tin Đơn hàng";
            // 
            // cbbTinhtrang
            // 
            this.cbbTinhtrang.Enabled = false;
            this.cbbTinhtrang.FormattingEnabled = true;
            this.cbbTinhtrang.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbbTinhtrang.Location = new System.Drawing.Point(557, 49);
            this.cbbTinhtrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTinhtrang.Name = "cbbTinhtrang";
            this.cbbTinhtrang.Size = new System.Drawing.Size(147, 21);
            this.cbbTinhtrang.TabIndex = 58;
            // 
            // txtNgaydat
            // 
            this.txtNgaydat.Enabled = false;
            this.txtNgaydat.Location = new System.Drawing.Point(108, 230);
            this.txtNgaydat.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgaydat.Name = "txtNgaydat";
            this.txtNgaydat.Size = new System.Drawing.Size(257, 20);
            this.txtNgaydat.TabIndex = 57;
            // 
            // txtPhi
            // 
            this.txtPhi.Enabled = false;
            this.txtPhi.Location = new System.Drawing.Point(108, 141);
            this.txtPhi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(257, 20);
            this.txtPhi.TabIndex = 56;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(108, 46);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(257, 20);
            this.txtTenKH.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Đặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phí Giao Dịch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ Tên KH:";
            // 
            // dgvDonhang
            // 
            this.dgvDonhang.AllowUserToAddRows = false;
            this.dgvDonhang.AllowUserToResizeRows = false;
            this.dgvDonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonhang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDonhang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDonhang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDonhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDonhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonhang.ColumnHeadersHeight = 39;
            this.dgvDonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.MaKH,
            this.PhiGiaoDich,
            this.TinhTrangDH,
            this.NgayDat,
            this.NgayGiao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonhang.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDonhang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDonhang.Location = new System.Drawing.Point(14, 306);
            this.dgvDonhang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDonhang.Name = "dgvDonhang";
            this.dgvDonhang.ReadOnly = true;
            this.dgvDonhang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonhang.RowHeadersVisible = false;
            this.dgvDonhang.RowHeadersWidth = 51;
            this.dgvDonhang.RowTemplate.Height = 24;
            this.dgvDonhang.RowTemplate.ReadOnly = true;
            this.dgvDonhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonhang.Size = new System.Drawing.Size(816, 182);
            this.dgvDonhang.TabIndex = 54;
            this.dgvDonhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonhang_CellClick);
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã ĐH";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // PhiGiaoDich
            // 
            this.PhiGiaoDich.DataPropertyName = "PhiGiaoDich";
            this.PhiGiaoDich.HeaderText = "Phí giao dịch";
            this.PhiGiaoDich.MinimumWidth = 6;
            this.PhiGiaoDich.Name = "PhiGiaoDich";
            this.PhiGiaoDich.ReadOnly = true;
            // 
            // TinhTrangDH
            // 
            this.TinhTrangDH.DataPropertyName = "TinhTrangDH";
            this.TinhTrangDH.HeaderText = "Tình trạng ĐH";
            this.TinhTrangDH.MinimumWidth = 6;
            this.TinhTrangDH.Name = "TinhTrangDH";
            this.TinhTrangDH.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // NgayGiao
            // 
            this.NgayGiao.DataPropertyName = "NgayGiao";
            this.NgayGiao.HeaderText = "Ngày Giao";
            this.NgayGiao.MinimumWidth = 6;
            this.NgayGiao.Name = "NgayGiao";
            this.NgayGiao.ReadOnly = true;
            // 
            // Manager_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.dgvDonhang);
            this.Controls.Add(this.txt);
            this.Name = "Manager_DonHang";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.Manager_DonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.txt.ResumeLayout(false);
            this.txt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMadh;
        private System.Windows.Forms.GroupBox txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.ComboBox cbbTinhtrang;
        private System.Windows.Forms.TextBox txtNgaydat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnEdit;
    }
}
