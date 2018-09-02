namespace QRCodeBasedLMS
{
    partial class UpdateBookInfo
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
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Link_Scan = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CopyrightYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Pages = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Edition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CallNumber = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.pb_QRBook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BookIDNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 87;
            this.label13.Text = "*ISBN :";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ISBN.Location = new System.Drawing.Point(54, 212);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(189, 22);
            this.txt_ISBN.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(285, 365);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 41);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(285, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Link_Scan
            // 
            this.Link_Scan.AutoSize = true;
            this.Link_Scan.Location = new System.Drawing.Point(605, 39);
            this.Link_Scan.Name = "Link_Scan";
            this.Link_Scan.Size = new System.Drawing.Size(79, 13);
            this.Link_Scan.TabIndex = 17;
            this.Link_Scan.TabStop = true;
            this.Link_Scan.Text = "Scan QR Code";
            this.Link_Scan.Visible = false;
            this.Link_Scan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Scan_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(605, 32);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(119, 22);
            this.txt_Search.TabIndex = 18;
            this.txt_Search.Visible = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Title"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(478, 34);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 16;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Search by: ";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(309, 158);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(103, 63);
            this.txt_Remarks.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 83;
            this.label12.Text = "Remarks : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "*Copyright Year :";
            // 
            // txt_CopyrightYear
            // 
            this.txt_CopyrightYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CopyrightYear.Location = new System.Drawing.Point(120, 386);
            this.txt_CopyrightYear.MaxLength = 4;
            this.txt_CopyrightYear.Name = "txt_CopyrightYear";
            this.txt_CopyrightYear.Size = new System.Drawing.Size(123, 22);
            this.txt_CopyrightYear.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 80;
            this.label9.Text = "*Publisher :";
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Publisher.Location = new System.Drawing.Point(82, 360);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(162, 22);
            this.txt_Publisher.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "Pages :";
            // 
            // txt_Pages
            // 
            this.txt_Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pages.Location = new System.Drawing.Point(66, 479);
            this.txt_Pages.Name = "txt_Pages";
            this.txt_Pages.Size = new System.Drawing.Size(177, 22);
            this.txt_Pages.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Volume :";
            // 
            // txt_Volume
            // 
            this.txt_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Volume.Location = new System.Drawing.Point(66, 451);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(177, 22);
            this.txt_Volume.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "Edition : ";
            // 
            // txt_Edition
            // 
            this.txt_Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Edition.Location = new System.Drawing.Point(66, 420);
            this.txt_Edition.Name = "txt_Edition";
            this.txt_Edition.Size = new System.Drawing.Size(177, 22);
            this.txt_Edition.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Author :";
            // 
            // txt_Author
            // 
            this.txt_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(64, 332);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(180, 22);
            this.txt_Author.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Call Number : ";
            // 
            // txt_CallNumber
            // 
            this.txt_CallNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CallNumber.Location = new System.Drawing.Point(103, 237);
            this.txt_CallNumber.Name = "txt_CallNumber";
            this.txt_CallNumber.Size = new System.Drawing.Size(141, 22);
            this.txt_CallNumber.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(285, 314);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 41);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(418, 65);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(477, 436);
            this.dgvBook.TabIndex = 73;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // pb_QRBook
            // 
            this.pb_QRBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_QRBook.Location = new System.Drawing.Point(124, 12);
            this.pb_QRBook.Name = "pb_QRBook";
            this.pb_QRBook.Size = new System.Drawing.Size(130, 130);
            this.pb_QRBook.TabIndex = 63;
            this.pb_QRBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Book ID Number :";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(55, 263);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(189, 63);
            this.txt_Title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "*Title :";
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.Enabled = false;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookIDNum.Location = new System.Drawing.Point(124, 160);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(119, 22);
            this.txt_BookIDNum.TabIndex = 1;
            this.txt_BookIDNum.TextChanged += new System.EventHandler(this.txt_BookIDNum_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "*Book Type :";
            // 
            // cmbBookType
            // 
            this.cmbBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "References",
            "Filipiniana",
            "General Reference",
            "Fiction"});
            this.cmbBookType.Location = new System.Drawing.Point(98, 185);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(145, 24);
            this.cmbBookType.TabIndex = 2;
            // 
            // UpdateBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 511);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbBookType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Link_Scan);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Remarks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_CopyrightYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Pages);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Edition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CallNumber);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pb_QRBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_BookIDNum);
            this.Name = "UpdateBookInfo";
            this.Text = "UpdateBookInfo";
            this.Load += new System.EventHandler(this.UpdateBookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel Link_Scan;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CopyrightYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Pages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Edition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CallNumber;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.PictureBox pb_QRBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BookIDNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBookType;
    }
}