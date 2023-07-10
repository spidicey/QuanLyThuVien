namespace QLTV
{
    partial class frmBaoTapChi
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
            System.Windows.Forms.Label nhaXBLabel;
            System.Windows.Forms.Label dinhKyLabel;
            System.Windows.Forms.Label namPhatHanhLabel;
            System.Windows.Forms.Label maTaiLieuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoTapChi));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
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
            this.bdsBaoTapChi = new System.Windows.Forms.BindingSource(this.components);
            this.baoTapChiTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BaoTapChiTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.gcBaoTapChi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDBTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamPhatHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDinhKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTaiLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.maTaiLieuComboBox = new System.Windows.Forms.ComboBox();
            this.bdsTaiLieu = new System.Windows.Forms.BindingSource(this.components);
            this.nhaXBTextBox = new System.Windows.Forms.TextBox();
            this.dinhKyTextBox = new System.Windows.Forms.TextBox();
            this.namPhatHanhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bdsKyXuatBan = new System.Windows.Forms.BindingSource(this.components);
            this.kyXuatBanTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.KyXuatBanTableAdapter();
            this.gcKyXuatBan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKyXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTMuonBaoTapChi = new System.Windows.Forms.BindingSource(this.components);
            this.taiLieuTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.TaiLieuTableAdapter();
            this.cmsKyXB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHieuChinh = new System.Windows.Forms.ToolStripMenuItem();
            nhaXBLabel = new System.Windows.Forms.Label();
            dinhKyLabel = new System.Windows.Forms.Label();
            namPhatHanhLabel = new System.Windows.Forms.Label();
            maTaiLieuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namPhatHanhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namPhatHanhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKyXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBaoTapChi)).BeginInit();
            this.cmsKyXB.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhaXBLabel
            // 
            nhaXBLabel.AutoSize = true;
            nhaXBLabel.Location = new System.Drawing.Point(161, 221);
            nhaXBLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nhaXBLabel.Name = "nhaXBLabel";
            nhaXBLabel.Size = new System.Drawing.Size(66, 19);
            nhaXBLabel.TabIndex = 21;
            nhaXBLabel.Text = "Nha XB:";
            // 
            // dinhKyLabel
            // 
            dinhKyLabel.AutoSize = true;
            dinhKyLabel.Location = new System.Drawing.Point(157, 153);
            dinhKyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dinhKyLabel.Name = "dinhKyLabel";
            dinhKyLabel.Size = new System.Drawing.Size(70, 19);
            dinhKyLabel.TabIndex = 20;
            dinhKyLabel.Text = "Dinh Ky:";
            // 
            // namPhatHanhLabel
            // 
            namPhatHanhLabel.AutoSize = true;
            namPhatHanhLabel.Location = new System.Drawing.Point(101, 92);
            namPhatHanhLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            namPhatHanhLabel.Name = "namPhatHanhLabel";
            namPhatHanhLabel.Size = new System.Drawing.Size(126, 19);
            namPhatHanhLabel.TabIndex = 18;
            namPhatHanhLabel.Text = "Nam Phat Hanh:";
            // 
            // maTaiLieuLabel
            // 
            maTaiLieuLabel.AutoSize = true;
            maTaiLieuLabel.Location = new System.Drawing.Point(147, 432);
            maTaiLieuLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            maTaiLieuLabel.Name = "maTaiLieuLabel";
            maTaiLieuLabel.Size = new System.Drawing.Size(96, 19);
            maTaiLieuLabel.TabIndex = 24;
            maTaiLieuLabel.Text = "Ma Tai Lieu:";
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu});
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
            // barMenu
            // 
            this.barMenu.BarName = "Tools";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.FloatLocation = new System.Drawing.Point(377, 288);
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.barMenu.Offset = 1;
            this.barMenu.Text = "Tools";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1503, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1503, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 534);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1503, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 534);
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
            // bdsBaoTapChi
            // 
            this.bdsBaoTapChi.DataMember = "BaoTapChi";
            this.bdsBaoTapChi.DataSource = this.quanLyThuVienDataSet;
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
            // gcBaoTapChi
            // 
            this.gcBaoTapChi.DataSource = this.bdsBaoTapChi;
            this.gcBaoTapChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBaoTapChi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcBaoTapChi.Location = new System.Drawing.Point(0, 34);
            this.gcBaoTapChi.MainView = this.gridView1;
            this.gcBaoTapChi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcBaoTapChi.MenuManager = this.bmrChucNang;
            this.gcBaoTapChi.Name = "gcBaoTapChi";
            this.gcBaoTapChi.Size = new System.Drawing.Size(1503, 246);
            this.gcBaoTapChi.TabIndex = 5;
            this.gcBaoTapChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDBTC,
            this.colNamPhatHanh,
            this.colDinhKy,
            this.colNhaXB,
            this.colMaTaiLieu});
            this.gridView1.DetailHeight = 807;
            this.gridView1.GridControl = this.gcBaoTapChi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
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
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(this.lblID);
            this.pncNhapLieu.Controls.Add(this.txtID);
            this.pncNhapLieu.Controls.Add(maTaiLieuLabel);
            this.pncNhapLieu.Controls.Add(this.maTaiLieuComboBox);
            this.pncNhapLieu.Controls.Add(nhaXBLabel);
            this.pncNhapLieu.Controls.Add(this.nhaXBTextBox);
            this.pncNhapLieu.Controls.Add(dinhKyLabel);
            this.pncNhapLieu.Controls.Add(this.dinhKyTextBox);
            this.pncNhapLieu.Controls.Add(namPhatHanhLabel);
            this.pncNhapLieu.Controls.Add(this.namPhatHanhDateEdit);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 280);
            this.pncNhapLieu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(753, 288);
            this.pncNhapLieu.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(157, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 19);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "IDBTC:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTapChi, "IDBTC", true));
            this.txtID.Location = new System.Drawing.Point(285, 29);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MenuManager = this.bmrChucNang;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(225, 26);
            this.txtID.TabIndex = 26;
            // 
            // maTaiLieuComboBox
            // 
            this.maTaiLieuComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBaoTapChi, "MaTaiLieu", true));
            this.maTaiLieuComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBaoTapChi, "MaTaiLieu", true));
            this.maTaiLieuComboBox.DataSource = this.bdsTaiLieu;
            this.maTaiLieuComboBox.DisplayMember = "TenTaiLieu";
            this.maTaiLieuComboBox.FormattingEnabled = true;
            this.maTaiLieuComboBox.Location = new System.Drawing.Point(303, 424);
            this.maTaiLieuComboBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.maTaiLieuComboBox.Name = "maTaiLieuComboBox";
            this.maTaiLieuComboBox.Size = new System.Drawing.Size(220, 27);
            this.maTaiLieuComboBox.TabIndex = 25;
            this.maTaiLieuComboBox.ValueMember = "MaTaiLieu";
            // 
            // bdsTaiLieu
            // 
            this.bdsTaiLieu.DataMember = "TaiLieu";
            this.bdsTaiLieu.DataSource = this.quanLyThuVienDataSet;
            // 
            // nhaXBTextBox
            // 
            this.nhaXBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBaoTapChi, "NhaXB", true));
            this.nhaXBTextBox.Location = new System.Drawing.Point(285, 221);
            this.nhaXBTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nhaXBTextBox.Name = "nhaXBTextBox";
            this.nhaXBTextBox.Size = new System.Drawing.Size(220, 27);
            this.nhaXBTextBox.TabIndex = 24;
            this.nhaXBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhaXBTextBox_KeyPress);
            // 
            // dinhKyTextBox
            // 
            this.dinhKyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBaoTapChi, "DinhKy", true));
            this.dinhKyTextBox.Location = new System.Drawing.Point(285, 145);
            this.dinhKyTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dinhKyTextBox.Name = "dinhKyTextBox";
            this.dinhKyTextBox.Size = new System.Drawing.Size(220, 27);
            this.dinhKyTextBox.TabIndex = 22;
            this.dinhKyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dinhKyTextBox_KeyPress);
            // 
            // namPhatHanhDateEdit
            // 
            this.namPhatHanhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTapChi, "NamPhatHanh", true));
            this.namPhatHanhDateEdit.EditValue = null;
            this.namPhatHanhDateEdit.Location = new System.Drawing.Point(285, 89);
            this.namPhatHanhDateEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.namPhatHanhDateEdit.MenuManager = this.bmrChucNang;
            this.namPhatHanhDateEdit.Name = "namPhatHanhDateEdit";
            this.namPhatHanhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.namPhatHanhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.namPhatHanhDateEdit.Size = new System.Drawing.Size(225, 26);
            this.namPhatHanhDateEdit.TabIndex = 19;
            // 
            // bdsKyXuatBan
            // 
            this.bdsKyXuatBan.DataMember = "FK_KyXuatBan_BaoTapChi";
            this.bdsKyXuatBan.DataSource = this.bdsBaoTapChi;
            // 
            // kyXuatBanTableAdapter
            // 
            this.kyXuatBanTableAdapter.ClearBeforeFill = true;
            // 
            // gcKyXuatBan
            // 
            this.gcKyXuatBan.DataSource = this.bdsKyXuatBan;
            this.gcKyXuatBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKyXuatBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcKyXuatBan.Location = new System.Drawing.Point(753, 280);
            this.gcKyXuatBan.MainView = this.gridView2;
            this.gcKyXuatBan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gcKyXuatBan.MenuManager = this.bmrChucNang;
            this.gcKyXuatBan.Name = "gcKyXuatBan";
            this.gcKyXuatBan.Size = new System.Drawing.Size(750, 288);
            this.gcKyXuatBan.TabIndex = 20;
            this.gcKyXuatBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKyXuatBan,
            this.colSoLuongNhap,
            this.colSoLuongTon,
            this.colIDBTC1,
            this.colLanXB});
            this.gridView2.DetailHeight = 807;
            this.gridView2.GridControl = this.gcKyXuatBan;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcKyXuatBan_MouseDown);
            // 
            // colIDKyXuatBan
            // 
            this.colIDKyXuatBan.FieldName = "IDKyXuatBan";
            this.colIDKyXuatBan.MinWidth = 45;
            this.colIDKyXuatBan.Name = "colIDKyXuatBan";
            this.colIDKyXuatBan.Visible = true;
            this.colIDKyXuatBan.VisibleIndex = 0;
            this.colIDKyXuatBan.Width = 168;
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.FieldName = "SoLuongNhap";
            this.colSoLuongNhap.MinWidth = 45;
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            this.colSoLuongNhap.Visible = true;
            this.colSoLuongNhap.VisibleIndex = 1;
            this.colSoLuongNhap.Width = 168;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.FieldName = "SoLuongTon";
            this.colSoLuongTon.MinWidth = 45;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.Visible = true;
            this.colSoLuongTon.VisibleIndex = 2;
            this.colSoLuongTon.Width = 168;
            // 
            // colIDBTC1
            // 
            this.colIDBTC1.FieldName = "IDBTC";
            this.colIDBTC1.MinWidth = 45;
            this.colIDBTC1.Name = "colIDBTC1";
            this.colIDBTC1.Visible = true;
            this.colIDBTC1.VisibleIndex = 3;
            this.colIDBTC1.Width = 168;
            // 
            // colLanXB
            // 
            this.colLanXB.FieldName = "LanXB";
            this.colLanXB.MinWidth = 45;
            this.colLanXB.Name = "colLanXB";
            this.colLanXB.Visible = true;
            this.colLanXB.VisibleIndex = 4;
            this.colLanXB.Width = 168;
            // 
            // bdsCTMuonBaoTapChi
            // 
            this.bdsCTMuonBaoTapChi.DataMember = "FK_MuonBaoTapChi_KyXuatBan";
            this.bdsCTMuonBaoTapChi.DataSource = this.bdsKyXuatBan;
            // 
            // taiLieuTableAdapter
            // 
            this.taiLieuTableAdapter.ClearBeforeFill = true;
            // 
            // cmsKyXB
            // 
            this.cmsKyXB.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsKyXB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiThem,
            this.tsmiHieuChinh});
            this.cmsKyXB.Name = "cmsKyXB";
            this.cmsKyXB.Size = new System.Drawing.Size(171, 68);
            // 
            // tmsiThem
            // 
            this.tmsiThem.Name = "tmsiThem";
            this.tmsiThem.Size = new System.Drawing.Size(170, 32);
            this.tmsiThem.Text = "Thêm";
            this.tmsiThem.Click += new System.EventHandler(this.tmsiThem_Click);
            // 
            // tsmiHieuChinh
            // 
            this.tsmiHieuChinh.Name = "tsmiHieuChinh";
            this.tsmiHieuChinh.Size = new System.Drawing.Size(170, 32);
            this.tsmiHieuChinh.Text = "Hiệu Chỉnh";
            this.tsmiHieuChinh.Click += new System.EventHandler(this.tsmiHieuChinh_Click);
            // 
            // frmBaoTapChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 568);
            this.Controls.Add(this.gcKyXuatBan);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcBaoTapChi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaoTapChi";
            this.Text = "frmBaoTapChi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namPhatHanhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namPhatHanhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKyXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBaoTapChi)).EndInit();
            this.cmsKyXB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmrChucNang;
        private DevExpress.XtraBars.Bar barMenu;
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
        private System.Windows.Forms.BindingSource bdsBaoTapChi;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private QuanLyThuVienDataSetTableAdapters.BaoTapChiTableAdapter baoTapChiTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcBaoTapChi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNamPhatHanh;
        private DevExpress.XtraGrid.Columns.GridColumn colDinhKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaXB;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiLieu;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.TextBox nhaXBTextBox;
        private System.Windows.Forms.TextBox dinhKyTextBox;
        private DevExpress.XtraEditors.DateEdit namPhatHanhDateEdit;
        private System.Windows.Forms.BindingSource bdsKyXuatBan;
        private QuanLyThuVienDataSetTableAdapters.KyXuatBanTableAdapter kyXuatBanTableAdapter;
        private DevExpress.XtraGrid.GridControl gcKyXuatBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdsCTMuonBaoTapChi;
        private System.Windows.Forms.ComboBox maTaiLieuComboBox;
        private System.Windows.Forms.BindingSource bdsTaiLieu;
        private QuanLyThuVienDataSetTableAdapters.TaiLieuTableAdapter taiLieuTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsKyXB;
        private System.Windows.Forms.ToolStripMenuItem tmsiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHieuChinh;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKyXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongTon;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colLanXB;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label lblID;
    }
}