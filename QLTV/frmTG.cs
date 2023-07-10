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
    public partial class frmTG : DevExpress.XtraEditors.XtraForm
    {
        private int viTri;
        private object[] oldDataRow;
        public frmTG()
        {
            InitializeComponent();
        }

        private void frmTachGia_Load(object sender, EventArgs e)
        {
            
            
            quanLyThuVienDataSet.EnforceConstraints = false;
            this.tableAdapterManager.Connection.ConnectionString = Program.connstr;
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);
            this.ctSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTSach);

            pncNhapLieu.Enabled = false;

            if (Program.mNhom.Equals("DocGia"))
            {

                btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnHieuChinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnInDanhSach.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;


                pncNhapLieu.Visible = false;
                gcTacGia.Dock = DockStyle.Fill;
            }
            else
            {
                btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnHieuChinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnGhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnInDanhSach.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                pncNhapLieu.Visible = true;
                pncNhapLieu.Enabled = false;

                gcTacGia.Dock = DockStyle.Top;
                pncNhapLieu.Dock = DockStyle.Fill;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTacGia.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsTacGia.AddNew();
            namSinhDateEdit.DateTime = DateTime.Today;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcTacGia.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTacGia.CancelEdit();
            if (btnThem.Enabled == false) bdsTacGia.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false;
            gcTacGia.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTacGia.Text.Trim()))
            {
                Program.WarningMessage("Mã tác giả không thể trống!");
                txtMaTacGia.Focus();
                return;
            }

            if (oldDataRow == null || oldDataRow[0].ToString() != txtMaTacGia.Text)
            {
                int isExisted = bdsTacGia.Find("MaTacGia", txtMaTacGia.Text.ToString().Trim());
                if (isExisted >= 0)
                {
                    Program.WarningMessage("Mã tác giả đã tồn tại!");
                    txtMaTacGia.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtTenTacGia.Text.Trim()))
            {
                Program.WarningMessage("Tên không thể trống!");
                txtTenTacGia.Focus();
                return;
            }

            try
            {
                bdsTacGia.EndEdit();
                bdsTacGia.ResetCurrentItem();
                this.tacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.tacGiaTableAdapter.Update(this.quanLyThuVienDataSet.TacGia);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcTacGia.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTacGia.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcTacGia.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsTacGia.Current).Row.ItemArray;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTSach.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Đã nhập tên tác giả!");
                return;
            }


            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            String maTacGia = "";
            try
            {
                maTacGia = ((DataRowView)bdsTacGia.Current)["MaTacGia"].ToString();
                bdsTacGia.RemoveCurrent();
                this.tacGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.tacGiaTableAdapter.Update(this.quanLyThuVienDataSet.TacGia);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);

                bdsTacGia.Position = bdsTacGia.Find("MaTacGia", maTacGia);
                return;
            }
            // KHÓA THAO TÁC XÓA KHI DANH SÁCH NHÂN VIÊN TRỐNG.
            if (bdsTacGia.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }



        }

        private void txtMaTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (txtMaTacGia.SelectionStart == 0 || txtMaTacGia.Text[txtMaTacGia.SelectionStart - 1] == ' '
               || (txtMaTacGia.SelectionStart != txtMaTacGia.Text.Length && txtMaTacGia.Text[txtMaTacGia.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void txtTenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (txtTenTacGia.SelectionStart == 0 || txtTenTacGia.Text[txtTenTacGia.SelectionStart - 1] == ' '
                || (txtTenTacGia.SelectionStart != txtTenTacGia.Text.Length && txtTenTacGia.Text[txtTenTacGia.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}