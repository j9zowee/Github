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
            this.btnAddOrUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_BookIDNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AccessionNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.label2.Location = new System.Drawing.Point(153, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Book ID Number :";
            // 
            // dtp_DateReceived
            // 
            this.dtp_DateReceived.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.dtp_DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReceived.Location = new System.Drawing.Point(272, 85);
            this.dtp_DateReceived.Name = "dtp_DateReceived";
            this.dtp_DateReceived.Size = new System.Drawing.Size(145, 20);
            this.dtp_DateReceived.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "*Accession Num:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(153, 89);
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
            this.dgvBook.Location = new System.Drawing.Point(26, 216);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(377, 222);
            this.dgvBook.TabIndex = 60;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 117);
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
        "On Shelf",
        "Borrowed"};
            this.cmb_Status.Location = new System.Drawing.Point(272, 112);
            this.cmb_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_Status.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_Status.selectedIndex = -1;
            this.cmb_Status.Size = new System.Drawing.Size(145, 21);
            this.cmb_Status.TabIndex = 4;
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
            this.btnAddOrUpdate.Location = new System.Drawing.Point(177, 160);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.selected = false;
            this.btnAddOrUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnAddOrUpdate.TabIndex = 74;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_BookIDNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_BookIDNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNum.BorderThickness = 1;
            this.txt_BookIDNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_BookIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_BookIDNum.isPassword = false;
            this.txt_BookIDNum.Location = new System.Drawing.Point(272, 23);
            this.txt_BookIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(145, 22);
            this.txt_BookIDNum.TabIndex = 1;
            this.txt_BookIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_BookIDNum.OnValueChanged += new System.EventHandler(this.txt_BookIDNum_OnValueChanged);
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
            this.txt_AccessionNumber.Location = new System.Drawing.Point(272, 55);
            this.txt_AccessionNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccessionNumber.Name = "txt_AccessionNumber";
            this.txt_AccessionNumber.Size = new System.Drawing.Size(145, 22);
            this.txt_AccessionNumber.TabIndex = 2;
            this.txt_AccessionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_AccessionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AccessionNumber_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 7;
            this.btnExit.ButtonText = "EXIT";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = false;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 80D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(293, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(110, 41);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pb_QRBook);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 76;
            // 
            // BookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnExit);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AccessionNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BookIDNum;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private System.Windows.Forms.Panel panel3;
    }
}