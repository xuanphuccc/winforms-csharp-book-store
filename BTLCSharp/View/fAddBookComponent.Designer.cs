using BTLCSharp.RJElements;

namespace BTLCSharp
{
    partial class fAddBookComponent
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptbBookImage = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboLanguages = new BTLCSharp.RJElements.RJComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPublishingCpn = new BTLCSharp.RJElements.RJComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboAuthors = new BTLCSharp.RJElements.RJComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSectors = new BTLCSharp.RJElements.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPages = new BTLCSharp.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new BTLCSharp.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentalPrice = new BTLCSharp.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new BTLCSharp.RJTextBox();
            this.cboBookTypes = new BTLCSharp.RJElements.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new BTLCSharp.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new BTLCSharp.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new BTLCSharp.RJElements.RJButton();
            this.btnSave = new BTLCSharp.RJElements.RJButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBookImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ptbBookImage);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cboLanguages);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cboPublishingCpn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cboAuthors);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cboSectors);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTotalPages);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtRentalPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.cboBookTypes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 423);
            this.panel3.TabIndex = 1;
            // 
            // ptbBookImage
            // 
            this.ptbBookImage.BackgroundImage = global::BTLCSharp.Properties.Resources.pictureIcon;
            this.ptbBookImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbBookImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbBookImage.Location = new System.Drawing.Point(711, 99);
            this.ptbBookImage.Name = "ptbBookImage";
            this.ptbBookImage.Size = new System.Drawing.Size(208, 214);
            this.ptbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBookImage.TabIndex = 25;
            this.ptbBookImage.TabStop = false;
            this.ptbBookImage.Click += new System.EventHandler(this.ptbBookImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(500, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 28);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ngôn ngữ";
            // 
            // cboLanguages
            // 
            this.cboLanguages.BackColor = System.Drawing.Color.White;
            this.cboLanguages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboLanguages.BorderSize = 2;
            this.cboLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLanguages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLanguages.ForeColor = System.Drawing.Color.Black;
            this.cboLanguages.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLanguages.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLanguages.ListTextColor = System.Drawing.Color.Black;
            this.cboLanguages.Location = new System.Drawing.Point(500, 183);
            this.cboLanguages.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLanguages.Name = "cboLanguages";
            this.cboLanguages.Padding = new System.Windows.Forms.Padding(2);
            this.cboLanguages.Size = new System.Drawing.Size(200, 46);
            this.cboLanguages.TabIndex = 23;
            this.cboLanguages.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(711, 320);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nhà xuất bản";
            // 
            // cboPublishingCpn
            // 
            this.cboPublishingCpn.BackColor = System.Drawing.Color.White;
            this.cboPublishingCpn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboPublishingCpn.BorderSize = 2;
            this.cboPublishingCpn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboPublishingCpn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPublishingCpn.ForeColor = System.Drawing.Color.Black;
            this.cboPublishingCpn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboPublishingCpn.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboPublishingCpn.ListTextColor = System.Drawing.Color.Black;
            this.cboPublishingCpn.Location = new System.Drawing.Point(711, 351);
            this.cboPublishingCpn.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboPublishingCpn.Name = "cboPublishingCpn";
            this.cboPublishingCpn.Padding = new System.Windows.Forms.Padding(2);
            this.cboPublishingCpn.Size = new System.Drawing.Size(208, 46);
            this.cboPublishingCpn.TabIndex = 21;
            this.cboPublishingCpn.Texts = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(500, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tác giả";
            // 
            // cboAuthors
            // 
            this.cboAuthors.BackColor = System.Drawing.Color.White;
            this.cboAuthors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboAuthors.BorderSize = 2;
            this.cboAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboAuthors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAuthors.ForeColor = System.Drawing.Color.Black;
            this.cboAuthors.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboAuthors.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboAuthors.ListTextColor = System.Drawing.Color.Black;
            this.cboAuthors.Location = new System.Drawing.Point(500, 351);
            this.cboAuthors.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboAuthors.Name = "cboAuthors";
            this.cboAuthors.Padding = new System.Windows.Forms.Padding(2);
            this.cboAuthors.Size = new System.Drawing.Size(200, 46);
            this.cboAuthors.TabIndex = 19;
            this.cboAuthors.Texts = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(500, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lĩnh vực";
            // 
            // cboSectors
            // 
            this.cboSectors.BackColor = System.Drawing.Color.White;
            this.cboSectors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboSectors.BorderSize = 2;
            this.cboSectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboSectors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSectors.ForeColor = System.Drawing.Color.Black;
            this.cboSectors.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboSectors.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboSectors.ListTextColor = System.Drawing.Color.Black;
            this.cboSectors.Location = new System.Drawing.Point(500, 267);
            this.cboSectors.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSectors.Name = "cboSectors";
            this.cboSectors.Padding = new System.Windows.Forms.Padding(2);
            this.cboSectors.Size = new System.Drawing.Size(200, 46);
            this.cboSectors.TabIndex = 17;
            this.cboSectors.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(500, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Loại sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(234, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số trang";
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtTotalPages.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotalPages.BorderRadius = 6;
            this.txtTotalPages.BorderSize = 2;
            this.txtTotalPages.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPages.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPages.Location = new System.Drawing.Point(234, 183);
            this.txtTotalPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtTotalPages.Multiline = false;
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.Padding = new System.Windows.Forms.Padding(10);
            this.txtTotalPages.PasswordChar = false;
            this.txtTotalPages.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPages.PlaceholderText = "";
            this.txtTotalPages.Size = new System.Drawing.Size(208, 46);
            this.txtTotalPages.TabIndex = 14;
            this.txtTotalPages.Texts = "";
            this.txtTotalPages.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(309, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuantity.BorderRadius = 6;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(309, 351);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(133, 46);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(19, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá cho thuê";
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtRentalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtRentalPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRentalPrice.BorderRadius = 6;
            this.txtRentalPrice.BorderSize = 2;
            this.txtRentalPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRentalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRentalPrice.Location = new System.Drawing.Point(19, 351);
            this.txtRentalPrice.Multiline = false;
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Padding = new System.Windows.Forms.Padding(10);
            this.txtRentalPrice.PasswordChar = false;
            this.txtRentalPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRentalPrice.PlaceholderText = "";
            this.txtRentalPrice.Size = new System.Drawing.Size(283, 46);
            this.txtRentalPrice.TabIndex = 10;
            this.txtRentalPrice.Texts = "";
            this.txtRentalPrice.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(19, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá sách";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrice.BorderRadius = 6;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(19, 267);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(423, 46);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // cboBookTypes
            // 
            this.cboBookTypes.BackColor = System.Drawing.Color.White;
            this.cboBookTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboBookTypes.BorderSize = 2;
            this.cboBookTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboBookTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboBookTypes.ForeColor = System.Drawing.Color.Black;
            this.cboBookTypes.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboBookTypes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboBookTypes.ListTextColor = System.Drawing.Color.Black;
            this.cboBookTypes.Location = new System.Drawing.Point(500, 99);
            this.cboBookTypes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboBookTypes.Name = "cboBookTypes";
            this.cboBookTypes.Padding = new System.Windows.Forms.Padding(2);
            this.cboBookTypes.Size = new System.Drawing.Size(200, 46);
            this.cboBookTypes.TabIndex = 7;
            this.cboBookTypes.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sách";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 6;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(19, 99);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(423, 46);
            this.txtName.TabIndex = 5;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sách";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderRadius = 6;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(19, 183);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
            this.txtId.Size = new System.Drawing.Size(208, 46);
            this.txtId.TabIndex = 3;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 70);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(229, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 6;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(19, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fAddBookComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddBookComponent";
            this.Text = "fAddBookComponent";
            this.Load += new System.EventHandler(this.fAddBookComponent_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBookImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private RJButton btnSave;
        private RJButton btnCancel;
        private Panel panel3;
        private RJTextBox txtId;
        private Label label6;
        private RJTextBox txtTotalPages;
        private Label label5;
        private RJTextBox txtQuantity;
        private Label label4;
        private RJTextBox txtRentalPrice;
        private Label label3;
        private RJTextBox txtPrice;
        private RJComboBox cboBookTypes;
        private Label label2;
        private RJTextBox txtName;
        private Label label1;
        private PictureBox ptbBookImage;
        private Label label11;
        private RJComboBox cboLanguages;
        private Label label10;
        private RJComboBox cboPublishingCpn;
        private Label label9;
        private RJComboBox cboAuthors;
        private Label label8;
        private RJComboBox cboSectors;
        private Label label7;
    }
}