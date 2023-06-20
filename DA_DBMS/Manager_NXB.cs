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
    public partial class Manager_NXB : UserControl
    {
        public Manager_NXB()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void Manager_NXB_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = db.NXB_table();
            btnThem.Visible = false;
            btnSua.Visible = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtTruso.Text == "" || txtQuocgia.Text == "" || txtWeb.Text == "") errorProvider1.SetError(txtTen, "Bắt buộc phải điền đầy đủ thông tin!");
            else
            {     
                db.SuaNXB(Convert.ToInt32(txtMaNXB.Text), txtTen.Text, txtTruso.Text, txtQuocgia.Text, txtWeb.Text);
                DialogResult a = MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (a == DialogResult.OK)
                {
                    txtTen.Enabled = false;
                    txtTruso.Enabled = false;
                    txtQuocgia.Enabled = false;
                    txtWeb.Enabled = false;
                }
                dgvNXB.DataSource = db.NXB_table();
                btnSua.Visible = false;
             
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtTruso.Text == "" || txtQuocgia.Text == "" || txtWeb.Text == "") errorProvider1.SetError(txtTen, "Bắt buộc phải điền đầy đủ thông tin!");
            else
            {
                if (db.checkNXB(txtTen.Text) == 0) MessageBox.Show("NXB đã được thêm trước đó!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    db.ThemNXB(txtTen.Text, txtTruso.Text, txtQuocgia.Text, txtWeb.Text);
                    DialogResult a = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (a == DialogResult.OK)
                    {
                        txtTen.Enabled = false;
                        txtTruso.Enabled = false;
                        txtQuocgia.Enabled = false;
                        txtWeb.Enabled = false;
                    }
                    dgvNXB.DataSource = db.NXB_table();
                    btnThem.Visible = false;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtTruso.Text = "";
            txtQuocgia.Text = "";
            txtWeb.Text = "";
            txtTen.Enabled = true;
            txtTruso.Enabled = true;
            txtQuocgia.Enabled = true;
            txtWeb.Enabled = true;
            txtTen.Focus();
            btnThem.Visible = true;
        }

        private void DgvNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNXB.Text = dgvNXB.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNXB.CurrentRow.Cells[1].Value.ToString();
            txtTruso.Text = dgvNXB.CurrentRow.Cells[2].Value.ToString();
            txtQuocgia.Text = dgvNXB.CurrentRow.Cells[3].Value.ToString();
            txtWeb.Text = dgvNXB.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            txtTruso.Enabled = true;
            txtQuocgia.Enabled = true;
            txtWeb.Enabled = true;
            btnSua.Visible = true;
            txtTen.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xóa NXB này!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                db.XoaNXB(Convert.ToInt32(txtMaNXB.Text));
                dgvNXB.DataSource = db.NXB_table();
            }
        }
    }
}
