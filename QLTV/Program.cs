using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    internal static class Program
    {
        // DATABASE CONNECTION.
        public static SqlConnection conn = new SqlConnection();
        // CONNECTION-STRING - SQL SERVER
        public static string connstr;
    
        public static SqlDataReader myReader;

        // STORE THE INFORMATION OF CONNECTION-STRING.
        public static string servername = "DESKTOP-AGARKV6"; // STORE THE CURRENT SERVER NAME.
        public static string database = "QuanLyThuVien"; // STORE THE DATABASE NAME.

        // ACCOUNT USED TO LOGIN DATABASE.
        public static string mlogin = "";
        public static string password = "";
       
        // STORE THE INFORMATION OF MEMBER ACCOUNT.
        public static string mloginDN = "";
        public static string passwordDN = "";
        // STORE THE INFORMATION OF STAFF FOR DISPLAYING IN STATUS STRIP.
        public static string username = ""; // STORE THE STAFF CODE.
        public static string mHoTen = ""; // STORE THE FULLNAME.
        public static string mNhom = ""; // STORE THE AUTHORITY.

        public static frmMain frmChinh;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
        public static SqlDataReader ExecSqlDataReader(string strCmd)
        {
            SqlDataReader reader;
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);
            sqlCmd.CommandType = CommandType.Text;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                reader = sqlCmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                conn.Close();
                ErrorMessage(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                ErrorMessage(ex.Message);
                return null;
            }
        }
        public static int ExecSqlNonQuery(string strCmd)
        {
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                conn.Close();
                ErrorMessage(ex.Message);
                return ex.State; // TRẠNG THÁI LỖI GỬI TỪ RAISERROR TRONG SQL.
            }
        }

        public static bool KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            try
            {
                connstr = $"Data Source={servername}; Initial Catalog={database}; User ID={mlogin}; password={password}";
                conn.ConnectionString = connstr;
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage("Lỗi kết nối cơ sở dữ liệu.\n" +
                    "Vui lòng kiểm tra thông tin đăng nhập! (Tài khoản & Mật khẩu)\n" + ex.Message);
                return false;
            }
        }

        //Sau khi đăng nhập thành công
        public static void HienThiMenu()
        {
            // THAY ĐỔI THANH TRẠNG THÁI.
            frmChinh.SOTHE.Text = $"Thẻ đọc: {username}";
            frmChinh.HOTEN.Text = $"Họ tên: {mHoTen}";
            frmChinh.NHOM.Text = $"Nhóm: {mNhom}";
            frmChinh.btnDangNhap.Enabled = false; 
            frmChinh.btnDangXuat.Enabled = true;           
            frmChinh.ribTaiNguyen.Visible = true;
            frmChinh.ribMuon.Visible = true;
            // PHÂN QUYỀN THANH MENU THEO NHÓM QUYỀN.
            switch (mNhom)
                {
                    case "ThuThu":
                        frmChinh.rpgTaiKhoan.Visible = frmChinh.ribThongKe.Visible = true;
                        frmChinh.rpgDocGia.Visible = true;
                        frmChinh.rbBackup.Visible = true;
                        frmChinh.btnSach.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    break;
                case "DocGia":

                    frmChinh.rpgTaiKhoan.Visible = false;
                    frmChinh.rpgDocGia.Visible = false;
                    frmChinh.rbBackup.Visible = false;
                    frmChinh.btnSach.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
              
                    break;
                }
        }

        public static bool EqualString(string a, string b)
        {
            return a.Trim() == b.Trim();
        }
        public static void SuccessMessage()
        {
            MessageBox.Show("Thực thi thành công!", "Thông báo thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show("Thực thi thất bại!\n" + message, "Thông báo lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningMessage(string message)
        {
            MessageBox.Show(message, "Thông báo thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ConfirmMessage()
        {
            return MessageBox.Show("Bạn có thực sự muốn thực hiện thao tác này?", "Thông báo xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
