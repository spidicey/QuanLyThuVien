using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
            btnDangNhap.PerformClick();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // KIỂM TRA THÔNG TIN ĐĂNG NHẬP.
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text.Trim()) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                Program.WarningMessage("Tài khoản & Mật khẩu không thể trống!");
                return;
            }
            // KẾT NỐI CƠ SỞ DỮ LIỆU.
            Program.mlogin = txtTaiKhoan.Text; Program.password = txtMatKhau.Text;
            if (!Program.KetNoi()) return;
           
            // KIỂM TRA & LẤY THÔNG TIN NHÂN VIÊN ĐĂNG NHẬP.
            Program.myReader = Program.ExecSqlDataReader($"EXEC SP_GET_READER_INFO '{Program.mlogin}'");
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoTen = Program.myReader.GetString(1);
                Program.mNhom = Program.myReader.GetString(2);
            }
            catch
            {
                Program.ErrorMessage("Tài khoản của bạn hiện không còn hoạt động hoặc không được cấp quyền truy cập vào cơ sở dữ liệu.\n" +
                        "Vui lòng liên hệ với quản lý chi nhánh hoặc kiểm tra thông tin đăng nhập (Tài khoản & Mật khẩu).");
                return;
            }
            finally
            {
                Program.myReader.Close();
                Program.conn.Close();
            }
            // ĐĂNG NHẬP THÀNH CÔNG.
            Program.HienThiMenu();
            Close();
            
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}