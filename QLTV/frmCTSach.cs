using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmCTSach : DevExpress.XtraEditors.XtraForm
    {
        private List<List<string>> lstTacGia = new List<List<string>>();
        private int idTuaSach;
        public frmCTSach()
        {
            InitializeComponent();
        }

        public frmCTSach(int idTuaSach)
        {
            InitializeComponent();
            this.idTuaSach = idTuaSach;
        }

        private void tacGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTacGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }

        private void frmCTSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string maTacGia = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MaTacGia"].ToString();
            string tenTacGia = ((DataRowView)bdsTacGia[bdsTacGia.Position])["TenTacGia"].ToString();
            string namSinh = ((DataRowView)bdsTacGia[bdsTacGia.Position])["NamSinh"].ToString();
            foreach (List<string> i in lstTacGia)
            {
                if (i[0].Equals(maTacGia))
                {
                    return;
                }
            }
            List<string> rowTacGia = new List<string>();
            rowTacGia.Add(maTacGia);
            rowTacGia.Add(tenTacGia);
            rowTacGia.Add(namSinh);
            gvTacGia.Rows.Add(maTacGia, tenTacGia, namSinh);
            lstTacGia.Add(rowTacGia);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstTacGia.RemoveAt(gvTacGia.CurrentRow.Index);
            gvTacGia.Rows.RemoveAt(gvTacGia.CurrentRow.Index);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaTacGia", typeof(string));
                dt.Columns.Add("IDTuaSach", typeof(string));

                foreach (DataGridViewRow row in gvTacGia.Rows)
                {
                    dt.Rows.Add(row.Cells["txtMaTacGia"].Value, idTuaSach);
                    //MessageBox.Show(row.Cells["txtMaTacGia"].Value.ToString(), "");
                }
                
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_CTSach";
                para.ParameterName = "@CTSach";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand Sqlcmd = new SqlCommand("SP_CTSach", Program.conn);
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK);
                this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu nhập \n" + ex.Message, "Xác nhận", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}