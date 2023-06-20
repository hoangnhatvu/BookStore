using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DBMS
{
    public partial class Manager_DonHang : UserControl
    {
        public Manager_DonHang()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();

        private void Manager_DonHang_Load(object sender, EventArgs e)
        {
            dgvDonhang.DataSource = db.DonHangtable();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            cbbTinhtrang.Enabled = true;
            btnLuu.Visible = true;
            btnEdit.Visible = false;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            db.XacnhanDonhang(Convert.ToInt32(txtMadh.Text), Convert.ToInt32(cbbTinhtrang.Text));
            DialogResult a = MessageBox.Show("Xác nhận thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (a == DialogResult.OK)
            {
                cbbTinhtrang.Enabled = false;
                btnLuu.Visible = false;
                btnEdit.Visible = true;
            }
            dgvDonhang.DataSource = db.DonHangtable();
        }

       

        private void dgvDonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMadh.Text = dgvDonhang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = db.getTenKH(Convert.ToInt32(dgvDonhang.CurrentRow.Cells[1].Value.ToString()));
            txtPhi.Text = dgvDonhang.CurrentRow.Cells[2].Value.ToString();
            txtNgaydat.Text = dgvDonhang.CurrentRow.Cells[4].Value.ToString();
            cbbTinhtrang.Text = dgvDonhang.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
