namespace QLTV
{
    partial class frmBaoTapChiDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoTapChiDG));
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bdsBTC = new System.Windows.Forms.BindingSource(this.components);
            this.baoTapChiTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BaoTapChiTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.restrictedKyXuatBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restrictedKyXuatBanTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.RestrictedKyXuatBanTableAdapter();
            this.gcRestrictedKXB = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDBTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamPhatHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDinhKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTaiLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBaoTapChi = new DevExpress.XtraGrid.GridControl();
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictedKyXuatBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRestrictedKXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBTC
            // 
            this.bdsBTC.DataMember = "BaoTapChi";
            this.bdsBTC.DataSource = this.quanLyThuVienDataSet;
            // 
            // baoTapChiTableAdapter
            // 
            this.baoTapChiTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.TuaSachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restrictedKyXuatBanBindingSource
            // 
            this.restrictedKyXuatBanBindingSource.DataMember = "RestrictedKyXuatBan";
            this.restrictedKyXuatBanBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // restrictedKyXuatBanTableAdapter
            // 
            this.restrictedKyXuatBanTableAdapter.ClearBeforeFill = true;
            // 
            // gcRestrictedKXB
            // 
            this.gcRestrictedKXB.DataSource = this.restrictedKyXuatBanBindingSource;
            this.gcRestrictedKXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRestrictedKXB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcRestrictedKXB.Location = new System.Drawing.Point(0, 364);
            this.gcRestrictedKXB.MainView = this.gridView2;
            this.gcRestrictedKXB.Margin = new System.Windows.Forms.Padding(4);
            this.gcRestrictedKXB.Name = "gcRestrictedKXB";
            this.gcRestrictedKXB.Size = new System.Drawing.Size(831, 266);
            this.gcRestrictedKXB.TabIndex = 1;
            this.gcRestrictedKXB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 525;
            this.gridView2.GridControl = this.gcRestrictedKXB;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDBTC,
            this.colNamPhatHanh,
            this.colDinhKy,
            this.colNhaXB,
            this.colMaTaiLieu});
            this.gridView1.DetailHeight = 525;
            this.gridView1.GridControl = this.gcBaoTapChi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gcBaoTapChi_FocusedRowChanged);
            // 
            // colIDBTC
            // 
            this.colIDBTC.FieldName = "IDBTC";
            this.colIDBTC.MinWidth = 45;
            this.colIDBTC.Name = "colIDBTC";
            this.colIDBTC.Visible = true;
            this.colIDBTC.VisibleIndex = 0;
            this.colIDBTC.Width = 168;
            // 
            // colNamPhatHanh
            // 
            this.colNamPhatHanh.FieldName = "NamPhatHanh";
            this.colNamPhatHanh.MinWidth = 45;
            this.colNamPhatHanh.Name = "colNamPhatHanh";
            this.colNamPhatHanh.Visible = true;
            this.colNamPhatHanh.VisibleIndex = 1;
            this.colNamPhatHanh.Width = 168;
            // 
            // colDinhKy
            // 
            this.colDinhKy.FieldName = "DinhKy";
            this.colDinhKy.MinWidth = 45;
            this.colDinhKy.Name = "colDinhKy";
            this.colDinhKy.Visible = true;
            this.colDinhKy.VisibleIndex = 2;
            this.colDinhKy.Width = 168;
            // 
            // colNhaXB
            // 
            this.colNhaXB.FieldName = "NhaXB";
            this.colNhaXB.MinWidth = 45;
            this.colNhaXB.Name = "colNhaXB";
            this.colNhaXB.Visible = true;
            this.colNhaXB.VisibleIndex = 3;
            this.colNhaXB.Width = 168;
            // 
            // colMaTaiLieu
            // 
            this.colMaTaiLieu.FieldName = "MaTaiLieu";
            this.colMaTaiLieu.MinWidth = 45;
            this.colMaTaiLieu.Name = "colMaTaiLieu";
            this.colMaTaiLieu.Visible = true;
            this.colMaTaiLieu.VisibleIndex = 4;
            this.colMaTaiLieu.Width = 168;
            // 
            // gcBaoTapChi
            // 
            this.gcBaoTapChi.DataSource = this.bdsBTC;
            this.gcBaoTapChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBaoTapChi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcBaoTapChi.Location = new System.Drawing.Point(0, 34);
            this.gcBaoTapChi.MainView = this.gridView1;
            this.gcBaoTapChi.Margin = new System.Windows.Forms.Padding(4);
            this.gcBaoTapChi.Name = "gcBaoTapChi";
            this.gcBaoTapChi.Size = new System.Drawing.Size(831, 330);
            this.gcBaoTapChi.TabIndex = 1;
            this.gcBaoTapChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Tools";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.FloatLocation = new System.Drawing.Point(377, 288);
            this.barMenu.Offset = 1;
            this.barMenu.Text = "Tools";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(377, 288);
            this.bar1.Offset = 1;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(377, 288);
            this.bar2.Offset = 1;
            this.bar2.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(377, 288);
            this.bar3.Offset = 1;
            this.bar3.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(377, 288);
            this.bar4.Offset = 1;
            this.bar4.Text = "Tools";
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5,
            this.bar6});
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
            this.bmrChucNang.StatusBar = this.bar6;
            // 
            // bar5
            // 
            this.bar5.BarName = "Tools";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.FloatLocation = new System.Drawing.Point(377, 288);
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar5.Offset = 1;
            this.bar5.Text = "Tools";
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
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmrChucNang;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(831, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 630);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(831, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 596);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(831, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // frmBaoTapChiDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 650);
            this.Controls.Add(this.gcRestrictedKXB);
            this.Controls.Add(this.gcBaoTapChi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBaoTapChiDG";
            this.Text = "BaoTapChiDG";
            this.Load += new System.EventHandler(this.BaoTapChiDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictedKyXuatBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRestrictedKXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bdsBTC;
        private QuanLyThuVienDataSetTableAdapters.BaoTapChiTableAdapter baoTapChiTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource restrictedKyXuatBanBindingSource;
        private QuanLyThuVienDataSetTableAdapters.RestrictedKyXuatBanTableAdapter restrictedKyXuatBanTableAdapter;
        private DevExpress.XtraGrid.GridControl gcRestrictedKXB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNamPhatHanh;
        private DevExpress.XtraGrid.Columns.GridColumn colDinhKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaXB;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiLieu;
        private DevExpress.XtraGrid.GridControl gcBaoTapChi;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarManager bmrChucNang;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
    }
}