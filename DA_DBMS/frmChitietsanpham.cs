using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DA_DBMS
{
    public partial class frmChitietsanpham : Form
    {
        public static string email;
        public static int masach;
        public frmChitietsanpham()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void DemoChitietsanpham_Load(object sender, EventArgs e)
        {
            dgvChitiet.DataSource = db.ChitietSach(masach);
            lbTacGia.DataBindings.Add("Text", dgvChitiet.DataSource, "TenTacGia");
            lbChuDe.DataBindings.Add("Text", dgvChitiet.DataSource, "TenChuDe");
            lbTenSach.DataBindings.Add("Text", dgvChitiet.DataSource, "TenSach");
            lbMoTa.DataBindings.Add("Text", dgvChitiet.DataSource, "MoTa");
            lbNXB.DataBindings.Add("Text", dgvChitiet.DataSource, "TenNXB");
            lbGiaBan.DataBindings.Add("Text", dgvChitiet.DataSource, "GiaBan");
            if (db.CheckHethang(masach)<=20 && db.CheckHethang(masach) >0) lbTinhtrang.Text = "Sắp Hết Hàng!";
            if (db.CheckHethang(masach) == 0)
            {
                lbTinhtrang.Text = "Hết Hàng!";
                btnSave.Enabled = false;
            }
            else lbTinhtrang.Text = "Còn Hàng!";
            LoadAnh();
        }

        private void LoadAnh()
        {
            try
            {
                DataConnDataContext db = new DataConnDataContext();
                Sach sach = db.Saches.Where(a => a.MaSach == masach).FirstOrDefault();
                if (sach == null) return;
                MemoryStream stream = new MemoryStream(sach.Anh.ToArray());
                Image img = Image.FromStream(stream);
                if (img == null) return;
                pictureBox1.Image = img;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            db.ThemvaoCart(email, masach);
            DialogResult a = MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (a == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
