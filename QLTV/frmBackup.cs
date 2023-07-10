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
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        private string default_folder_path = @"E:\TTCS\QLTVBackup";
        public frmBackup()
        {
            InitializeComponent();
            txtFile.Text = default_folder_path;
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dialog.SelectedPath;
            }
            else
            {
                txtFile.Text = default_folder_path;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtFile.Text == "")
            {
                MessageBox.Show("Đường dẫn không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            string createFileName = "Backup_QuanLyThuVien";
            string path = txtFile.Text + @"\" + createFileName + ".bak";

            //Console.WriteLine(path);

            if (Program.ExecSqlNonQuery($"EXEC Backup_QLTV '{path}'") == 0)
            {
                MessageBox.Show("Backup thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Backup thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}