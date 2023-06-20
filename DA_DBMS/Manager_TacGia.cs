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
    public partial class Manager_TacGia : UserControl
    {
        public Manager_TacGia()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();

        private void Manager_TacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = db.TacGia_table();
            btnThem.Visible = false;
            btnSua.Visible = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtQue.Text == "" || txtQuoctich.Text == "" || txtCongviec.Text == "") errorProvider1.SetError(txtTen, "Bắt buộc phải điền đầy đủ thông tin!");
            else
            {                
                db.SuaTG(Convert.ToInt32(txtMatg.Text), txtTen.Text, txtQue.Text, txtCongviec.Text, txtQuoctich.Text, dptNgaysinh.Value);
                DialogResult a = MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (a == DialogResult.OK)
                {
                    txtTen.Enabled = false;
                    txtQue.Enabled = false;
                    txtQuoctich.Enabled = false;
                    txtCongviec.Enabled = false;
                    dptNgaysinh.Enabled = false;
                }
                btnSua.Visible = false;
                dgvTacGia.DataSource = db.TacGia_table();
                btnSua.Visible = false;               
            }
        }

        private void DgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatg.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
            txtQue.Text = dgvTacGia.CurrentRow.Cells[3].Value.ToString();
            txtCongviec.Text = dgvTacGia.CurrentRow.Cells[4].Value.ToString();
            txtQuoctich.Text = dgvTacGia.CurrentRow.Cells[5].Value.ToString();
            dptNgaysinh.Text = dgvTacGia.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtQue.Text == "" || txtQuoctich.Text == "" || txtCongviec.Text == "") errorProvider1.SetError(txtTen, "Bắt buộc phải điền đầy đủ thông tin!");
            else
            {
                if (db.checkTacGia(txtTen.Text) == 0)
                {
                    MessageBox.Show("Tác giả đã được thêm trước đó!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    db.ThemTG(txtTen.Text, txtQue.Text, txtCongviec.Text, txtQuoctich.Text, dptNgaysinh.Value);
                    DialogResult a = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (a == DialogResult.OK)
                    {
                        txtTen.Enabled = false;
                        txtQue.Enabled = false;
                        txtQuoctich.Enabled = false;
                        txtCongviec.Enabled = false;
                        dptNgaysinh.Enabled = false;
                    }
                    dgvTacGia.DataSource = db.TacGia_table();
                    btnThem.Visible = false;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtQue.Text = "";
            txtQuoctich.Text = "";
            txtCongviec.Text = "";
            txtTen.Enabled = true;
            txtQue.Enabled = true;
            txtQuoctich.Enabled = true;
            txtCongviec.Enabled = true;
            dptNgaysinh.Enabled = true;
            btnThem.Visible = true;
            txtTen.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            txtQue.Enabled = true;
            txtQuoctich.Enabled = true;
            txtCongviec.Enabled = true;
            dptNgaysinh.Enabled = true;
            btnSua.Visible = true;
            txtTen.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xóa Tác giả này!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                db.XoaTG(Convert.ToInt32(txtMatg.Text));
                dgvTacGia.DataSource = db.TacGia_table();
            }
        }
    }
}
