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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_SchoolID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Lastname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ContactNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintLibCard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbSchoolYear = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.cmbLibraryUser = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.link_ScanQr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_SearchCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Penalty = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firstname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Contact Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "School ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Lastname :";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Enabled = false;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(331, 245);
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
            this.rb_Male.Enabled = false;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(258, 245);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(56, 20);
            this.rb_Male.TabIndex = 6;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.AllowUserToAddRows = false;
            this.dgvBorrowers.AllowUserToDeleteRows = false;
            this.dgvBorrowers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrowers.Location = new System.Drawing.Point(24, 337);
            this.dgvBorrowers.MultiSelect = false;
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.ReadOnly = true;
            this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowers.Size = new System.Drawing.Size(690, 207);
            this.dgvBorrowers.TabIndex = 53;
            this.dgvBorrowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowers_CellClick);
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
            this.panel3.Location = new System.Drawing.Point(22, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 66;
            // 
            // txt_SchoolID
            // 
            this.txt_SchoolID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SchoolID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolID.BorderThickness = 1;
            this.txt_SchoolID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SchoolID.Enabled = false;
            this.txt_SchoolID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchoolID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SchoolID.isPassword = false;
            this.txt_SchoolID.Location = new System.Drawing.Point(255, 148);
            this.txt_SchoolID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SchoolID.Name = "txt_SchoolID";
            this.txt_SchoolID.Size = new System.Drawing.Size(176, 22);
            this.txt_SchoolID.TabIndex = 67;
            this.txt_SchoolID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SchoolID.OnValueChanged += new System.EventHandler(this.txt_SchoolID_OnValueChanged);
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Firstname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstname.BorderThickness = 1;
            this.txt_Firstname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Firstname.isPassword = false;
            this.txt_Firstname.Location = new System.Drawing.Point(255, 178);
            this.txt_Firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(176, 22);
            this.txt_Firstname.TabIndex = 68;
            this.txt_Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Lastname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastname.BorderThickness = 1;
            this.txt_Lastname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Lastname.isPassword = false;
            this.txt_Lastname.Location = new System.Drawing.Point(255, 206);
            this.txt_Lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(176, 22);
            this.txt_Lastname.TabIndex = 69;
            this.txt_Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ContactNum
            // 
            this.txt_ContactNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ContactNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_ContactNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ContactNum.BorderThickness = 1;
            this.txt_ContactNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ContactNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ContactNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_ContactNum.isPassword = false;
            this.txt_ContactNum.Location = new System.Drawing.Point(552, 178);
            this.txt_ContactNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ContactNum.Name = "txt_ContactNum";
            this.txt_ContactNum.Size = new System.Drawing.Size(147, 22);
            this.txt_ContactNum.TabIndex = 71;
            this.txt_ContactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 7;
            this.btnUpdate.ButtonText = "UPDATE INFORMATION";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Enabled = false;
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
            this.btnUpdate.Location = new System.Drawing.Point(586, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(128, 41);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "UPDATE INFORMATION";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.link_GoBack.Location = new System.Drawing.Point(651, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(73, 22);
            this.link_GoBack.TabIndex = 78;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // btnPrintLibCard
            // 
            this.btnPrintLibCard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnPrintLibCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnPrintLibCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintLibCard.BorderRadius = 7;
            this.btnPrintLibCard.ButtonText = "PRINT LIBRARY CARD";
            this.btnPrintLibCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintLibCard.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintLibCard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintLibCard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintLibCard.Iconimage")));
            this.btnPrintLibCard.Iconimage_right = null;
            this.btnPrintLibCard.Iconimage_right_Selected = null;
            this.btnPrintLibCard.Iconimage_Selected = null;
            this.btnPrintLibCard.IconMarginLeft = 0;
            this.btnPrintLibCard.IconMarginRight = 0;
            this.btnPrintLibCard.IconRightVisible = false;
            this.btnPrintLibCard.IconRightZoom = 0D;
            this.btnPrintLibCard.IconVisible = true;
            this.btnPrintLibCard.IconZoom = 80D;
            this.btnPrintLibCard.IsTab = false;
            this.btnPrintLibCard.Location = new System.Drawing.Point(452, 285);
            this.btnPrintLibCard.Name = "btnPrintLibCard";
            this.btnPrintLibCard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnPrintLibCard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnPrintLibCard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintLibCard.selected = false;
            this.btnPrintLibCard.Size = new System.Drawing.Size(128, 41);
            this.btnPrintLibCard.TabIndex = 79;
            this.btnPrintLibCard.Text = "PRINT LIBRARY CARD";
            this.btnPrintLibCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintLibCard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnPrintLibCard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrintLibCard.Click += new System.EventHandler(this.btnPrintLibCard_Click);
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.BackColor = System.Drawing.Color.Transparent;
            this.cmbSchoolYear.BorderRadius = 3;
            this.cmbSchoolYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbSchoolYear.DisabledColor = System.Drawing.Color.Gray;
            this.cmbSchoolYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbSchoolYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbSchoolYear.Items = new string[0];
            this.cmbSchoolYear.Location = new System.Drawing.Point(435, 19);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbSchoolYear.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbSchoolYear.selectedIndex = -1;
            this.cmbSchoolYear.Size = new System.Drawing.Size(189, 24);
            this.cmbSchoolYear.TabIndex = 83;
            this.cmbSchoolYear.onItemSelected += new System.EventHandler(this.cmbSchoolYear_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Library User :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(306, 23);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(122, 16);
            this.lbl.TabIndex = 80;
            this.lbl.Text = "Enter School Year :";
            // 
            // cmbLibraryUser
            // 
            this.cmbLibraryUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbLibraryUser.BorderRadius = 3;
            this.cmbLibraryUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbLibraryUser.DisabledColor = System.Drawing.Color.Gray;
            this.cmbLibraryUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbLibraryUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbLibraryUser.Items = new string[] {
        "Student",
        "Teacher"};
            this.cmbLibraryUser.Location = new System.Drawing.Point(110, 19);
            this.cmbLibraryUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLibraryUser.Name = "cmbLibraryUser";
            this.cmbLibraryUser.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbLibraryUser.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbLibraryUser.selectedIndex = 0;
            this.cmbLibraryUser.Size = new System.Drawing.Size(189, 24);
            this.cmbLibraryUser.TabIndex = 82;
            this.cmbLibraryUser.onItemSelected += new System.EventHandler(this.cmbLibraryUser_onItemSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSchoolYear);
            this.groupBox1.Controls.Add(this.cmbLibraryUser);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Location = new System.Drawing.Point(22, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 55);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // link_ScanQr
            // 
            this.link_ScanQr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanQr.BackColor = System.Drawing.Color.Transparent;
            this.link_ScanQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_ScanQr.BorderRadius = 7;
            this.link_ScanQr.ButtonText = "Scan QR Code";
            this.link_ScanQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ScanQr.DisabledColor = System.Drawing.Color.Gray;
            this.link_ScanQr.Iconcolor = System.Drawing.Color.Transparent;
            this.link_ScanQr.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_ScanQr.Iconimage")));
            this.link_ScanQr.Iconimage_right = null;
            this.link_ScanQr.Iconimage_right_Selected = null;
            this.link_ScanQr.Iconimage_Selected = null;
            this.link_ScanQr.IconMarginLeft = 0;
            this.link_ScanQr.IconMarginRight = 0;
            this.link_ScanQr.IconRightVisible = false;
            this.link_ScanQr.IconRightZoom = 0D;
            this.link_ScanQr.IconVisible = false;
            this.link_ScanQr.IconZoom = 110D;
            this.link_ScanQr.IsTab = false;
            this.link_ScanQr.Location = new System.Drawing.Point(224, 309);
            this.link_ScanQr.Name = "link_ScanQr";
            this.link_ScanQr.Normalcolor = System.Drawing.Color.Transparent;
            this.link_ScanQr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanQr.OnHoverTextColor = System.Drawing.Color.White;
            this.link_ScanQr.selected = false;
            this.link_ScanQr.Size = new System.Drawing.Size(122, 22);
            this.link_ScanQr.TabIndex = 88;
            this.link_ScanQr.Text = "Scan QR Code";
            this.link_ScanQr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ScanQr.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_ScanQr.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_ScanQr.Click += new System.EventHandler(this.link_ScanQr_Click);
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
        "Name",
        "With Penalty"};
            this.cmb_SearchCategory.Location = new System.Drawing.Point(85, 309);
            this.cmb_SearchCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategory.selectedIndex = -1;
            this.cmb_SearchCategory.Size = new System.Drawing.Size(127, 21);
            this.cmb_SearchCategory.TabIndex = 86;
            this.cmb_SearchCategory.onItemSelected += new System.EventHandler(this.cmb_SearchCategory_onItemSelected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 85;
            this.label14.Text = "Search by: ";
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
            this.txt_Search.Location = new System.Drawing.Point(224, 308);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(165, 22);
            this.txt_Search.TabIndex = 87;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.Visible = false;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Address.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Address.BorderThickness = 1;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Address.Enabled = false;
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Address.isPassword = false;
            this.txt_Address.Location = new System.Drawing.Point(523, 148);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(176, 22);
            this.txt_Address.TabIndex = 89;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "View :";
            // 
            // cmb_Penalty
            // 
            this.cmb_Penalty.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Penalty.BorderRadius = 3;
            this.cmb_Penalty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_Penalty.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_Penalty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_Penalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_Penalty.Items = new string[] {
        "ALL",
        "WITH PENALTY"};
            this.cmb_Penalty.Location = new System.Drawing.Point(71, 40);
            this.cmb_Penalty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Penalty.Name = "cmb_Penalty";
            this.cmb_Penalty.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_Penalty.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_Penalty.selectedIndex = -1;
            this.cmb_Penalty.Size = new System.Drawing.Size(189, 24);
            this.cmb_Penalty.TabIndex = 91;
            this.cmb_Penalty.onItemSelected += new System.EventHandler(this.cmb_Penalty_onItemSelected);
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(736, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Penalty);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.link_ScanQr);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrintLibCard);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txt_ContactNum);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.txt_SchoolID);
            this.Controls.Add(this.dgvBorrowers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBorrowerQR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SchoolID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ContactNum;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintLibCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cmbSchoolYear;
        private Bunifu.Framework.UI.BunifuDropdown cmbLibraryUser;
        private System.Windows.Forms.Label lbl;
        private Bunifu.Framework.UI.BunifuFlatButton link_ScanQr;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategory;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Address;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown cmb_Penalty;
    }
}