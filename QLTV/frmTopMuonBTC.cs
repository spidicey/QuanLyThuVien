using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmTopMuonBTC : DevExpress.XtraEditors.XtraForm
    {
        public frmTopMuonBTC()
        {
            InitializeComponent();
        }

        private bool checkInput()
        {
            if (detNgayBatDau.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập ngày bắt đầu", "", MessageBoxButtons.OK);
                detNgayBatDau.Focus();
                return false;
            }

            if (detNgayKetThuc.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập ngày kết thúc", "", MessageBoxButtons.OK);
                detNgayKetThuc.Focus();
                return false;
            }
            return true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(checkInput()== false)
            {
                return;
            }  
            
            if (detNgayBatDau.DateTime.CompareTo(detNgayKetThuc.DateTime) > 0)
            {
                Program.WarningMessage("Ngày bắt đầu không thể sau ngày kết thúc!");
                return;
            }
            new ReportPrintTool(new ReportTop10BTC(detNgayBatDau.DateTime, detNgayKetThuc.DateTime)).ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}