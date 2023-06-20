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
    public partial class Chitiet : Form
    {
        public static int madh;
        public static string email;
        public Chitiet()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void Chitiet_Load(object sender, EventArgs e)
        {
            try
            {
                dgvChitiet.DataSource = null;
                dgvChitiet.DataSource = db.chitiet_donhang(madh, db.getmakh(email));
                lbTenSach.Text = dgvChitiet.CurrentRow.Cells[1].Value.ToString();
                lbSoluong.Text = dgvChitiet.CurrentRow.Cells[4].Value.ToString();
                lbDongia.Text = dgvChitiet.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void DgvChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTenSach.Text = dgvChitiet.CurrentRow.Cells[1].Value.ToString();
            lbSoluong.Text = dgvChitiet.CurrentRow.Cells[4].Value.ToString();
            lbDongia.Text = dgvChitiet.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
