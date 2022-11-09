using BTLCSharp.RJElements;

namespace BTLCSharp
{
    partial class fBookManagement
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
            this.btnAddBook = new BTLCSharp.RJElements.RJButton();
            this.btnSearchBook = new BTLCSharp.RJElements.RJButton();
            this.pnlSearchBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnSearchBook);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.BackgroundColor = System.Drawing.Color.White;
            this.btnAddBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnAddBook.BorderRadius = 6;
            this.btnAddBook.BorderSize = 0;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddBook.Location = new System.Drawing.Point(173, 13);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddBook.Size = new System.Drawing.Size(134, 42);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Thêm sách";
            this.btnAddBook.TextColor = System.Drawing.Color.Black;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchBook.BackColor = System.Drawing.Color.White;
            this.btnSearchBook.BackgroundColor = System.Drawing.Color.White;
            this.btnSearchBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnSearchBook.BorderRadius = 6;
            this.btnSearchBook.BorderSize = 0;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchBook.ForeColor = System.Drawing.Color.Black;
            this.btnSearchBook.Location = new System.Drawing.Point(0, 13);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSearchBook.Size = new System.Drawing.Size(167, 42);
            this.btnSearchBook.TabIndex = 4;
            this.btnSearchBook.Text = "Tìm kiếm sách";
            this.btnSearchBook.TextColor = System.Drawing.Color.Black;
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // pnlSearchBody
            // 
            this.pnlSearchBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchBody.Location = new System.Drawing.Point(39, 88);
            this.pnlSearchBody.Name = "pnlSearchBody";
            this.pnlSearchBody.Size = new System.Drawing.Size(954, 499);
            this.pnlSearchBody.TabIndex = 4;
            // 
            // fBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 615);
            this.Controls.Add(this.pnlSearchBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBookManagement";
            this.Text = "fBookManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RJButton btnSearchBook;
        private RJButton btnAddBook;
        private Panel pnlSearchBody;
    }
}