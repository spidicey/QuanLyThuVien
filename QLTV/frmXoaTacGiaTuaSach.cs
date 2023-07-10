using DevExpress.XtraEditors;
using System;
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
    public partial class frmXoaTacGiaTuaSach : DevExpress.XtraEditors.XtraForm
    {
        private int idTuaSach;
        private string tenTuaSach;
        private int viTri;
        private DataTable dt;
        public frmXoaTacGiaTuaSach()
        {
            InitializeComponent();
        }

        public frmXoaTacGiaTuaSach(int idTuaSach, string tenTuaSach)
        {
            InitializeComponent();
            this.idTuaSach = idTuaSach;
            this.tenTuaSach = tenTuaSach;
        }

        private void frmXoaTacGiaTuaSach_Load(object sender, EventArgs e)
        {
            lblTuaSach.Text = lblTuaSach.Text + " " + tenTuaSach;
        
            dt = new DataTable();
            string query = $"EXEC XoaTacGiaTuaSach '{idTuaSach}' ";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
                if(Program.myReader == null) 
                {
                    return;
                }
                //Program.myReader.Read();
               dt.Load(Program.myReader);
               gvTacGia.DataSource = dt;
               Program.myReader.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi thực thi database\n" + ex.Message, "Thông báo",MessageBoxButtons.OK);
            }
            dieuChinhDoRongGirdView();
        }

        private void dieuChinhDoRongGirdView()
        {
            gvTacGia.Columns[0].Width = 100;
            gvTacGia.Columns[1].Width = 366;
            gvTacGia.Columns[2].Width = 200;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {           
            string maTacGia = gvTacGia.Rows[viTri].Cells[0].Value.ToString().Trim();
            string query = $"DELETE FROM CTSach WHERE IDTuaSach = '{idTuaSach}' AND MaTacGia = '{maTacGia}' ";
            if (MessageBox.Show("Bạn muốn xóa ?", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Program.ExecSqlNonQuery(query) == 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                    gvTacGia.Rows.RemoveAt(gvTacGia.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
               

        }

        private void gvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            viTri = gvTacGia.CurrentCell.RowIndex;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}