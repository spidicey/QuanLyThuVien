using DevExpress.XtraEditors;
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
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        private string default_folder_path = @"E:\TTCS\QLTVBackup";
        public frmRestore()
        {
            InitializeComponent();
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {

        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = default_folder_path;
            openFileDialog.Filter = "Backup File (.bak)|.bak|All files (.)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if(txtFile.Text == "")
            {
                MessageBox.Show("Đường dẫn không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            string path = txtFile.Text;

            string query = "USE MASTER " +
                                    "ALTER DATABASE QuanLyThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                                    $"RESTORE DATABASE QuanLyThuVien FROM DISK = '{path}' WITH REPLACE " +
                                    "ALTER DATABASE QuanLyThuVien set multi_user";

            int ketQua = Program.ExecSqlNonQuery(query);

            if (ketQua == 0)
            {
                MessageBox.Show("Restore thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Restore thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}