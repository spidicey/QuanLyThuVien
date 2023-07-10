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
    public partial class frmKyXuatBanBao : DevExpress.XtraEditors.XtraForm
    {

        public string query = "";
        private int idBTC;
        private string nhaXB;
        
        public frmKyXuatBanBao()
        {
            InitializeComponent();
        }

        public frmKyXuatBanBao(int idBTC, string nhaXB)
        {
            InitializeComponent();
            this.idBTC = idBTC;
            this.nhaXB = nhaXB;
        }

        private void frmKyXuatBanBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.KyXuatBan' table. You can move, or remove it, as needed.
            this.kyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.KyXuatBan);
            txtIDBTC.Text = idBTC.ToString();
            txtNhaXuatBan.Text = nhaXB; 
        }

        private bool checkInput()
        {

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

            if (string.IsNullOrEmpty(txtLanXB.Text.ToString()))
            {
                MessageBox.Show("Chưa nhập lần xuất bản!", "Thông Báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
                return false;
            }
            if (Regex.IsMatch(txtLanXB.Text, "[0-9]") == false)
            {
                MessageBox.Show("lần xuất bản chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtLanXB.Focus();
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
                txtSoLuongNhap.Focus();
                return false;
            }
           
            string truyVan = $"DECLARE @result INT " +
                                       $"EXEC @result = Check_ADD_IDBTC_LanXB  '{idBTC}', '{lxb}' "
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

            query = $"EXEC ThemKyXuatBan '{idBTC}', '{lxb}',  '{soLuongNhap}' ";
         
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void kyXuatBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKXB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }
    }
}