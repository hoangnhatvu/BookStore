using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DA_DBMS
{
    public partial class ThemSach : Form
    {
        public ThemSach()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void ThemSach_Load(object sender, EventArgs e)
        {
            cbbNCC.DataSource = db.TenNCC();
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";

            cbbNXB.DataSource = db.TenNXB();
            cbbNXB.DisplayMember = "TenNXB";
            cbbNXB.ValueMember = "MaNXB";

            cbbTacGia.DataSource = db.TenTacGia();
            cbbTacGia.DisplayMember = "TenTacGia";
            cbbTacGia.ValueMember = "MaTacGia";

            cbbChuDe.DataSource = db.Tenchude();
            cbbChuDe.DisplayMember = "TenChuDe";
            cbbChuDe.ValueMember = "MaChuDe";
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string file = openFileDialog.FileName;
            if (string.IsNullOrEmpty(file)) return;
            Image myimage = Image.FromFile(file);
            pictureBox1.Image = myimage;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                if (txtTen.Text == "" || txtGia.Text == "" || txtSoluong.Text == "" || txtMoTa.Text == "") errorProvider1.SetError(txtTen, "Bắt buộc phải điền đầy đủ thông tin!");
                else
                {
                    if (db.CheckSach(txtTen.Text) == 0)
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            db.ThemSach(txtTen.Text, db.convert_matg(cbbTacGia.Text), Convert.ToDecimal(txtGia.Text), txtMoTa.Text, dtpNgay.Value, Convert.ToInt32(txtSoluong.Text), db.convert_manxb(cbbNXB.Text), db.convert_mancc(cbbNCC.Text), db.convert_machude(cbbChuDe.Text), stream.ToArray());



                            DialogResult a = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (a == DialogResult.OK)
                            {
                                txtTen.Text = "";
                                txtGia.Text = "";
                                txtMoTa.Text = "";
                                txtSoluong.Text = "";
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
