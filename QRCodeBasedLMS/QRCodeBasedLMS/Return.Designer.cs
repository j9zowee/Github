namespace QRCodeBasedLMS
{
    partial class Return
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_AccNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Title = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_BorrowerID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbDevice = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.btnBorrows = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.clsReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AccessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfDaysUnreturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBorrowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_AccNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Title);
            this.groupBox2.Location = new System.Drawing.Point(426, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 74);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            // 
            // txt_AccNum
            // 
            this.txt_AccNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_AccNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_AccNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_AccNum.BorderThickness = 1;
            this.txt_AccNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_AccNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AccNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_AccNum.isPassword = false;
            this.txt_AccNum.Location = new System.Drawing.Point(143, 14);
            this.txt_AccNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccNum.Name = "txt_AccNum";
            this.txt_AccNum.Size = new System.Drawing.Size(151, 22);
            this.txt_AccNum.TabIndex = 69;
            this.txt_AccNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_AccNum.OnValueChanged += new System.EventHandler(this.txt_BookIDNum_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Accession Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Title :";
            // 
            // txt_Title
            // 
            this.txt_Title.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Title.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Title.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Title.BorderThickness = 1;
            this.txt_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Title.isPassword = false;
            this.txt_Title.Location = new System.Drawing.Point(56, 46);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(238, 22);
            this.txt_Title.TabIndex = 70;
            this.txt_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_BorrowerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(426, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 74);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // txt_BorrowerID
            // 
            this.txt_BorrowerID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BorrowerID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_BorrowerID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_BorrowerID.BorderThickness = 1;
            this.txt_BorrowerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_BorrowerID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_BorrowerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_BorrowerID.isPassword = false;
            this.txt_BorrowerID.Location = new System.Drawing.Point(148, 16);
            this.txt_BorrowerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BorrowerID.Name = "txt_BorrowerID";
            this.txt_BorrowerID.Size = new System.Drawing.Size(146, 22);
            this.txt_BorrowerID.TabIndex = 67;
            this.txt_BorrowerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_BorrowerID.OnValueChanged += new System.EventHandler(this.txt_BorrowerID_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Borrower ID Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name : ";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Name.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Name.BorderThickness = 1;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Name.isPassword = false;
            this.txt_Name.Location = new System.Drawing.Point(70, 42);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(224, 22);
            this.txt_Name.TabIndex = 68;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbDevice
            // 
            this.cmbDevice.BackColor = System.Drawing.Color.Transparent;
            this.cmbDevice.BorderRadius = 3;
            this.cmbDevice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbDevice.DisabledColor = System.Drawing.Color.Gray;
            this.cmbDevice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbDevice.Items = new string[0];
            this.cmbDevice.Location = new System.Drawing.Point(7, 11);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbDevice.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbDevice.selectedIndex = -1;
            this.cmbDevice.Size = new System.Drawing.Size(298, 24);
            this.cmbDevice.TabIndex = 84;
            this.cmbDevice.onItemSelected += new System.EventHandler(this.cmbDevice_onItemSelected);
            // 
            // btnCamera
            // 
            this.btnCamera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.BorderRadius = 7;
            this.btnCamera.ButtonText = "Start Camera";
            this.btnCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamera.DisabledColor = System.Drawing.Color.Gray;
            this.btnCamera.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCamera.Iconimage = null;
            this.btnCamera.Iconimage_right = null;
            this.btnCamera.Iconimage_right_Selected = null;
            this.btnCamera.Iconimage_Selected = null;
            this.btnCamera.IconMarginLeft = 0;
            this.btnCamera.IconMarginRight = 0;
            this.btnCamera.IconRightVisible = false;
            this.btnCamera.IconRightZoom = 0D;
            this.btnCamera.IconVisible = true;
            this.btnCamera.IconZoom = 80D;
            this.btnCamera.IsTab = false;
            this.btnCamera.Location = new System.Drawing.Point(312, 7);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCamera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCamera.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCamera.selected = false;
            this.btnCamera.Size = new System.Drawing.Size(102, 31);
            this.btnCamera.TabIndex = 83;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCamera.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnCamera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_ScanQR.Location = new System.Drawing.Point(7, 49);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(407, 303);
            this.pb_ScanQR.TabIndex = 82;
            this.pb_ScanQR.TabStop = false;
            // 
            // btnBorrows
            // 
            this.btnBorrows.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBorrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnBorrows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrows.BorderRadius = 7;
            this.btnBorrows.ButtonText = "RETURN";
            this.btnBorrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrows.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrows.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrows.Iconimage = null;
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
            this.btnBorrows.Location = new System.Drawing.Point(575, 311);
            this.btnBorrows.Name = "btnBorrows";
            this.btnBorrows.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnBorrows.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBorrows.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrows.selected = false;
            this.btnBorrows.Size = new System.Drawing.Size(131, 41);
            this.btnBorrows.TabIndex = 81;
            this.btnBorrows.Text = "RETURN";
            this.btnBorrows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrows.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnBorrows.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBorrows.Click += new System.EventHandler(this.btnBorrows_Click);
            // 
            // btnScan
            // 
            this.btnScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.BorderRadius = 7;
            this.btnScan.ButtonText = "SCAN BOOK";
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.DisabledColor = System.Drawing.Color.Gray;
            this.btnScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScan.Iconimage = null;
            this.btnScan.Iconimage_right = null;
            this.btnScan.Iconimage_right_Selected = null;
            this.btnScan.Iconimage_Selected = null;
            this.btnScan.IconMarginLeft = 0;
            this.btnScan.IconMarginRight = 0;
            this.btnScan.IconRightVisible = false;
            this.btnScan.IconRightZoom = 0D;
            this.btnScan.IconVisible = true;
            this.btnScan.IconZoom = 80D;
            this.btnScan.IsTab = false;
            this.btnScan.Location = new System.Drawing.Point(438, 311);
            this.btnScan.Name = "btnScan";
            this.btnScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScan.selected = false;
            this.btnScan.Size = new System.Drawing.Size(131, 41);
            this.btnScan.TabIndex = 80;
            this.btnScan.Text = "SCAN BOOK";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Back.Location = new System.Drawing.Point(661, 1);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(60, 16);
            this.link_Back.TabIndex = 79;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Go Back";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalFee);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(426, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 56);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(140, 23);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(0, 16);
            this.lblTotalFee.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total Penalty Fee :";
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AutoGenerateColumns = false;
            this.dgvReturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.AccessionNumber,
            this.bookTitleDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.NoOfDaysUnreturned,
            this.PenaltyFee});
            this.dgvReturn.DataSource = this.clsReturnBindingSource;
            this.dgvReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReturn.Location = new System.Drawing.Point(8, 368);
            this.dgvReturn.MultiSelect = false;
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturn.Size = new System.Drawing.Size(714, 215);
            this.dgvReturn.TabIndex = 88;
            this.dgvReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturn_CellContentClick);
            // 
            // clsReturnBindingSource
            // 
            this.clsReturnBindingSource.DataSource = typeof(QRCodeBasedLMS.clsReturn);
            // 
            // clsBorrowBindingSource
            // 
            this.clsBorrowBindingSource.DataSource = typeof(QRCodeBasedLMS.clsBorrow);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // AccessionNumber
            // 
            this.AccessionNumber.DataPropertyName = "AccNum";
            this.AccessionNumber.HeaderText = "AccessionNumber";
            this.AccessionNumber.Name = "AccessionNumber";
            this.AccessionNumber.ReadOnly = true;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NoOfDaysUnreturned
            // 
            this.NoOfDaysUnreturned.DataPropertyName = "NoOfDaysUnreturned";
            this.NoOfDaysUnreturned.HeaderText = "NoOfDaysUnreturned";
            this.NoOfDaysUnreturned.Name = "NoOfDaysUnreturned";
            this.NoOfDaysUnreturned.ReadOnly = true;
            // 
            // PenaltyFee
            // 
            this.PenaltyFee.DataPropertyName = "PenaltyFee";
            this.PenaltyFee.HeaderText = "PenaltyFee";
            this.PenaltyFee.Name = "PenaltyFee";
            this.PenaltyFee.ReadOnly = true;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(734, 583);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.pb_ScanQR);
            this.Controls.Add(this.btnBorrows);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.link_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnReturn_FormClosing);
            this.Load += new System.EventHandler(this.btnReturn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBorrowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clsBorrowBindingSource;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AccNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BorrowerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Name;
        private Bunifu.Framework.UI.BunifuDropdown cmbDevice;
        private Bunifu.Framework.UI.BunifuFlatButton btnCamera;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrows;
        private Bunifu.Framework.UI.BunifuFlatButton btnScan;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.BindingSource clsReturnBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfDaysUnreturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyFee;
    }
}