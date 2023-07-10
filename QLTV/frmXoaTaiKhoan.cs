using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmXoaTaiKhoan : Form
    {
        public frmXoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {

            if (Program.EqualString(txtSoThe.Text, Program.username))
            {
                Program.WarningMessage("Bạn không thể tự xóa tài khoản của bản thân!");
                txtSoThe.Focus();
                return;
            }

            /*int isExisted = bdsCTMuonSach.Find("SoThe", txtSoThe.Text);
            if (isExisted >= 0)
            {
                Program.WarningMessage("Độc giả đã mượn sách không thể xóa!");
                //txtSoThe.Focus();
                return;
            }

            int isExistedBTC = bdsCTMuonBTC.Find("SoThe", txtSoThe.Text);
            if (isExistedBTC >= 0)
            {
                Program.WarningMessage("Độc giả đã mượn báo tạp chí không thể xóa!");
                //txtSoThe.Focus();
                return;
            }*/


            // THỰC HIỆN XÓA TÀI KHOẢN.
            //MessageBox.Show(cmbTenDangNhap.Text.ToString().Trim(), "");
            
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            if (Program.ExecSqlNonQuery($"EXEC SP_REMOVE_ACCOUNT '{cmbTenDangNhap.Text.ToString().Trim()}', '{txtSoThe.Text}'") != 0) return;
            Program.SuccessMessage();
            this.getACCOUNTS_READERTableAdapter.Connection.ConnectionString = Program.connstr;
            this.getACCOUNTS_READERTableAdapter.Fill(this.quanLyThuVienDataSet.GET_ACCOUNTS_READER);
            // LÀM MỚI VÙNG NHẬP LIỆU.
            // txtTenDangNhap.Text = txtMaNhanVien.Text = string.Empty;
            if (cmbTenDangNhap.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cmbTenDangNhap.SelectedIndex = 0;
                txtSoThe.Text = cmbTenDangNhap.SelectedValue.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            quanLyThuVienDataSet.EnforceConstraints = false;
            
            this.getACCOUNTS_READERTableAdapter.Connection.ConnectionString = Program.connstr;
            this.getACCOUNTS_READERTableAdapter.Fill(this.quanLyThuVienDataSet.GET_ACCOUNTS_READER);
            this.cTMuonBaoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTMuonBaoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.CTMuonBaoTapChi);
            this.cTMuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTMuonSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTMuonSach);

            if (cmbTenDangNhap.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cmbTenDangNhap.SelectedIndex = 0;
                txtSoThe.Text = cmbTenDangNhap.SelectedValue.ToString();
            }         
        }

        private void cmbTenDangNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtSoThe.Text = cmbTenDangNhap.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
