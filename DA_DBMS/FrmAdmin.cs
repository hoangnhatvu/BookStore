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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            this.thongKe1.Hide();
            this.manager_NXB1.Hide();
            this.manager_NCC1.Hide();
            this.manager_TacGia1.Hide();
            this.managerSanPham1.Hide();
            this.managerKhachHang1.Show();
            this.manager_DonHang1.Hide();
        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            this.thongKe1.Hide();
            this.manager_NXB1.Hide();
            this.manager_NCC1.Hide();
            this.manager_TacGia1.Hide();
            this.managerSanPham1.Show();
            this.managerKhachHang1.Hide();
            this.manager_DonHang1.Hide();
        }

        private void BtnDonHang_Click(object sender, EventArgs e)
        {
            this.thongKe1.Hide();
            this.manager_NXB1.Hide();
            this.manager_NCC1.Hide();
            this.manager_TacGia1.Hide();
            this.managerSanPham1.Hide();
            this.managerKhachHang1.Hide();
            this.manager_DonHang1.Show();
        }

        private void BtnNCC_Click(object sender, EventArgs e)
        {
            this.thongKe1.Hide();
            this.manager_NXB1.Hide();
            this.manager_NCC1.Show();
            this.manager_TacGia1.Hide();
            this.managerSanPham1.Hide();
            this.managerKhachHang1.Hide();
            this.manager_DonHang1.Hide();
        }

        private void BtnTacGia_Click(object sender, EventArgs e)
        {
            this.thongKe1.Hide();
            this.manager_NXB1.Hide();
            this.manager_NCC1.Hide();
            this.manager_TacGia1.Show();
            this.managerSanPham1.Hide();
            this.managerKhachHang1.Hide();
            this.manager_DonHang1.Hide();
        }

        private void BtnNXB_Click(object sender, EventArgs e)
        {
            this.thongKe1.Hide();
            this.manager_NXB1.Show();
            this.manager_NCC1.Hide();
            this.manager_TacGia1.Hide();
            this.managerSanPham1.Hide();
            this.managerKhachHang1.Hide();
            this.manager_DonHang1.Hide();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
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


        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            this.thongKe1.Show();
            this.manager_NXB1.Hide();
            this.manager_NCC1.Hide();
            this.manager_TacGia1.Hide();
            this.managerSanPham1.Hide();
            this.managerKhachHang1.Hide();
            this.manager_DonHang1.Hide();  
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
