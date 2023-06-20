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
    public partial class Store : UserControl
    {
        public Store()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void Store_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = db.InfoSach();
            dgvSanPham.Columns[0].Visible = false;
            (clbChuDe as ListBox).DataSource = db.Tenchude();
            (clbChuDe as ListBox).DisplayMember = "TenChuDe";
            (clbChuDe as ListBox).ValueMember = "MaChuDe";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") dgvSanPham.DataSource = db.InfoSach();
            else dgvSanPham.DataSource = db.Search_table(txtSearch.Text);
        }

        private void DgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.SelectedCells[0].RowIndex;
            DataGridViewRow r = dgvSanPham.Rows[i];
            frmChitietsanpham.masach = Convert.ToInt32(dgvSanPham.Rows[i].Cells[0].Value.ToString());
            frmChitietsanpham frm = new frmChitietsanpham();
            frm.ShowDialog();
        }

        private void ClbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "";
            if (clbChuDe.CheckedItems.Count > 0)
            {
                for (int i = 0; i < clbChuDe.CheckedItems.Count; i++)
                {
                    a = (clbChuDe as ListBox).GetItemText((clbChuDe as ListBox).SelectedItem);
                }
                dgvSanPham.DataSource = db.Sachtheochude(a);
            }
            else dgvSanPham.DataSource = db.InfoSach();
        }

        private void ClbChuDe_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clbChuDe.Items.Count; ++i)
                if (i != e.Index) clbChuDe.SetItemChecked(i, false);
        }

        
    }
}
