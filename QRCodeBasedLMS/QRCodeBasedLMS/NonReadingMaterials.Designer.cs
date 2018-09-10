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
            this.dgv_NonReadingMaterials = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBorrowerQR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_MaterialIDNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Volume = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Issue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_CopyrightYear = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Author = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Publisher = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Page = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Searchs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_SearchCategorys = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmb_MatType = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddOrUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_NumberOfCopies = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NonReadingMaterials)).BeginInit();
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
            // dgv_NonReadingMaterials
            // 
            this.dgv_NonReadingMaterials.AllowUserToAddRows = false;
            this.dgv_NonReadingMaterials.AllowUserToDeleteRows = false;
            this.dgv_NonReadingMaterials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgv_NonReadingMaterials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_NonReadingMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NonReadingMaterials.Location = new System.Drawing.Point(350, 37);
            this.dgv_NonReadingMaterials.Name = "dgv_NonReadingMaterials";
            this.dgv_NonReadingMaterials.ReadOnly = true;
            this.dgv_NonReadingMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NonReadingMaterials.Size = new System.Drawing.Size(595, 506);
            this.dgv_NonReadingMaterials.TabIndex = 52;
            this.dgv_NonReadingMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NonReadingMaterials_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Copyright Year :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "Volume :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Page :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Publisher :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Author :";
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
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Material ID Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Issue :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Title :";
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Title.Location = new System.Drawing.Point(1, 1);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(187, 45);
            this.txt_Title.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Type :";
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
            this.panel3.Location = new System.Drawing.Point(100, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 76;
            // 
            // txt_MaterialIDNumber
            // 
            this.txt_MaterialIDNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_MaterialIDNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_MaterialIDNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_MaterialIDNumber.BorderThickness = 1;
            this.txt_MaterialIDNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_MaterialIDNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_MaterialIDNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_MaterialIDNumber.isPassword = false;
            this.txt_MaterialIDNumber.Location = new System.Drawing.Point(148, 146);
            this.txt_MaterialIDNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaterialIDNumber.Name = "txt_MaterialIDNumber";
            this.txt_MaterialIDNumber.Size = new System.Drawing.Size(189, 22);
            this.txt_MaterialIDNumber.TabIndex = 77;
            this.txt_MaterialIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txt_Title);
            this.panel1.Location = new System.Drawing.Point(148, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 47);
            this.panel1.TabIndex = 78;
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
            this.txt_Volume.Location = new System.Drawing.Point(148, 262);
            this.txt_Volume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(189, 22);
            this.txt_Volume.TabIndex = 79;
            this.txt_Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Issue
            // 
            this.txt_Issue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Issue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Issue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Issue.BorderThickness = 1;
            this.txt_Issue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Issue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Issue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Issue.isPassword = false;
            this.txt_Issue.Location = new System.Drawing.Point(148, 294);
            this.txt_Issue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Issue.Name = "txt_Issue";
            this.txt_Issue.Size = new System.Drawing.Size(189, 22);
            this.txt_Issue.TabIndex = 80;
            this.txt_Issue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_CopyrightYear.Location = new System.Drawing.Point(148, 326);
            this.txt_CopyrightYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CopyrightYear.Name = "txt_CopyrightYear";
            this.txt_CopyrightYear.Size = new System.Drawing.Size(189, 22);
            this.txt_CopyrightYear.TabIndex = 81;
            this.txt_CopyrightYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Author.Location = new System.Drawing.Point(148, 358);
            this.txt_Author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(189, 22);
            this.txt_Author.TabIndex = 82;
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
            this.txt_Publisher.Location = new System.Drawing.Point(148, 390);
            this.txt_Publisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(189, 22);
            this.txt_Publisher.TabIndex = 83;
            this.txt_Publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Page
            // 
            this.txt_Page.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Page.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Page.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Page.BorderThickness = 1;
            this.txt_Page.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Page.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Page.isPassword = false;
            this.txt_Page.Location = new System.Drawing.Point(148, 422);
            this.txt_Page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Page.Name = "txt_Page";
            this.txt_Page.Size = new System.Drawing.Size(189, 22);
            this.txt_Page.TabIndex = 84;
            this.txt_Page.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.cmb_SearchCategorys.Location = new System.Drawing.Point(363, 7);
            this.cmb_SearchCategorys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategorys.Name = "cmb_SearchCategorys";
            this.cmb_SearchCategorys.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategorys.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategorys.selectedIndex = 0;
            this.cmb_SearchCategorys.Size = new System.Drawing.Size(205, 24);
            this.cmb_SearchCategorys.TabIndex = 86;
            // 
            // cmb_MatType
            // 
            this.cmb_MatType.BackColor = System.Drawing.Color.Transparent;
            this.cmb_MatType.BorderRadius = 3;
            this.cmb_MatType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_MatType.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_MatType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_MatType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_MatType.Items = new string[] {
        "Journal",
        "Magazine"};
            this.cmb_MatType.Location = new System.Drawing.Point(148, 177);
            this.cmb_MatType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_MatType.Name = "cmb_MatType";
            this.cmb_MatType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_MatType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_MatType.selectedIndex = 0;
            this.cmb_MatType.Size = new System.Drawing.Size(189, 24);
            this.cmb_MatType.TabIndex = 87;
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
            this.btn_Exit.Location = new System.Drawing.Point(235, 498);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Exit.selected = false;
            this.btn_Exit.Size = new System.Drawing.Size(101, 45);
            this.btn_Exit.TabIndex = 90;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.btnAddOrUpdate.Location = new System.Drawing.Point(15, 498);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.selected = false;
            this.btnAddOrUpdate.Size = new System.Drawing.Size(101, 45);
            this.btnAddOrUpdate.TabIndex = 88;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 7;
            this.btnClear.ButtonText = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClear.Iconimage")));
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = false;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 80D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(126, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(101, 45);
            this.btnClear.TabIndex = 89;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txt_NumberOfCopies
            // 
            this.txt_NumberOfCopies.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_NumberOfCopies.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_NumberOfCopies.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_NumberOfCopies.BorderThickness = 1;
            this.txt_NumberOfCopies.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_NumberOfCopies.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NumberOfCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_NumberOfCopies.isPassword = false;
            this.txt_NumberOfCopies.Location = new System.Drawing.Point(148, 454);
            this.txt_NumberOfCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NumberOfCopies.Name = "txt_NumberOfCopies";
            this.txt_NumberOfCopies.Size = new System.Drawing.Size(189, 22);
            this.txt_NumberOfCopies.TabIndex = 92;
            this.txt_NumberOfCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 91;
            this.label8.Text = "Number of Copies :";
            // 
            // NonReadingMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(957, 556);
            this.Controls.Add(this.txt_NumberOfCopies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmb_MatType);
            this.Controls.Add(this.cmb_SearchCategorys);
            this.Controls.Add(this.txt_Searchs);
            this.Controls.Add(this.txt_Page);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_CopyrightYear);
            this.Controls.Add(this.txt_Issue);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.txt_MaterialIDNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_NonReadingMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonReadingMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NonReadingMaterials";
            this.Load += new System.EventHandler(this.NonReadingMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NonReadingMaterials)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_NonReadingMaterials;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBorrowerQR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Search;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_MaterialIDNumber;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Volume;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Issue;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CopyrightYear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Author;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Publisher;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Page;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Searchs;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategorys;
        private Bunifu.Framework.UI.BunifuDropdown cmb_MatType;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Exit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_NumberOfCopies;
        private System.Windows.Forms.Label label8;
    }
}