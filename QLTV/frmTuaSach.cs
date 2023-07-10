using DevExpress.XtraEditors.Repository;
using QLTV.QuanLyThuVienDataSetTableAdapters;
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
    public partial class frmTuaSach : Form
    {
        private int viTri;
        private object[] oldDataRow;
        public frmTuaSach()
        {
            InitializeComponent();
        }

        private void frmTuaSach_Load(object sender, EventArgs e)
        {       
            quanLyThuVienDataSet.EnforceConstraints = false;
            
            this.tuaSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tuaSachTableAdapter.Fill(this.quanLyThuVienDataSet.TuaSach);

            this.taiLieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiLieuTableAdapter.Fill(this.quanLyThuVienDataSet.TaiLieu);

            this.CTSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTSach);

            this.lanXuatBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lanXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.LanXuatBan);

            RepositoryItemLookUpEdit repositoryItemTV = new RepositoryItemLookUpEdit();
            repositoryItemTV.DataSource = bdsTaiLieu;
            repositoryItemTV.DisplayMember = "TenTaiLieu";
            repositoryItemTV.ValueMember = "MaTaiLieu";
            gcTuaSach.RepositoryItems.Add(repositoryItemTV);
            colMaTaiLieu.ColumnEdit = repositoryItemTV;

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
                gcTuaSach.Dock = DockStyle.Top;
                gcLanXuatBan.Dock = DockStyle.Left;
                gcCTSach.Dock = DockStyle.Fill;
                cmsKyXuatBan.Enabled = false;
                cmsCTSach.Enabled = false;
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

                gcTuaSach.Dock = DockStyle.Top;
                pncNhapLieu.Dock = DockStyle.Left;
                gcLanXuatBan.Dock = DockStyle.Left;
                gcCTSach.Dock = DockStyle.Fill;
                cmsKyXuatBan.Enabled = true;
                cmsCTSach.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTuaSach.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.
            bdsTuaSach.AddNew();

            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcTuaSach.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTuaSach.CancelEdit();
            if (btnThem.Enabled == false) bdsTuaSach.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false;
            gcLanXuatBan.Enabled = true;
            gcCTSach.Enabled = true;
            gcTuaSach.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*if (string.IsNullOrEmpty(iDTuaSachTextBox.Text.Trim()))
            {
                Program.WarningMessage("Mã tác giả không thể trống!");
                iDTuaSachTextBox.Focus();
                return;
            }*/

          /*  if (oldDataRow == null || oldDataRow[0].ToString() != iDTuaSachTextBox.Text)
            {
                int isExisted = bdsTuaSach.Find("IDTuaSach", iDTuaSachTextBox);
                if (isExisted >= 0)
                {
                    Program.WarningMessage("Mã tác giả đã tồn tại!");
                    iDTuaSachTextBox.Focus();
                    return;
                }
            }*/

            if (string.IsNullOrEmpty(tenTuaSachTextEdit.Text.Trim()))
            {
                Program.WarningMessage("Tên không thể trống!");
                tenTuaSachTextEdit.Focus();
                return;
            }

            try
            {
                bdsTuaSach.EndEdit();
                bdsTuaSach.ResetCurrentItem();
                this.tuaSachTableAdapter.Connection.ConnectionString = Program.connstr;
                this.tuaSachTableAdapter.Update(this.quanLyThuVienDataSet.TuaSach);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            gcTuaSach.Enabled = true;
            gcLanXuatBan.Enabled = true;
            gcCTSach.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsTuaSach.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcTuaSach.Enabled = false;
            gcLanXuatBan.Enabled = false;
            gcCTSach.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsTuaSach.Current).Row.ItemArray;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTSach.Count > 0)
            {
                Program.WarningMessage("Không thể xóa.  Tựa sách đã có tác giả!");
                return;
            }

            if (lanXuatBanBindingSource.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Đã xuất bản!");
                return;
            }

            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            String idTuaSach = "";
            try
            {
                idTuaSach = ((DataRowView)bdsTuaSach.Current)["IDTuaSach"].ToString();
                bdsTuaSach.RemoveCurrent();
                this.tuaSachTableAdapter.Connection.ConnectionString = Program.connstr;
                this.tuaSachTableAdapter.Update(this.quanLyThuVienDataSet.TuaSach);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                this.tuaSachTableAdapter.Fill(this.quanLyThuVienDataSet.TuaSach);

                bdsTuaSach.Position = bdsTuaSach.Find("IDTuaSach", idTuaSach);
                return;
            }
            // KHÓA THAO TÁC XÓA KHI DANH SÁCH NHÂN VIÊN TRỐNG.
            if (bdsTuaSach.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tuaSachTableAdapter.Fill(this.quanLyThuVienDataSet.TuaSach);
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


        private void gcKyXuatBan_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) 
            {
                gcLanXuatBan.ContextMenuStrip = cmsKyXuatBan;
            }
        }

        //Them Lan Xuat Ban
        private void tmsiThem_Click(object sender, EventArgs e)
        {
            int idTuaSach  =  Int32.Parse(((DataRowView)bdsTuaSach.Current)["IDTuaSach"].ToString()) ;
            string tuaSach  = ((DataRowView)bdsTuaSach.Current)["TenTuaSach"].ToString();
            frmLanKyXBSach frm = new frmLanKyXBSach(idTuaSach, tuaSach);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Program.ExecSqlNonQuery(frm.query) == 0)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    this.lanXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.LanXuatBan);
                }
                else
                {
                    //That Bai
                    MessageBox.Show("Thất bại!");
                }
            }
            frm.Dispose();
        }

        private void tsmiHieuChinhLXB_Click(object sender, EventArgs e)
        {
            int idLXB = Int32.Parse(((DataRowView)lanXuatBanBindingSource.Current)["IDLXB"].ToString());
            int idTuaSach = Int32.Parse(((DataRowView)bdsTuaSach.Current)["IDTuaSach"].ToString());
            string tuaSach = ((DataRowView)bdsTuaSach.Current)["TenTuaSach"].ToString();
            int lanXB = Int32.Parse(((DataRowView)lanXuatBanBindingSource.Current)["LanXB"].ToString());
            DateTime namXB = DateTime.Parse(((DataRowView)lanXuatBanBindingSource.Current)["NamXB"].ToString());
            string khoGiay = ((DataRowView)lanXuatBanBindingSource.Current)["KhoGiay"].ToString();
            int soTrang = Int32.Parse(((DataRowView)lanXuatBanBindingSource.Current)["SoTrang"].ToString());
            string nhaXB = ((DataRowView)lanXuatBanBindingSource.Current)["NhaXB"].ToString();
            float gia = float.Parse(((DataRowView)lanXuatBanBindingSource.Current)["Gia"].ToString());
            bool diaCD = Boolean.Parse(((DataRowView)lanXuatBanBindingSource.Current)["DiaCD"].ToString());

            frmHieuChinhLXB frm = new frmHieuChinhLXB(idLXB, idTuaSach, tuaSach, lanXB, namXB, khoGiay, soTrang, nhaXB, gia, diaCD) ;
            //frmHieuChinhLXB frm = new frmHieuChinhLXB();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Program.ExecSqlNonQuery(frm.query) == 0)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    this.lanXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.LanXuatBan);
                }
                else
                {
                    //That Bai
                    MessageBox.Show("Thất bại!");
                }
            }
            frm.Dispose();

        }   


        //CTSach
        private void tsmiThemCTSach_Click(object sender, EventArgs e)
        {
            int idTuaSach = Int32.Parse(((DataRowView)bdsTuaSach.Current)["IDTuaSach"].ToString());
            frmCTSach frm = new frmCTSach(idTuaSach);
            frm.ShowDialog();
            this.CTSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTSach);
        }

        private void gcCTSach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gcCTSach.ContextMenuStrip = cmsCTSach;
            }
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            int idTuaSach = Int32.Parse(((DataRowView)bdsTuaSach[bdsTuaSach.Position])["IDTuaSach"].ToString());
            string tenTuaSach = ((DataRowView)bdsTuaSach[bdsTuaSach.Position])["TenTuaSach"].ToString();    
            frmXoaTacGiaTuaSach frm = new frmXoaTacGiaTuaSach(idTuaSach, tenTuaSach);
            frm.ShowDialog();
            this.CTSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTSach);
        }

       
    }
}
