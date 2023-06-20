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
    public partial class ManagerSanPham : UserControl
    {
        public ManagerSanPham()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void ManagerSanPham_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = db.SachTable();
            dgvSach.Columns[2].Visible = false;
            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns[9].Visible = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ThemSach frm = new ThemSach();
            frm.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SuaChiTiet.masach = Convert.ToInt32(txtMaSach.Text);
                SuaChiTiet frm = new SuaChiTiet();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Hãy chọn một tựa Sách trước!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show("Xóa Tựa Sách này!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (a == DialogResult.OK)
                {
                    db.XoaSach(Convert.ToInt32(txtMaSach.Text));
                    dgvSach.DataSource = db.SachTable();
                    dgvSach.Columns[2].Visible = false;
                    dgvSach.Columns[7].Visible = false;
                    dgvSach.Columns[8].Visible = false;
                    dgvSach.Columns[9].Visible = false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Tựa Sách đang tồn tại trong một số đơn hàng. Vui lòng xóa hết các Đơn hàng liên quan đến tựa Sách này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = db.SachTable();
            dgvSach.Columns[2].Visible = false;
            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns[9].Visible = false;
        }

        private void DgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
