using DevExpress.Data.XtraReports.ReportGeneration;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExist(Type ftype)
        {
            return Array.Find(MdiChildren, f => f.GetType() == ftype);
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                
                Form frm = CheckExist(typeof(frmDangNhap));
                if (frm != null) frm.Activate();
                else
                {
                    frmDangNhap f = new frmDangNhap();
                    f.MdiParent = this;
                    f.Show();
                }
       
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmDocGia));
            if (frm != null) frm.Activate();
            else
            {
                frmDocGia f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmCuonSach));
            if (frm != null) frm.Activate();
            else
            {
                frmCuonSach f = new frmCuonSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTapChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mNhom.Equals("ThuThu"))
            {
                Form frm = CheckExist(typeof(frmBaoTapChi));
                if (frm != null) frm.Activate();
                else
                {
                    frmBaoTapChi f = new frmBaoTapChi();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                Form frm = CheckExist(typeof(frmBaoTapChiDG));
                if (frm != null) frm.Activate();
                else
                {
                    frmBaoTapChiDG f = new frmBaoTapChiDG();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnTaiLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTaiLieu));
            if (frm != null) frm.Activate();
            else
            {
                frmTaiLieu f = new frmTaiLieu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTG));
            if (frm != null) frm.Activate();
            else
            {
                frmTG f = new frmTG();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTuaSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTuaSach));
            if (frm != null) frm.Activate();
            else
            {
                frmTuaSach f = new frmTuaSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // RESET CÁC TRẠNG THÁI.
            SOTHE.Text = "SOTHE"; HOTEN.Text = "HOTEN"; NHOM.Text = "NHOM";
            btnDangNhap.Enabled = true; btnDangXuat.Enabled = false;
            rpgTaiKhoan.Visible = ribTaiNguyen.Visible = ribMuon.Visible = ribThongKe.Visible = false;
            MdiChildren.ForEach(form => form.Dispose());
            // TẠO MỚI FORM ĐĂNG NHẬP.
            frmDangNhap f = new frmDangNhap { MdiParent = this };
            f.Show();
        }

        private void btnXoaTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmXoaTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmXoaTaiKhoan f = new frmXoaTaiKhoan { MdiParent = this };
                f.Show();
            }
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*            string query =   "EXEC Backup_QLTV";                                 

                        if (Program.ExecSqlNonQuery(query) == 0)
                        {
                            MessageBox.Show("Backup thành công!", "Thông báo", MessageBoxButtons.OK);
                        }*/
            Form frm = CheckExist(typeof(frmBackup));
            if (frm != null) frm.Activate();
            else
            {
                frmBackup f = new frmBackup { MdiParent = this };
                f.Show();
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*string query = "USE MASTER " +
                                    "ALTER DATABASE QuanLyThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                                    "RESTORE DATABASE QuanLyThuVien FROM DISK = 'E:\\TTCS\\BackupCuoiKy\\Backup_QuanLyThuVien.bak' WITH REPLACE " +
                                    "ALTER DATABASE QuanLyThuVien set multi_user";
            if (Program.ExecSqlNonQuery(query) == 0)
            {
                MessageBox.Show("Restore thành công!", "Thông báo", MessageBoxButtons.OK);
            }*/

            Form frm = CheckExist(typeof(frmRestore));
            if (frm != null) frm.Activate();
            else
            {
                frmRestore f = new frmRestore { MdiParent = this };
                f.Show();
            }

        }

        private void btnDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmMuonSach));
            if (frm != null) frm.Activate();
            else
            {
                int sothe = 0;
                try
                {
                    sothe = Int32.Parse(Program.username);
                }
                catch
                {

                }
                frmMuonSach f = new frmMuonSach(sothe) { MdiParent = this };
                f.Show();
            }
        }

        private void btnMuonBao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmMuonBao));
            if (frm != null) frm.Activate();
            else
            {
                int sothe = 0;
                try
                {
                    sothe = Int32.Parse(Program.username);
                }
                catch
                {

                }
                frmMuonBao f = new frmMuonBao(sothe) { MdiParent = this };
                f.Show();
            }
        }

        private void btnDocGiaTreHan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDocGiaMuonQuaHan rp = new ReportDocGiaMuonQuaHan();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();

        }

        private void btnTinhHinhHoatDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportSachDangDuocMuon rp = new ReportSachDangDuocMuon();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDanhSachBTCDangMuon rp = new ReportDanhSachBTCDangMuon();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDGMuonBTCQuaHan rp = new ReportDGMuonBTCQuaHan();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnTop10Sach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTopMuonSach));
            if (frm != null) frm.Activate();
            else
            {
                frmTopMuonSach f = new frmTopMuonSach { MdiParent = this };
                f.Show();
            }
        }

        private void btnTop10BTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTopMuonBTC));
            if (frm != null) frm.Activate();
            else
            {
                frmTopMuonBTC f = new frmTopMuonBTC { MdiParent = this };
                f.Show();
            }
        }
    }
}
