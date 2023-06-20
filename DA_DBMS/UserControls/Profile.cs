using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DA_DBMS.UserControls
{
    public partial class Profile : UserControl
    {
        public static string email = "";
        DataConnDataContext db = new DataConnDataContext();
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            dgvThongtin.DataSource = db.SelectAllKhachHang(email);
            txtHoTen.DataBindings.Add("Text", dgvThongtin.DataSource, "TenKH");
            txtDiaChi.DataBindings.Add("Text", dgvThongtin.DataSource, "DiaChi");
            txtSdt.DataBindings.Add("Text", dgvThongtin.DataSource, "SDT");
            txtSex.DataBindings.Add("Text", dgvThongtin.DataSource, "Gioitinh");
            dptNgaysinh.DataBindings.Add("Text", dgvThongtin.DataSource, "Ngaysinh");
            LoadAnh();
        }
        private void LoadAnh()
        {
            try
            {
                DataConnDataContext db = new DataConnDataContext();
                KhachHang kh = db.KhachHangs.Where(a => a.Email == email).FirstOrDefault();
                if (kh == null) return;
                MemoryStream stream = new MemoryStream(kh.Avatar.ToArray());
                Image img = Image.FromStream(stream);
                if (img == null) return;
                pbxAvatar.Image = img;
            }        
            catch(Exception)
            {
                return;
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string file = openFileDialog.FileName;
            if (string.IsNullOrEmpty(file)) return;
            Image myimage = Image.FromFile(file);
            pbxAvatar.Image = myimage;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnOpenFile.Visible = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSdt.Enabled = true;
            txtSex.Enabled = true;
            dptNgaysinh.Enabled = true;
        }

        private void BtnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pbxAvatar.Image.Save(stream, ImageFormat.Jpeg);
            DialogResult a = MessageBox.Show("Sửa thông tin?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                if (txtHoTen.Text == ""||txtSdt.Text == ""||txtDiaChi.Text==""||txtSex.Text=="") errorProvider1.SetError(txtHoTen, "Bạn chưa điền đủ thông tin!");
                else
                {
                    db.Editprofile(email, txtHoTen.Text, txtDiaChi.Text, txtSdt.Text, txtSex.Text, stream.ToArray(), dptNgaysinh.Value);
                    dgvThongtin.Refresh();
                    LoadAnh();
                    txtHoTen.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtSdt.Enabled = false;
                    txtSex.Enabled = false;
                    dptNgaysinh.Enabled = false;
                    btnEdit.Visible = true;
                    btnSave.Visible = false;
                    btnOpenFile.Visible = false;
                }
            }
        }

    }
}
