namespace QLTV
{
    partial class frmHieuChinhBTC
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtSoLuongNhap = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaXuatBan = new DevExpress.XtraEditors.TextEdit();
            this.txtIDBTC = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtLanXB = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bdsKXB = new System.Windows.Forms.BindingSource(this.components);
            this.kyXuatBanTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.KyXuatBanTableAdapter();
            this.tableAdapterManager = new QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaXuatBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDBTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.MintCream;
            this.btnThoat.Location = new System.Drawing.Point(455, 406);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 46);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.MintCream;
            this.btnXacNhan.Location = new System.Drawing.Point(244, 406);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 46);
            this.btnXacNhan.TabIndex = 24;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(324, 306);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongNhap.Size = new System.Drawing.Size(208, 40);
            this.txtSoLuongNhap.TabIndex = 23;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(324, 166);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXuatBan.Properties.Appearance.Options.UseFont = true;
            this.txtNhaXuatBan.Properties.ReadOnly = true;
            this.txtNhaXuatBan.Size = new System.Drawing.Size(282, 40);
            this.txtNhaXuatBan.TabIndex = 22;
            // 
            // txtIDBTC
            // 
            this.txtIDBTC.Location = new System.Drawing.Point(324, 92);
            this.txtIDBTC.Name = "txtIDBTC";
            this.txtIDBTC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBTC.Properties.Appearance.Options.UseFont = true;
            this.txtIDBTC.Properties.ReadOnly = true;
            this.txtIDBTC.Size = new System.Drawing.Size(208, 40);
            this.txtIDBTC.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nhà Xuất Bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số Lượng Nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã BáoTạp Chí:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(937, 65);
            this.lblTieuDe.TabIndex = 17;
            this.lblTieuDe.Text = "THÔNG TIN LẦN XUẤT BẢN BÁO TẠP CHÍ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLanXB
            // 
            this.txtLanXB.Location = new System.Drawing.Point(324, 230);
            this.txtLanXB.Name = "txtLanXB";
            this.txtLanXB.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanXB.Properties.Appearance.Options.UseFont = true;
            this.txtLanXB.Size = new System.Drawing.Size(208, 40);
            this.txtLanXB.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "Lần Xuất Bản:";
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKXB
            // 
            this.bdsKXB.DataMember = "KyXuatBan";
            this.bdsKXB.DataSource = this.quanLyThuVienDataSet;
            // 
            // kyXuatBanTableAdapter
            // 
            this.kyXuatBanTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KyXuatBanTableAdapter = this.kyXuatBanTableAdapter;
            this.tableAdapterManager.LanXuatBanTableAdapter = null;
            this.tableAdapterManager.SACH_CO_THE_MUONTableAdapter = null;
            this.tableAdapterManager.SP_GET_CTMUONBAOTableAdapter = null;
            this.tableAdapterManager.SP_GET_CTMUONSACHTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.TuaSachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV.QuanLyThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmHieuChinhBTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 576);
            this.Controls.Add(this.txtLanXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.txtIDBTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmHieuChinhBTC";
            this.Text = "frmHieuChinhSoLuongBTC";
            this.Load += new System.EventHandler(this.frmHieuChinhSoLuongBTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaXuatBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDBTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraEditors.TextEdit txtSoLuongNhap;
        private DevExpress.XtraEditors.TextEdit txtNhaXuatBan;
        private DevExpress.XtraEditors.TextEdit txtIDBTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTieuDe;
        private DevExpress.XtraEditors.TextEdit txtLanXB;
        private System.Windows.Forms.Label label4;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bdsKXB;
        private QuanLyThuVienDataSetTableAdapters.KyXuatBanTableAdapter kyXuatBanTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}