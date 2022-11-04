namespace BTLCSharp.View
{
    partial class fRentalManagement
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
            this.btnReturn = new BTLCSharp.RJElements.RJButton();
            this.btnRental = new BTLCSharp.RJElements.RJButton();
            this.pnlSearchBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnRental);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 70);
            this.panel1.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundColor = System.Drawing.Color.White;
            this.btnReturn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnReturn.BorderRadius = 6;
            this.btnReturn.BorderSize = 0;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(154, 13);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnReturn.Size = new System.Drawing.Size(118, 42);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Phiếu trả";
            this.btnReturn.TextColor = System.Drawing.Color.Black;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRental
            // 
            this.btnRental.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRental.BackColor = System.Drawing.Color.White;
            this.btnRental.BackgroundColor = System.Drawing.Color.White;
            this.btnRental.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnRental.BorderRadius = 6;
            this.btnRental.BorderSize = 0;
            this.btnRental.FlatAppearance.BorderSize = 0;
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRental.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRental.ForeColor = System.Drawing.Color.Black;
            this.btnRental.Location = new System.Drawing.Point(0, 13);
            this.btnRental.Name = "btnRental";
            this.btnRental.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnRental.Size = new System.Drawing.Size(148, 42);
            this.btnRental.TabIndex = 4;
            this.btnRental.Text = "Phiếu thuê";
            this.btnRental.TextColor = System.Drawing.Color.Black;
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
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
            // fRentalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 615);
            this.Controls.Add(this.pnlSearchBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRentalManagement";
            this.Text = "fRentalManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RJElements.RJButton btnReturn;
        private RJElements.RJButton btnRental;
        private Panel pnlSearchBody;
    }
}