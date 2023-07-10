namespace QLTV
{
    partial class frmTG
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
            System.Windows.Forms.Label maTacGiaLabel;
            System.Windows.Forms.Label tenTacGiaLabel;
            System.Windows.Forms.Label namSinhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTG));
            this.bmrChucNang = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarCheckItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.ctSachTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CTSachTableAdapter();
            this.gcTacGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncNhapLieu = new System.Windows.Forms.Panel();
            this.namSinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.bdsCTSach = new System.Windows.Forms.BindingSource(this.components);
            maTacGiaLabel = new System.Windows.Forms.Label();
            tenTacGiaLabel = new System.Windows.Forms.Label();
            namSinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pncNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namSinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namSinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTSach)).BeginInit();
            this.SuspendLayout();
            // 
            // maTacGiaLabel
            // 
            maTacGiaLabel.AutoSize = true;
            maTacGiaLabel.Location = new System.Drawing.Point(41, 66);
            maTacGiaLabel.Name = "maTacGiaLabel";
            maTacGiaLabel.Size = new System.Drawing.Size(93, 19);
            maTacGiaLabel.TabIndex = 0;
            maTacGiaLabel.Text = "Ma Tac Gia:";
            // 
            // tenTacGiaLabel
            // 
            tenTacGiaLabel.AutoSize = true;
            tenTacGiaLabel.Location = new System.Drawing.Point(25, 111);
            tenTacGiaLabel.Name = "tenTacGiaLabel";
            tenTacGiaLabel.Size = new System.Drawing.Size(100, 19);
            tenTacGiaLabel.TabIndex = 2;
            tenTacGiaLabel.Text = "Ten Tac Gia:";
            // 
            // namSinhLabel
            // 
            namSinhLabel.AutoSize = true;
            namSinhLabel.Location = new System.Drawing.Point(41, 160);
            namSinhLabel.Name = "namSinhLabel";
            namSinhLabel.Size = new System.Drawing.Size(84, 19);
            namSinhLabel.TabIndex = 4;
            namSinhLabel.Text = "Nam Sinh:";
            // 
            // bmrChucNang
            // 
            this.bmrChucNang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu,
            this.bar4});
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
            this.bmrChucNang.StatusBar = this.bar4;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmrChucNang;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(836, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 659);
            this.barDockControlBottom.Manager = this.bmrChucNang;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(836, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.bmrChucNang;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 625);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(836, 34);
            this.barDockControlRight.Manager = this.bmrChucNang;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 625);
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
            this.tableAdapterManager.CTSachTableAdapter = this.ctSachTableAdapter;
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
            // ctSachTableAdapter
            // 
            this.ctSachTableAdapter.ClearBeforeFill = true;
            // 
            // gcTacGia
            // 
            this.gcTacGia.DataSource = this.bdsTacGia;
            this.gcTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTacGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcTacGia.Location = new System.Drawing.Point(0, 34);
            this.gcTacGia.MainView = this.gridView1;
            this.gcTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.gcTacGia.MenuManager = this.bmrChucNang;
            this.gcTacGia.Name = "gcTacGia";
            this.gcTacGia.Size = new System.Drawing.Size(836, 261);
            this.gcTacGia.TabIndex = 5;
            this.gcTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTacGia,
            this.colTenTacGia,
            this.colNamSinh});
            this.gridView1.DetailHeight = 525;
            this.gridView1.GridControl = this.gcTacGia;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.FieldName = "MaTacGia";
            this.colMaTacGia.MinWidth = 45;
            this.colMaTacGia.Name = "colMaTacGia";
            this.colMaTacGia.Visible = true;
            this.colMaTacGia.VisibleIndex = 0;
            this.colMaTacGia.Width = 168;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.FieldName = "TenTacGia";
            this.colTenTacGia.MinWidth = 45;
            this.colTenTacGia.Name = "colTenTacGia";
            this.colTenTacGia.Visible = true;
            this.colTenTacGia.VisibleIndex = 1;
            this.colTenTacGia.Width = 168;
            // 
            // colNamSinh
            // 
            this.colNamSinh.FieldName = "NamSinh";
            this.colNamSinh.MinWidth = 45;
            this.colNamSinh.Name = "colNamSinh";
            this.colNamSinh.Visible = true;
            this.colNamSinh.VisibleIndex = 2;
            this.colNamSinh.Width = 168;
            // 
            // pncNhapLieu
            // 
            this.pncNhapLieu.Controls.Add(namSinhLabel);
            this.pncNhapLieu.Controls.Add(this.namSinhDateEdit);
            this.pncNhapLieu.Controls.Add(tenTacGiaLabel);
            this.pncNhapLieu.Controls.Add(this.txtTenTacGia);
            this.pncNhapLieu.Controls.Add(maTacGiaLabel);
            this.pncNhapLieu.Controls.Add(this.txtMaTacGia);
            this.pncNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncNhapLieu.Location = new System.Drawing.Point(0, 295);
            this.pncNhapLieu.Name = "pncNhapLieu";
            this.pncNhapLieu.Size = new System.Drawing.Size(836, 364);
            this.pncNhapLieu.TabIndex = 6;
            // 
            // namSinhDateEdit
            // 
            this.namSinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "NamSinh", true));
            this.namSinhDateEdit.EditValue = null;
            this.namSinhDateEdit.Location = new System.Drawing.Point(140, 157);
            this.namSinhDateEdit.MenuManager = this.bmrChucNang;
            this.namSinhDateEdit.Name = "namSinhDateEdit";
            this.namSinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.namSinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.namSinhDateEdit.Size = new System.Drawing.Size(216, 26);
            this.namSinhDateEdit.TabIndex = 5;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "TenTacGia", true));
            this.txtTenTacGia.Location = new System.Drawing.Point(140, 108);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(216, 27);
            this.txtTenTacGia.TabIndex = 3;
            this.txtTenTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTacGia_KeyPress);
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTacGia, "MaTacGia", true));
            this.txtMaTacGia.Location = new System.Drawing.Point(140, 63);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(100, 27);
            this.txtMaTacGia.TabIndex = 1;
            this.txtMaTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaTacGia_KeyPress);
            // 
            // bdsCTSach
            // 
            this.bdsCTSach.DataMember = "FK_CTSach_TacGia";
            this.bdsCTSach.DataSource = this.bdsTacGia;
            // 
            // frmTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 679);
            this.Controls.Add(this.pncNhapLieu);
            this.Controls.Add(this.gcTacGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTG";
            this.Text = "frmTachGia";
            this.Load += new System.EventHandler(this.frmTachGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmrChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pncNhapLieu.ResumeLayout(false);
            this.pncNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namSinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namSinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTSach)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private QuanLyThuVienDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pncNhapLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSinh;
        private DevExpress.XtraEditors.DateEdit namSinhDateEdit;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private QuanLyThuVienDataSetTableAdapters.CTSachTableAdapter ctSachTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTSach;
    }
}