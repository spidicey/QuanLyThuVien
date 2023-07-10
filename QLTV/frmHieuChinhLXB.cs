using DevExpress.XtraEditors;
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
    public partial class frmHieuChinhLXB : DevExpress.XtraEditors.XtraForm
    {
        public string query = "";
      
        private int idTuaSach;
        private string tenTuaSach;
        private int lanXB;
        private DateTime namXB; 
        private string khoGiay;
        private int soTrang;
        private string nhaXB;
        private float gia;
        private  bool diaCD;
        private int idLXB;
        public frmHieuChinhLXB()
        {
            InitializeComponent();
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

            if (string.IsNullOrEmpty(dteNamXB.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập năm xuất bản!", "Thông Báo", MessageBoxButtons.OK);
                dteNamXB.Focus();
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
                                       $"EXEC @result = Check_IDBTC_LanXB_Sach '{idLXB}', '{idTuaSach}', '{lxb}' "
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

        public frmHieuChinhLXB(int idLXB, int idTS, string tenTS, int LXB, DateTime namXB, string KhoGiay, int soTrang, string NXB, float gia, bool diaCD)
        {
            InitializeComponent();
            this.idLXB = idLXB;
            this.idTuaSach = idTS;
            this.tenTuaSach= tenTS;
            this.lanXB = LXB;
           this.namXB = namXB;
            this.khoGiay = KhoGiay;
            this.soTrang = soTrang;
            this.nhaXB = NXB;
            this.gia = gia;
            this.diaCD = diaCD;
        }

        private void frmHieuChinhLXB_Load(object sender, EventArgs e)
        {
            txtID.Text = idTuaSach.ToString();
            txtTen.Text = tenTuaSach;
            txtLanXB.Text = lanXB.ToString();
            dteNamXB.Text = namXB.ToString();
           txtKhoGiay.Text = khoGiay.ToString();
            txtSoTrang.Text = soTrang.ToString();
            txtNXB.Text = nhaXB.ToString();
            txtGia.Text = gia.ToString();
            if (diaCD == true)
                rdCheck.Checked = true;
            else
                rdCheck.Checked = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(checkInput() == false)
            {
                return;
            }    
            DateTime namXB = dteNamXB.DateTime;
            int lxb = Convert.ToInt32(txtLanXB.Text.ToString().Trim());
            string khoGiay = txtKhoGiay.Text.ToString();
            //MessageBox.Show(txtSoTrang.ToString().Trim(), "");
            int st = Convert.ToInt32(txtSoTrang.Text.ToString().Trim());
            string nhaXB = (txtNXB.Text.ToString());
            float gia = float.Parse(txtGia.Text.ToString().Trim());
            int dia = rdCheck.Checked ? 1 : 0;
            
            query = $"EXEC HieuChinhLanXB '{idLXB}',  '{lxb}', '{namXB}', '{khoGiay}', '{st}', '{nhaXB}', '{gia}', '{dia}'";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}