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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AccessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_BorrowerID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnScan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrows = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbDevice = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsBorrowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Borrower ID Number :";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AutoGenerateColumns = false;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.AccessionNumber,
            this.bookTitleDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.dgvBorrow.DataSource = this.clsBorrowBindingSource;
            this.dgvBorrow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrow.Location = new System.Drawing.Point(18, 384);
            this.dgvBorrow.MultiSelect = false;
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(714, 215);
            this.dgvBorrow.TabIndex = 32;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
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
            this.AccessionNumber.DataPropertyName = "AccessionIDNumber";
            this.AccessionNumber.HeaderText = "AccessionNumber";
            this.AccessionNumber.Name = "AccessionNumber";
            this.AccessionNumber.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name : ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.txt_BorrowerID.Location = new System.Drawing.Point(148, 31);
            this.txt_BorrowerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BorrowerID.Name = "txt_BorrowerID";
            this.txt_BorrowerID.Size = new System.Drawing.Size(146, 22);
            this.txt_BorrowerID.TabIndex = 67;
            this.txt_BorrowerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_BorrowerID.OnValueChanged += new System.EventHandler(this.txt_BorrowerIDs_OnValueChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Name.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Name.BorderThickness = 1;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Name.isPassword = false;
            this.txt_Name.Location = new System.Drawing.Point(70, 57);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(224, 22);
            this.txt_Name.TabIndex = 68;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnScan
            // 
            this.btnScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.BorderRadius = 7;
            this.btnScan.ButtonText = "SCAN BORROWER";
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.DisabledColor = System.Drawing.Color.Gray;
            this.btnScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnScan.Iconimage")));
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
            this.btnScan.Location = new System.Drawing.Point(449, 328);
            this.btnScan.Name = "btnScan";
            this.btnScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScan.selected = false;
            this.btnScan.Size = new System.Drawing.Size(131, 41);
            this.btnScan.TabIndex = 59;
            this.btnScan.Text = "SCAN BORROWER";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnScan.Click += new System.EventHandler(this.btnScans_Click);
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
            this.btnBorrows.Enabled = false;
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
            this.btnBorrows.Location = new System.Drawing.Point(586, 328);
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
            this.btnBorrows.Click += new System.EventHandler(this.btnBorrows_Click);
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
            this.cmbDevice.Location = new System.Drawing.Point(18, 28);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbDevice.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbDevice.selectedIndex = -1;
            this.cmbDevice.Size = new System.Drawing.Size(298, 24);
            this.cmbDevice.TabIndex = 75;
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
            this.btnCamera.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCamera.Iconimage")));
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
            this.btnCamera.Location = new System.Drawing.Point(323, 24);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCamera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCamera.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCamera.selected = false;
            this.btnCamera.Size = new System.Drawing.Size(102, 31);
            this.btnCamera.TabIndex = 74;
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
            this.pb_ScanQR.Location = new System.Drawing.Point(18, 66);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(407, 303);
            this.pb_ScanQR.TabIndex = 73;
            this.pb_ScanQR.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_BorrowerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(437, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 98);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Location = new System.Drawing.Point(437, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 98);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtAccNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtAccNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtAccNumber.BorderThickness = 1;
            this.txtAccNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAccNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAccNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtAccNumber.isPassword = false;
            this.txtAccNumber.Location = new System.Drawing.Point(148, 31);
            this.txtAccNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(146, 22);
            this.txtAccNumber.TabIndex = 67;
            this.txtAccNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAccNumber.OnValueChanged += new System.EventHandler(this.txtAccNumber_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Borrower ID Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Title :";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtTitle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtTitle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtTitle.BorderThickness = 1;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtTitle.isPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(56, 61);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(238, 22);
            this.txtTitle.TabIndex = 68;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // clsBorrowBindingSource
            // 
            this.clsBorrowBindingSource.DataSource = typeof(QRCodeBasedLMS.clsBorrow);
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
            this.link_GoBack.Location = new System.Drawing.Point(658, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(73, 22);
            this.link_GoBack.TabIndex = 97;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(750, 621);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.pb_ScanQR);
            this.Controls.Add(this.btnBorrows);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.dgvBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Borrow_FormClosing);
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsBorrowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_BorrowerID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Name;
        private Bunifu.Framework.UI.BunifuFlatButton btnScan;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrows;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDropdown cmbDevice;
        private Bunifu.Framework.UI.BunifuFlatButton btnCamera;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.BindingSource clsBorrowBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAccNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTitle;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
    }
}