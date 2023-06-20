using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DBMS
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();

        private void BtnDangky_Click_1(object sender, EventArgs e)
        {
            if (txtHoten.Text == "") errorProvider1.SetError(txtHoten, "Không được để trống!");
            if (txtTaikhoan.Text == "") errorProvider1.SetError(txtTaikhoan, "Không được để trống!");
            if (txtEmail.Text == "") errorProvider1.SetError(txtEmail, "Không được để trống!");
            if (txtSdt.Text == "") errorProvider1.SetError(txtSdt, "Không được để trống!");
            if (txtMK.Text == "") errorProvider1.SetError(txtMK, "Không được để trống!");
            else
            {
                if (db.DangKy(txtEmail.Text,txtSdt.Text, txtMK.Text, txtConfirm.Text) == 1)
                {
                    db.DangKyTK(txtHoten.Text, txtTaikhoan.Text, txtEmail.Text, txtMK.Text, txtConfirm.Text, txtDiachi.Text, txtSdt.Text, txtGioitinh.Text, dtpNgaysinh.Value);
                    MessageBox.Show("Đăng kí thành công!", "Thông báo!");
                }
                if (db.DangKy(txtEmail.Text, txtSdt.Text, txtMK.Text, txtConfirm.Text) == 2)
                {
                    errorProvider1.SetError(txtConfirm, "Mật khẩu không trùng khớp!");
                }
                if (db.DangKy(txtEmail.Text, txtSdt.Text, txtMK.Text, txtConfirm.Text) == 0)
                {
                    errorProvider1.SetError(txtEmail, "Email hoặc SĐT đã tồn tại!");
                }
            }
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }
    }
}
