namespace QLTV
{
    partial class frmXoaTacGiaTuaSach
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
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblTuaSach = new DevExpress.XtraEditors.LabelControl();
            this.gvTacGia = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTacGia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.lblTuaSach);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(730, 100);
            this.pnlThongTin.TabIndex = 0;
            // 
            // lblTuaSach
            // 
            this.lblTuaSach.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuaSach.Appearance.Options.UseFont = true;
            this.lblTuaSach.Location = new System.Drawing.Point(3, 30);
            this.lblTuaSach.Name = "lblTuaSach";
            this.lblTuaSach.Size = new System.Drawing.Size(124, 34);
            this.lblTuaSach.TabIndex = 0;
            this.lblTuaSach.Text = "Tựa sách:";
            // 
            // gvTacGia
            // 
            this.gvTacGia.AllowUserToAddRows = false;
            this.gvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvTacGia.Location = new System.Drawing.Point(0, 100);
            this.gvTacGia.Name = "gvTacGia";
            this.gvTacGia.ReadOnly = true;
            this.gvTacGia.RowHeadersWidth = 62;
            this.gvTacGia.RowTemplate.Height = 28;
            this.gvTacGia.Size = new System.Drawing.Size(730, 221);
            this.gvTacGia.TabIndex = 1;
            this.gvTacGia.SelectionChanged += new System.EventHandler(this.gvTacGia_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 137);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(348, 50);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(191, 54);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.MintCream;
            this.btnXoa.Location = new System.Drawing.Point(114, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(191, 54);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmXoaTacGiaTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvTacGia);
            this.Controls.Add(this.pnlThongTin);
            this.Name = "frmXoaTacGiaTuaSach";
            this.Text = "frmXoaTacGiaTuaSach";
            this.Load += new System.EventHandler(this.frmXoaTacGiaTuaSach_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTacGia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTin;
        private DevExpress.XtraEditors.LabelControl lblTuaSach;
        private System.Windows.Forms.DataGridView gvTacGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}