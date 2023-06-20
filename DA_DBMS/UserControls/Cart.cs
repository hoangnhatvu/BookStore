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

namespace DA_DBMS.UserControls
{
    public partial class Cart : UserControl
    {
        public static string email;
        public Cart()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
     
        public void Cart_Load(object sender, EventArgs e)
        {
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTien.Text = Convert.ToDouble(db.Tongtien(db.getmakh(email))).ToString("c", culture);
        }

        private void DgvGiohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbSach.Text = dgvGiohang.CurrentRow.Cells[1].Value.ToString();
            lbDongia.Text = dgvGiohang.CurrentRow.Cells[2].Value.ToString();
            txtSoluong.Text = dgvGiohang.CurrentRow.Cells[3].Value.ToString();
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTien.Text = Convert.ToDouble(db.Tongtien(db.getmakh(email))).ToString("c", culture);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            db.Xoaspkhoicart(Convert.ToInt32(dgvGiohang.CurrentRow.Cells[0].Value.ToString()), db.getmakh(email));
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTien.Text = Convert.ToDouble(db.Tongtien(db.getmakh(email))).ToString("c", culture);
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGiohang.SelectedRows.Count == 1)
            {
                db.Updatesoluong(email, Convert.ToInt32(dgvGiohang.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(txtSoluong.Text));
                CultureInfo culture = new CultureInfo("vi-VN");
                txtTien.Text = Convert.ToDouble(db.Tongtien(db.getmakh(email))).ToString("c", culture);
                dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm nào trong giỏ hàng!", "Thông báo");
            }
        }
    }
}
