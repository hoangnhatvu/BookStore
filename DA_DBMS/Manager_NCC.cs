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
    public partial class Manager_NCC : UserControl
    {
        public Manager_NCC()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Manager_NCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = db.NCCtable();
            btnThem.Visible = false;
            btnSua.Visible = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtSDT_NCC.Text == "" || txtEmailNCC.Text == "" || txtWebsiteNCC.Text == "") errorProvider1.SetError(txtTenNCC, "Bắt buộc phải điền đầy đủ thông tin!");
            else
            {
                if (db.checkNCC(txtTenNCC.Text) == 0)
                {
                    MessageBox.Show("Trùng NCC!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    db.SuaNCC(Convert.ToInt32(txtMaNCC.Text), txtTenNCC.Text, txtDiaChiNCC.Text, txtSDT_NCC.Text, txtEmailNCC.Text, txtWebsiteNCC.Text);
                    DialogResult a = MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (a == DialogResult.OK)
                    {
                        txtTenNCC.Enabled = false;
                        txtDiaChiNCC.Enabled = false;
                        txtSDT_NCC.Enabled = false;
                        txtEmailNCC.Enabled = false;
                        txtWebsiteNCC.Enabled = false;                        
                    }
                    dgvNCC.DataSource = db.NCCtable();
                }
                btnSua.Visible = false;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtSDT_NCC.Text == "" || txtEmailNCC.Text == "" || txtWebsiteNCC.Text == "") errorProvider1.SetError(txtTenNCC, "Bắt buộc phải điền đầy đủ thông tin!");
            else
            {
                if (db.checkNCC(txtTenNCC.Text) == 0)
                {
                    MessageBox.Show("NCC đã được thêm trước đó!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    db.ThemNCC(txtTenNCC.Text, txtDiaChiNCC.Text, txtSDT_NCC.Text, txtEmailNCC.Text, txtWebsiteNCC.Text);
                    DialogResult a = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (a == DialogResult.OK)
                    {
                        txtTenNCC.Enabled = false;
                        txtDiaChiNCC.Enabled = false;
                        txtSDT_NCC.Enabled = false;
                        txtEmailNCC.Enabled = false;
                        txtWebsiteNCC.Enabled = false;
                    }
                    dgvNCC.DataSource = db.NCCtable();
                }
                btnThem.Visible = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTenNCC.Text = "";
            txtDiaChiNCC.Text = "";
            txtSDT_NCC.Text = "";
            txtEmailNCC.Text = "";
            txtWebsiteNCC.Text = "";
            txtTenNCC.Enabled = true;
            txtDiaChiNCC.Enabled = true;
            txtSDT_NCC.Enabled = true;
            txtEmailNCC.Enabled = true;
            txtWebsiteNCC.Enabled = true;
            txtTenNCC.Focus();
            btnThem.Visible = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtTenNCC.Enabled = true;
            txtDiaChiNCC.Enabled = true;
            txtSDT_NCC.Enabled = true;
            txtEmailNCC.Enabled = true;
            txtWebsiteNCC.Enabled = true;
            btnSua.Visible = true;
            txtTenNCC.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xóa NCC này!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                db.XoaNCC(Convert.ToInt32(txtMaNCC.Text));
                dgvNCC.DataSource = db.NCCtable();
            }
        }

        private void DgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNCC.Enabled = false;
            txtDiaChiNCC.Enabled = false;
            txtSDT_NCC.Enabled = false;
            txtEmailNCC.Enabled = false;
            txtWebsiteNCC.Enabled = false;
            txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNCC.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txtSDT_NCC.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            txtEmailNCC.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
            txtWebsiteNCC.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
