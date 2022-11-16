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
    public partial class fReportBookStatus : Form
    {
        public fReportBookStatus()
        {
            InitializeComponent();
        }

        private void fReportBookStatus_Load(object sender, EventArgs e)
        {
            try
            {
                rpvData.LocalReport.ReportEmbeddedResource = "BTLCSharp.Reports.BookStatus.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "SachThueChuaTra";
                reportDataSource.Value = DataProvider.Instance.ReadTable("select * from ReportSachThueChuaTra()");
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
