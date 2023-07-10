using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTV
{
    public partial class ReportTop10Sach : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTop10Sach()
        {
            InitializeComponent();
        }

        public ReportTop10Sach(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connstr;
            sqlDataSource1.Queries[0].Parameters[0].Value = dateFrom;
            sqlDataSource1.Queries[0].Parameters[1].Value = dateTo;
            sqlDataSource1.Fill();
            lblNgayBatDau.Text = lblNgayBatDau.Text + " " + dateFrom.ToString("dd/MM/yyyy");
            lblNgayKetThuc.Text = lblNgayKetThuc.Text + " " + dateTo.ToString("dd/MM/yyyy");

        }

    }
}
