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
    public partial class MyDonHang : UserControl
    {
        public static string email;
        public MyDonHang()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
     

        private void MyDonHang_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLSdonhang.DataSource = db.Lichsuadonhang(db.getmakh(email));
                if (dgvLSdonhang.RowCount != 0)
                {
                    lbMadh.Text = dgvLSdonhang.CurrentRow.Cells[0].Value.ToString();
                    lbPhi.Text = dgvLSdonhang.CurrentRow.Cells[1].Value.ToString();
                    lbngaydat.Text = dgvLSdonhang.CurrentRow.Cells[2].Value.ToString();
                    lbTinhtrang.Text = db.Tinhtrang(Convert.ToInt32(dgvLSdonhang.CurrentRow.Cells[3].Value.ToString()));
                }
                else
                    return;
            }
            catch(Exception)
            {
                return;
            }
                    
        }

        private void DgvLSdonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMadh.Text = dgvLSdonhang.CurrentRow.Cells[0].Value.ToString();
            lbPhi.Text = dgvLSdonhang.CurrentRow.Cells[1].Value.ToString();
            lbngaydat.Text = dgvLSdonhang.CurrentRow.Cells[2].Value.ToString();
            lbTinhtrang.Text = db.Tinhtrang(Convert.ToInt32(dgvLSdonhang.CurrentRow.Cells[3].Value.ToString()));
        }

        private void BtnHuyDH_Click(object sender, EventArgs e)
        {
            try
            {
                db.Xoa_DonHang(Convert.ToInt32(lbMadh.Text));
                MessageBox.Show("Hủy đơn hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    dgvLSdonhang.DataSource = db.Lichsuadonhang(db.getmakh(email));
                    lbMadh.Text = dgvLSdonhang.CurrentRow.Cells[0].Value.ToString();
                    lbPhi.Text = dgvLSdonhang.CurrentRow.Cells[1].Value.ToString();
                    lbngaydat.Text = dgvLSdonhang.CurrentRow.Cells[2].Value.ToString();
                    lbTinhtrang.Text = db.Tinhtrang(Convert.ToInt32(dgvLSdonhang.CurrentRow.Cells[3].Value.ToString()));
                }
                catch (Exception)
                {
                    lbMadh.Text = "Mã ĐH";
                    lbPhi.Text = "Phí";
                    lbngaydat.Text = "Ngày đặt";
                    lbTinhtrang.Text = "Tình trạng";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Chitiet.madh = Convert.ToInt32(lbMadh.Text);
                Chitiet frm = new Chitiet();
                frm.ShowDialog();
            }
            catch(Exception)
            {
                return;
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                MyDonHang_Load(sender, e);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
