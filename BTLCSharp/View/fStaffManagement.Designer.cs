namespace BTLCSharp.View
{
    partial class fStaffManagement
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
            this.btnAddStaff = new BTLCSharp.RJElements.RJButton();
            this.btnSearchStaff = new BTLCSharp.RJElements.RJButton();
            this.pnlSearchBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.btnSearchStaff);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 70);
            this.panel1.TabIndex = 2;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddStaff.BackColor = System.Drawing.Color.White;
            this.btnAddStaff.BackgroundColor = System.Drawing.Color.White;
            this.btnAddStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnAddStaff.BorderRadius = 6;
            this.btnAddStaff.BorderSize = 0;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStaff.ForeColor = System.Drawing.Color.Black;
            this.btnAddStaff.Location = new System.Drawing.Point(224, 13);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddStaff.Size = new System.Drawing.Size(186, 42);
            this.btnAddStaff.TabIndex = 5;
            this.btnAddStaff.Text = "Thêm nhân viên";
            this.btnAddStaff.TextColor = System.Drawing.Color.Black;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchStaff.BackColor = System.Drawing.Color.White;
            this.btnSearchStaff.BackgroundColor = System.Drawing.Color.White;
            this.btnSearchStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnSearchStaff.BorderRadius = 6;
            this.btnSearchStaff.BorderSize = 0;
            this.btnSearchStaff.FlatAppearance.BorderSize = 0;
            this.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchStaff.ForeColor = System.Drawing.Color.Black;
            this.btnSearchStaff.Location = new System.Drawing.Point(0, 13);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSearchStaff.Size = new System.Drawing.Size(218, 42);
            this.btnSearchStaff.TabIndex = 4;
            this.btnSearchStaff.Text = "Tìm kiếm nhân viên";
            this.btnSearchStaff.TextColor = System.Drawing.Color.Black;
            this.btnSearchStaff.UseVisualStyleBackColor = false;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // pnlSearchBody
            // 
            this.pnlSearchBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchBody.Location = new System.Drawing.Point(39, 88);
            this.pnlSearchBody.Name = "pnlSearchBody";
            this.pnlSearchBody.Size = new System.Drawing.Size(954, 499);
            this.pnlSearchBody.TabIndex = 3;
            // 
            // fStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 615);
            this.Controls.Add(this.pnlSearchBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStaffManagement";
            this.Text = "fStaffManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RJElements.RJButton btnAddStaff;
        private RJElements.RJButton btnSearchStaff;
        private Panel pnlSearchBody;
    }
}