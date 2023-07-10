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
    public partial class frmCuonSach : Form
    {
        private int viTri;
        private object[] oldDataRow;
        private bool them = false;
        public frmCuonSach()
        {
            InitializeComponent();
        }

        
        private void frmCuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.GET_TEN_SACH' table. You can move, or remove it, as needed.
            this.gET_TEN_SACHTableAdapter.Fill(this.quanLyThuVienDataSet.GET_TEN_SACH);
            quanLyThuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LanXuatBan' table. You can move, or remove it, as needed.
            this.lanXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.LanXuatBan);
            this.cuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cuonSachTableAdapter.Fill(this.quanLyThuVienDataSet.CuonSach);


            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LanXuatBan' table. You can move, or remove it, as needed.
            this.lanXuatBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lanXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.LanXuatBan);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LanXuatBan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CTMuonSach' table. You can move, or remove it, as needed.
            this.cTMuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTMuonSachTableAdapter.Fill(this.quanLyThuVienDataSet.CTMuonSach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CuonSach' table. You can move, or remove it, as needed.
            RepositoryItemLookUpEdit repositoryItemVT = new RepositoryItemLookUpEdit();
            repositoryItemVT.DataSource = bdsGET_TEN_SACHB;
            repositoryItemVT.DisplayMember = "TenTuaSach";
            repositoryItemVT.ValueMember = "IDCuonSach";
            gcCTMuonSach.RepositoryItems.Add(repositoryItemVT);
            colIDCuonSach1.ColumnEdit = repositoryItemVT;
            pncNhapLieu.Enabled = false;
        }

        

        private void btnThemCTMuonSach_Click(object sender, EventArgs e)
        {
           
            string maSach = ((DataRowView)bdsCuonSach.Current).Row["IDCuonSach"].ToString();
            DataTable dt = Program.ExecSqlDataTable($"EXEC SP_GET_ORDERED_GOODS '{maSach}'");
            Program.conn.Close();

            if (dt.Rows.Count == 0)
            {
                Program.WarningMessage("!");
                return;
            }
            dt.DefaultView.Sort = "TENVT ASC";

            bdsCTMuonSach.AddNew();
           // new frmNhapXuatVatTu(maPN, dt, this).Show();
        }

        private void btnXoaCTMuonSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            them = true;
            lbID.Visible = false;
            iDCuonSachTextBox.Visible = false;
            txtSTT.Visible = false;
            lbSTT.Visible = false;
            viTri = bdsCuonSach.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.

            bdsCuonSach.AddNew();
            iDCuonSachTextBox.Text = "";
            txtSTT.Text = "";
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.
            gcCuonSach.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbIDLXB.Enabled = true;
            them = false;
            lbID.Visible = true;
            iDCuonSachTextBox.Visible = true;
            txtSTT.Visible = true;
            lbSTT.Visible = true;
            bdsCuonSach.CancelEdit();
            if (btnThem.Enabled == false) bdsCuonSach.Position = viTri;
            // THIẾT LẬP CHẾ ĐỘ KHI PHỤC HỒI.
            pncNhapLieu.Enabled = false;   
            gcCuonSach.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(them == true)
            {
                lbID.Visible = true;
                iDCuonSachTextBox.Visible = true;
                txtSTT.Visible = true;
                lbSTT.Visible = true;
                if (string.IsNullOrEmpty(txtTinhTrang.Text.Trim()))
                {
                    Program.WarningMessage("Tình trạng sách không thể trống!");
                    iDCuonSachTextBox.Focus();
                    return;
                }

                int idLXB = Int32.Parse(cmbIDLXB.SelectedValue.ToString());
                string tinhTrang = txtTinhTrang.Text.ToString();
                string query = $"EXEC Them_Cuon_Sach '{idLXB}', '{tinhTrang}' ";
                if (Program.ExecSqlNonQuery(query) == 0)
                {
                    Program.SuccessMessage();
                }

                this.cuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cuonSachTableAdapter.Fill(quanLyThuVienDataSet.CuonSach);
            }
            else 
            {
                try
                {
                    bdsCuonSach.EndEdit();
                    bdsCuonSach.ResetCurrentItem();
                    this.cuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cuonSachTableAdapter.Update(this.quanLyThuVienDataSet.CuonSach);
                }
                catch (Exception ex)
                {
                    Program.ErrorMessage(ex.Message);
                    return;
                }
            }
            cmbIDLXB.Enabled = true;



            /* if (oldDataRow == null || oldDataRow[0].ToString() != iDCuonSachTextBox.Text)
             {
                 Program.myReader = Program.ExecSqlDataReader($"EXEC SP_CHECK_CUON_SACH '{iDCuonSachTextBox.Text}'");
                 bool isExisted = Program.myReader.Read();
                 Program.myReader.Close();
                 Program.conn.Close();
                 if (isExisted)
                 {
                     Program.WarningMessage("ID sách đã tồn tại!");
                     iDCuonSachTextBox.Focus();
                     return;
                 }
             }*/

            /* if (string.IsNullOrEmpty(txtSTT.Text.Trim()))
             {
                 Program.WarningMessage("Tên không thể trống!");
                 txtSTT.Focus();
                 return;
             }*/



            /*try
            {
                bdsCuonSach.EndEdit();
                bdsCuonSach.ResetCurrentItem();
                this.cuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cuonSachTableAdapter.Update(this.quanLyThuVienDataSet.CuonSach);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }*/

            gcCuonSach.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

       

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbIDLXB.Enabled = false;
            them = false;
            viTri = bdsCuonSach.Position;
            // THIẾT LẬP CHẾ ĐỘ KHI HIỆU CHỈNH.
            gcCuonSach.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = ((DataRowView)bdsCuonSach.Current).Row.ItemArray;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTMuonSach.Count > 0)
            {
                Program.WarningMessage("Không thể xóa. Người này vẫn chưa trả sách!");
                return;
            }
            if (Program.ConfirmMessage() == DialogResult.Cancel) return;
            int soThe = 0;
            try
            {
                soThe = int.Parse(((DataRowView)bdsCuonSach.Current)["IDCuonSach"].ToString());
                bdsCuonSach.RemoveCurrent();
                this.cuonSachTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cuonSachTableAdapter.Update(this.quanLyThuVienDataSet.CuonSach);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                // KHÔI PHỤC DỮ LIỆU.
                this.cuonSachTableAdapter.Fill(this.quanLyThuVienDataSet.CuonSach);
                bdsCuonSach.Position = bdsCuonSach.Find("IDCuonSach", soThe);
                return;
            }
            // KHÓA THAO TÁC XÓA KHI DANH SÁCH NHÂN VIÊN TRỐNG.
            if (bdsCuonSach.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cuonSachTableAdapter.Fill(this.quanLyThuVienDataSet.CuonSach);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void gcCTMuonSach_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gcCTMuonSach.ContextMenuStrip = cmsCTMuonSach;
            }
        }

        private void iDCuonSachTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void sTTTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
