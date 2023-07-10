namespace QLTV
{
    partial class frmXoaTaiKhoan
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
            this.bdsGetAccount = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.getACCOUNTS_READERTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.GET_ACCOUNTS_READERTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.bdsCTMuonSach = new System.Windows.Forms.BindingSource(this.components);
            this.cTMuonSachTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CTMuonSachTableAdapter();
            this.bdsCTMuonBTC = new System.Windows.Forms.BindingSource(this.components);
            this.cTMuonBaoTapChiTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CTMuonBaoTapChiTableAdapter();
            this.cmbTenDangNhap = new System.Windows.Forms.ComboBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGetAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBTC)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsGetAccount
            // 
            this.bdsGetAccount.DataMember = "GET_ACCOUNTS_READER";
            this.bdsGetAccount.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(711, 491);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(225, 80);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(266, 491);
            this.btnXoaTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(225, 80);
            this.btnXoaTaiKhoan.TabIndex = 4;
            this.btnXoaTaiKhoan.Text = "XÓA";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // getACCOUNTS_READERTableAdapter
            // 
            this.getACCOUNTS_READERTableAdapter.ClearBeforeFill = true;
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
            // bdsCTMuonSach
            // 
            this.bdsCTMuonSach.DataMember = "CTMuonSach";
            this.bdsCTMuonSach.DataSource = this.quanLyThuVienDataSet;
            // 
            // cTMuonSachTableAdapter
            // 
            this.cTMuonSachTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTMuonBTC
            // 
            this.bdsCTMuonBTC.DataMember = "CTMuonBaoTapChi";
            this.bdsCTMuonBTC.DataSource = this.quanLyThuVienDataSet;
            // 
            // cTMuonBaoTapChiTableAdapter
            // 
            this.cTMuonBaoTapChiTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTenDangNhap
            // 
            this.cmbTenDangNhap.DataSource = this.bdsGetAccount;
            this.cmbTenDangNhap.DisplayMember = "Ten";
            this.cmbTenDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenDangNhap.FormattingEnabled = true;
            this.cmbTenDangNhap.Location = new System.Drawing.Point(510, 195);
            this.cmbTenDangNhap.Name = "cmbTenDangNhap";
            this.cmbTenDangNhap.Size = new System.Drawing.Size(426, 40);
            this.cmbTenDangNhap.TabIndex = 9;
            this.cmbTenDangNhap.ValueMember = "SoThe";
            this.cmbTenDangNhap.SelectedIndexChanged += new System.EventHandler(this.cmbTenDangNhap_SelectedIndexChanged_1);
            // 
            // txtSoThe
            // 
            this.txtSoThe.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThe.Location = new System.Drawing.Point(510, 296);
            this.txtSoThe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.ReadOnly = true;
            this.txtSoThe.Size = new System.Drawing.Size(426, 40);
            this.txtSoThe.TabIndex = 8;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(260, 202);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(213, 33);
            this.lblTenDangNhap.TabIndex = 6;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(363, 303);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(101, 33);
            this.lblMaNhanVien.TabIndex = 7;
            this.lblMaNhanVien.Text = "Số thẻ:";
            // 
            // frmXoaTaiKhoan
            // 
            this.AcceptButton = this.btnXoaTaiKhoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1154, 636);
            this.Controls.Add(this.cmbTenDangNhap);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmXoaTaiKhoan";
            this.Text = "frmXoaTaiKhoan";
            this.Load += new System.EventHandler(this.frmXoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGetAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bdsGetAccount;
        private QuanLyThuVienDataSetTableAdapters.GET_ACCOUNTS_READERTableAdapter getACCOUNTS_READERTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCTMuonSach;
        private QuanLyThuVienDataSetTableAdapters.CTMuonSachTableAdapter cTMuonSachTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTMuonBTC;
        private QuanLyThuVienDataSetTableAdapters.CTMuonBaoTapChiTableAdapter cTMuonBaoTapChiTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenDangNhap;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMaNhanVien;
    }
}