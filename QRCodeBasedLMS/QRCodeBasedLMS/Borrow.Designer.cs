namespace QRCodeBasedLMS
{
    partial class Borrow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.btnScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BorrowerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BookIDNum = new System.Windows.Forms.TextBox();
            this.pb_QRCode = new System.Windows.Forms.PictureBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_BorrowerIDs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Names = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_BookIDNums = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Titles = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnScans = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrows = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(122, 303);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 34);
            this.btnScan.TabIndex = 28;
            this.btnScan.Text = "SCAN BOOK";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Borrower ID Number :";
            // 
            // txt_BorrowerID
            // 
            this.txt_BorrowerID.Enabled = false;
            this.txt_BorrowerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BorrowerID.Location = new System.Drawing.Point(157, 169);
            this.txt_BorrowerID.Name = "txt_BorrowerID";
            this.txt_BorrowerID.Size = new System.Drawing.Size(155, 22);
            this.txt_BorrowerID.TabIndex = 25;
            this.txt_BorrowerID.TextChanged += new System.EventHandler(this.txt_BorrowerID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Book ID Number :";
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.Enabled = false;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookIDNum.Location = new System.Drawing.Point(140, 236);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(168, 22);
            this.txt_BookIDNum.TabIndex = 23;
            this.txt_BookIDNum.TextChanged += new System.EventHandler(this.txt_BookIDNum_TextChanged);
            // 
            // pb_QRCode
            // 
            this.pb_QRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pb_QRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_QRCode.Location = new System.Drawing.Point(1, 1);
            this.pb_QRCode.Name = "pb_QRCode";
            this.pb_QRCode.Size = new System.Drawing.Size(130, 130);
            this.pb_QRCode.TabIndex = 29;
            this.pb_QRCode.TabStop = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(218, 303);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(90, 34);
            this.btnBorrow.TabIndex = 33;
            this.btnBorrow.Text = "BORROW";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrow.Location = new System.Drawing.Point(334, 42);
            this.dgvBorrow.MultiSelect = false;
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(428, 301);
            this.dgvBorrow.TabIndex = 32;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Back.Location = new System.Drawing.Point(702, 12);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(60, 16);
            this.link_Back.TabIndex = 34;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Go Back";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name : ";
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(81, 197);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(227, 22);
            this.txt_Name.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Title :";
            // 
            // txt_Title
            // 
            this.txt_Title.Enabled = false;
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(61, 268);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(247, 22);
            this.txt_Title.TabIndex = 37;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_BorrowerIDs
            // 
            this.txt_BorrowerIDs.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BorrowerIDs.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_BorrowerIDs.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BorrowerIDs.BorderThickness = 1;
            this.txt_BorrowerIDs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_BorrowerIDs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_BorrowerIDs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_BorrowerIDs.isPassword = false;
            this.txt_BorrowerIDs.Location = new System.Drawing.Point(193, 167);
            this.txt_BorrowerIDs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BorrowerIDs.Name = "txt_BorrowerIDs";
            this.txt_BorrowerIDs.Size = new System.Drawing.Size(173, 22);
            this.txt_BorrowerIDs.TabIndex = 67;
            this.txt_BorrowerIDs.Text = "for txt_BorrowerID";
            this.txt_BorrowerIDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Names
            // 
            this.txt_Names.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Names.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Names.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Names.BorderThickness = 1;
            this.txt_Names.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Names.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Names.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Names.isPassword = false;
            this.txt_Names.Location = new System.Drawing.Point(193, 195);
            this.txt_Names.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Names.Name = "txt_Names";
            this.txt_Names.Size = new System.Drawing.Size(173, 22);
            this.txt_Names.TabIndex = 68;
            this.txt_Names.Text = "for txt_Name";
            this.txt_Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_BookIDNums
            // 
            this.txt_BookIDNums.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNums.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_BookIDNums.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNums.BorderThickness = 1;
            this.txt_BookIDNums.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_BookIDNums.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_BookIDNums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_BookIDNums.isPassword = false;
            this.txt_BookIDNums.Location = new System.Drawing.Point(193, 237);
            this.txt_BookIDNums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BookIDNums.Name = "txt_BookIDNums";
            this.txt_BookIDNums.Size = new System.Drawing.Size(173, 22);
            this.txt_BookIDNums.TabIndex = 69;
            this.txt_BookIDNums.Text = "for txt_BookIDNum";
            this.txt_BookIDNums.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Titles
            // 
            this.txt_Titles.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Titles.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Titles.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Titles.BorderThickness = 1;
            this.txt_Titles.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Titles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Titles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Titles.isPassword = false;
            this.txt_Titles.Location = new System.Drawing.Point(193, 269);
            this.txt_Titles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Titles.Name = "txt_Titles";
            this.txt_Titles.Size = new System.Drawing.Size(173, 22);
            this.txt_Titles.TabIndex = 70;
            this.txt_Titles.Text = "for txt_Title";
            this.txt_Titles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pb_QRCode);
            this.panel3.Location = new System.Drawing.Point(99, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 71;
            // 
            // btnScans
            // 
            this.btnScans.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScans.BorderRadius = 7;
            this.btnScans.ButtonText = "SCAN BOOK";
            this.btnScans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScans.DisabledColor = System.Drawing.Color.Gray;
            this.btnScans.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScans.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnScans.Iconimage")));
            this.btnScans.Iconimage_right = null;
            this.btnScans.Iconimage_right_Selected = null;
            this.btnScans.Iconimage_Selected = null;
            this.btnScans.IconMarginLeft = 0;
            this.btnScans.IconMarginRight = 0;
            this.btnScans.IconRightVisible = false;
            this.btnScans.IconRightZoom = 0D;
            this.btnScans.IconVisible = true;
            this.btnScans.IconZoom = 80D;
            this.btnScans.IsTab = false;
            this.btnScans.Location = new System.Drawing.Point(12, 299);
            this.btnScans.Name = "btnScans";
            this.btnScans.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScans.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScans.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScans.selected = false;
            this.btnScans.Size = new System.Drawing.Size(131, 41);
            this.btnScans.TabIndex = 59;
            this.btnScans.Text = "SCAN BOOK";
            this.btnScans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScans.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnScans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btnBorrows
            // 
            this.btnBorrows.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBorrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnBorrows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrows.BorderRadius = 7;
            this.btnBorrows.ButtonText = "BORROW";
            this.btnBorrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrows.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrows.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrows.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBorrows.Iconimage")));
            this.btnBorrows.Iconimage_right = null;
            this.btnBorrows.Iconimage_right_Selected = null;
            this.btnBorrows.Iconimage_Selected = null;
            this.btnBorrows.IconMarginLeft = 0;
            this.btnBorrows.IconMarginRight = 0;
            this.btnBorrows.IconRightVisible = false;
            this.btnBorrows.IconRightZoom = 0D;
            this.btnBorrows.IconVisible = true;
            this.btnBorrows.IconZoom = 80D;
            this.btnBorrows.IsTab = false;
            this.btnBorrows.Location = new System.Drawing.Point(298, 299);
            this.btnBorrows.Name = "btnBorrows";
            this.btnBorrows.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnBorrows.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBorrows.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrows.selected = false;
            this.btnBorrows.Size = new System.Drawing.Size(131, 41);
            this.btnBorrows.TabIndex = 72;
            this.btnBorrows.Text = "BORROW";
            this.btnBorrows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrows.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnBorrows.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(782, 349);
            this.Controls.Add(this.btnBorrows);
            this.Controls.Add(this.btnScans);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_Titles);
            this.Controls.Add(this.txt_BookIDNums);
            this.Controls.Add(this.txt_Names);
            this.Controls.Add(this.txt_BorrowerIDs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BorrowerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BookIDNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BorrowerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BookIDNum;
        private System.Windows.Forms.PictureBox pb_QRCode;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Title;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BorrowerIDs;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Names;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BookIDNums;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Titles;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnScans;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrows;
    }
}