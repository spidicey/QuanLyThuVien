using DevExpress.Utils.Gesture;
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
    public partial class frmHieuChinhBTC : DevExpress.XtraEditors.XtraForm
    {
        public string query = "";
        private int idkxb;
        private int idbtc;
        private string nhaXB;
        private int lanXB;
        private int soLuong;

        public frmHieuChinhBTC()
        {
            InitializeComponent();
        }

        public frmHieuChinhBTC(int idkxb, int idbtc, string nhaXB, int lanXB, int soLuong)
        {
            InitializeComponent();
            this.idkxb = idkxb;
            this.idbtc = idbtc;
            this.nhaXB = nhaXB;
            this.lanXB = lanXB;
            this.soLuong = soLuong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool checkInput()
        {
            if (string.IsNullOrEmpty(txtLanXB.Text.ToString()))
            {
                MessageBox.Show("Lần xuất bảnChưa nhập!", "Thông Báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }
            if (Regex.IsMatch(txtLanXB.Text.ToString(), "[0-9]") == false)
            {
                MessageBox.Show("Lần xuất bản chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }           

            if (string.IsNullOrEmpty(txtSoLuongNhap.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập số lượng!", "Thông Báo", MessageBoxButtons.OK);
                txtSoLuongNhap.Focus();
                return false;
            }

            if (Regex.IsMatch(txtSoLuongNhap.Text, "[0-9]") == false)
            {
                MessageBox.Show("Số lượng chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSoLuongNhap.Focus();
                return false;
            }

            int soLuongNhap = Int32.Parse(txtSoLuongNhap.Text.ToString());
            if (soLuongNhap < 0)
            {
                MessageBox.Show("Số lượng nhập không thể < 0!", "Thông Báo", MessageBoxButtons.OK);
                txtSoLuongNhap.Focus();
                return false;
            }

           

            int lxb = Int32.Parse(txtLanXB.Text.ToString());
            if (lxb <= 0)
            {
                MessageBox.Show("Lần xuất bản không thể <= 0!", "Thông Báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }

            string truyVan = $"DECLARE @result INT " +
                                       $"EXEC @result = Check_IDBTC_LanXB '{idkxb}', '{idbtc}', '{lxb}' "
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
            if(checkInput() == false)
            {
                return;
            }

            int lxb = Int32.Parse(txtLanXB.Text.ToString());
            int soLuongNhap = Int32.Parse(txtSoLuongNhap.Text.ToString().Trim());

            query = $"DECLARE @result INT " +
                $"EXEC @result = HieuChinhBTC '{idkxb}', '{idbtc}', '{lxb}', '{soLuongNhap}' "
                +$"SELECT 'value' = @result ";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmHieuChinhSoLuongBTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.KyXuatBan' table. You can move, or remove it, as needed.
            this.kyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.KyXuatBan);
            txtIDBTC.Text = idbtc.ToString();
            txtNhaXuatBan.Text = nhaXB.ToString();
            txtLanXB.Text = lanXB.ToString();
            txtSoLuongNhap.Text = soLuong.ToString();
        }

        private void kyXuatBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKXB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }
    }
}