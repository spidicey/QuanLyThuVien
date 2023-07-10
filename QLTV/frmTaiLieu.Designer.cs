namespace QLTV
{
    partial class frmTaiLieu
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
            System.Windows.Forms.Label maTaiLieuLabel;
            System.Windows.Forms.Label tenTaiLieuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiLieu));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bdsTaiLieu = new System.Windows.Forms.BindingSource(this.components);
            this.taiLieuTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.TaiLieuTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.baoTapChiTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BaoTapChiTableAdapter();
            this.tuaSachTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.TuaSachTableAdapter();
            this.gcTaiLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTaiLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTuaSach = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBaoTapChi = new System.Windows.Forms.BindingSource(this.components);
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.maTaiLieuTextBox = new System.Windows.Forms.TextBox();
            this.tenTaiLieuTextBox = new System.Windows.Forms.TextBox();
            maTaiLieuLabel = new System.Windows.Forms.Label();
            tenTaiLieuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // maTaiLieuLabel
            // 
            maTaiLieuLabel.AutoSize = true;
            maTaiLieuLabel.Location = new System.Drawing.Point(90, 79);
            maTaiLieuLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            maTaiLieuLabel.Name = "maTaiLieuLabel";
            maTaiLieuLabel.Size = new System.Drawing.Size(96, 19);
            maTaiLieuLabel.TabIndex = 12;
            maTaiLieuLabel.Text = "Ma Tai Lieu:";
            // 
            // tenTaiLieuLabel
            // 
            tenTaiLieuLabel.AutoSize = true;
            tenTaiLieuLabel.Location = new System.Drawing.Point(83, 159);
            tenTaiLieuLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tenTaiLieuLabel.Name = "tenTaiLieuLabel";
            tenTaiLieuLabel.Size = new System.Drawing.Size(103, 19);
            tenTaiLieuLabel.TabIndex = 10;
            tenTaiLieuLabel.Text = "Ten Tai Lieu:";
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bmrChucNang.DockControls.Add(this.barDockControlTop);
            this.bmrChucNang.DockControls.Add(this.barDockControlBottom);
            this.bmrChucNang.DockControls.Add(this.barDockControlLeft);
            this.bmrChucNang.DockControls.Add(this.barDockControlRight);
            this.bmrChucNang.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmrChucNang.Form = this;
            this.bmrChucNang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnChuyenChiNhanh,
            this.btnInDanhSach});
            this.bmrChucNang.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmrChucNang;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1252, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1252, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1252, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 507);
            // 
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btnChuyenChiNhanh.Id = 7;
            this.btnChuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.SvgImage")));
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            this.btnChuyenChiNhanh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách";
            this.btnInDanhSach.Id = 8;
            this.btnInDanhSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDanhSach.ImageOptions.SvgImage")));
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTaiLieu
            // 
            this.bdsTaiLieu.DataMember = "TaiLieu";
            this.bdsTaiLieu.DataSource = this.quanLyThuVienDataSet;
            // 
            // taiLieuTableAdapter
            // 
            this.taiLieuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoTapChiTableAdapter = this.baoTapChiTableAdapter;
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
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = this.taiLieuTableAdapter;
            this.tableAdapterManager.TuaSachTableAdapter = this.tuaSachTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // baoTapChiTableAdapter
            // 
            this.baoTapChiTableAdapter.ClearBeforeFill = true;
            // 
            // tuaSachTableAdapter
            // 
            this.tuaSachTableAdapter.ClearBeforeFill = true;
            // 
            // gcTaiLieu
            // 
            this.gcTaiLieu.DataSource = this.bdsTaiLieu;
            this.gcTaiLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTaiLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcTaiLieu.Location = new System.Drawing.Point(0, 34);
            this.gcTaiLieu.MainView = this.gridView1;
            this.gcTaiLieu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcTaiLieu.MenuManager = this.bmrChucNang;
            this.gcTaiLieu.Name = "gcTaiLieu";
            this.gcTaiLieu.Size = new System.Drawing.Size(1252, 263);
            this.gcTaiLieu.TabIndex = 5;
            this.gcTaiLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTaiLieu,
            this.colTenTaiLieu});
            this.gridView1.DetailHeight = 807;
            this.gridView1.GridControl = this.gcTaiLieu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaTaiLieu
            // 
            this.colMaTaiLieu.FieldName = "MaTaiLieu";
            this.colMaTaiLieu.MinWidth = 45;
            this.colMaTaiLieu.Name = "colMaTaiLieu";
            this.colMaTaiLieu.Visible = true;
            this.colMaTaiLieu.VisibleIndex = 0;
            this.colMaTaiLieu.Width = 168;
            // 
            // colTenTaiLieu
            // 
            this.colTenTaiLieu.FieldName = "TenTaiLieu";
            this.colTenTaiLieu.MinWidth = 45;
            this.colTenTaiLieu.Name = "colTenTaiLieu";
            this.colTenTaiLieu.Visible = true;
            this.colTenTaiLieu.VisibleIndex = 1;
            this.colTenTaiLieu.Width = 168;
            // 
            // bdsTuaSach
            // 
            this.bdsTuaSach.DataMember = "FK_TuaSach_TaiLieu";
            this.bdsTuaSach.DataSource = this.bdsTaiLieu;
            // 
            // bdsBaoTapChi
            // 
            this.bdsBaoTapChi.DataMember = "FK_BaoTapChi_TaiLieu";
            this.bdsBaoTapChi.DataSource = this.bdsTaiLieu;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(maTaiLieuLabel);
            this.pncNhapLieu.Controls.Add(this.maTaiLieuTextBox);
            this.pncNhapLieu.Controls.Add(tenTaiLieuLabel);
            this.pncNhapLieu.Controls.Add(this.tenTaiLieuTextBox);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 297);
            this.pncNhapLieu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1252, 244);
            this.pncNhapLieu.TabIndex = 6;
            // 
            // maTaiLieuTextBox
            // 
            this.maTaiLieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTaiLieu, "MaTaiLieu", true));
            this.maTaiLieuTextBox.Location = new System.Drawing.Point(252, 72);
            this.maTaiLieuTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.maTaiLieuTextBox.Name = "maTaiLieuTextBox";
            this.maTaiLieuTextBox.Size = new System.Drawing.Size(220, 27);
            this.maTaiLieuTextBox.TabIndex = 13;
            // 
            // tenTaiLieuTextBox
            // 
            this.tenTaiLieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTaiLieu, "TenTaiLieu", true));
            this.tenTaiLieuTextBox.Location = new System.Drawing.Point(254, 152);
            this.tenTaiLieuTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tenTaiLieuTextBox.Name = "tenTaiLieuTextBox";
            this.tenTaiLieuTextBox.Size = new System.Drawing.Size(220, 27);
            this.tenTaiLieuTextBox.TabIndex = 11;
            // 
            // frmTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 541);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcTaiLieu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaiLieu";
            this.Text = "frmTaiLieu";
            this.Load += new System.EventHandler(this.frmTaiLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmrChucNang;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private System.Windows.Forms.BindingSource bdsTaiLieu;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private QuanLyThuVienDataSetTableAdapters.TaiLieuTableAdapter taiLieuTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTaiLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiLieu;
        private QuanLyThuVienDataSetTableAdapters.TuaSachTableAdapter tuaSachTableAdapter;
        private System.Windows.Forms.BindingSource bdsTuaSach;
        private QuanLyThuVienDataSetTableAdapters.BaoTapChiTableAdapter baoTapChiTableAdapter;
        private System.Windows.Forms.BindingSource bdsBaoTapChi;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.TextBox maTaiLieuTextBox;
        private System.Windows.Forms.TextBox tenTaiLieuTextBox;
    }
}