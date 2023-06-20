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
    public partial class frmDoiMatKhau : Form
    {
        public static string email= UserControls.Profile.email;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();         

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
        }

        private void BtnDoiMK_Click_1(object sender, EventArgs e)
        {
            if (txtMKmoi.Text == "") errorProvider1.SetError(txtMKmoi, "Chưa nhập mật khẩu!");
            else
            {
                if (db.DoiMK(txtEmail.Text, txtMKcu.Text, txtMKmoi.Text, txtConfirm.Text) == 1)
                {
                    db.UpdateMK(txtEmail.Text, txtMKcu.Text, txtMKmoi.Text, txtConfirm.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!");
                }
                if (db.DoiMK(txtEmail.Text, txtMKcu.Text, txtMKmoi.Text, txtConfirm.Text) == 2) errorProvider1.SetError(txtConfirm, "Mật khẩu không trùng khớp!");
                if (db.DoiMK(txtEmail.Text, txtMKcu.Text, txtMKmoi.Text, txtConfirm.Text) == 3) errorProvider1.SetError(txtEmail, "Sai Email hoặc mật khẩu!");
                if (db.DoiMK(txtEmail.Text, txtMKcu.Text, txtMKmoi.Text, txtConfirm.Text) == 0) errorProvider1.SetError(txtEmail, "Tài khoản không tồn tại!");
            }
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
