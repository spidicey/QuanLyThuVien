using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmLanKyXBSach : Form
    {
        public string query = "";
        private int idTuaSach;
        private string tuaSach;

        public frmLanKyXBSach()
        {
            InitializeComponent();
        }

        public frmLanKyXBSach(int idTuaSach, string tuaSach)
        {
            InitializeComponent();
            this.idTuaSach = idTuaSach;
            this.tuaSach = tuaSach;
        }

        private bool checkInput()
        {
            if (string.IsNullOrEmpty(txtLanXB.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập lần xuất bản!", "Thông Báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }
            if (Regex.IsMatch(txtLanXB.Text, "[0-9]") == false)
            {
                MessageBox.Show("Lần xuất bản chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }

            int lxb = Int32.Parse(txtLanXB.Text.ToString());
            if (lxb < 0)
            {
                MessageBox.Show("Lần xuất bản không thể <= 0!", "Thông Báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dtpNamXB.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập năm xuất bản!", "Thông Báo", MessageBoxButtons.OK);
                dtpNamXB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtKhoGiay.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập khổ giấy!", "Thông Báo", MessageBoxButtons.OK);
                txtKhoGiay.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSoTrang.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập số trang!", "Thông Báo", MessageBoxButtons.OK);
                txtSoTrang.Focus();
                return false;
            }
            if (Regex.IsMatch(txtSoTrang.Text, "[0-9]") == false)
            {
                MessageBox.Show("Số trang chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSoTrang.Focus();
                return false;
            }
            int soTrang = Int32.Parse(txtSoTrang.Text.ToString());
            if (soTrang < 0)
            {
                MessageBox.Show("Số trang không thể < 0!", "Thông Báo", MessageBoxButtons.OK);
                txtSoTrang.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtNXB.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập nhà xuất bản!", "Thông Báo", MessageBoxButtons.OK);
                txtNXB.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtGia.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập giá!", "Thông Báo", MessageBoxButtons.OK);
                txtGia.Focus();
                return false;
            }
            if (Regex.IsMatch(txtGia.Text, @"^\d+(?:\.\d+)?$") == false)
            {
                MessageBox.Show("Gía là số thực dương", "Thông báo", MessageBoxButtons.OK);
                txtGia.Focus();
                return false;
            }           
            float gia = float.Parse(txtGia.Text.ToString());
                      
            if (gia < 0)
            {
                MessageBox.Show("Gía không thể < 0!", "Thông Báo", MessageBoxButtons.OK);
                txtGia.Focus();
                return false;
            }

            string truyVan = $"DECLARE @result INT " +
                                       $"EXEC @result = Check_ADD_IDTS_LanXB_Sach '{idTuaSach}', '{lxb}' "
                                    + $"SELECT 'value' = @result ";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyVan);
                if (Program.myReader == null)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Lần xuất bản bị trùng!\n", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                //MessageBox.Show("Hiệu chỉnh thành công!\n", "Thông báo", MessageBoxButtons.OK);
                //this.kyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.KyXuatBan);
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (checkInput() == false)
                return;

            int lxb = Int32.Parse(txtLanXB.Text.ToString().Trim());
            DateTime namXuatBan = dtpNamXB.Value;  
            string khoGiay = txtKhoGiay.Text.ToString().Trim();
            int soTrang = Int32.Parse(txtSoTrang.Text.ToString().Trim());
            string nhaXB = txtNXB.Text.ToString().Trim();
            float gia = float.Parse(txtGia.Text.ToString().Trim());
            int diaCD = rdCo.Checked ? 1 : 0;

            query = $"EXEC ThemLanXuatBan '{lxb}', '{idTuaSach}', '{namXuatBan}', '{khoGiay}', " +
                           $"{soTrang}, '{nhaXB}', {gia}, {diaCD}";

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void frmThemKyXB_Load(object sender, EventArgs e)
        {
            txtMaTuaSach.Text = idTuaSach.ToString();
            txtTuaSach.Text = tuaSach;
        }
    }
}
