namespace QLTV
{
    partial class frmMuonSach
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
            System.Windows.Forms.Label soTheLabel;
            System.Windows.Forms.Label ngayMuonLabel;
            System.Windows.Forms.Label iDCuonSachLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonSach));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLTV.QuanLyThuVienDataSet();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.bdsSPCTMS = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GET_CTMUONSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.SP_GET_CTMUONSACHTableAdapter();
            this.sP_GET_CTMUONSACHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCuonSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtIDCuonSach = new DevExpress.XtraEditors.TextEdit();
            this.bdsSCTM = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTSCTM = new System.Windows.Forms.BindingSource(this.components);
            this.sACH_CO_THE_MUONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCuonSach2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLXB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cT_SACH_CO_THE_MUONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenTuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLXB1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.txtSoThe = new DevExpress.XtraEditors.TextEdit();
            this.sACH_CO_THE_MUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.SACH_CO_THE_MUONTableAdapter();
            this.colIDCuonSach1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cT_SACH_CO_THE_MUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_SACH_CO_THE_MUONTableAdapter();
            soTheLabel = new System.Windows.Forms.Label();
            ngayMuonLabel = new System.Windows.Forms.Label();
            iDCuonSachLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPCTMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_CTMUONSACHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCuonSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSCTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTSCTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACH_CO_THE_MUONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_SACH_CO_THE_MUONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // soTheLabel
            // 
            soTheLabel.AutoSize = true;
            soTheLabel.Location = new System.Drawing.Point(30, 27);
            soTheLabel.Name = "soTheLabel";
            soTheLabel.Size = new System.Drawing.Size(65, 19);
            soTheLabel.TabIndex = 0;
            soTheLabel.Text = "So The:";
            // 
            // ngayMuonLabel
            // 
            ngayMuonLabel.AutoSize = true;
            ngayMuonLabel.Location = new System.Drawing.Point(30, 69);
            ngayMuonLabel.Name = "ngayMuonLabel";
            ngayMuonLabel.Size = new System.Drawing.Size(95, 19);
            ngayMuonLabel.TabIndex = 2;
            ngayMuonLabel.Text = "Ngay Muon:";
            // 
            // iDCuonSachLabel
            // 
            iDCuonSachLabel.AutoSize = true;
            iDCuonSachLabel.Location = new System.Drawing.Point(12, 105);
            iDCuonSachLabel.Name = "iDCuonSachLabel";
            iDCuonSachLabel.Size = new System.Drawing.Size(107, 19);
            iDCuonSachLabel.TabIndex = 7;
            iDCuonSachLabel.Text = "IDCuon Sach:";
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
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
            this.bmrChucNang.StatusBar = this.bar3;
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
            this.btnHieuChinh.Caption = "Trả sách";
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
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmrChucNang;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1849, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 673);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1849, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 639);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1849, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 639);
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
            // DS
            // 
            this.DS.DataSetName = "QuanLyThuVienDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoTapChiTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // bdsSPCTMS
            // 
            this.bdsSPCTMS.DataMember = "SP_GET_CTMUONSACH";
            this.bdsSPCTMS.DataSource = this.DS;
            this.bdsSPCTMS.CurrentChanged += new System.EventHandler(this.bdsSPCTMS_CurrentChanged);
            // 
            // sP_GET_CTMUONSACHTableAdapter
            // 
            this.sP_GET_CTMUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GET_CTMUONSACHGridControl
            // 
            this.sP_GET_CTMUONSACHGridControl.DataSource = this.bdsSPCTMS;
            this.sP_GET_CTMUONSACHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_GET_CTMUONSACHGridControl.Location = new System.Drawing.Point(0, 34);
            this.sP_GET_CTMUONSACHGridControl.MainView = this.gridView1;
            this.sP_GET_CTMUONSACHGridControl.MenuManager = this.bmrChucNang;
            this.sP_GET_CTMUONSACHGridControl.Name = "sP_GET_CTMUONSACHGridControl";
            this.sP_GET_CTMUONSACHGridControl.Size = new System.Drawing.Size(1849, 220);
            this.sP_GET_CTMUONSACHGridControl.TabIndex = 5;
            this.sP_GET_CTMUONSACHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoThe,
            this.colIDCuonSach,
            this.colNgayMuon,
            this.colNgayTra});
            this.gridView1.GridControl = this.sP_GET_CTMUONSACHGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colSoThe
            // 
            this.colSoThe.FieldName = "SoThe";
            this.colSoThe.MinWidth = 30;
            this.colSoThe.Name = "colSoThe";
            this.colSoThe.Visible = true;
            this.colSoThe.VisibleIndex = 0;
            this.colSoThe.Width = 112;
            // 
            // colIDCuonSach
            // 
            this.colIDCuonSach.FieldName = "IDCuonSach";
            this.colIDCuonSach.MinWidth = 30;
            this.colIDCuonSach.Name = "colIDCuonSach";
            this.colIDCuonSach.Visible = true;
            this.colIDCuonSach.VisibleIndex = 1;
            this.colIDCuonSach.Width = 112;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.FieldName = "NgayMuon";
            this.colNgayMuon.MinWidth = 30;
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.Visible = true;
            this.colNgayMuon.VisibleIndex = 2;
            this.colNgayMuon.Width = 112;
            // 
            // colNgayTra
            // 
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.MinWidth = 30;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 3;
            this.colNgayTra.Width = 112;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(iDCuonSachLabel);
            this.pncNhapLieu.Controls.Add(this.txtIDCuonSach);
            this.pncNhapLieu.Controls.Add(this.sACH_CO_THE_MUONGridControl);
            this.pncNhapLieu.Controls.Add(this.cT_SACH_CO_THE_MUONGridControl);
            this.pncNhapLieu.Controls.Add(ngayMuonLabel);
            this.pncNhapLieu.Controls.Add(this.txtNgayMuon);
            this.pncNhapLieu.Controls.Add(soTheLabel);
            this.pncNhapLieu.Controls.Add(this.txtSoThe);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 254);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1849, 419);
            this.pncNhapLieu.TabIndex = 10;
            // 
            // txtIDCuonSach
            // 
            this.txtIDCuonSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSCTM, "IDCuonSach", true));
            this.txtIDCuonSach.Location = new System.Drawing.Point(143, 102);
            this.txtIDCuonSach.MenuManager = this.bmrChucNang;
            this.txtIDCuonSach.Name = "txtIDCuonSach";
            this.txtIDCuonSach.Properties.ReadOnly = true;
            this.txtIDCuonSach.Size = new System.Drawing.Size(150, 26);
            this.txtIDCuonSach.TabIndex = 8;
            // 
            // bdsSCTM
            // 
            this.bdsSCTM.DataMember = "FK_CuonSach_LanXuatBan3";
            this.bdsSCTM.DataSource = this.bdsCTSCTM;
            // 
            // bdsCTSCTM
            // 
            this.bdsCTSCTM.DataMember = "CT_SACH_CO_THE_MUON";
            this.bdsCTSCTM.DataSource = this.DS;
            // 
            // sACH_CO_THE_MUONGridControl
            // 
            this.sACH_CO_THE_MUONGridControl.DataSource = this.bdsSCTM;
            this.sACH_CO_THE_MUONGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sACH_CO_THE_MUONGridControl.Location = new System.Drawing.Point(347, 2);
            this.sACH_CO_THE_MUONGridControl.MainView = this.gridView3;
            this.sACH_CO_THE_MUONGridControl.MenuManager = this.bmrChucNang;
            this.sACH_CO_THE_MUONGridControl.Name = "sACH_CO_THE_MUONGridControl";
            this.sACH_CO_THE_MUONGridControl.Size = new System.Drawing.Size(517, 415);
            this.sACH_CO_THE_MUONGridControl.TabIndex = 7;
            this.sACH_CO_THE_MUONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCuonSach2,
            this.colSTT1,
            this.colTinhTrang1,
            this.colIDLXB2});
            this.gridView3.GridControl = this.sACH_CO_THE_MUONGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.ReadOnly = true;
            // 
            // colIDCuonSach2
            // 
            this.colIDCuonSach2.FieldName = "IDCuonSach";
            this.colIDCuonSach2.MinWidth = 30;
            this.colIDCuonSach2.Name = "colIDCuonSach2";
            this.colIDCuonSach2.Visible = true;
            this.colIDCuonSach2.VisibleIndex = 0;
            this.colIDCuonSach2.Width = 112;
            // 
            // colSTT1
            // 
            this.colSTT1.FieldName = "STT";
            this.colSTT1.MinWidth = 30;
            this.colSTT1.Name = "colSTT1";
            this.colSTT1.Visible = true;
            this.colSTT1.VisibleIndex = 1;
            this.colSTT1.Width = 112;
            // 
            // colTinhTrang1
            // 
            this.colTinhTrang1.FieldName = "TinhTrang";
            this.colTinhTrang1.MinWidth = 30;
            this.colTinhTrang1.Name = "colTinhTrang1";
            this.colTinhTrang1.Visible = true;
            this.colTinhTrang1.VisibleIndex = 2;
            this.colTinhTrang1.Width = 112;
            // 
            // colIDLXB2
            // 
            this.colIDLXB2.FieldName = "IDLXB";
            this.colIDLXB2.MinWidth = 30;
            this.colIDLXB2.Name = "colIDLXB2";
            this.colIDLXB2.Visible = true;
            this.colIDLXB2.VisibleIndex = 3;
            this.colIDLXB2.Width = 112;
            // 
            // cT_SACH_CO_THE_MUONGridControl
            // 
            this.cT_SACH_CO_THE_MUONGridControl.DataSource = this.bdsCTSCTM;
            this.cT_SACH_CO_THE_MUONGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.cT_SACH_CO_THE_MUONGridControl.Location = new System.Drawing.Point(864, 2);
            this.cT_SACH_CO_THE_MUONGridControl.MainView = this.gridView2;
            this.cT_SACH_CO_THE_MUONGridControl.MenuManager = this.bmrChucNang;
            this.cT_SACH_CO_THE_MUONGridControl.Name = "cT_SACH_CO_THE_MUONGridControl";
            this.cT_SACH_CO_THE_MUONGridControl.Size = new System.Drawing.Size(983, 415);
            this.cT_SACH_CO_THE_MUONGridControl.TabIndex = 6;
            this.cT_SACH_CO_THE_MUONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenTuaSach,
            this.colLanXB,
            this.colNamXB,
            this.colNhaXB,
            this.colDiaCD,
            this.colTenTacGia,
            this.colIDLXB1});
            this.gridView2.GridControl = this.cT_SACH_CO_THE_MUONGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colTenTuaSach
            // 
            this.colTenTuaSach.FieldName = "TenTuaSach";
            this.colTenTuaSach.MinWidth = 30;
            this.colTenTuaSach.Name = "colTenTuaSach";
            this.colTenTuaSach.Visible = true;
            this.colTenTuaSach.VisibleIndex = 0;
            this.colTenTuaSach.Width = 112;
            // 
            // colLanXB
            // 
            this.colLanXB.FieldName = "LanXB";
            this.colLanXB.MinWidth = 30;
            this.colLanXB.Name = "colLanXB";
            this.colLanXB.Visible = true;
            this.colLanXB.VisibleIndex = 1;
            this.colLanXB.Width = 112;
            // 
            // colNamXB
            // 
            this.colNamXB.FieldName = "NamXB";
            this.colNamXB.MinWidth = 30;
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.Visible = true;
            this.colNamXB.VisibleIndex = 2;
            this.colNamXB.Width = 112;
            // 
            // colNhaXB
            // 
            this.colNhaXB.FieldName = "NhaXB";
            this.colNhaXB.MinWidth = 30;
            this.colNhaXB.Name = "colNhaXB";
            this.colNhaXB.Visible = true;
            this.colNhaXB.VisibleIndex = 3;
            this.colNhaXB.Width = 112;
            // 
            // colDiaCD
            // 
            this.colDiaCD.FieldName = "DiaCD";
            this.colDiaCD.MinWidth = 30;
            this.colDiaCD.Name = "colDiaCD";
            this.colDiaCD.Visible = true;
            this.colDiaCD.VisibleIndex = 4;
            this.colDiaCD.Width = 112;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.FieldName = "TenTacGia";
            this.colTenTacGia.MinWidth = 30;
            this.colTenTacGia.Name = "colTenTacGia";
            this.colTenTacGia.Visible = true;
            this.colTenTacGia.VisibleIndex = 5;
            this.colTenTacGia.Width = 112;
            // 
            // colIDLXB1
            // 
            this.colIDLXB1.FieldName = "IDLXB";
            this.colIDLXB1.MinWidth = 30;
            this.colIDLXB1.Name = "colIDLXB1";
            this.colIDLXB1.Visible = true;
            this.colIDLXB1.VisibleIndex = 6;
            this.colIDLXB1.Width = 112;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPCTMS, "NgayMuon", true));
            this.txtNgayMuon.EditValue = null;
            this.txtNgayMuon.Location = new System.Drawing.Point(143, 66);
            this.txtNgayMuon.MenuManager = this.bmrChucNang;
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayMuon.Properties.ReadOnly = true;
            this.txtNgayMuon.Size = new System.Drawing.Size(150, 26);
            this.txtNgayMuon.TabIndex = 3;
            // 
            // txtSoThe
            // 
            this.txtSoThe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSPCTMS, "SoThe", true));
            this.txtSoThe.Location = new System.Drawing.Point(143, 24);
            this.txtSoThe.MenuManager = this.bmrChucNang;
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Properties.ReadOnly = true;
            this.txtSoThe.Size = new System.Drawing.Size(150, 26);
            this.txtSoThe.TabIndex = 1;
            // 
            // sACH_CO_THE_MUONTableAdapter
            // 
            this.sACH_CO_THE_MUONTableAdapter.ClearBeforeFill = true;
            // 
            // colIDCuonSach1
            // 
            this.colIDCuonSach1.FieldName = "IDCuonSach";
            this.colIDCuonSach1.Name = "colIDCuonSach1";
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            // 
            // colIDLXB
            // 
            this.colIDLXB.FieldName = "IDLXB";
            this.colIDLXB.Name = "colIDLXB";
            // 
            // cT_SACH_CO_THE_MUONTableAdapter
            // 
            this.cT_SACH_CO_THE_MUONTableAdapter.ClearBeforeFill = true;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 693);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.sP_GET_CTMUONSACHGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMuonSach";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPCTMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_CTMUONSACHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCuonSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSCTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTSCTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACH_CO_THE_MUONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_SACH_CO_THE_MUONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThe.Properties)).EndInit();
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
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QuanLyThuVienDataSet DS;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsSPCTMS;
        private QuanLyThuVienDataSetTableAdapters.SP_GET_CTMUONSACHTableAdapter sP_GET_CTMUONSACHTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_GET_CTMUONSACHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoThe;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCuonSach;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private DevExpress.XtraEditors.DateEdit txtNgayMuon;
        private DevExpress.XtraEditors.TextEdit txtSoThe;
        private QuanLyThuVienDataSetTableAdapters.SACH_CO_THE_MUONTableAdapter sACH_CO_THE_MUONTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCuonSach1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLXB;
        private System.Windows.Forms.BindingSource bdsCTSCTM;
        private QuanLyThuVienDataSetTableAdapters.CT_SACH_CO_THE_MUONTableAdapter cT_SACH_CO_THE_MUONTableAdapter;
        private System.Windows.Forms.BindingSource bdsSCTM;
        private DevExpress.XtraGrid.GridControl cT_SACH_CO_THE_MUONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colLanXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNamXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaXB;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaCD;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLXB1;
        private DevExpress.XtraGrid.GridControl sACH_CO_THE_MUONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCuonSach2;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT1;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLXB2;
        private DevExpress.XtraEditors.TextEdit txtIDCuonSach;
    }
}