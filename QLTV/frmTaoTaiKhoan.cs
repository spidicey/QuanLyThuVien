using QLTV.QuanLyThuVienDataSetTableAdapters;
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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            // KIỂM TRA NHẬP LIỆU.
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                Program.WarningMessage("Tên đăng nhập không thể trống!");
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                Program.WarningMessage("Mật khẩu không thể trống!");
                txtMatKhau.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhauXacNhan.Text))
            {
                Program.WarningMessage("Mật khẩu xác nhận không thể trống!");
                txtMatKhauXacNhan.Focus();
                return;
            }

            if (txtMatKhauXacNhan.Text != txtMatKhau.Text)
            {
                Program.WarningMessage("Mật khẩu xác nhận không chính xác!");
                txtMatKhauXacNhan.Focus();
                return;
            }
            string strCmd = $"EXEC SP_CREATE_ACCOUNT '{txtTenDangNhap.Text}', '{txtMatKhau.Text}', '{cmbDocGia.SelectedValue}' ";
            if (Program.ExecSqlNonQuery(strCmd) != 0) return;
            Program.SuccessMessage();
            // LÀM MỚI VÙNG NHẬP LIỆU.
            gET_NO_ACCOUNTS_READERTableAdapter.Fill(quanLyThuVienDataSet.GET_NO_ACCOUNTS_READER);
            txtTenDangNhap.Text = txtMatKhau.Text = txtMatKhauXacNhan.Text = string.Empty;
            // KIỂM TRA ĐIỀU KIỆN CÓ THỂ TẠO TÀI KHOẢN.
            if (bdsGET_NO_ACCOUNTS_READER.Count > 0)
            {
                cmbDocGia.SelectedIndex = 0;
                txtSoThe.Text = cmbDocGia.SelectedValue.ToString();
            }
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            quanLyThuVienDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.GET_NO_ACCOUNTS_READER' table. You can move, or remove it, as needed.
            this.gET_NO_ACCOUNTS_READERTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gET_NO_ACCOUNTS_READERTableAdapter.Fill(this.quanLyThuVienDataSet.GET_NO_ACCOUNTS_READER);
            if (bdsGET_NO_ACCOUNTS_READER.Count > 0)
            {
               cmbDocGia.SelectedIndex = 0;
                txtSoThe.Text = cmbDocGia.SelectedValue.ToString();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void txtMatKhauXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '_' && !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void cmbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoThe.Text = cmbDocGia.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
