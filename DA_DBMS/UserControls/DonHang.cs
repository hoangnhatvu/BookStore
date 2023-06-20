using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace DA_DBMS.UserControls
{
    public partial class DonHang : UserControl
    {
        public static string email;
        CultureInfo culture = new CultureInfo("vi-VN");
        public DonHang()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();

        private void DonHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = db.Thongtindathang(email);
            lbTen.DataBindings.Add("Text", dgvKH.DataSource, "TenKH");
            lbSdt.DataBindings.Add("Text", dgvKH.DataSource, "SDT");
            lbEmail.DataBindings.Add("Text", dgvKH.DataSource, "Email");
            lbDiachi.DataBindings.Add("Text", dgvKH.DataSource, "DiaChi");
            lbTongtien.Text =Convert.ToDouble( db.Tongtien(db.getmakh(email))).ToString("c",culture);
            DateTime dat = DateTime.Now;
            lbNgaydat.Text = dat.ToString();
            lbNgaygiao.Text = db.getngaygiao(dat).ToString();
            dgvDonhang.DataSource = db.GioHangtable(db.getmakh(email));
        }

        private void BtnThanhtoan_Click(object sender, EventArgs e)
        {
            if (db.CheckGiohang() == 0) MessageBox.Show("Bạn chưa thêm SP vào giỏ hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    db.Taodonhang(db.getmakh(email), db.Tongtien(db.getmakh(email)), Convert.ToDateTime(lbNgaydat.Text), Convert.ToDateTime(lbNgaygiao.Text));
                    MessageBox.Show("Đặt hàng thành công!", "Thông báo!");
                    btnThanhtoan.Enabled = false;
                    db.ResertGiohang(email);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            lbTongtien.Text = Convert.ToDouble(db.Tongtien(db.getmakh(email))).ToString("c", culture);
            DateTime dat = DateTime.Now;
            lbNgaydat.Text = dat.ToString();
            lbNgaygiao.Text = db.getngaygiao(dat).ToString();
            dgvDonhang.DataSource = db.GioHangtable(db.getmakh(email));
            btnThanhtoan.Enabled = true;
        }
    }
}
