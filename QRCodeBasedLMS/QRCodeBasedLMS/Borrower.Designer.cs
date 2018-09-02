namespace QRCodeBasedLMS
{
    partial class Borrower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrower));
            this.pbBorrowerQR = new System.Windows.Forms.PictureBox();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateorSave = new System.Windows.Forms.Button();
            this.dgvBorrower = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ContactNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SchoolIDNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.Link_Scan = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.link_ScanBrwr = new System.Windows.Forms.LinkLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_SchoolIDNumbers = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstnames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Lastnames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ContactNums = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Searchs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_SearchCategorys = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnUpdateorSaves = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Exits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_Scans = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_ScanBrwrs = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBorrowerQR
            // 
            this.pbBorrowerQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pbBorrowerQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBorrowerQR.Location = new System.Drawing.Point(1, 1);
            this.pbBorrowerQR.Name = "pbBorrowerQR";
            this.pbBorrowerQR.Size = new System.Drawing.Size(130, 130);
            this.pbBorrowerQR.TabIndex = 11;
            this.pbBorrowerQR.TabStop = false;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Enabled = false;
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(101, 257);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(190, 22);
            this.txt_Firstname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firstname :";
            // 
            // btnUpdateorSave
            // 
            this.btnUpdateorSave.Location = new System.Drawing.Point(105, 460);
            this.btnUpdateorSave.Name = "btnUpdateorSave";
            this.btnUpdateorSave.Size = new System.Drawing.Size(93, 41);
            this.btnUpdateorSave.TabIndex = 10;
            this.btnUpdateorSave.Text = "UPDATE";
            this.btnUpdateorSave.UseVisualStyleBackColor = true;
            this.btnUpdateorSave.Click += new System.EventHandler(this.btnUpdateorSave_Click);
            // 
            // dgvBorrower
            // 
            this.dgvBorrower.AllowUserToAddRows = false;
            this.dgvBorrower.AllowUserToDeleteRows = false;
            this.dgvBorrower.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBorrower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrower.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrower.Location = new System.Drawing.Point(331, 48);
            this.dgvBorrower.MultiSelect = false;
            this.dgvBorrower.Name = "dgvBorrower";
            this.dgvBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrower.Size = new System.Drawing.Size(584, 200);
            this.dgvBorrower.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gender :";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_Address.Enabled = false;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(1, 1);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(192, 59);
            this.txt_Address.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address :";
            // 
            // txt_ContactNum
            // 
            this.txt_ContactNum.Enabled = false;
            this.txt_ContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContactNum.Location = new System.Drawing.Point(144, 421);
            this.txt_ContactNum.Name = "txt_ContactNum";
            this.txt_ContactNum.Size = new System.Drawing.Size(147, 22);
            this.txt_ContactNum.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Contact Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Search by :";
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "Book QR Code",
            "Title",
            "School Year"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(390, 23);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 13;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "School ID :";
            // 
            // txt_SchoolIDNumber
            // 
            this.txt_SchoolIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchoolIDNumber.Location = new System.Drawing.Point(101, 229);
            this.txt_SchoolIDNumber.Name = "txt_SchoolIDNumber";
            this.txt_SchoolIDNumber.Size = new System.Drawing.Size(190, 22);
            this.txt_SchoolIDNumber.TabIndex = 2;
            this.txt_SchoolIDNumber.TextChanged += new System.EventHandler(this.txt_SchoolIDNumber_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Lastname :";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Enabled = false;
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(101, 285);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(190, 22);
            this.txt_Lastname.TabIndex = 4;
            // 
            // Link_Scan
            // 
            this.Link_Scan.AutoSize = true;
            this.Link_Scan.Location = new System.Drawing.Point(533, 28);
            this.Link_Scan.Name = "Link_Scan";
            this.Link_Scan.Size = new System.Drawing.Size(107, 13);
            this.Link_Scan.TabIndex = 14;
            this.Link_Scan.TabStop = true;
            this.Link_Scan.Text = "Scan Book QR Code";
            this.Link_Scan.Visible = false;
            this.Link_Scan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Scan_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(517, 23);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 22);
            this.txt_Search.TabIndex = 15;
            this.txt_Search.Visible = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(204, 460);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 41);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Female);
            this.groupBox2.Controls.Add(this.rb_Male);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(99, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 36);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(90, 12);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(72, 20);
            this.rb_Female.TabIndex = 7;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(17, 12);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(56, 20);
            this.rb_Male.TabIndex = 6;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(331, 295);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 206);
            this.dataGridView1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "CURRENTLY BORROWED BOOKS";
            // 
            // link_ScanBrwr
            // 
            this.link_ScanBrwr.AutoSize = true;
            this.link_ScanBrwr.Location = new System.Drawing.Point(90, 202);
            this.link_ScanBrwr.Name = "link_ScanBrwr";
            this.link_ScanBrwr.Size = new System.Drawing.Size(124, 13);
            this.link_ScanBrwr.TabIndex = 55;
            this.link_ScanBrwr.TabStop = true;
            this.link_ScanBrwr.Text = "Scan Borrower QR Code";
            this.link_ScanBrwr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ScanBrwr_LinkClicked);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pbBorrowerQR);
            this.panel3.Location = new System.Drawing.Point(86, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 66;
            // 
            // txt_SchoolIDNumbers
            // 
            this.txt_SchoolIDNumbers.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolIDNumbers.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SchoolIDNumbers.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolIDNumbers.BorderThickness = 1;
            this.txt_SchoolIDNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SchoolIDNumbers.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchoolIDNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SchoolIDNumbers.isPassword = false;
            this.txt_SchoolIDNumbers.Location = new System.Drawing.Point(155, 229);
            this.txt_SchoolIDNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SchoolIDNumbers.Name = "txt_SchoolIDNumbers";
            this.txt_SchoolIDNumbers.Size = new System.Drawing.Size(189, 22);
            this.txt_SchoolIDNumbers.TabIndex = 67;
            this.txt_SchoolIDNumbers.Text = "for txt_SchoolIDNumber";
            this.txt_SchoolIDNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Firstnames
            // 
            this.txt_Firstnames.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstnames.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Firstnames.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstnames.BorderThickness = 1;
            this.txt_Firstnames.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Firstnames.Enabled = false;
            this.txt_Firstnames.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Firstnames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Firstnames.isPassword = false;
            this.txt_Firstnames.Location = new System.Drawing.Point(155, 259);
            this.txt_Firstnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstnames.Name = "txt_Firstnames";
            this.txt_Firstnames.Size = new System.Drawing.Size(189, 22);
            this.txt_Firstnames.TabIndex = 68;
            this.txt_Firstnames.Text = "for txt_Firstname";
            this.txt_Firstnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Lastnames
            // 
            this.txt_Lastnames.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastnames.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Lastnames.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastnames.BorderThickness = 1;
            this.txt_Lastnames.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Lastnames.Enabled = false;
            this.txt_Lastnames.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Lastnames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Lastnames.isPassword = false;
            this.txt_Lastnames.Location = new System.Drawing.Point(155, 287);
            this.txt_Lastnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastnames.Name = "txt_Lastnames";
            this.txt_Lastnames.Size = new System.Drawing.Size(189, 22);
            this.txt_Lastnames.TabIndex = 69;
            this.txt_Lastnames.Text = "for txt_Lastname";
            this.txt_Lastnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Location = new System.Drawing.Point(101, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 61);
            this.panel1.TabIndex = 70;
            // 
            // txt_ContactNums
            // 
            this.txt_ContactNums.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ContactNums.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_ContactNums.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ContactNums.BorderThickness = 1;
            this.txt_ContactNums.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ContactNums.Enabled = false;
            this.txt_ContactNums.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ContactNums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_ContactNums.isPassword = false;
            this.txt_ContactNums.Location = new System.Drawing.Point(189, 421);
            this.txt_ContactNums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ContactNums.Name = "txt_ContactNums";
            this.txt_ContactNums.Size = new System.Drawing.Size(189, 22);
            this.txt_ContactNums.TabIndex = 71;
            this.txt_ContactNums.Text = "for txt_ContactNum";
            this.txt_ContactNums.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Searchs.Location = new System.Drawing.Point(660, 14);
            this.txt_Searchs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Searchs.Name = "txt_Searchs";
            this.txt_Searchs.Size = new System.Drawing.Size(189, 22);
            this.txt_Searchs.TabIndex = 72;
            this.txt_Searchs.Text = "for txt_Search";
            this.txt_Searchs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
        "for cmb_SearchCategory (DELETE ME)",
        "Book QR Code",
        "Title",
        "School Year"};
            this.cmb_SearchCategorys.Location = new System.Drawing.Point(369, 57);
            this.cmb_SearchCategorys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategorys.Name = "cmb_SearchCategorys";
            this.cmb_SearchCategorys.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategorys.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategorys.selectedIndex = 0;
            this.cmb_SearchCategorys.Size = new System.Drawing.Size(296, 24);
            this.cmb_SearchCategorys.TabIndex = 73;
            // 
            // btnUpdateorSaves
            // 
            this.btnUpdateorSaves.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdateorSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdateorSaves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateorSaves.BorderRadius = 7;
            this.btnUpdateorSaves.ButtonText = "UPDATE";
            this.btnUpdateorSaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateorSaves.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateorSaves.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateorSaves.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateorSaves.Iconimage")));
            this.btnUpdateorSaves.Iconimage_right = null;
            this.btnUpdateorSaves.Iconimage_right_Selected = null;
            this.btnUpdateorSaves.Iconimage_Selected = null;
            this.btnUpdateorSaves.IconMarginLeft = 0;
            this.btnUpdateorSaves.IconMarginRight = 0;
            this.btnUpdateorSaves.IconRightVisible = false;
            this.btnUpdateorSaves.IconRightZoom = 0D;
            this.btnUpdateorSaves.IconVisible = true;
            this.btnUpdateorSaves.IconZoom = 80D;
            this.btnUpdateorSaves.IsTab = false;
            this.btnUpdateorSaves.Location = new System.Drawing.Point(15, 460);
            this.btnUpdateorSaves.Name = "btnUpdateorSaves";
            this.btnUpdateorSaves.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdateorSaves.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdateorSaves.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateorSaves.selected = false;
            this.btnUpdateorSaves.Size = new System.Drawing.Size(110, 41);
            this.btnUpdateorSaves.TabIndex = 74;
            this.btnUpdateorSaves.Text = "UPDATE";
            this.btnUpdateorSaves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateorSaves.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnUpdateorSaves.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btn_Exits
            // 
            this.btn_Exits.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Exits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Exits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exits.BorderRadius = 7;
            this.btn_Exits.ButtonText = "EXIT";
            this.btn_Exits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exits.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Exits.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Exits.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Exits.Iconimage")));
            this.btn_Exits.Iconimage_right = null;
            this.btn_Exits.Iconimage_right_Selected = null;
            this.btn_Exits.Iconimage_Selected = null;
            this.btn_Exits.IconMarginLeft = 0;
            this.btn_Exits.IconMarginRight = 0;
            this.btn_Exits.IconRightVisible = false;
            this.btn_Exits.IconRightZoom = 0D;
            this.btn_Exits.IconVisible = true;
            this.btn_Exits.IconZoom = 80D;
            this.btn_Exits.IsTab = false;
            this.btn_Exits.Location = new System.Drawing.Point(268, 460);
            this.btn_Exits.Name = "btn_Exits";
            this.btn_Exits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Exits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Exits.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Exits.selected = false;
            this.btn_Exits.Size = new System.Drawing.Size(110, 41);
            this.btn_Exits.TabIndex = 75;
            this.btn_Exits.Text = "EXIT";
            this.btn_Exits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exits.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Exits.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // link_Scans
            // 
            this.link_Scans.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_Scans.BackColor = System.Drawing.Color.Transparent;
            this.link_Scans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_Scans.BorderRadius = 7;
            this.link_Scans.ButtonText = "Scan Book QR Code";
            this.link_Scans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_Scans.DisabledColor = System.Drawing.Color.Gray;
            this.link_Scans.Iconcolor = System.Drawing.Color.Transparent;
            this.link_Scans.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_Scans.Iconimage")));
            this.link_Scans.Iconimage_right = null;
            this.link_Scans.Iconimage_right_Selected = null;
            this.link_Scans.Iconimage_Selected = null;
            this.link_Scans.IconMarginLeft = 0;
            this.link_Scans.IconMarginRight = 0;
            this.link_Scans.IconRightVisible = false;
            this.link_Scans.IconRightZoom = 0D;
            this.link_Scans.IconVisible = false;
            this.link_Scans.IconZoom = 110D;
            this.link_Scans.IsTab = false;
            this.link_Scans.Location = new System.Drawing.Point(660, 32);
            this.link_Scans.Name = "link_Scans";
            this.link_Scans.Normalcolor = System.Drawing.Color.Transparent;
            this.link_Scans.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_Scans.OnHoverTextColor = System.Drawing.Color.White;
            this.link_Scans.selected = false;
            this.link_Scans.Size = new System.Drawing.Size(176, 22);
            this.link_Scans.TabIndex = 76;
            this.link_Scans.Text = "Scan Book QR Code";
            this.link_Scans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_Scans.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_Scans.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            // 
            // link_ScanBrwrs
            // 
            this.link_ScanBrwrs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanBrwrs.BackColor = System.Drawing.Color.Transparent;
            this.link_ScanBrwrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_ScanBrwrs.BorderRadius = 7;
            this.link_ScanBrwrs.ButtonText = "Scan Borrower QR Code";
            this.link_ScanBrwrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ScanBrwrs.DisabledColor = System.Drawing.Color.Gray;
            this.link_ScanBrwrs.Iconcolor = System.Drawing.Color.Transparent;
            this.link_ScanBrwrs.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_ScanBrwrs.Iconimage")));
            this.link_ScanBrwrs.Iconimage_right = null;
            this.link_ScanBrwrs.Iconimage_right_Selected = null;
            this.link_ScanBrwrs.Iconimage_Selected = null;
            this.link_ScanBrwrs.IconMarginLeft = 0;
            this.link_ScanBrwrs.IconMarginRight = 0;
            this.link_ScanBrwrs.IconRightVisible = false;
            this.link_ScanBrwrs.IconRightZoom = 0D;
            this.link_ScanBrwrs.IconVisible = false;
            this.link_ScanBrwrs.IconZoom = 110D;
            this.link_ScanBrwrs.IsTab = false;
            this.link_ScanBrwrs.Location = new System.Drawing.Point(70, 177);
            this.link_ScanBrwrs.Name = "link_ScanBrwrs";
            this.link_ScanBrwrs.Normalcolor = System.Drawing.Color.Transparent;
            this.link_ScanBrwrs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanBrwrs.OnHoverTextColor = System.Drawing.Color.White;
            this.link_ScanBrwrs.selected = false;
            this.link_ScanBrwrs.Size = new System.Drawing.Size(176, 22);
            this.link_ScanBrwrs.TabIndex = 77;
            this.link_ScanBrwrs.Text = "Scan Borrower QR Code";
            this.link_ScanBrwrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ScanBrwrs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_ScanBrwrs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(923, 518);
            this.Controls.Add(this.link_ScanBrwrs);
            this.Controls.Add(this.link_Scans);
            this.Controls.Add(this.btn_Exits);
            this.Controls.Add(this.btnUpdateorSaves);
            this.Controls.Add(this.cmb_SearchCategorys);
            this.Controls.Add(this.txt_Searchs);
            this.Controls.Add(this.txt_ContactNums);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Lastnames);
            this.Controls.Add(this.txt_Firstnames);
            this.Controls.Add(this.txt_SchoolIDNumbers);
            this.Controls.Add(this.link_ScanBrwr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Link_Scan);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SchoolIDNumber);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ContactNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateorSave);
            this.Controls.Add(this.dgvBorrower);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrower";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBorrowerQR;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateorSave;
        private System.Windows.Forms.DataGridView dgvBorrower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ContactNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SchoolIDNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.LinkLabel Link_Scan;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_ScanBrwr;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SchoolIDNumbers;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstnames;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastnames;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ContactNums;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Searchs;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategorys;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateorSaves;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Exits;
        private Bunifu.Framework.UI.BunifuFlatButton link_Scans;
        private Bunifu.Framework.UI.BunifuFlatButton link_ScanBrwrs;
    }
}