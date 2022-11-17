using BTLCSharp.Controllers;
using Microsoft.CodeAnalysis.FlowAnalysis;
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
using System.Windows.Media;

namespace BTLCSharp.View
{
    public partial class fReportTurnover : Form
    {
        private string? viewMode;

        public fReportTurnover()
        {
            InitializeComponent();
        }

        private void fReportTurnover_Load(object sender, EventArgs e)
        {
            DataTable yearsData = DataProvider.Instance.ReadTable("select * from LoadExistYears()");
            DataTable monthsData = DataProvider.Instance.ReadTable("select * from LoadExistMonths()");
            List<string> monthsList = new List<string>();
            List<string> yearsList = new List<string>();

            foreach(DataRow item in yearsData.Rows)
            {
                yearsList.Add(item["Nam"].ToString());
            }

            foreach (DataRow item in monthsData.Rows)
            {
                monthsList.Add(item["Thang"].ToString());
            }


            cboMonths.DataSource = monthsList;
            cboYears.DataSource = yearsList;
            
            if(cboYears.Items.Count > 0)
            {
                viewYearReport(cboYears.SelectedItem.ToString());
                cboMonths.Enabled = false;
            }
        }

        private void viewMonthReport(string? month, string ?year)
        {
            try
            {
                rpvData.LocalReport.ReportEmbeddedResource = "BTLCSharp.Reports.TurnoverMonths.rdlc";

                // Set title
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("TitleParam", $"BÁO CÁO DOANH THU THÁNG {month}"));
                rpvData.LocalReport.SetParameters(reportParameters);

                // Data
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DoanhThuThang";
                reportDataSource.Value = DataProvider.Instance.ReadTable($"select * from ChiTietTongTienThueThang({month}, {year})");
                
                // Clear and add data
                rpvData.LocalReport.DataSources.Clear();
                rpvData.LocalReport.DataSources.Add(reportDataSource);
                rpvData.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewYearReport(string? year)
        {
            try
            {
                rpvData.LocalReport.ReportEmbeddedResource = "BTLCSharp.Reports.TurnoverYears.rdlc";

                // Set title
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("TitleParam", $"BÁO CÁO DOANH THU NĂM {year}"));
                rpvData.LocalReport.SetParameters(reportParameters);

                // Data
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DoanhThuNam";
                reportDataSource.Value = DataProvider.Instance.ReadTable($"select * from ChiTietTongTienThueNam({year})");

                // Clear and add data
                rpvData.LocalReport.DataSources.Clear();
                rpvData.LocalReport.DataSources.Add(reportDataSource);
                rpvData.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboViewMode_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboViewMode.SelectedItem.ToString() == "Xem theo năm")
            {
                viewMode = "year";
                viewYearReport(cboYears.SelectedItem.ToString());
                cboMonths.Enabled = false;
            }
            else
            {
                viewMode = "month";
                viewMonthReport(cboMonths.SelectedItem.ToString(), cboYears.SelectedItem.ToString());
                cboMonths.Enabled = true;
            }
        }

        private void cboMonths_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(viewMode == "month")
            {
                viewMonthReport(cboMonths.SelectedItem.ToString(), cboYears.SelectedItem.ToString());
            }
        }

        private void cboYears_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(viewMode == "month")
            {
                viewMonthReport(cboMonths.SelectedItem.ToString(), cboYears.SelectedItem.ToString());
            }
            else if(viewMode == "year")
            {
                viewYearReport(cboYears.SelectedItem.ToString());
            }
        }
    }
}
