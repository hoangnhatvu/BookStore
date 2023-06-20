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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
  
        DataConnDataContext DB = new DataConnDataContext();      
        private void LblDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
            this.Close();
        }
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtMatKhau.Text == "") errorProvider1.SetError(txtEmail, "Bạn không được để trống!");
            else
            {
                if (DB.Logins(txtEmail.Text, txtMatKhau.Text) == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo!");
                    this.Hide();
                    if (DB.GetQuyen(txtEmail.Text) == 0)
                    {
                        UserControls.Profile.email = txtEmail.Text;
                        frmChitietsanpham.email = txtEmail.Text;
                        UserControls.Cart.email = txtEmail.Text;
                        UserControls.DonHang.email = txtEmail.Text;
                        UserControls.MyDonHang.email = txtEmail.Text;
                        Chitiet.email = txtEmail.Text;
                        FrmNguoiDung frm = new FrmNguoiDung();
                        frm.ShowDialog();
                    }
                    else
                    {
                        FrmAdmin frm = new FrmAdmin();
                        frm.ShowDialog();
                    }
                    this.Close();
                }
                else MessageBox.Show("Sai Email hoặc Mật khẩu!", "Thông báo!");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
