namespace QRCodeBasedLMS
{
    partial class NonReadingMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonReadingMaterials));
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CopyrightYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.txt_Page = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbBorrowerQR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Issue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaterialIDNumber = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_MatType = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_MaterialIDNumbers = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Volumes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Issues = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_CopyrightYears = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Authors = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Publishers = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Pages = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Searchs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_SearchCategorys = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmb_MatTypes = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_Exits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddOrUpdates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClears = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Accession Number",
            "Call Number",
            "Title",
            "Author",
            "Copyright Year",
            "Status"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(363, 13);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(305, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Search by: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 478);
            this.dataGridView1.TabIndex = 52;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(202, 454);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 41);
            this.btn_Exit.TabIndex = 63;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Copyright Year :";
            // 
            // txt_CopyrightYear
            // 
            this.txt_CopyrightYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CopyrightYear.Location = new System.Drawing.Point(135, 338);
            this.txt_CopyrightYear.Name = "txt_CopyrightYear";
            this.txt_CopyrightYear.Size = new System.Drawing.Size(142, 22);
            this.txt_CopyrightYear.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "Volume :";
            // 
            // txt_Volume
            // 
            this.txt_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Volume.Location = new System.Drawing.Point(88, 282);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(190, 22);
            this.txt_Volume.TabIndex = 54;
            // 
            // txt_Page
            // 
            this.txt_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Page.Location = new System.Drawing.Point(79, 426);
            this.txt_Page.Name = "txt_Page";
            this.txt_Page.Size = new System.Drawing.Size(199, 22);
            this.txt_Page.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Page :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Publisher :";
            // 
            // txt_Author
            // 
            this.txt_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(84, 366);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(193, 22);
            this.txt_Author.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Author :";
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(7, 454);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnAddOrUpdate.TabIndex = 60;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 41);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pbBorrowerQR
            // 
            this.pbBorrowerQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pbBorrowerQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBorrowerQR.Location = new System.Drawing.Point(1, 1);
            this.pbBorrowerQR.Name = "pbBorrowerQR";
            this.pbBorrowerQR.Size = new System.Drawing.Size(130, 130);
            this.pbBorrowerQR.TabIndex = 61;
            this.pbBorrowerQR.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Material ID Number :";
            // 
            // txt_Issue
            // 
            this.txt_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Issue.Location = new System.Drawing.Point(88, 310);
            this.txt_Issue.Name = "txt_Issue";
            this.txt_Issue.Size = new System.Drawing.Size(190, 22);
            this.txt_Issue.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Issue :";
            // 
            // txt_MaterialIDNumber
            // 
            this.txt_MaterialIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaterialIDNumber.Location = new System.Drawing.Point(156, 172);
            this.txt_MaterialIDNumber.Name = "txt_MaterialIDNumber";
            this.txt_MaterialIDNumber.Size = new System.Drawing.Size(122, 22);
            this.txt_MaterialIDNumber.TabIndex = 53;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Publisher.Location = new System.Drawing.Point(100, 396);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(176, 22);
            this.txt_Publisher.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Title :";
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(1, 1);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(205, 45);
            this.txt_Title.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Type :";
            // 
            // cmb_MatType
            // 
            this.cmb_MatType.FormattingEnabled = true;
            this.cmb_MatType.Items.AddRange(new object[] {
            "Journal",
            "Magazine"});
            this.cmb_MatType.Location = new System.Drawing.Point(72, 200);
            this.cmb_MatType.Name = "cmb_MatType";
            this.cmb_MatType.Size = new System.Drawing.Size(205, 21);
            this.cmb_MatType.TabIndex = 75;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(490, 11);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(119, 22);
            this.txt_Search.TabIndex = 50;
            this.txt_Search.Visible = false;
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
            this.panel3.Location = new System.Drawing.Point(88, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 76;
            // 
            // txt_MaterialIDNumbers
            // 
            this.txt_MaterialIDNumbers.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_MaterialIDNumbers.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_MaterialIDNumbers.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_MaterialIDNumbers.BorderThickness = 1;
            this.txt_MaterialIDNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_MaterialIDNumbers.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_MaterialIDNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_MaterialIDNumbers.isPassword = false;
            this.txt_MaterialIDNumbers.Location = new System.Drawing.Point(232, 172);
            this.txt_MaterialIDNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaterialIDNumbers.Name = "txt_MaterialIDNumbers";
            this.txt_MaterialIDNumbers.Size = new System.Drawing.Size(189, 22);
            this.txt_MaterialIDNumbers.TabIndex = 77;
            this.txt_MaterialIDNumbers.Text = "for txt_MaterialIDNumber";
            this.txt_MaterialIDNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txt_Title);
            this.panel1.Location = new System.Drawing.Point(79, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 47);
            this.panel1.TabIndex = 78;
            // 
            // txt_Volumes
            // 
            this.txt_Volumes.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Volumes.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Volumes.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Volumes.BorderThickness = 1;
            this.txt_Volumes.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Volumes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Volumes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Volumes.isPassword = false;
            this.txt_Volumes.Location = new System.Drawing.Point(232, 282);
            this.txt_Volumes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Volumes.Name = "txt_Volumes";
            this.txt_Volumes.Size = new System.Drawing.Size(189, 22);
            this.txt_Volumes.TabIndex = 79;
            this.txt_Volumes.Text = "for txt_Volume";
            this.txt_Volumes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Issues
            // 
            this.txt_Issues.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Issues.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Issues.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Issues.BorderThickness = 1;
            this.txt_Issues.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Issues.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Issues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Issues.isPassword = false;
            this.txt_Issues.Location = new System.Drawing.Point(232, 312);
            this.txt_Issues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Issues.Name = "txt_Issues";
            this.txt_Issues.Size = new System.Drawing.Size(189, 22);
            this.txt_Issues.TabIndex = 80;
            this.txt_Issues.Text = "for txt_Issue";
            this.txt_Issues.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_CopyrightYears
            // 
            this.txt_CopyrightYears.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_CopyrightYears.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_CopyrightYears.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_CopyrightYears.BorderThickness = 1;
            this.txt_CopyrightYears.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_CopyrightYears.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CopyrightYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_CopyrightYears.isPassword = false;
            this.txt_CopyrightYears.Location = new System.Drawing.Point(232, 338);
            this.txt_CopyrightYears.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CopyrightYears.Name = "txt_CopyrightYears";
            this.txt_CopyrightYears.Size = new System.Drawing.Size(189, 22);
            this.txt_CopyrightYears.TabIndex = 81;
            this.txt_CopyrightYears.Text = "for txt_CopyrightYear";
            this.txt_CopyrightYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Authors
            // 
            this.txt_Authors.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Authors.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Authors.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Authors.BorderThickness = 1;
            this.txt_Authors.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Authors.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Authors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Authors.isPassword = false;
            this.txt_Authors.Location = new System.Drawing.Point(232, 368);
            this.txt_Authors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Authors.Name = "txt_Authors";
            this.txt_Authors.Size = new System.Drawing.Size(189, 22);
            this.txt_Authors.TabIndex = 82;
            this.txt_Authors.Text = "for txt_Author";
            this.txt_Authors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Publishers
            // 
            this.txt_Publishers.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Publishers.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Publishers.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Publishers.BorderThickness = 1;
            this.txt_Publishers.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Publishers.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Publishers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Publishers.isPassword = false;
            this.txt_Publishers.Location = new System.Drawing.Point(232, 396);
            this.txt_Publishers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Publishers.Name = "txt_Publishers";
            this.txt_Publishers.Size = new System.Drawing.Size(189, 22);
            this.txt_Publishers.TabIndex = 83;
            this.txt_Publishers.Text = "for txt_Publisher";
            this.txt_Publishers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Pages.Location = new System.Drawing.Point(232, 426);
            this.txt_Pages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pages.Name = "txt_Pages";
            this.txt_Pages.Size = new System.Drawing.Size(189, 22);
            this.txt_Pages.TabIndex = 84;
            this.txt_Pages.Text = "for txt_Page";
            this.txt_Pages.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Searchs.Location = new System.Drawing.Point(616, 7);
            this.txt_Searchs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Searchs.Name = "txt_Searchs";
            this.txt_Searchs.Size = new System.Drawing.Size(189, 22);
            this.txt_Searchs.TabIndex = 85;
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
        "(for cmb_SearchCategory)",
        "QR Code",
        "Accession Number",
        "Call Number",
        "Title",
        "Author",
        "Copyright Year",
        "Status"};
            this.cmb_SearchCategorys.Location = new System.Drawing.Point(363, 41);
            this.cmb_SearchCategorys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategorys.Name = "cmb_SearchCategorys";
            this.cmb_SearchCategorys.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategorys.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategorys.selectedIndex = 0;
            this.cmb_SearchCategorys.Size = new System.Drawing.Size(205, 24);
            this.cmb_SearchCategorys.TabIndex = 86;
            // 
            // cmb_MatTypes
            // 
            this.cmb_MatTypes.BackColor = System.Drawing.Color.Transparent;
            this.cmb_MatTypes.BorderRadius = 3;
            this.cmb_MatTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_MatTypes.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_MatTypes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_MatTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_MatTypes.Items = new string[] {
        "(for cmb_MatType)",
        "Journal",
        "Magazine"};
            this.cmb_MatTypes.Location = new System.Drawing.Point(232, 197);
            this.cmb_MatTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_MatTypes.Name = "cmb_MatTypes";
            this.cmb_MatTypes.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_MatTypes.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_MatTypes.selectedIndex = 0;
            this.cmb_MatTypes.Size = new System.Drawing.Size(205, 24);
            this.cmb_MatTypes.TabIndex = 87;
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
            this.btn_Exits.Location = new System.Drawing.Point(256, 477);
            this.btn_Exits.Name = "btn_Exits";
            this.btn_Exits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Exits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Exits.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Exits.selected = false;
            this.btn_Exits.Size = new System.Drawing.Size(110, 41);
            this.btn_Exits.TabIndex = 90;
            this.btn_Exits.Text = "EXIT";
            this.btn_Exits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exits.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Exits.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btnAddOrUpdates
            // 
            this.btnAddOrUpdates.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddOrUpdates.BorderRadius = 7;
            this.btnAddOrUpdates.ButtonText = "ADD";
            this.btnAddOrUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrUpdates.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddOrUpdates.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddOrUpdates.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddOrUpdates.Iconimage")));
            this.btnAddOrUpdates.Iconimage_right = null;
            this.btnAddOrUpdates.Iconimage_right_Selected = null;
            this.btnAddOrUpdates.Iconimage_Selected = null;
            this.btnAddOrUpdates.IconMarginLeft = 0;
            this.btnAddOrUpdates.IconMarginRight = 0;
            this.btnAddOrUpdates.IconRightVisible = false;
            this.btnAddOrUpdates.IconRightZoom = 0D;
            this.btnAddOrUpdates.IconVisible = true;
            this.btnAddOrUpdates.IconZoom = 80D;
            this.btnAddOrUpdates.IsTab = false;
            this.btnAddOrUpdates.Location = new System.Drawing.Point(24, 477);
            this.btnAddOrUpdates.Name = "btnAddOrUpdates";
            this.btnAddOrUpdates.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdates.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdates.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrUpdates.selected = false;
            this.btnAddOrUpdates.Size = new System.Drawing.Size(110, 41);
            this.btnAddOrUpdates.TabIndex = 88;
            this.btnAddOrUpdates.Text = "ADD";
            this.btnAddOrUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrUpdates.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrUpdates.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btnClears
            // 
            this.btnClears.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnClears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnClears.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClears.BorderRadius = 7;
            this.btnClears.ButtonText = "CLEAR";
            this.btnClears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClears.DisabledColor = System.Drawing.Color.Gray;
            this.btnClears.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClears.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClears.Iconimage")));
            this.btnClears.Iconimage_right = null;
            this.btnClears.Iconimage_right_Selected = null;
            this.btnClears.Iconimage_Selected = null;
            this.btnClears.IconMarginLeft = 0;
            this.btnClears.IconMarginRight = 0;
            this.btnClears.IconRightVisible = false;
            this.btnClears.IconRightZoom = 0D;
            this.btnClears.IconVisible = true;
            this.btnClears.IconZoom = 80D;
            this.btnClears.IsTab = false;
            this.btnClears.Location = new System.Drawing.Point(140, 477);
            this.btnClears.Name = "btnClears";
            this.btnClears.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnClears.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnClears.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClears.selected = false;
            this.btnClears.Size = new System.Drawing.Size(110, 41);
            this.btnClears.TabIndex = 89;
            this.btnClears.Text = "CLEAR";
            this.btnClears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClears.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnClears.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // NonReadingMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(908, 530);
            this.Controls.Add(this.btn_Exits);
            this.Controls.Add(this.btnAddOrUpdates);
            this.Controls.Add(this.btnClears);
            this.Controls.Add(this.cmb_MatTypes);
            this.Controls.Add(this.cmb_SearchCategorys);
            this.Controls.Add(this.txt_Searchs);
            this.Controls.Add(this.txt_Pages);
            this.Controls.Add(this.txt_Publishers);
            this.Controls.Add(this.txt_Authors);
            this.Controls.Add(this.txt_CopyrightYears);
            this.Controls.Add(this.txt_Issues);
            this.Controls.Add(this.txt_Volumes);
            this.Controls.Add(this.txt_MaterialIDNumbers);
            this.Controls.Add(this.cmb_MatType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_CopyrightYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Page);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Issue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MaterialIDNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonReadingMaterials";
            this.Text = "NonReadingMaterials";
            this.Load += new System.EventHandler(this.NonReadingMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CopyrightYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.TextBox txt_Page;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbBorrowerQR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Issue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaterialIDNumber;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_MatType;
        private System.Windows.Forms.TextBox txt_Search;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_MaterialIDNumbers;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Volumes;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Issues;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CopyrightYears;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Authors;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Publishers;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Pages;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Searchs;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategorys;
        private Bunifu.Framework.UI.BunifuDropdown cmb_MatTypes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Exits;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrUpdates;
        private Bunifu.Framework.UI.BunifuFlatButton btnClears;
    }
}