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
    public partial class FrmNguoiDung : Form
    {
        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        private void BtnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Đăng xuất khỏi tài khoản?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            this.myDonHang1.Hide();
            this.donHang1.Hide();
            this.store1.Hide();
            this.cart1.Hide();
            this.profile1.Show();
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            this.myDonHang1.Hide();
            this.donHang1.Hide();
            this.store1.Show();
            this.cart1.Hide();
            this.profile1.Hide();
        }

        private void BtnGioHang_Click(object sender, EventArgs e)
        {
            this.myDonHang1.Hide();
            this.donHang1.Hide();
            this.store1.Hide();
            this.cart1.Show();
            this.profile1.Hide();
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            this.myDonHang1.Hide();
            this.donHang1.Show();
            this.store1.Hide();
            this.cart1.Hide();
            this.profile1.Hide();
        }


        private void BtnDonHang_Click(object sender, EventArgs e)
        {
            this.myDonHang1.Show();
            this.donHang1.Hide();
            this.store1.Hide();
            this.cart1.Hide();
            this.profile1.Hide();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
