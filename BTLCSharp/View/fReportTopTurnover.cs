using BTLCSharp.Controllers;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp.View
{
    public partial class fReportTopTurnover : Form
    {
        public fReportTopTurnover()
        {
            InitializeComponent();
        }

        private void fReportTop5DoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                rpvData.LocalReport.ReportEmbeddedResource = "BTLCSharp.Reports.Top5DoanhThu.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "Top5DoanhThu";
                reportDataSource.Value = DataProvider.Instance.ReadTable("select * from Top5Doanhthu()");
                rpvData.LocalReport.DataSources.Add(reportDataSource);
                this.rpvData.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
