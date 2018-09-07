namespace QRCodeBasedLMS
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.pb_QRBook = new System.Windows.Forms.PictureBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_DateReceived = new System.Windows.Forms.DateTimePicker();
            this.gb_Copy = new System.Windows.Forms.GroupBox();
            this.txt_AccessionNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_Status = new Bunifu.Framework.UI.BunifuDropdown();
            this.lbl_NumCopies = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddOrAddBookCopy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_BookIDNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ISBN = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_CallNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Author = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Publisher = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_CopyrightYear = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Edition = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Volume = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Pages = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbBookType = new Bunifu.Framework.UI.BunifuDropdown();
            this.link_Scan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.gb_Copy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pb_QRBook.TabIndex = 11;
            this.pb_QRBook.TabStop = false;
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Title.Location = new System.Drawing.Point(1, 1);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(187, 42);
            this.txt_Title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "*Title :";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(57, 271);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(884, 269);
            this.dgvBook.TabIndex = 22;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Accession Num:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Call Number : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Author :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Edition : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Volume :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "*Pages :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "*Publisher :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "*Copyright Year :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "*Status :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Remarks : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Search by: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(156, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "*ISBN :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Date Received :";
            // 
            // dtp_DateReceived
            // 
            this.dtp_DateReceived.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.dtp_DateReceived.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp_DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReceived.Location = new System.Drawing.Point(119, 50);
            this.dtp_DateReceived.Name = "dtp_DateReceived";
            this.dtp_DateReceived.Size = new System.Drawing.Size(137, 20);
            this.dtp_DateReceived.TabIndex = 14;
            // 
            // gb_Copy
            // 
            this.gb_Copy.Controls.Add(this.txt_AccessionNumber);
            this.gb_Copy.Controls.Add(this.cmb_Status);
            this.gb_Copy.Controls.Add(this.dtp_DateReceived);
            this.gb_Copy.Controls.Add(this.label1);
            this.gb_Copy.Controls.Add(this.label15);
            this.gb_Copy.Controls.Add(this.label11);
            this.gb_Copy.Location = new System.Drawing.Point(781, 51);
            this.gb_Copy.Name = "gb_Copy";
            this.gb_Copy.Size = new System.Drawing.Size(263, 111);
            this.gb_Copy.TabIndex = 53;
            this.gb_Copy.TabStop = false;
            this.gb_Copy.Text = "1st Book Copy";
            // 
            // txt_AccessionNumber
            // 
            this.txt_AccessionNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_AccessionNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_AccessionNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_AccessionNumber.BorderThickness = 1;
            this.txt_AccessionNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_AccessionNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AccessionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_AccessionNumber.isPassword = false;
            this.txt_AccessionNumber.Location = new System.Drawing.Point(119, 20);
            this.txt_AccessionNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccessionNumber.Name = "txt_AccessionNumber";
            this.txt_AccessionNumber.Size = new System.Drawing.Size(137, 22);
            this.txt_AccessionNumber.TabIndex = 71;
            this.txt_AccessionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_AccessionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AccessionNumber_KeyPress);
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
        "Damaged"};
            this.cmb_Status.Location = new System.Drawing.Point(119, 77);
            this.cmb_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_Status.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_Status.selectedIndex = -1;
            this.cmb_Status.Size = new System.Drawing.Size(137, 22);
            this.cmb_Status.TabIndex = 71;
            // 
            // lbl_NumCopies
            // 
            this.lbl_NumCopies.AutoSize = true;
            this.lbl_NumCopies.Location = new System.Drawing.Point(13, 147);
            this.lbl_NumCopies.Name = "lbl_NumCopies";
            this.lbl_NumCopies.Size = new System.Drawing.Size(0, 13);
            this.lbl_NumCopies.TabIndex = 55;
            this.lbl_NumCopies.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(156, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 57;
            this.label16.Text = "*Book Type :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAddOrAddBookCopy
            // 
            this.btnAddOrAddBookCopy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrAddBookCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrAddBookCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddOrAddBookCopy.BorderRadius = 7;
            this.btnAddOrAddBookCopy.ButtonText = "ADD";
            this.btnAddOrAddBookCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrAddBookCopy.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddOrAddBookCopy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddOrAddBookCopy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddOrAddBookCopy.Iconimage")));
            this.btnAddOrAddBookCopy.Iconimage_right = null;
            this.btnAddOrAddBookCopy.Iconimage_right_Selected = null;
            this.btnAddOrAddBookCopy.Iconimage_Selected = null;
            this.btnAddOrAddBookCopy.IconMarginLeft = 0;
            this.btnAddOrAddBookCopy.IconMarginRight = 0;
            this.btnAddOrAddBookCopy.IconRightVisible = false;
            this.btnAddOrAddBookCopy.IconRightZoom = 0D;
            this.btnAddOrAddBookCopy.IconVisible = true;
            this.btnAddOrAddBookCopy.IconZoom = 80D;
            this.btnAddOrAddBookCopy.IsTab = false;
            this.btnAddOrAddBookCopy.Location = new System.Drawing.Point(599, 224);
            this.btnAddOrAddBookCopy.Name = "btnAddOrAddBookCopy";
            this.btnAddOrAddBookCopy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrAddBookCopy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrAddBookCopy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrAddBookCopy.selected = false;
            this.btnAddOrAddBookCopy.Size = new System.Drawing.Size(110, 41);
            this.btnAddOrAddBookCopy.TabIndex = 58;
            this.btnAddOrAddBookCopy.Text = "ADD";
            this.btnAddOrAddBookCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrAddBookCopy.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrAddBookCopy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddOrAddBookCopy.Click += new System.EventHandler(this.btnAddOrAddBookCopy_Click);
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
            this.btn_Clear.Location = new System.Drawing.Point(715, 224);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Clear.selected = false;
            this.btn_Clear.Size = new System.Drawing.Size(110, 41);
            this.btn_Clear.TabIndex = 59;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.BorderRadius = 7;
            this.btn_Exit.ButtonText = "EXIT";
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Iconimage")));
            this.btn_Exit.Iconimage_right = null;
            this.btn_Exit.Iconimage_right_Selected = null;
            this.btn_Exit.Iconimage_Selected = null;
            this.btn_Exit.IconMarginLeft = 0;
            this.btn_Exit.IconMarginRight = 0;
            this.btn_Exit.IconRightVisible = false;
            this.btn_Exit.IconRightZoom = 0D;
            this.btn_Exit.IconVisible = true;
            this.btn_Exit.IconZoom = 80D;
            this.btn_Exit.IsTab = false;
            this.btn_Exit.Location = new System.Drawing.Point(831, 224);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Exit.selected = false;
            this.btn_Exit.Size = new System.Drawing.Size(110, 41);
            this.btn_Exit.TabIndex = 60;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_BookIDNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BookIDNum.BorderThickness = 1;
            this.txt_BookIDNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_BookIDNum.Enabled = false;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_BookIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_BookIDNum.isPassword = false;
            this.txt_BookIDNum.Location = new System.Drawing.Point(276, 12);
            this.txt_BookIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(189, 22);
            this.txt_BookIDNum.TabIndex = 22;
            this.txt_BookIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_BookIDNum.OnValueChanged += new System.EventHandler(this.txt_BookIDNum_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Book ID Number :";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ISBN.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_ISBN.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ISBN.BorderThickness = 1;
            this.txt_ISBN.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_ISBN.isPassword = false;
            this.txt_ISBN.Location = new System.Drawing.Point(276, 76);
            this.txt_ISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(189, 22);
            this.txt_ISBN.TabIndex = 62;
            this.txt_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_CallNumber
            // 
            this.txt_CallNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_CallNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_CallNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_CallNumber.BorderThickness = 1;
            this.txt_CallNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_CallNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CallNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_CallNumber.isPassword = false;
            this.txt_CallNumber.Location = new System.Drawing.Point(276, 108);
            this.txt_CallNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CallNumber.Name = "txt_CallNumber";
            this.txt_CallNumber.Size = new System.Drawing.Size(189, 22);
            this.txt_CallNumber.TabIndex = 63;
            this.txt_CallNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txt_Title);
            this.panel1.Location = new System.Drawing.Point(276, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 44);
            this.panel1.TabIndex = 64;
            // 
            // txt_Author
            // 
            this.txt_Author.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Author.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Author.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Author.BorderThickness = 1;
            this.txt_Author.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Author.isPassword = false;
            this.txt_Author.Location = new System.Drawing.Point(276, 190);
            this.txt_Author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(189, 22);
            this.txt_Author.TabIndex = 65;
            this.txt_Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Publisher.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Publisher.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Publisher.BorderThickness = 1;
            this.txt_Publisher.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Publisher.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Publisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Publisher.isPassword = false;
            this.txt_Publisher.Location = new System.Drawing.Point(578, 12);
            this.txt_Publisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(189, 22);
            this.txt_Publisher.TabIndex = 66;
            this.txt_Publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_CopyrightYear
            // 
            this.txt_CopyrightYear.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_CopyrightYear.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_CopyrightYear.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_CopyrightYear.BorderThickness = 1;
            this.txt_CopyrightYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_CopyrightYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CopyrightYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_CopyrightYear.isPassword = false;
            this.txt_CopyrightYear.Location = new System.Drawing.Point(578, 44);
            this.txt_CopyrightYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CopyrightYear.Name = "txt_CopyrightYear";
            this.txt_CopyrightYear.Size = new System.Drawing.Size(189, 22);
            this.txt_CopyrightYear.TabIndex = 67;
            this.txt_CopyrightYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CopyrightYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CopyrightYear_KeyPress);
            // 
            // txt_Edition
            // 
            this.txt_Edition.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Edition.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Edition.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Edition.BorderThickness = 1;
            this.txt_Edition.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Edition.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Edition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Edition.isPassword = false;
            this.txt_Edition.Location = new System.Drawing.Point(578, 76);
            this.txt_Edition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Edition.Name = "txt_Edition";
            this.txt_Edition.Size = new System.Drawing.Size(189, 22);
            this.txt_Edition.TabIndex = 68;
            this.txt_Edition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Volume
            // 
            this.txt_Volume.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Volume.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Volume.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Volume.BorderThickness = 1;
            this.txt_Volume.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Volume.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Volume.isPassword = false;
            this.txt_Volume.Location = new System.Drawing.Point(578, 108);
            this.txt_Volume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(189, 22);
            this.txt_Volume.TabIndex = 69;
            this.txt_Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Pages
            // 
            this.txt_Pages.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Pages.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Pages.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Pages.BorderThickness = 1;
            this.txt_Pages.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Pages.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Pages.isPassword = false;
            this.txt_Pages.Location = new System.Drawing.Point(578, 140);
            this.txt_Pages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pages.Name = "txt_Pages";
            this.txt_Pages.Size = new System.Drawing.Size(189, 22);
            this.txt_Pages.TabIndex = 70;
            this.txt_Pages.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pages_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.txt_Remarks);
            this.panel2.Location = new System.Drawing.Point(578, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 44);
            this.panel2.TabIndex = 65;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Remarks.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Remarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Remarks.Location = new System.Drawing.Point(1, 1);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(187, 42);
            this.txt_Remarks.TabIndex = 12;
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmb_SearchCategory.BorderRadius = 3;
            this.cmb_SearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_SearchCategory.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_SearchCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_SearchCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_SearchCategory.Items = new string[] {
        "QR Code",
        "Title"};
            this.cmb_SearchCategory.Location = new System.Drawing.Point(124, 239);
            this.cmb_SearchCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategory.selectedIndex = -1;
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 72;
            this.cmb_SearchCategory.onItemSelected += new System.EventHandler(this.cmb_SelectedCategory_onItemSelected);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Search.BorderThickness = 1;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Search.isPassword = false;
            this.txt_Search.Location = new System.Drawing.Point(257, 238);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(119, 22);
            this.txt_Search.TabIndex = 73;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pb_QRBook);
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 65;
            // 
            // cmbBookType
            // 
            this.cmbBookType.BackColor = System.Drawing.Color.Transparent;
            this.cmbBookType.BorderRadius = 3;
            this.cmbBookType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbBookType.DisabledColor = System.Drawing.Color.Gray;
            this.cmbBookType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbBookType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbBookType.Items = new string[] {
        "References",
        "Filipiniana",
        "General Reference",
        "Fiction"};
            this.cmbBookType.Location = new System.Drawing.Point(275, 43);
            this.cmbBookType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbBookType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbBookType.selectedIndex = -1;
            this.cmbBookType.Size = new System.Drawing.Size(189, 24);
            this.cmbBookType.TabIndex = 61;
            // 
            // link_Scan
            // 
            this.link_Scan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_Scan.BackColor = System.Drawing.Color.Transparent;
            this.link_Scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_Scan.BorderRadius = 7;
            this.link_Scan.ButtonText = "Scan QR Code";
            this.link_Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_Scan.DisabledColor = System.Drawing.Color.Gray;
            this.link_Scan.Iconcolor = System.Drawing.Color.Transparent;
            this.link_Scan.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_Scan.Iconimage")));
            this.link_Scan.Iconimage_right = null;
            this.link_Scan.Iconimage_right_Selected = null;
            this.link_Scan.Iconimage_Selected = null;
            this.link_Scan.IconMarginLeft = 0;
            this.link_Scan.IconMarginRight = 0;
            this.link_Scan.IconRightVisible = false;
            this.link_Scan.IconRightZoom = 0D;
            this.link_Scan.IconVisible = false;
            this.link_Scan.IconZoom = 110D;
            this.link_Scan.IsTab = false;
            this.link_Scan.Location = new System.Drawing.Point(252, 239);
            this.link_Scan.Name = "link_Scan";
            this.link_Scan.Normalcolor = System.Drawing.Color.Transparent;
            this.link_Scan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_Scan.OnHoverTextColor = System.Drawing.Color.White;
            this.link_Scan.selected = false;
            this.link_Scan.Size = new System.Drawing.Size(124, 22);
            this.link_Scan.TabIndex = 74;
            this.link_Scan.Text = "Scan QR Code";
            this.link_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_Scan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_Scan.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_Scan.Click += new System.EventHandler(this.link_Scan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 7;
            this.btnUpdate.ButtonText = "UPDATE";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = false;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 80D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(483, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnUpdate.TabIndex = 95;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1056, 552);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.link_Scan);
            this.Controls.Add(this.cmbBookType);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Pages);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.txt_Edition);
            this.Controls.Add(this.txt_CopyrightYear);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_CallNumber);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnAddOrAddBookCopy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_NumCopies);
            this.Controls.Add(this.gb_Copy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.txt_BookIDNum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 568);
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.gb_Copy.ResumeLayout(false);
            this.gb_Copy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        


        private System.Windows.Forms.PictureBox pb_QRBook;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_DateReceived;
        private System.Windows.Forms.GroupBox gb_Copy;
        private System.Windows.Forms.Label lbl_NumCopies;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrAddBookCopy;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Clear;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Exit;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BookIDNum;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ISBN;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CallNumber;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Author;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Publisher;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CopyrightYear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Edition;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Volume;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Pages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Remarks;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AccessionNumber;
        private Bunifu.Framework.UI.BunifuDropdown cmb_Status;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategory;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDropdown cmbBookType;
        private Bunifu.Framework.UI.BunifuFlatButton link_Scan;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
    }
}