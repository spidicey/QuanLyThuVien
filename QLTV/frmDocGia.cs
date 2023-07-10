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
    public partial class frmDocGia : Form
    {
        private int viTri;
        private object[] oldDataRow;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void docGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDocGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quanLyThuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CTMuonBaoTapChi' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.docGiaTableAdapter.Fill(this.quanLyThuVienDataSet.DocGia);

            this.CTMuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTMuonSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTMuonSach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CTMuonBaoTapChi' table. You can move, or remove it, as needed.
            this.CTMuonBaoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTMuonBaoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.CTMuonBaoTapChi);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DocGia' table. You can move, or remove it, as needed.
            pncNhapLieu.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbSoThe.Visible = false;
            txtSoThe.Visible = false;
            viTri = bdsDocGia.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsDocGia.AddNew();
            txtSoThe.Text = "";
            tenTextBox.Text = " ";
            ngheNghiepTextBox.Text = " ";
            phaiCheckBox.Checked = false;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcDocGia.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbSoThe.Visible = true;
            txtSoThe.Visible = true;
            bdsDocGia.CancelEdit();
            if (btnThem.Enabled == false) bdsDocGia.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false;
            gcDocGia.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }
        

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbSoThe.Visible = true;
            txtSoThe.Visible = true;
            if (string.IsNullOrEmpty(txtSoThe.Text.Trim()))
            {
                Program.WarningMessage("Số thẻ không thể trống!");
                txtSoThe.Focus();
                return;
            }

            if (oldDataRow == null || oldDataRow[0].ToString() != txtSoThe.Text)
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_SO_THE '{txtSoThe.Text}'");
                bool isExisted = Program.myReader.Read();
                Program.myReader.Close();
                Program.conn.Close();
                if (isExisted)
                {
                    Program.WarningMessage("Số thẻ đã tồn tại!");
                    txtSoThe.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(tenTextBox.Text.Trim()))
            {
                Program.WarningMessage("Tên không thể trống!");
                tenTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ngheNghiepTextBox.Text.Trim()))
            {
                Program.WarningMessage("Nghề nghiệp không thể trống!");
                ngheNghiepTextBox.Focus();
                return;
            }

            try
            {
                bdsDocGia.EndEdit();
                bdsDocGia.ResetCurrentItem();
                this.docGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.docGiaTableAdapter.Update(this.quanLyThuVienDataSet.DocGia);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcDocGia.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }


        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDocGia.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcDocGia.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsDocGia.Current).Row.ItemArray;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTMuonBaoTapChi.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Người này vẫn chưa trả sách!");
                return;
            }

            if (bdsCTMuonSach.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Người này vẫn chưa trả sách!");
                return;
            }
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            int soThe = 0;
            try
            {
                soThe = int.Parse(((DataRowView)bdsDocGia.Current)["SoThe"].ToString());
                bdsDocGia.RemoveCurrent();
                this.docGiaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.docGiaTableAdapter.Update(this.quanLyThuVienDataSet.DocGia);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                this.docGiaTableAdapter.Fill(this.quanLyThuVienDataSet.DocGia);

                bdsDocGia.Position = bdsDocGia.Find("SoThe", soThe);
                return;
            }
            // KHÓA THAO TÁC XÓA KHI DANH SÁCH NHÂN VIÊN TRỐNG.
            if (bdsDocGia.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.docGiaTableAdapter.Fill(this.quanLyThuVienDataSet.DocGia);
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


        private void soTheTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void tenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (tenTextBox.SelectionStart == 0 || tenTextBox.Text[tenTextBox.SelectionStart - 1] == ' '
                || (tenTextBox.SelectionStart != tenTextBox.Text.Length && tenTextBox.Text[tenTextBox.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void ngheNghiepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (tenTextBox.SelectionStart == 0 || tenTextBox.Text[tenTextBox.SelectionStart - 1] == ' '
                || (tenTextBox.SelectionStart != tenTextBox.Text.Length && tenTextBox.Text[tenTextBox.SelectionStart] == ' ')))
                e.Handled = true;
        }
    }
}
