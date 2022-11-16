namespace BTLCSharp.View
{
    partial class fReportTurnover
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboViewMode = new BTLCSharp.RJElements.RJComboBox();
            this.cboMonths = new BTLCSharp.RJElements.RJComboBox();
            this.cboYears = new BTLCSharp.RJElements.RJComboBox();
            this.pnlBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Controls.Add(this.rpvData);
            this.pnlBody.Location = new System.Drawing.Point(0, 84);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(954, 398);
            this.pnlBody.TabIndex = 4;
            // 
            // rpvData
            // 
            this.rpvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvData.Location = new System.Drawing.Point(0, 0);
            this.rpvData.Name = "ReportViewer";
            this.rpvData.ServerReport.BearerToken = null;
            this.rpvData.Size = new System.Drawing.Size(954, 398);
            this.rpvData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.cboViewMode);
            this.panel1.Controls.Add(this.cboMonths);
            this.panel1.Controls.Add(this.cboYears);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 78);
            this.panel1.TabIndex = 5;
            // 
            // cboViewMode
            // 
            this.cboViewMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboViewMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.cboViewMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboViewMode.BorderSize = 2;
            this.cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboViewMode.ForeColor = System.Drawing.Color.Black;
            this.cboViewMode.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboViewMode.Items.AddRange(new object[] {
            "Xem theo năm",
            "Xem theo tháng"});
            this.cboViewMode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboViewMode.ListTextColor = System.Drawing.Color.Black;
            this.cboViewMode.Location = new System.Drawing.Point(16, 16);
            this.cboViewMode.Margin = new System.Windows.Forms.Padding(16);
            this.cboViewMode.MinimumSize = new System.Drawing.Size(160, 30);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Padding = new System.Windows.Forms.Padding(2);
            this.cboViewMode.Size = new System.Drawing.Size(221, 46);
            this.cboViewMode.TabIndex = 13;
            this.cboViewMode.Texts = "Xem theo năm";
            this.cboViewMode.OnSelectedIndexChanged += new System.EventHandler(this.cboViewMode_OnSelectedIndexChanged);
            // 
            // cboMonths
            // 
            this.cboMonths.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.cboMonths.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboMonths.BorderSize = 2;
            this.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonths.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMonths.ForeColor = System.Drawing.Color.Black;
            this.cboMonths.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMonths.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMonths.ListTextColor = System.Drawing.Color.Black;
            this.cboMonths.Location = new System.Drawing.Point(604, 16);
            this.cboMonths.Margin = new System.Windows.Forms.Padding(16);
            this.cboMonths.MinimumSize = new System.Drawing.Size(160, 30);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Padding = new System.Windows.Forms.Padding(2);
            this.cboMonths.Size = new System.Drawing.Size(160, 46);
            this.cboMonths.TabIndex = 12;
            this.cboMonths.Texts = "Tháng";
            this.cboMonths.OnSelectedIndexChanged += new System.EventHandler(this.cboMonths_OnSelectedIndexChanged);
            // 
            // cboYears
            // 
            this.cboYears.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboYears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.cboYears.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboYears.BorderSize = 2;
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboYears.ForeColor = System.Drawing.Color.Black;
            this.cboYears.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboYears.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboYears.ListTextColor = System.Drawing.Color.Black;
            this.cboYears.Location = new System.Drawing.Point(778, 16);
            this.cboYears.Margin = new System.Windows.Forms.Padding(16);
            this.cboYears.MinimumSize = new System.Drawing.Size(160, 30);
            this.cboYears.Name = "cboYears";
            this.cboYears.Padding = new System.Windows.Forms.Padding(2);
            this.cboYears.Size = new System.Drawing.Size(160, 46);
            this.cboYears.TabIndex = 11;
            this.cboYears.Texts = "Năm";
            this.cboYears.OnSelectedIndexChanged += new System.EventHandler(this.cboYears_OnSelectedIndexChanged);
            // 
            // fReportTurnover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReportTurnover";
            this.Text = "fReportTurnover";
            this.Load += new System.EventHandler(this.fReportTurnover_Load);
            this.pnlBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBody;
        private Microsoft.Reporting.WinForms.ReportViewer rpvData;
        private Panel panel1;
        private RJElements.RJComboBox cboYears;
        private RJElements.RJComboBox cboMonths;
        private RJElements.RJComboBox cboViewMode;
    }
}