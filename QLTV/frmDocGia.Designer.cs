namespace QLTV
{
    partial class frmDocGia
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
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label phaiLabel;
            System.Windows.Forms.Label ngheNghiepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
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
            this.bdsDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.docGiaTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.DocGiaTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.CTMuonBaoTapChiTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CTMuonBaoTapChiTableAdapter();
            this.CTMuonSachTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CTMuonSachTableAdapter();
            this.gcDocGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.lbSoThe = new System.Windows.Forms.Label();
            this.ngheNghiepTextBox = new System.Windows.Forms.TextBox();
            this.phaiCheckBox = new System.Windows.Forms.CheckBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.bdsCTMuonSach = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTMuonBaoTapChi = new System.Windows.Forms.BindingSource(this.components);
            tenLabel = new System.Windows.Forms.Label();
            phaiLabel = new System.Windows.Forms.Label();
            ngheNghiepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBaoTapChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(84, 105);
            tenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(42, 19);
            tenLabel.TabIndex = 2;
            tenLabel.Text = "Tên:";
            // 
            // phaiLabel
            // 
            phaiLabel.AutoSize = true;
            phaiLabel.Location = new System.Drawing.Point(81, 212);
            phaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phaiLabel.Name = "phaiLabel";
            phaiLabel.Size = new System.Drawing.Size(45, 19);
            phaiLabel.TabIndex = 4;
            phaiLabel.Text = "Phái:";
            // 
            // ngheNghiepLabel
            // 
            ngheNghiepLabel.AutoSize = true;
            ngheNghiepLabel.Location = new System.Drawing.Point(20, 158);
            ngheNghiepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ngheNghiepLabel.Name = "ngheNghiepLabel";
            ngheNghiepLabel.Size = new System.Drawing.Size(105, 19);
            ngheNghiepLabel.TabIndex = 6;
            ngheNghiepLabel.Text = "Nghề nghiệp:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1248, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 772);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1248, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 738);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1248, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 738);
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
            // bdsDocGia
            // 
            this.bdsDocGia.DataMember = "DocGia";
            this.bdsDocGia.DataSource = this.quanLyThuVienDataSet;
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoTapChiTableAdapter = null;
            this.tableAdapterManager.CTMuonBaoTapChiTableAdapter = this.CTMuonBaoTapChiTableAdapter;
            this.tableAdapterManager.CTMuonSachTableAdapter = this.CTMuonSachTableAdapter;
            this.tableAdapterManager.CTSachTableAdapter = null;
            this.tableAdapterManager.CuonSachTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = this.docGiaTableAdapter;
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
            // CTMuonBaoTapChiTableAdapter
            // 
            this.CTMuonBaoTapChiTableAdapter.ClearBeforeFill = true;
            // 
            // CTMuonSachTableAdapter
            // 
            this.CTMuonSachTableAdapter.ClearBeforeFill = true;
            // 
            // gcDocGia
            // 
            this.gcDocGia.DataSource = this.bdsDocGia;
            this.gcDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDocGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcDocGia.Location = new System.Drawing.Point(0, 34);
            this.gcDocGia.MainView = this.gridView1;
            this.gcDocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcDocGia.MenuManager = this.bmrChucNang;
            this.gcDocGia.Name = "gcDocGia";
            this.gcDocGia.Size = new System.Drawing.Size(1248, 275);
            this.gcDocGia.TabIndex = 5;
            this.gcDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoThe,
            this.colTen,
            this.colNgheNghiep,
            this.colPhai});
            this.gridView1.DetailHeight = 538;
            this.gridView1.GridControl = this.gcDocGia;
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
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 30;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 112;
            // 
            // colNgheNghiep
            // 
            this.colNgheNghiep.FieldName = "NgheNghiep";
            this.colNgheNghiep.MinWidth = 30;
            this.colNgheNghiep.Name = "colNgheNghiep";
            this.colNgheNghiep.Visible = true;
            this.colNgheNghiep.VisibleIndex = 2;
            this.colNgheNghiep.Width = 112;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.MinWidth = 30;
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 3;
            this.colPhai.Width = 112;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(this.lbSoThe);
            this.pncNhapLieu.Controls.Add(ngheNghiepLabel);
            this.pncNhapLieu.Controls.Add(this.ngheNghiepTextBox);
            this.pncNhapLieu.Controls.Add(phaiLabel);
            this.pncNhapLieu.Controls.Add(this.phaiCheckBox);
            this.pncNhapLieu.Controls.Add(tenLabel);
            this.pncNhapLieu.Controls.Add(this.tenTextBox);
            this.pncNhapLieu.Controls.Add(this.txtSoThe);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 309);
            this.pncNhapLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(1248, 463);
            this.pncNhapLieu.TabIndex = 6;
            // 
            // lbSoThe
            // 
            this.lbSoThe.AutoSize = true;
            this.lbSoThe.Location = new System.Drawing.Point(60, 50);
            this.lbSoThe.Name = "lbSoThe";
            this.lbSoThe.Size = new System.Drawing.Size(60, 19);
            this.lbSoThe.TabIndex = 8;
            this.lbSoThe.Text = "Số thẻ:";
            // 
            // ngheNghiepTextBox
            // 
            this.ngheNghiepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDocGia, "NgheNghiep", true));
            this.ngheNghiepTextBox.Location = new System.Drawing.Point(136, 154);
            this.ngheNghiepTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ngheNghiepTextBox.Name = "ngheNghiepTextBox";
            this.ngheNghiepTextBox.Size = new System.Drawing.Size(148, 27);
            this.ngheNghiepTextBox.TabIndex = 7;
            this.ngheNghiepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ngheNghiepTextBox_KeyPress);
            // 
            // phaiCheckBox
            // 
            this.phaiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsDocGia, "Phai", true));
            this.phaiCheckBox.Location = new System.Drawing.Point(136, 205);
            this.phaiCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phaiCheckBox.Name = "phaiCheckBox";
            this.phaiCheckBox.Size = new System.Drawing.Size(156, 37);
            this.phaiCheckBox.TabIndex = 5;
            this.phaiCheckBox.UseVisualStyleBackColor = true;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDocGia, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(136, 100);
            this.tenTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(148, 27);
            this.tenTextBox.TabIndex = 3;
            this.tenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenTextBox_KeyPress);
            // 
            // txtSoThe
            // 
            this.txtSoThe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDocGia, "SoThe", true));
            this.txtSoThe.Location = new System.Drawing.Point(136, 42);
            this.txtSoThe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.ReadOnly = true;
            this.txtSoThe.Size = new System.Drawing.Size(148, 27);
            this.txtSoThe.TabIndex = 1;
            this.txtSoThe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soTheTextBox_KeyPress);
            // 
            // bdsCTMuonSach
            // 
            this.bdsCTMuonSach.DataMember = "FK_MuonSach_DocGia";
            this.bdsCTMuonSach.DataSource = this.bdsDocGia;
            // 
            // bdsCTMuonBaoTapChi
            // 
            this.bdsCTMuonBaoTapChi.DataMember = "FK_MuonBaoTapChi_DocGia";
            this.bdsCTMuonBaoTapChi.DataSource = this.bdsDocGia;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 772);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcDocGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDocGia";
            this.Text = "Danh sách đọc giả";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncNhapLieu)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBaoTapChi)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDocGia;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private QuanLyThuVienDataSetTableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pncNhapLieu;
        private System.Windows.Forms.TextBox ngheNghiepTextBox;
        private System.Windows.Forms.CheckBox phaiCheckBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox txtSoThe;
        private DevExpress.XtraGrid.GridControl gcDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyThuVienDataSetTableAdapters.CTMuonSachTableAdapter CTMuonSachTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTMuonSach;
        private QuanLyThuVienDataSetTableAdapters.CTMuonBaoTapChiTableAdapter CTMuonBaoTapChiTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTMuonBaoTapChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoThe;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private System.Windows.Forms.Label lbSoThe;
    }
}