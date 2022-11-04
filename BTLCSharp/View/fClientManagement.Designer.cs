namespace BTLCSharp.View
{
    partial class fClientManagement
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
            this.btnAddClient = new BTLCSharp.RJElements.RJButton();
            this.btnSearchClient = new BTLCSharp.RJElements.RJButton();
            this.pnlSearchBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddClient);
            this.panel1.Controls.Add(this.btnSearchClient);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddClient.BackColor = System.Drawing.Color.White;
            this.btnAddClient.BackgroundColor = System.Drawing.Color.White;
            this.btnAddClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnAddClient.BorderRadius = 6;
            this.btnAddClient.BorderSize = 0;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.Location = new System.Drawing.Point(240, 13);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddClient.Size = new System.Drawing.Size(200, 42);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Thêm khách hàng";
            this.btnAddClient.TextColor = System.Drawing.Color.Black;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchClient.BackColor = System.Drawing.Color.White;
            this.btnSearchClient.BackgroundColor = System.Drawing.Color.White;
            this.btnSearchClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnSearchClient.BorderRadius = 6;
            this.btnSearchClient.BorderSize = 0;
            this.btnSearchClient.FlatAppearance.BorderSize = 0;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchClient.ForeColor = System.Drawing.Color.Black;
            this.btnSearchClient.Location = new System.Drawing.Point(0, 13);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSearchClient.Size = new System.Drawing.Size(234, 42);
            this.btnSearchClient.TabIndex = 4;
            this.btnSearchClient.Text = "Tìm kiếm khách hàng";
            this.btnSearchClient.TextColor = System.Drawing.Color.Black;
            this.btnSearchClient.UseVisualStyleBackColor = false;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // pnlSearchBody
            // 
            this.pnlSearchBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchBody.Location = new System.Drawing.Point(39, 88);
            this.pnlSearchBody.Name = "pnlSearchBody";
            this.pnlSearchBody.Size = new System.Drawing.Size(954, 499);
            this.pnlSearchBody.TabIndex = 2;
            // 
            // fClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 615);
            this.Controls.Add(this.pnlSearchBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fClientManagement";
            this.Text = "fClientManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RJElements.RJButton btnAddClient;
        private RJElements.RJButton btnSearchClient;
        private Panel pnlSearchBody;
    }
}