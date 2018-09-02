namespace QRCodeBasedLMS
{
    partial class UnapprovedAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnapprovedAccounts));
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UserIDNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.pbUserQR = new System.Windows.Forms.PictureBox();
            this.Link_ScanQR = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.brnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Lastnames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstnames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_UserIDNums = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_Statuss = new Bunifu.Framework.UI.BunifuDropdown();
            this.Link_ScanQRs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_SearchCategorys = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Searchs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSaves = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brnClears = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 117;
            this.label9.Text = "User ID Number :";
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.Enabled = false;
            this.txt_UserIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserIDNum.Location = new System.Drawing.Point(126, 163);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(106, 22);
            this.txt_UserIDNum.TabIndex = 106;
            this.txt_UserIDNum.TextChanged += new System.EventHandler(this.txt_UserIDNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Lastname :";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Enabled = false;
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(93, 219);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(140, 22);
            this.txt_Lastname.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Firstname :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Enabled = false;
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(93, 191);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(140, 22);
            this.txt_Firstname.TabIndex = 107;
            // 
            // pbUserQR
            // 
            this.pbUserQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pbUserQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserQR.Location = new System.Drawing.Point(1, 1);
            this.pbUserQR.Name = "pbUserQR";
            this.pbUserQR.Size = new System.Drawing.Size(130, 130);
            this.pbUserQR.TabIndex = 114;
            this.pbUserQR.TabStop = false;
            // 
            // Link_ScanQR
            // 
            this.Link_ScanQR.AutoSize = true;
            this.Link_ScanQR.Location = new System.Drawing.Point(478, 15);
            this.Link_ScanQR.Name = "Link_ScanQR";
            this.Link_ScanQR.Size = new System.Drawing.Size(79, 13);
            this.Link_ScanQR.TabIndex = 110;
            this.Link_ScanQR.TabStop = true;
            this.Link_ScanQR.Text = "Scan QR Code";
            this.Link_ScanQR.Visible = false;
            this.Link_ScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ScanQR_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(478, 8);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 22);
            this.txt_Search.TabIndex = 111;
            this.txt_Search.Visible = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Lastname",
            "Firstname"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(351, 8);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 109;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 113;
            this.label15.Text = "Search by :";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.Location = new System.Drawing.Point(291, 41);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(404, 299);
            this.dgvAccount.TabIndex = 112;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Status :";
            // 
            // cmb_Status
            // 
            this.cmb_Status.Enabled = false;
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Deactivate"});
            this.cmb_Status.Location = new System.Drawing.Point(71, 247);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(162, 24);
            this.cmb_Status.TabIndex = 119;
            // 
            // brnClear
            // 
            this.brnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClear.Location = new System.Drawing.Point(129, 291);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(75, 40);
            this.brnClear.TabIndex = 121;
            this.brnClear.Text = "CLEAR";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(210, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 122;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(45, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 120;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_Lastnames
            // 
            this.txt_Lastnames.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastnames.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Lastnames.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastnames.BorderThickness = 1;
            this.txt_Lastnames.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Lastnames.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Lastnames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Lastnames.isPassword = false;
            this.txt_Lastnames.Location = new System.Drawing.Point(210, 219);
            this.txt_Lastnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastnames.Name = "txt_Lastnames";
            this.txt_Lastnames.Size = new System.Drawing.Size(159, 22);
            this.txt_Lastnames.TabIndex = 125;
            this.txt_Lastnames.Text = "for txt_Lastname";
            this.txt_Lastnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Firstnames
            // 
            this.txt_Firstnames.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstnames.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Firstnames.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstnames.BorderThickness = 1;
            this.txt_Firstnames.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Firstnames.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Firstnames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Firstnames.isPassword = false;
            this.txt_Firstnames.Location = new System.Drawing.Point(210, 191);
            this.txt_Firstnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstnames.Name = "txt_Firstnames";
            this.txt_Firstnames.Size = new System.Drawing.Size(159, 22);
            this.txt_Firstnames.TabIndex = 124;
            this.txt_Firstnames.Text = "for txt_Firstname";
            this.txt_Firstnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_UserIDNums
            // 
            this.txt_UserIDNums.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNums.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_UserIDNums.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNums.BorderThickness = 1;
            this.txt_UserIDNums.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_UserIDNums.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_UserIDNums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_UserIDNums.isPassword = false;
            this.txt_UserIDNums.Location = new System.Drawing.Point(210, 163);
            this.txt_UserIDNums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserIDNums.Name = "txt_UserIDNums";
            this.txt_UserIDNums.Size = new System.Drawing.Size(159, 22);
            this.txt_UserIDNums.TabIndex = 123;
            this.txt_UserIDNums.Text = "for txt_UserIDNum";
            this.txt_UserIDNums.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmb_Statuss
            // 
            this.cmb_Statuss.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Statuss.BorderRadius = 3;
            this.cmb_Statuss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_Statuss.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_Statuss.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_Statuss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_Statuss.Items = new string[] {
        "for cmb_Status",
        "Active",
        "Inactive",
        "Deactivate"};
            this.cmb_Statuss.Location = new System.Drawing.Point(210, 247);
            this.cmb_Statuss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Statuss.Name = "cmb_Statuss";
            this.cmb_Statuss.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_Statuss.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_Statuss.selectedIndex = 0;
            this.cmb_Statuss.Size = new System.Drawing.Size(159, 24);
            this.cmb_Statuss.TabIndex = 126;
            // 
            // Link_ScanQRs
            // 
            this.Link_ScanQRs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.Link_ScanQRs.BackColor = System.Drawing.Color.Transparent;
            this.Link_ScanQRs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Link_ScanQRs.BorderRadius = 7;
            this.Link_ScanQRs.ButtonText = "Change \"Scan QR Code\"";
            this.Link_ScanQRs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_ScanQRs.DisabledColor = System.Drawing.Color.Gray;
            this.Link_ScanQRs.Iconcolor = System.Drawing.Color.Transparent;
            this.Link_ScanQRs.Iconimage = ((System.Drawing.Image)(resources.GetObject("Link_ScanQRs.Iconimage")));
            this.Link_ScanQRs.Iconimage_right = null;
            this.Link_ScanQRs.Iconimage_right_Selected = null;
            this.Link_ScanQRs.Iconimage_Selected = null;
            this.Link_ScanQRs.IconMarginLeft = 0;
            this.Link_ScanQRs.IconMarginRight = 0;
            this.Link_ScanQRs.IconRightVisible = false;
            this.Link_ScanQRs.IconRightZoom = 0D;
            this.Link_ScanQRs.IconVisible = false;
            this.Link_ScanQRs.IconZoom = 110D;
            this.Link_ScanQRs.IsTab = false;
            this.Link_ScanQRs.Location = new System.Drawing.Point(519, 41);
            this.Link_ScanQRs.Name = "Link_ScanQRs";
            this.Link_ScanQRs.Normalcolor = System.Drawing.Color.Transparent;
            this.Link_ScanQRs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.Link_ScanQRs.OnHoverTextColor = System.Drawing.Color.White;
            this.Link_ScanQRs.selected = false;
            this.Link_ScanQRs.Size = new System.Drawing.Size(176, 22);
            this.Link_ScanQRs.TabIndex = 129;
            this.Link_ScanQRs.Text = "Change \"Scan QR Code\"";
            this.Link_ScanQRs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Link_ScanQRs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.Link_ScanQRs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            // 
            // cmb_SearchCategorys
            // 
            this.cmb_SearchCategorys.BackColor = System.Drawing.Color.Transparent;
            this.cmb_SearchCategorys.BorderRadius = 3;
            this.cmb_SearchCategorys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_SearchCategorys.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_SearchCategorys.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_SearchCategorys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_SearchCategorys.Items = new string[] {
        "for cmb_SearchCategory",
        "QR Code",
        "Lastname",
        "Firstname"};
            this.cmb_SearchCategorys.Location = new System.Drawing.Point(261, 33);
            this.cmb_SearchCategorys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategorys.Name = "cmb_SearchCategorys";
            this.cmb_SearchCategorys.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategorys.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategorys.selectedIndex = 0;
            this.cmb_SearchCategorys.Size = new System.Drawing.Size(211, 21);
            this.cmb_SearchCategorys.TabIndex = 127;
            // 
            // txt_Searchs
            // 
            this.txt_Searchs.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Searchs.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Searchs.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Searchs.BorderThickness = 1;
            this.txt_Searchs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Searchs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Searchs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Searchs.isPassword = false;
            this.txt_Searchs.Location = new System.Drawing.Point(576, 17);
            this.txt_Searchs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Searchs.Name = "txt_Searchs";
            this.txt_Searchs.Size = new System.Drawing.Size(119, 22);
            this.txt_Searchs.TabIndex = 128;
            this.txt_Searchs.Text = "for txt_Search";
            this.txt_Searchs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSaves
            // 
            this.btnSaves.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnSaves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaves.BorderRadius = 7;
            this.btnSaves.ButtonText = "SAVE";
            this.btnSaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaves.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaves.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaves.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaves.Iconimage")));
            this.btnSaves.Iconimage_right = null;
            this.btnSaves.Iconimage_right_Selected = null;
            this.btnSaves.Iconimage_Selected = null;
            this.btnSaves.IconMarginLeft = 0;
            this.btnSaves.IconMarginRight = 0;
            this.btnSaves.IconRightVisible = false;
            this.btnSaves.IconRightZoom = 0D;
            this.btnSaves.IconVisible = true;
            this.btnSaves.IconZoom = 80D;
            this.btnSaves.IsTab = false;
            this.btnSaves.Location = new System.Drawing.Point(300, 289);
            this.btnSaves.Name = "btnSaves";
            this.btnSaves.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnSaves.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnSaves.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaves.selected = false;
            this.btnSaves.Size = new System.Drawing.Size(110, 41);
            this.btnSaves.TabIndex = 130;
            this.btnSaves.Text = "SAVE";
            this.btnSaves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaves.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnSaves.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // brnClears
            // 
            this.brnClears.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.brnClears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.brnClears.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnClears.BorderRadius = 7;
            this.brnClears.ButtonText = "CLEAR";
            this.brnClears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnClears.DisabledColor = System.Drawing.Color.Gray;
            this.brnClears.Iconcolor = System.Drawing.Color.Transparent;
            this.brnClears.Iconimage = ((System.Drawing.Image)(resources.GetObject("brnClears.Iconimage")));
            this.brnClears.Iconimage_right = null;
            this.brnClears.Iconimage_right_Selected = null;
            this.brnClears.Iconimage_Selected = null;
            this.brnClears.IconMarginLeft = 0;
            this.brnClears.IconMarginRight = 0;
            this.brnClears.IconRightVisible = false;
            this.brnClears.IconRightZoom = 0D;
            this.brnClears.IconVisible = true;
            this.brnClears.IconZoom = 80D;
            this.brnClears.IsTab = false;
            this.brnClears.Location = new System.Drawing.Point(416, 289);
            this.brnClears.Name = "brnClears";
            this.brnClears.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.brnClears.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.brnClears.OnHoverTextColor = System.Drawing.Color.White;
            this.brnClears.selected = false;
            this.brnClears.Size = new System.Drawing.Size(110, 41);
            this.brnClears.TabIndex = 131;
            this.brnClears.Text = "CLEAR";
            this.brnClears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnClears.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.brnClears.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btnExits
            // 
            this.btnExits.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExits.BorderRadius = 7;
            this.btnExits.ButtonText = "EXIT";
            this.btnExits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExits.DisabledColor = System.Drawing.Color.Gray;
            this.btnExits.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExits.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExits.Iconimage")));
            this.btnExits.Iconimage_right = null;
            this.btnExits.Iconimage_right_Selected = null;
            this.btnExits.Iconimage_Selected = null;
            this.btnExits.IconMarginLeft = 0;
            this.btnExits.IconMarginRight = 0;
            this.btnExits.IconRightVisible = false;
            this.btnExits.IconRightZoom = 0D;
            this.btnExits.IconVisible = true;
            this.btnExits.IconZoom = 80D;
            this.btnExits.IsTab = false;
            this.btnExits.Location = new System.Drawing.Point(532, 289);
            this.btnExits.Name = "btnExits";
            this.btnExits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExits.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExits.selected = false;
            this.btnExits.Size = new System.Drawing.Size(110, 41);
            this.btnExits.TabIndex = 132;
            this.btnExits.Text = "EXIT";
            this.btnExits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExits.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnExits.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pbUserQR);
            this.panel3.Location = new System.Drawing.Point(93, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 133;
            // 
            // UnapprovedAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(707, 352);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnSaves);
            this.Controls.Add(this.brnClears);
            this.Controls.Add(this.Link_ScanQRs);
            this.Controls.Add(this.cmb_SearchCategorys);
            this.Controls.Add(this.txt_Searchs);
            this.Controls.Add(this.cmb_Statuss);
            this.Controls.Add(this.txt_Lastnames);
            this.Controls.Add(this.txt_Firstnames);
            this.Controls.Add(this.txt_UserIDNums);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.Link_ScanQR);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnapprovedAccounts";
            this.Text = "UnapprovedAccounts";
            this.Load += new System.EventHandler(this.UnapprovedAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UserIDNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.PictureBox pbUserQR;
        private System.Windows.Forms.LinkLabel Link_ScanQR;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastnames;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstnames;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_UserIDNums;
        private Bunifu.Framework.UI.BunifuDropdown cmb_Statuss;
        private Bunifu.Framework.UI.BunifuFlatButton Link_ScanQRs;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategorys;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Searchs;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaves;
        private Bunifu.Framework.UI.BunifuFlatButton brnClears;
        private Bunifu.Framework.UI.BunifuFlatButton btnExits;
        private System.Windows.Forms.Panel panel3;
    }
}