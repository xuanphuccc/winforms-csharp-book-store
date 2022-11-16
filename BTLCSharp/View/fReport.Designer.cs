using BTLCSharp.RJElements;

namespace BTLCSharp
{
    partial class fReport
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnTopTurnoverReport = new BTLCSharp.RJElements.RJButton();
            this.btnTurnoverReport = new BTLCSharp.RJElements.RJButton();
            this.btnBooksReport = new BTLCSharp.RJElements.RJButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.btnTopTurnoverReport);
            this.pnlControls.Controls.Add(this.btnTurnoverReport);
            this.pnlControls.Controls.Add(this.btnBooksReport);
            this.pnlControls.Controls.Add(this.iconButton1);
            this.pnlControls.Location = new System.Drawing.Point(39, 12);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(954, 70);
            this.pnlControls.TabIndex = 1;
            // 
            // btnTopTurnoverReport
            // 
            this.btnTopTurnoverReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTopTurnoverReport.BackColor = System.Drawing.Color.White;
            this.btnTopTurnoverReport.BackgroundColor = System.Drawing.Color.White;
            this.btnTopTurnoverReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnTopTurnoverReport.BorderRadius = 6;
            this.btnTopTurnoverReport.BorderSize = 0;
            this.btnTopTurnoverReport.FlatAppearance.BorderSize = 0;
            this.btnTopTurnoverReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopTurnoverReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTopTurnoverReport.ForeColor = System.Drawing.Color.Black;
            this.btnTopTurnoverReport.Location = new System.Drawing.Point(312, 13);
            this.btnTopTurnoverReport.Name = "btnTopTurnoverReport";
            this.btnTopTurnoverReport.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnTopTurnoverReport.Size = new System.Drawing.Size(185, 42);
            this.btnTopTurnoverReport.TabIndex = 3;
            this.btnTopTurnoverReport.Text = "Top doanh thu";
            this.btnTopTurnoverReport.TextColor = System.Drawing.Color.Black;
            this.btnTopTurnoverReport.UseVisualStyleBackColor = false;
            this.btnTopTurnoverReport.Click += new System.EventHandler(this.btnTopTurnoverReport_Click);
            // 
            // btnTurnoverReport
            // 
            this.btnTurnoverReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTurnoverReport.BackColor = System.Drawing.Color.White;
            this.btnTurnoverReport.BackgroundColor = System.Drawing.Color.White;
            this.btnTurnoverReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnTurnoverReport.BorderRadius = 6;
            this.btnTurnoverReport.BorderSize = 0;
            this.btnTurnoverReport.FlatAppearance.BorderSize = 0;
            this.btnTurnoverReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnoverReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTurnoverReport.ForeColor = System.Drawing.Color.Black;
            this.btnTurnoverReport.Location = new System.Drawing.Point(156, 13);
            this.btnTurnoverReport.Name = "btnTurnoverReport";
            this.btnTurnoverReport.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnTurnoverReport.Size = new System.Drawing.Size(150, 42);
            this.btnTurnoverReport.TabIndex = 2;
            this.btnTurnoverReport.Text = "Doanh thu";
            this.btnTurnoverReport.TextColor = System.Drawing.Color.Black;
            this.btnTurnoverReport.UseVisualStyleBackColor = false;
            this.btnTurnoverReport.Click += new System.EventHandler(this.btnTurnoverReport_Click);
            // 
            // btnBooksReport
            // 
            this.btnBooksReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBooksReport.BackColor = System.Drawing.Color.White;
            this.btnBooksReport.BackgroundColor = System.Drawing.Color.White;
            this.btnBooksReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnBooksReport.BorderRadius = 6;
            this.btnBooksReport.BorderSize = 0;
            this.btnBooksReport.FlatAppearance.BorderSize = 0;
            this.btnBooksReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooksReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBooksReport.ForeColor = System.Drawing.Color.Black;
            this.btnBooksReport.Location = new System.Drawing.Point(0, 13);
            this.btnBooksReport.Name = "btnBooksReport";
            this.btnBooksReport.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnBooksReport.Size = new System.Drawing.Size(150, 42);
            this.btnBooksReport.TabIndex = 1;
            this.btnBooksReport.Text = "Thuê sách";
            this.btnBooksReport.TextColor = System.Drawing.Color.Black;
            this.btnBooksReport.UseVisualStyleBackColor = false;
            this.btnBooksReport.Click += new System.EventHandler(this.btnBooksReport_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(747, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iconButton1.Size = new System.Drawing.Size(186, 51);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Xuất báo cáo";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Location = new System.Drawing.Point(39, 98);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(954, 482);
            this.pnlBody.TabIndex = 3;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 615);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReport";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fReport_Load);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlControls;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJButton btnTopTurnoverReport;
        private RJButton btnTurnoverReport;
        private RJButton btnBooksReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpvData;
        private Panel pnlBody;
    }
}