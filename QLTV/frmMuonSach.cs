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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        int sothe;
        private int viTri;
        private object[] oldDataRow;
        public frmMuonSach(int sothe)
        {
            this.sothe= sothe;
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.cT_SACH_CO_THE_MUONTableAdapter.Fill(this.DS.CT_SACH_CO_THE_MUON);
            this.sACH_CO_THE_MUONTableAdapter.Fill(this.DS.SACH_CO_THE_MUON);
            this.sP_GET_CTMUONSACHTableAdapter.Fill(this.DS.SP_GET_CTMUONSACH, sothe);
            if (sothe == 0)
            {
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            }
            else
            {
                btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnHieuChinh.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            pncNhapLieu.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsSPCTMS.Position;
            // THIẾT LẬP MỘT SỐ GIÁ TRỊ KHI THÊM.

            bdsSPCTMS.AddNew();
            txtSoThe.Text = sothe.ToString();
            txtNgayMuon.EditValue = DateTime.Today;
            // THIẾT LẬP CHẾ ĐỘ KHI THÊM.

            sP_GET_CTMUONSACHGridControl.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnInDanhSach.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void bdsSPCTMS_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gridView3_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtIDCuonSach.Text = ((DataRowView)bdsSCTM[bdsSCTM.Position])["IDCuonSach"].ToString();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIDCuonSach.Text.ToString().CompareTo("")==0)
            {
                MessageBox.Show("Chưa chọn sách!");
                return;
            }
            try
            {
                bdsSPCTMS.EndEdit();
                bdsSPCTMS.ResetCurrentItem();
                this.sP_GET_CTMUONSACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTMUONSACHTableAdapter.Insert(Int32.Parse(txtSoThe.Text.ToString()),Int32.Parse(txtIDCuonSach.Text.ToString()),DateTime.Parse(txtNgayMuon.Text.ToString()));
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            sP_GET_CTMUONSACHGridControl.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled  = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = false;
            try
            {
                this.cT_SACH_CO_THE_MUONTableAdapter.Fill(this.DS.CT_SACH_CO_THE_MUON);
                this.sACH_CO_THE_MUONTableAdapter.Fill(this.DS.SACH_CO_THE_MUON);
                this.sP_GET_CTMUONSACHTableAdapter.Fill(this.DS.SP_GET_CTMUONSACH, sothe);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSPCTMS.CancelEdit();
            if (btnThem.Enabled == false) bdsSPCTMS.Position = viTri;
            pncNhapLieu.Enabled = false;
            sP_GET_CTMUONSACHGridControl.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnHieuChinh.Enabled =  false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsSPCTMS.ResetCurrentItem();
                this.sP_GET_CTMUONSACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTMUONSACHTableAdapter.Delete(Int32.Parse(((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["SoThe"].ToString()), Int32.Parse(((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["IDCuonSach"].ToString()), DateTime.Parse(((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["NgayMuon"].ToString()));
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
        }
        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["NgayTra"].ToString().CompareTo("") !=0)
            {
                MessageBox.Show("Sách này đã được trả");
                return;
            }
            try
            {
                bdsSPCTMS.ResetCurrentItem();
                this.sP_GET_CTMUONSACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTMUONSACHTableAdapter.Insert(Int32.Parse(((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["SoThe"].ToString()), Int32.Parse(((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["IDCuonSach"].ToString()), DateTime.Parse(((DataRowView)bdsSPCTMS[bdsSPCTMS.Position])["NgayMuon"].ToString()));
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            try
            {
                this.cT_SACH_CO_THE_MUONTableAdapter.Fill(this.DS.CT_SACH_CO_THE_MUON);
                this.sACH_CO_THE_MUONTableAdapter.Fill(this.DS.SACH_CO_THE_MUON);
                this.sP_GET_CTMUONSACHTableAdapter.Fill(this.DS.SP_GET_CTMUONSACH, sothe);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void btnReload_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cT_SACH_CO_THE_MUONTableAdapter.Fill(this.DS.CT_SACH_CO_THE_MUON);
                this.sACH_CO_THE_MUONTableAdapter.Fill(this.DS.SACH_CO_THE_MUON);
                this.sP_GET_CTMUONSACHTableAdapter.Fill(this.DS.SP_GET_CTMUONSACH, sothe);
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