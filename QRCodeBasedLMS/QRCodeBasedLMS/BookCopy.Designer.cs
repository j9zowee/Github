namespace QRCodeBasedLMS
{
    partial class BookCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCopy));
            this.pb_QRBook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DateReceived = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmb_Status = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_BookIDNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AccessionNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddOrUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintQR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_QRBook
            // 
            this.pb_QRBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pb_QRBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_QRBook.Location = new System.Drawing.Point(1, 1);
            this.pb_QRBook.Name = "pb_QRBook";
            this.pb_QRBook.Size = new System.Drawing.Size(130, 130);
            this.pb_QRBook.TabIndex = 55;
            this.pb_QRBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Book ID Number :";
            // 
            // dtp_DateReceived
            // 
            this.dtp_DateReceived.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.dtp_DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReceived.Location = new System.Drawing.Point(272, 108);
            this.dtp_DateReceived.Name = "dtp_DateReceived";
            this.dtp_DateReceived.Size = new System.Drawing.Size(211, 20);
            this.dtp_DateReceived.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "*Accession Num:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(153, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Date Received :";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(13, 216);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(471, 222);
            this.dgvBook.TabIndex = 60;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "*Status :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmb_Status
            // 
            this.cmb_Status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Status.BorderRadius = 3;
            this.cmb_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_Status.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_Status.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_Status.Items = new string[] {
        "Available",
        "Borrowed",
        "Damaged",
        "Lost"};
            this.cmb_Status.Location = new System.Drawing.Point(272, 135);
            this.cmb_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_Status.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_Status.selectedIndex = -1;
            this.cmb_Status.Size = new System.Drawing.Size(211, 21);
            this.cmb_Status.TabIndex = 4;
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_BookIDNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_BookIDNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNum.BorderThickness = 1;
            this.txt_BookIDNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_BookIDNum.Enabled = false;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_BookIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_BookIDNum.isPassword = false;
            this.txt_BookIDNum.Location = new System.Drawing.Point(272, 46);
            this.txt_BookIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(211, 22);
            this.txt_BookIDNum.TabIndex = 1;
            this.txt_BookIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AccessionNumber
            // 
            this.txt_AccessionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_AccessionNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_AccessionNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_AccessionNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_AccessionNumber.BorderThickness = 1;
            this.txt_AccessionNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_AccessionNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AccessionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_AccessionNumber.isPassword = false;
            this.txt_AccessionNumber.Location = new System.Drawing.Point(272, 78);
            this.txt_AccessionNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccessionNumber.Name = "txt_AccessionNumber";
            this.txt_AccessionNumber.Size = new System.Drawing.Size(211, 22);
            this.txt_AccessionNumber.TabIndex = 2;
            this.txt_AccessionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_AccessionNumber.OnValueChanged += new System.EventHandler(this.txt_AccessionNumber_OnValueChanged);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddOrUpdate.BorderRadius = 7;
            this.btnAddOrUpdate.ButtonText = "ADD";
            this.btnAddOrUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddOrUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddOrUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddOrUpdate.Iconimage")));
            this.btnAddOrUpdate.Iconimage_right = null;
            this.btnAddOrUpdate.Iconimage_right_Selected = null;
            this.btnAddOrUpdate.Iconimage_Selected = null;
            this.btnAddOrUpdate.IconMarginLeft = 0;
            this.btnAddOrUpdate.IconMarginRight = 0;
            this.btnAddOrUpdate.IconRightVisible = false;
            this.btnAddOrUpdate.IconRightZoom = 0D;
            this.btnAddOrUpdate.IconVisible = true;
            this.btnAddOrUpdate.IconZoom = 80D;
            this.btnAddOrUpdate.IsTab = false;
            this.btnAddOrUpdate.Location = new System.Drawing.Point(142, 170);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.selected = false;
            this.btnAddOrUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnAddOrUpdate.TabIndex = 75;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pb_QRBook);
            this.panel3.Location = new System.Drawing.Point(12, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 76;
            // 
            // link_GoBack
            // 
            this.link_GoBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.BackColor = System.Drawing.Color.Transparent;
            this.link_GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_GoBack.BorderRadius = 7;
            this.link_GoBack.ButtonText = "Go Back";
            this.link_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_GoBack.DisabledColor = System.Drawing.Color.Gray;
            this.link_GoBack.Iconcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_GoBack.Iconimage")));
            this.link_GoBack.Iconimage_right = null;
            this.link_GoBack.Iconimage_right_Selected = null;
            this.link_GoBack.Iconimage_Selected = null;
            this.link_GoBack.IconMarginLeft = 0;
            this.link_GoBack.IconMarginRight = 0;
            this.link_GoBack.IconRightVisible = false;
            this.link_GoBack.IconRightZoom = 0D;
            this.link_GoBack.IconVisible = false;
            this.link_GoBack.IconZoom = 110D;
            this.link_GoBack.IsTab = false;
            this.link_GoBack.Location = new System.Drawing.Point(423, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(60, 22);
            this.link_GoBack.TabIndex = 97;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clear.BorderRadius = 7;
            this.btn_Clear.ButtonText = "CLEAR";
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Clear.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Iconimage")));
            this.btn_Clear.Iconimage_right = null;
            this.btn_Clear.Iconimage_right_Selected = null;
            this.btn_Clear.Iconimage_Selected = null;
            this.btn_Clear.IconMarginLeft = 0;
            this.btn_Clear.IconMarginRight = 0;
            this.btn_Clear.IconRightVisible = false;
            this.btn_Clear.IconRightZoom = 0D;
            this.btn_Clear.IconVisible = true;
            this.btn_Clear.IconZoom = 80D;
            this.btn_Clear.IsTab = false;
            this.btn_Clear.Location = new System.Drawing.Point(258, 169);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Clear.selected = false;
            this.btn_Clear.Size = new System.Drawing.Size(110, 41);
            this.btn_Clear.TabIndex = 98;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btnPrintQR
            // 
            this.btnPrintQR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnPrintQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnPrintQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintQR.BorderRadius = 7;
            this.btnPrintQR.ButtonText = "Print QR Code";
            this.btnPrintQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintQR.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintQR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintQR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintQR.Iconimage")));
            this.btnPrintQR.Iconimage_right = null;
            this.btnPrintQR.Iconimage_right_Selected = null;
            this.btnPrintQR.Iconimage_Selected = null;
            this.btnPrintQR.IconMarginLeft = 0;
            this.btnPrintQR.IconMarginRight = 0;
            this.btnPrintQR.IconRightVisible = false;
            this.btnPrintQR.IconRightZoom = 0D;
            this.btnPrintQR.IconVisible = true;
            this.btnPrintQR.IconZoom = 80D;
            this.btnPrintQR.IsTab = false;
            this.btnPrintQR.Location = new System.Drawing.Point(373, 169);
            this.btnPrintQR.Name = "btnPrintQR";
            this.btnPrintQR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnPrintQR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnPrintQR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintQR.selected = false;
            this.btnPrintQR.Size = new System.Drawing.Size(110, 41);
            this.btnPrintQR.TabIndex = 99;
            this.btnPrintQR.Text = "Print QR Code";
            this.btnPrintQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintQR.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnPrintQR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrintQR.Click += new System.EventHandler(this.btnPrintQR_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btnPrintQR);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.txt_BookIDNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_DateReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_AccessionNumber);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCopy";
            this.Load += new System.EventHandler(this.BookCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_QRBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DateReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown cmb_Status;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AccessionNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BookIDNum;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrUpdate;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Clear;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintQR;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}