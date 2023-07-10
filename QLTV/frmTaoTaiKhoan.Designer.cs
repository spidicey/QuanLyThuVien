namespace QLTV
{
    partial class frmTaoTaiKhoan
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
            System.Windows.Forms.Label lbDocGia;
            System.Windows.Forms.Label lblSoThe;
            this.bdsGET_NO_ACCOUNTS_READER = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.gET_NO_ACCOUNTS_READERTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.GET_NO_ACCOUNTS_READERTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.lblMatKhauXacNhan = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauXacNhan = new System.Windows.Forms.TextBox();
            lbDocGia = new System.Windows.Forms.Label();
            lblSoThe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGET_NO_ACCOUNTS_READER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsGET_NO_ACCOUNTS_READER
            // 
            this.bdsGET_NO_ACCOUNTS_READER.DataMember = "GET_NO_ACCOUNTS_READER";
            this.bdsGET_NO_ACCOUNTS_READER.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(457, 499);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 54);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(149, 499);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(150, 54);
            this.btnTaoTaiKhoan.TabIndex = 8;
            this.btnTaoTaiKhoan.Text = "TẠO";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // gET_NO_ACCOUNTS_READERTableAdapter
            // 
            this.gET_NO_ACCOUNTS_READERTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.TuaSachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbDocGia
            // 
            lbDocGia.AutoSize = true;
            lbDocGia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbDocGia.Location = new System.Drawing.Point(93, 78);
            lbDocGia.Name = "lbDocGia";
            lbDocGia.Size = new System.Drawing.Size(90, 25);
            lbDocGia.TabIndex = 10;
            lbDocGia.Text = "Đọc giả:";
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.DataSource = this.bdsGET_NO_ACCOUNTS_READER;
            this.cmbDocGia.DisplayMember = "Ten";
            this.cmbDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocGia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocGia.FormattingEnabled = true;
            this.cmbDocGia.Location = new System.Drawing.Point(322, 75);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(330, 33);
            this.cmbDocGia.TabIndex = 16;
            this.cmbDocGia.ValueMember = "SoThe";
            this.cmbDocGia.SelectedIndexChanged += new System.EventHandler(this.cmbDocGia_SelectedIndexChanged);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(93, 229);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(161, 25);
            this.lblTenDangNhap.TabIndex = 11;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(93, 302);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(110, 25);
            this.lblMatKhau.TabIndex = 12;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThe.Location = new System.Drawing.Point(322, 149);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.ReadOnly = true;
            this.txtSoThe.Size = new System.Drawing.Size(330, 32);
            this.txtSoThe.TabIndex = 13;
            this.txtSoThe.TabStop = false;
            // 
            // lblMatKhauXacNhan
            // 
            this.lblMatKhauXacNhan.AutoSize = true;
            this.lblMatKhauXacNhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauXacNhan.Location = new System.Drawing.Point(93, 375);
            this.lblMatKhauXacNhan.Name = "lblMatKhauXacNhan";
            this.lblMatKhauXacNhan.Size = new System.Drawing.Size(201, 25);
            this.lblMatKhauXacNhan.TabIndex = 14;
            this.lblMatKhauXacNhan.Text = "Mật khẩu xác nhận:";
            // 
            // lblSoThe
            // 
            lblSoThe.AutoSize = true;
            lblSoThe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoThe.Location = new System.Drawing.Point(93, 156);
            lblSoThe.Name = "lblSoThe";
            lblSoThe.Size = new System.Drawing.Size(77, 25);
            lblSoThe.TabIndex = 15;
            lblSoThe.Text = "Số thẻ:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(322, 222);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(330, 32);
            this.txtTenDangNhap.TabIndex = 17;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(322, 295);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(330, 32);
            this.txtMatKhau.TabIndex = 18;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(322, 368);
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(330, 32);
            this.txtMatKhauXacNhan.TabIndex = 19;
            this.txtMatKhauXacNhan.UseSystemPasswordChar = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AcceptButton = this.btnTaoTaiKhoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(741, 579);
            this.Controls.Add(lbDocGia);
            this.Controls.Add(this.cmbDocGia);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.lblMatKhauXacNhan);
            this.Controls.Add(lblSoThe);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMatKhauXacNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGET_NO_ACCOUNTS_READER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bdsGET_NO_ACCOUNTS_READER;
        private QuanLyThuVienDataSetTableAdapters.GET_NO_ACCOUNTS_READERTableAdapter gET_NO_ACCOUNTS_READERTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbDocGia;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label lblMatKhauXacNhan;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauXacNhan;
    }
}