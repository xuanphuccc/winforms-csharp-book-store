namespace BTLCSharp.View
{
    partial class fReportTopTurnover
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.rpvData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.rpvData);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(954, 482);
            this.pnlBody.TabIndex = 3;
            // 
            // rpvData
            // 
            this.rpvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvData.Location = new System.Drawing.Point(0, 0);
            this.rpvData.Name = "ReportViewer";
            this.rpvData.ServerReport.BearerToken = null;
            this.rpvData.Size = new System.Drawing.Size(954, 482);
            this.rpvData.TabIndex = 0;
            // 
            // fReportTop5DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 482);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReportTop5DoanhThu";
            this.Text = "fReportTop5DoanhThu";
            this.Load += new System.EventHandler(this.fReportTop5DoanhThu_Load);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBody;
        private Microsoft.Reporting.WinForms.ReportViewer rpvData;
    }
}