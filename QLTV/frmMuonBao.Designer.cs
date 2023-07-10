namespace QLTV
{
    partial class frmMuonBao
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
            System.Windows.Forms.Label iDKyXBLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonBao));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnTra = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLTV.QuanLyThuVienDataSet();
            this.bdsCTMB = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GET_CTMUONBAOTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.SP_GET_CTMUONBAOTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.txtSoThe = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.bdsBCTM = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GET_BAO_CO_THE_MUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.SP_GET_BAO_CO_THE_MUONTableAdapter();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtIDKyXB = new DevExpress.XtraEditors.TextEdit();
            this.sP_GET_BAO_CO_THE_MUONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNamPhatHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDinhKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDKyXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_GET_CTMUONBAOGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDKyXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            soTheLabel = new System.Windows.Forms.Label();
            ngayMuonLabel = new System.Windows.Forms.Label();
            iDKyXBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBCTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKyXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_BAO_CO_THE_MUONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_CTMUONBAOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // soTheLabel
            // 
            soTheLabel.AutoSize = true;
            soTheLabel.Location = new System.Drawing.Point(25, 38);
            soTheLabel.Name = "soTheLabel";
            soTheLabel.Size = new System.Drawing.Size(65, 19);
            soTheLabel.TabIndex = 8;
            soTheLabel.Text = "So The:";
            // 
            // ngayMuonLabel
            // 
            ngayMuonLabel.AutoSize = true;
            ngayMuonLabel.Location = new System.Drawing.Point(25, 151);
            ngayMuonLabel.Name = "ngayMuonLabel";
            ngayMuonLabel.Size = new System.Drawing.Size(95, 19);
            ngayMuonLabel.TabIndex = 12;
            ngayMuonLabel.Text = "Ngay Muon:";
            // 
            // iDKyXBLabel
            // 
            iDKyXBLabel.AutoSize = true;
            iDKyXBLabel.Location = new System.Drawing.Point(18, 100);
            iDKyXBLabel.Name = "iDKyXBLabel";
            iDKyXBLabel.Size = new System.Drawing.Size(72, 19);
            iDKyXBLabel.TabIndex = 13;
            iDKyXBLabel.Text = "IDKy XB:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 34);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1294, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 34);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControl1.Size = new System.Drawing.Size(1294, 0);
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar4});
            this.bmrChucNang.DockControls.Add(this.barDockControl2);
            this.bmrChucNang.DockControls.Add(this.barDockControlBottom);
            this.bmrChucNang.DockControls.Add(this.barDockControlLeft);
            this.bmrChucNang.DockControls.Add(this.barDockControlRight);
            this.bmrChucNang.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmrChucNang.Form = this;
            this.bmrChucNang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnTra,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnChuyenChiNhanh,
            this.btnInDanhSach});
            this.bmrChucNang.MaxItemId = 9;
            this.bmrChucNang.StatusBar = this.bar4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTra),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.Text = "Tools";
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
            // btnTra
            // 
            this.btnTra.Caption = "Trả báo";
            this.btnTra.Id = 1;
            this.btnTra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTra.ImageOptions.SvgImage")));
            this.btnTra.Name = "btnTra";
            this.btnTra.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTra_ItemClick);
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
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.bmrChucNang;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControl2.Size = new System.Drawing.Size(1294, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 797);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1294, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 763);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1294, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 763);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // bdsCTMB
            // 
            this.bdsCTMB.DataMember = "SP_GET_CTMUONBAO";
            this.bdsCTMB.DataSource = this.DS;
            // 
            // sP_GET_CTMUONBAOTableAdapter
            // 
            this.sP_GET_CTMUONBAOTableAdapter.ClearBeforeFill = true;
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
            // txtSoThe
            // 
            this.txtSoThe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTMB, "SoThe", true));
            this.txtSoThe.Location = new System.Drawing.Point(161, 35);
            this.txtSoThe.MenuManager = this.bmrChucNang;
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Properties.ReadOnly = true;
            this.txtSoThe.Size = new System.Drawing.Size(150, 26);
            this.txtSoThe.TabIndex = 9;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTMB, "NgayMuon", true));
            this.txtNgayMuon.EditValue = null;
            this.txtNgayMuon.Location = new System.Drawing.Point(161, 148);
            this.txtNgayMuon.MenuManager = this.bmrChucNang;
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayMuon.Properties.ReadOnly = true;
            this.txtNgayMuon.Size = new System.Drawing.Size(150, 26);
            this.txtNgayMuon.TabIndex = 13;
            // 
            // bdsBCTM
            // 
            this.bdsBCTM.DataMember = "SP_GET_BAO_CO_THE_MUON";
            this.bdsBCTM.DataSource = this.DS;
            // 
            // sP_GET_BAO_CO_THE_MUONTableAdapter
            // 
            this.sP_GET_BAO_CO_THE_MUONTableAdapter.ClearBeforeFill = true;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(iDKyXBLabel);
            this.pncNhapLieu.Controls.Add(this.txtIDKyXB);
            this.pncNhapLieu.Controls.Add(this.sP_GET_BAO_CO_THE_MUONGridControl);
            this.pncNhapLieu.Controls.Add(soTheLabel);
            this.pncNhapLieu.Controls.Add(this.txtSoThe);
            this.pncNhapLieu.Controls.Add(this.txtNgayMuon);
            this.pncNhapLieu.Controls.Add(ngayMuonLabel);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 254);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1294, 543);
            this.pncNhapLieu.TabIndex = 29;
            // 
            // txtIDKyXB
            // 
            this.txtIDKyXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTMB, "IDKyXB", true));
            this.txtIDKyXB.Location = new System.Drawing.Point(161, 93);
            this.txtIDKyXB.MenuManager = this.bmrChucNang;
            this.txtIDKyXB.Name = "txtIDKyXB";
            this.txtIDKyXB.Properties.ReadOnly = true;
            this.txtIDKyXB.Size = new System.Drawing.Size(150, 26);
            this.txtIDKyXB.TabIndex = 14;
            // 
            // sP_GET_BAO_CO_THE_MUONGridControl
            // 
            this.sP_GET_BAO_CO_THE_MUONGridControl.DataSource = this.bdsBCTM;
            this.sP_GET_BAO_CO_THE_MUONGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sP_GET_BAO_CO_THE_MUONGridControl.Location = new System.Drawing.Point(370, 2);
            this.sP_GET_BAO_CO_THE_MUONGridControl.MainView = this.gridView2;
            this.sP_GET_BAO_CO_THE_MUONGridControl.MenuManager = this.bmrChucNang;
            this.sP_GET_BAO_CO_THE_MUONGridControl.Name = "sP_GET_BAO_CO_THE_MUONGridControl";
            this.sP_GET_BAO_CO_THE_MUONGridControl.Size = new System.Drawing.Size(922, 539);
            this.sP_GET_BAO_CO_THE_MUONGridControl.TabIndex = 13;
            this.sP_GET_BAO_CO_THE_MUONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNamPhatHanh,
            this.colDinhKy,
            this.colNhaXB,
            this.colIDKyXuatBan,
            this.colLanXB});
            this.gridView2.GridControl = this.sP_GET_BAO_CO_THE_MUONGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colNamPhatHanh
            // 
            this.colNamPhatHanh.FieldName = "NamPhatHanh";
            this.colNamPhatHanh.MinWidth = 30;
            this.colNamPhatHanh.Name = "colNamPhatHanh";
            this.colNamPhatHanh.Visible = true;
            this.colNamPhatHanh.VisibleIndex = 0;
            this.colNamPhatHanh.Width = 112;
            // 
            // colDinhKy
            // 
            this.colDinhKy.FieldName = "DinhKy";
            this.colDinhKy.MinWidth = 30;
            this.colDinhKy.Name = "colDinhKy";
            this.colDinhKy.Visible = true;
            this.colDinhKy.VisibleIndex = 1;
            this.colDinhKy.Width = 112;
            // 
            // colNhaXB
            // 
            this.colNhaXB.FieldName = "NhaXB";
            this.colNhaXB.MinWidth = 30;
            this.colNhaXB.Name = "colNhaXB";
            this.colNhaXB.Visible = true;
            this.colNhaXB.VisibleIndex = 2;
            this.colNhaXB.Width = 112;
            // 
            // colIDKyXuatBan
            // 
            this.colIDKyXuatBan.FieldName = "IDKyXuatBan";
            this.colIDKyXuatBan.MinWidth = 30;
            this.colIDKyXuatBan.Name = "colIDKyXuatBan";
            this.colIDKyXuatBan.Visible = true;
            this.colIDKyXuatBan.VisibleIndex = 3;
            this.colIDKyXuatBan.Width = 112;
            // 
            // colLanXB
            // 
            this.colLanXB.FieldName = "LanXB";
            this.colLanXB.MinWidth = 30;
            this.colLanXB.Name = "colLanXB";
            this.colLanXB.Visible = true;
            this.colLanXB.VisibleIndex = 4;
            this.colLanXB.Width = 112;
            // 
            // sP_GET_CTMUONBAOGridControl
            // 
            this.sP_GET_CTMUONBAOGridControl.DataSource = this.bdsCTMB;
            this.sP_GET_CTMUONBAOGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_GET_CTMUONBAOGridControl.Location = new System.Drawing.Point(0, 34);
            this.sP_GET_CTMUONBAOGridControl.MainView = this.gridView1;
            this.sP_GET_CTMUONBAOGridControl.MenuManager = this.bmrChucNang;
            this.sP_GET_CTMUONBAOGridControl.Name = "sP_GET_CTMUONBAOGridControl";
            this.sP_GET_CTMUONBAOGridControl.Size = new System.Drawing.Size(1294, 220);
            this.sP_GET_CTMUONBAOGridControl.TabIndex = 35;
            this.sP_GET_CTMUONBAOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoThe,
            this.colIDKyXB,
            this.colNgayMuon,
            this.colNgayTra});
            this.gridView1.GridControl = this.sP_GET_CTMUONBAOGridControl;
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
            // colIDKyXB
            // 
            this.colIDKyXB.FieldName = "IDKyXB";
            this.colIDKyXB.MinWidth = 30;
            this.colIDKyXB.Name = "colIDKyXB";
            this.colIDKyXB.Visible = true;
            this.colIDKyXB.VisibleIndex = 1;
            this.colIDKyXB.Width = 112;
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
            // frmMuonBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 817);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.sP_GET_CTMUONBAOGridControl);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Name = "frmMuonBao";
            this.Text = "frmMuonBao";
            this.Load += new System.EventHandler(this.frmMuonBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBCTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKyXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_BAO_CO_THE_MUONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_CTMUONBAOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager bmrChucNang;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnTra;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private System.Windows.Forms.BindingSource bdsCTMB;
        private QuanLyThuVienDataSet DS;
        private QuanLyThuVienDataSetTableAdapters.SP_GET_CTMUONBAOTableAdapter sP_GET_CTMUONBAOTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit txtNgayMuon;
        private DevExpress.XtraEditors.TextEdit txtSoThe;
        private System.Windows.Forms.BindingSource bdsBCTM;
        private QuanLyThuVienDataSetTableAdapters.SP_GET_BAO_CO_THE_MUONTableAdapter sP_GET_BAO_CO_THE_MUONTableAdapter;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private DevExpress.XtraGrid.GridControl sP_GET_CTMUONBAOGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl sP_GET_BAO_CO_THE_MUONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNamPhatHanh;
        private DevExpress.XtraGrid.Columns.GridColumn colDinhKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaXB;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKyXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn colLanXB;
        private DevExpress.XtraEditors.TextEdit txtIDKyXB;
        private DevExpress.XtraGrid.Columns.GridColumn colSoThe;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKyXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
    }
}