using BTLCSharp.RJElements;

namespace BTLCSharp.View
{
    partial class fSearchComponent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjComboBox1 = new RJComboBox();
            this.rjTextBox1 = new BTLCSharp.RJTextBox();
            this.rjButton4 = new RJButton();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjButton2 = new RJButton();
            this.rjButton3 = new RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rjButton4);
            this.panel2.Controls.Add(this.rjTextBox1);
            this.panel2.Controls.Add(this.rjComboBox1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 73);
            this.panel2.TabIndex = 0;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjComboBox1.BorderSize = 2;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.Black;
            this.rjComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjComboBox1.Items.AddRange(new object[] {
            "Tên sách",
            "Lĩnh vực",
            "Tác giả",
            "Nhà xuất bản"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBox1.Location = new System.Drawing.Point(19, 14);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBox1.Size = new System.Drawing.Size(236, 46);
            this.rjComboBox1.TabIndex = 3;
            this.rjComboBox1.Texts = "Tìm kiếm theo";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox1.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox1.Location = new System.Drawing.Point(282, 14);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(375, 46);
            this.rjTextBox1.TabIndex = 4;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 6;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(683, 14);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(184, 46);
            this.rjButton4.TabIndex = 6;
            this.rjButton4.Text = "Tìm kiếm";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(0, 92);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 62;
            this.dgvReport.RowTemplate.Height = 33;
            this.dgvReport.Size = new System.Drawing.Size(954, 327);
            this.dgvReport.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.panel3.Controls.Add(this.rjButton2);
            this.panel3.Controls.Add(this.rjButton3);
            this.panel3.Location = new System.Drawing.Point(0, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 70);
            this.panel3.TabIndex = 5;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 6;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(19, 12);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(184, 46);
            this.rjButton2.TabIndex = 2;
            this.rjButton2.Text = "Chi tiết";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 6;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(229, 12);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(184, 46);
            this.rjButton3.TabIndex = 3;
            this.rjButton3.Text = "Xóa";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // fSearchBookComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 499);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSearchBookComponent";
            this.Text = "fSearchBookComponent";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RJComboBox rjComboBox1;
        private RJTextBox rjTextBox1;
        private RJButton rjButton4;
        private DataGridView dgvReport;
        private Panel panel3;
        private RJButton rjButton2;
        private RJButton rjButton3;
    }
}