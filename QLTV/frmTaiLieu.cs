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
    public partial class frmTaiLieu : Form
    {
        private int viTri;
        private object[] oldDataRow;
        public frmTaiLieu()
        {
            InitializeComponent();
        }

        private void taiLieuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTaiLieu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }

        private void frmTaiLieu_Load(object sender, EventArgs e)
        {
            quanLyThuVienDataSet.EnforceConstraints = false;
            this.taiLieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiLieuTableAdapter.Fill(this.quanLyThuVienDataSet.TaiLieu);

            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BaoTapChi' table. You can move, or remove it, as needed.
            this.baoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.baoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.BaoTapChi);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TuaSach' table. You can move, or remove it, as needed.
            this.tuaSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tuaSachTableAdapter.Fill(this.quanLyThuVienDataSet.TuaSach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TaiLieu' table. You can move, or remove it, as needed.          

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
                gcTaiLieu.Dock = DockStyle.Fill;             
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

                gcTaiLieu.Dock = DockStyle.Top;
                pncNhapLieu.Dock = DockStyle.Fill;            
            }
            bar1.Visible = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTaiLieu.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsTaiLieu.AddNew();
           
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcTaiLieu.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTaiLieu.CancelEdit();
            if (btnThem.Enabled == false) bdsTaiLieu.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false;
            gcTaiLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(maTaiLieuTextBox.Text.Trim()))
            {
                Program.WarningMessage("Mã tài liệu không thể trống!");
                maTaiLieuTextBox.Focus();
                return;
            }

            if (oldDataRow == null || oldDataRow[0].ToString() != maTaiLieuTextBox.Text)
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_MA_TAI_LIEU '{maTaiLieuTextBox.Text}'");
                bool isExisted = Program.myReader.Read();
                Program.myReader.Close();
                Program.conn.Close();
                if (isExisted)
                {
                    Program.WarningMessage("Mã tài liệu đã tồn tại!");
                    maTaiLieuTextBox.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(tenTaiLieuTextBox.Text.Trim()))
            {
                Program.WarningMessage("Tên không thể trống!");
                tenTaiLieuTextBox.Focus();
                return;
            }

            

            try
            {
                bdsTaiLieu.EndEdit();
                bdsTaiLieu.ResetCurrentItem();
                this.taiLieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiLieuTableAdapter.Update(this.quanLyThuVienDataSet.TaiLieu);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcTaiLieu.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTaiLieu.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcTaiLieu.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsTaiLieu.Current).Row.ItemArray;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTuaSach.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Đã nhập tụa sách!");
                return;
            }

            if (bdsBaoTapChi.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Đã nhập báo, tạp chí!");
                return;
            }
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            String maTL = "";
            try
            {
                maTL = ((DataRowView)bdsTaiLieu.Current)["MaTaiLieu"].ToString();
                bdsTaiLieu.RemoveCurrent();
                this.taiLieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiLieuTableAdapter.Update(this.quanLyThuVienDataSet.TaiLieu);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                this.taiLieuTableAdapter.Fill(this.quanLyThuVienDataSet.TaiLieu);

                bdsTaiLieu.Position = bdsTaiLieu.Find("MaTaiLieu", maTL);
                return;
            }
            // KHÓA THAO TÁC XÓA KHI DANH SÁCH NHÂN VIÊN TRỐNG.
            if (bdsTaiLieu.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taiLieuTableAdapter.Fill(this.quanLyThuVienDataSet.TaiLieu);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
