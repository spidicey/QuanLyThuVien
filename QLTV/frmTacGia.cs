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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void tacGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTacGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyThuVienDataSet);

        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);

        }
    }
}