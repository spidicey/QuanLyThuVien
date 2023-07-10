using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class frmBaoTapChiDG : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        public frmBaoTapChiDG()
        {
            InitializeComponent();
            
            
        }

        private void BaoTapChiDG_Load(object sender, EventArgs e)
        {
            this.quanLyThuVienDataSet.EnforceConstraints = false;
            /*this.restrictedKyXuatBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.restrictedKyXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet.RestrictedKyXuatBan);*/
            this.baoTapChiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.baoTapChiTableAdapter.Fill(this.quanLyThuVienDataSet.BaoTapChi);

        }

        private void gcBaoTapChi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dt = new DataTable();
            gcRestrictedKXB.DataSource = null;
            gcRestrictedKXB.RefreshDataSource();
            int idBTC = Int32.Parse(((DataRowView)bdsBTC[bdsBTC.Position])["IDBTC"].ToString());
            string query = $"SELECT * FROM RestrictedKyXuatBan WHERE IDBTC = '{idBTC}' ";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
                if (Program.myReader == null)
                {
                    return;
                }
                dt.Load(Program.myReader);
                gcRestrictedKXB.DataSource = dt;
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi database!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}