namespace QLTV
{
    partial class frmCTSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.gcTacGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvTacGia = new System.Windows.Forms.DataGridView();
            this.txtMaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTacGia
            // 
            this.bdsTacGia.DataMember = "TacGia";
            this.bdsTacGia.DataSource = this.quanLyThuVienDataSet;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoTapChiTableAdapter = null;
            this.tableAdapterManager.CTMuonBaoTapChiTableAdapter = null;
            this.tableAdapterManager.CTMuonSachTableAdapter = null;
            this.tableAdapterManager.CTSachTableAdapter = null;
            this.tableAdapterManager.CuonSachTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.KyXuatBanTableAdapter = null;
            this.tableAdapterManager.LanXuatBanTableAdapter = null;
            this.tableAdapterManager.SACH_CO_THE_MUONTableAdapter = null;
            this.tableAdapterManager.SP_GET_CTMUONBAOTableAdapter = null;
            this.tableAdapterManager.SP_GET_CTMUONSACHTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = this.tacGiaTableAdapter;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.TuaSachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTacGia
            // 
            this.gcTacGia.DataSource = this.bdsTacGia;
            this.gcTacGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcTacGia.Location = new System.Drawing.Point(0, 0);
            this.gcTacGia.MainView = this.gridView1;
            this.gcTacGia.Name = "gcTacGia";
            this.gcTacGia.Size = new System.Drawing.Size(469, 358);
            this.gcTacGia.TabIndex = 1;
            this.gcTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTacGia,
            this.colTenTacGia,
            this.colNamSinh});
            this.gridView1.GridControl = this.gcTacGia;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.FieldName = "MaTacGia";
            this.colMaTacGia.MinWidth = 30;
            this.colMaTacGia.Name = "colMaTacGia";
            this.colMaTacGia.Visible = true;
            this.colMaTacGia.VisibleIndex = 0;
            this.colMaTacGia.Width = 112;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.FieldName = "TenTacGia";
            this.colTenTacGia.MinWidth = 30;
            this.colTenTacGia.Name = "colTenTacGia";
            this.colTenTacGia.Visible = true;
            this.colTenTacGia.VisibleIndex = 1;
            this.colTenTacGia.Width = 112;
            // 
            // colNamSinh
            // 
            this.colNamSinh.FieldName = "NamSinh";
            this.colNamSinh.MinWidth = 30;
            this.colNamSinh.Name = "colNamSinh";
            this.colNamSinh.Visible = true;
            this.colNamSinh.VisibleIndex = 2;
            this.colNamSinh.Width = 112;
            // 
            // gvTacGia
            // 
            this.gvTacGia.AllowUserToAddRows = false;
            this.gvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaTacGia,
            this.txtTenTacGia,
            this.txtNamSinh});
            this.gvTacGia.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvTacGia.Location = new System.Drawing.Point(580, 0);
            this.gvTacGia.Name = "gvTacGia";
            this.gvTacGia.ReadOnly = true;
            this.gvTacGia.RowHeadersWidth = 62;
            this.gvTacGia.RowTemplate.Height = 28;
            this.gvTacGia.Size = new System.Drawing.Size(489, 358);
            this.gvTacGia.TabIndex = 2;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.HeaderText = "Mã tác giả";
            this.txtMaTacGia.MinimumWidth = 8;
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.ReadOnly = true;
            this.txtMaTacGia.Width = 150;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.HeaderText = "Tên tác giả";
            this.txtTenTacGia.MinimumWidth = 8;
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.ReadOnly = true;
            this.txtTenTacGia.Width = 150;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.HeaderText = "Năm sinh";
            this.txtNamSinh.MinimumWidth = 8;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.ReadOnly = true;
            this.txtNamSinh.Width = 150;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1069, 358);
            this.panelControl1.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(485, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(485, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnXacNhan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 358);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1069, 100);
            this.panelControl2.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(548, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 47);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(383, 27);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(148, 47);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmCTSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 458);
            this.Controls.Add(this.gvTacGia);
            this.Controls.Add(this.gcTacGia);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmCTSach";
            this.Text = "frmCTSach";
            this.Load += new System.EventHandler(this.frmCTSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSinh;
        private System.Windows.Forms.DataGridView gvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNamSinh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
    }
}