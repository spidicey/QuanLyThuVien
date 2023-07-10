using DevExpress.XtraEditors.Repository;
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
    public partial class frmBaoTapChi : Form
    {
        private int viTri;
        private object[] oldDataRow;
        public frmBaoTapChi()
        {
            InitializeComponent();
        }

        private void baoTapChiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBaoTapChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quanLyThuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TaiLieu' table. You can move, or remove it, as needed.
            this.taiLieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiLieuTableAdapter.Fill(this.quanLyThuVienDataSet.TaiLieu);
           

            this.baoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.baoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.BaoTapChi);

            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CTMuonBaoTapChi' table. You can move, or remove it, as needed.
           // this.cTMuonBaoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.cTMuonBaoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.CTMuonBaoTapChi);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.KyXuatBan' table. You can move, or remove it, as needed.
            
            this.kyXuatBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.KyXuatBan);
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BaoTapChi' table. You can move, or remove it, as needed.
           //Chuyen Ma Tai Lieu Thanh Ten
            RepositoryItemLookUpEdit repositoryItemVT = new RepositoryItemLookUpEdit();
            repositoryItemVT.DataSource = bdsTaiLieu;
            repositoryItemVT.DisplayMember = "TenTaiLieu";
            repositoryItemVT.ValueMember = "MaTaiLieu";
            gcBaoTapChi.RepositoryItems.Add(repositoryItemVT);
            colMaTaiLieu.ColumnEdit = repositoryItemVT;

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
                gcBaoTapChi.Dock = DockStyle.Top;
                gcKyXuatBan.Dock = DockStyle.Fill;
                cmsKyXB.Enabled = false;
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

                gcBaoTapChi.Dock = DockStyle.Top;
                pncNhapLieu.Dock = DockStyle.Left;
                gcKyXuatBan.Dock = DockStyle.Fill;
                cmsKyXB.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsBaoTapChi.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            lblID.Visible = false;
            txtID.Visible = false;

            bdsBaoTapChi.AddNew();
            namPhatHanhDateEdit.DateTime = DateTime.Today;
            maTaiLieuComboBox.SelectedIndex = 0;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcBaoTapChi.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lblID.Visible = true;
            txtID.Visible = true;
            bdsBaoTapChi.CancelEdit();
            if (btnThem.Enabled == false) bdsBaoTapChi.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false;
            gcBaoTapChi.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsBaoTapChi.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcBaoTapChi.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtID.Enabled = false;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsBaoTapChi.Current).Row.ItemArray;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                Program.WarningMessage("ID sách không thể trống!");
                txtID.Focus();
                return;
            }

            if (oldDataRow == null || oldDataRow[0].ToString() != txtID.Text)
            {
                Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_BTC '{txtID.Text}'");
                bool isExisted = Program.myReader.Read();
                Program.myReader.Close();
                Program.conn.Close();
                if (isExisted)
                {
                    Program.WarningMessage("ID sách đã tồn tại!");
                    txtID.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(dinhKyTextBox.Text.Trim()))
            {
                Program.WarningMessage("Tên không thể trống!");
                dinhKyTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nhaXBTextBox.Text.Trim()))
            {
                Program.WarningMessage("Tên không thể trống!");
                nhaXBTextBox.Focus();
                return;
            }



            try
            {
                bdsBaoTapChi.EndEdit();
                bdsBaoTapChi.ResetCurrentItem();
                this.baoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.baoTapChiTableAdapter.Update(this.quanLyThuVienDataSet.BaoTapChi);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcBaoTapChi.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            lblID.Visible = true;
            txtID.Visible = true;

        }

        private void iDBTCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void dinhKyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (dinhKyTextBox.SelectionStart == 0 || dinhKyTextBox.Text[dinhKyTextBox.SelectionStart - 1] == ' '
                || (dinhKyTextBox.SelectionStart != dinhKyTextBox.Text.Length && dinhKyTextBox.Text[dinhKyTextBox.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void nhaXBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && (nhaXBTextBox.SelectionStart == 0 || nhaXBTextBox.Text[nhaXBTextBox.SelectionStart - 1] == ' '
                || (nhaXBTextBox.SelectionStart != nhaXBTextBox.Text.Length && nhaXBTextBox.Text[nhaXBTextBox.SelectionStart] == ' ')))
                e.Handled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKyXuatBan.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Có trong kỳ xuất bản!");
                return;
            }

            if (bdsCTMuonBaoTapChi.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Người này vẫn chưa trả tài liệu!");
                return;
            }
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            int idBTC = 0;
            try
            {
                idBTC = int.Parse(((DataRowView)bdsBaoTapChi.Current)["IDBTC"].ToString());
                bdsBaoTapChi.RemoveCurrent();
                this.baoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.baoTapChiTableAdapter.Update(this.quanLyThuVienDataSet.BaoTapChi);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                this.baoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.BaoTapChi);

                bdsBaoTapChi.Position = bdsBaoTapChi.Find("IDBTC", idBTC);
                return;
            }
            // KHÓA THAO TÁC XÓA KHI DANH SÁCH NHÂN VIÊN TRỐNG.
            if (bdsBaoTapChi.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.baoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.BaoTapChi);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void gcKyXuatBan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gcKyXuatBan.ContextMenuStrip = cmsKyXB;
            }
        }

        private void tmsiThem_Click(object sender, EventArgs e)
        {
            int idBTC  = Int32.Parse(((DataRowView)bdsBaoTapChi.Current)["IDBTC"].ToString());
            string nhaXB =  ((DataRowView)bdsBaoTapChi.Current)["NHAXB"].ToString();
            frmKyXuatBanBao frm = new frmKyXuatBanBao(idBTC, nhaXB);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Program.ExecSqlNonQuery(frm.query) == 0)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    this.kyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.KyXuatBan);
                }
                else
                {
                    //That Bai
                    MessageBox.Show("Thất bại!");
                }
            }
            frm.Dispose();
        }

        private void tsmiHieuChinh_Click(object sender, EventArgs e)
        {
            int idKXB = Int32.Parse(((DataRowView)bdsKyXuatBan.Current)["IDKyXuatBan"].ToString());
            int idBTC = Int32.Parse(((DataRowView)bdsBaoTapChi.Current)["IDBTC"].ToString());
            string nhaXB = ((DataRowView)bdsBaoTapChi.Current)["NHAXB"].ToString();
            int lanXB = Int32.Parse(((DataRowView)bdsKyXuatBan.Current)["LanXB"].ToString());
            int soLuong = Int32.Parse(((DataRowView)bdsKyXuatBan.Current)["SoLuongNhap"].ToString());
            frmHieuChinhBTC frm = new frmHieuChinhBTC(idKXB, idBTC, nhaXB, lanXB, soLuong);
            while (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(frm.query);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                if(result == 0)
                {
                    MessageBox.Show("Số lượng nhập hiệu chỉnh nhỏ hơn số lượng đã cho mượn!\n", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hiệu chỉnh thành công!\n", "Thông báo", MessageBoxButtons.OK);
                    this.kyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.KyXuatBan);
                    break;
                }
            }
            frm.Dispose();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
