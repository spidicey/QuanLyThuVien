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
    public partial class frmMuonBao : DevExpress.XtraEditors.XtraForm
    {
        int sothe = 0;
        private int viTri;
        private object[] oldDataRow;
        public frmMuonBao(int sothe)
        {
            this.sothe = sothe;
            InitializeComponent();
        }

        private void frmMuonBao_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints=false;
            this.sP_GET_BAO_CO_THE_MUONTableAdapter.Fill(DS.SP_GET_BAO_CO_THE_MUON, sothe);
            this.sP_GET_CTMUONBAOTableAdapter.Fill(DS.SP_GET_CTMUONBAO, sothe);
            if (sothe == 0)
            {
                btnThem.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled  = false;
                btnTra.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            }
            else
            {
                btnPhucHoi.Enabled = btnGhi.Enabled = btnTra.Enabled  = false;
                btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            }
            pncNhapLieu.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsCTMB.Position;

            bdsCTMB.AddNew();
            txtSoThe.Text = sothe.ToString();
            txtNgayMuon.EditValue = DateTime.Today;

            sP_GET_CTMUONBAOGridControl.Enabled = false;
            pncNhapLieu.Enabled = true;
            btnThem.Enabled  = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            // LƯU TRỮ DỮ LIỆU TRƯỚC KHI THỰC HIỆN.
            oldDataRow = null;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIDKyXB.Text.ToString().CompareTo("") == 0)
            {
                MessageBox.Show("Chưa chọn báo!");
                return;
            }
            try
            {
                bdsCTMB.EndEdit();
                bdsCTMB.ResetCurrentItem();
                this.sP_GET_CTMUONBAOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTMUONBAOTableAdapter.Insert(Int32.Parse(txtSoThe.Text.ToString()), Int32.Parse(txtIDKyXB.Text.ToString()), DateTime.Parse(txtNgayMuon.Text.ToString()));
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            sP_GET_CTMUONBAOGridControl.Enabled = true;
            pncNhapLieu.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            try
            {
                this.sP_GET_CTMUONBAOTableAdapter.Fill(this.DS.SP_GET_CTMUONBAO, sothe);
                this.sP_GET_BAO_CO_THE_MUONTableAdapter.Fill(DS.SP_GET_BAO_CO_THE_MUON, sothe);
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtIDKyXB.EditValue = ((DataRowView)bdsBCTM[bdsBCTM.Position])["IDKyXuatBan"];
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTMB.CancelEdit();
            if (btnThem.Enabled == false) bdsCTMB.Position = viTri;
            pncNhapLieu.Enabled = false;
            sP_GET_CTMUONBAOGridControl.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DataRowView)bdsCTMB[bdsCTMB.Position])["NgayTra"].ToString().CompareTo("") != 0)
            {
                MessageBox.Show("Báo này đã được trả");
                return;
            }
            try
            {
                bdsCTMB.ResetCurrentItem();
                this.sP_GET_CTMUONBAOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTMUONBAOTableAdapter.Insert(Int32.Parse(((DataRowView)bdsCTMB[bdsCTMB.Position])["SoThe"].ToString()), Int32.Parse(((DataRowView)bdsCTMB[bdsCTMB.Position])["IDKyXB"].ToString()), DateTime.Parse(((DataRowView)bdsCTMB[bdsCTMB.Position])["NgayMuon"].ToString()));
            }
            catch (Exception ex)
            {
                Program.ErrorMessage(ex.Message);
                return;
            }
            try
            {
                this.sP_GET_CTMUONBAOTableAdapter.Fill(this.DS.SP_GET_CTMUONBAO, sothe);
                this.sP_GET_BAO_CO_THE_MUONTableAdapter.Fill(DS.SP_GET_BAO_CO_THE_MUON, sothe);
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
                this.sP_GET_CTMUONBAOTableAdapter.Fill(this.DS.SP_GET_CTMUONBAO, sothe);
                this.sP_GET_BAO_CO_THE_MUONTableAdapter.Fill(DS.SP_GET_BAO_CO_THE_MUON, sothe);
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