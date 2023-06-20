using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DBMS.UserControls
{
    public partial class ManagerKhachHang : UserControl
    {
        public ManagerKhachHang()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void ManagerKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = db.KhachHangtable();
            btnLuu.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") dgvKH.DataSource = db.KhachHangtable();
            else dgvKH.DataSource = db.Search_KH(txtSearch.Text);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            db.Capquyen(Convert.ToInt32(txtMaKH.Text), db.ConvertQuyen(cbbQuyen.Text.ToString()));
            DialogResult a = MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (a == DialogResult.OK)
            {
                cbbQuyen.Enabled = false;
                btnLuu.Visible = false;
            }
            dgvKH.DataSource = db.KhachHangtable();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xóa Khách hàng này!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                btnLuu.Visible = false;
                cbbQuyen.Enabled = false;
                db.Xoa_KH(Convert.ToInt32(txtMaKH.Text));
                dgvKH.DataSource = db.KhachHangtable();
            }
        }

        private void DgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbQuyen.Enabled = false;
            txtMaKH.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
            cbbQuyen.Text = db.ConvertQuyen1(Convert.ToInt32(dgvKH.CurrentRow.Cells[9].Value.ToString()));
        }

        private void BtnQuyen_Click(object sender, EventArgs e)
        {
            cbbQuyen.Enabled = true;
            btnLuu.Visible = true;
        }
    }
}
