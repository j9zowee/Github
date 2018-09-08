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
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_SchoolID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Lastname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ContactNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnUpdateorSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_ScanBrwr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintLibCard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firstname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 155);
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
            this.txt_Address.Size = new System.Drawing.Size(184, 71);
            this.txt_Address.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Contact Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "School ID :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(183, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Lastname :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Female);
            this.groupBox2.Controls.Add(this.rb_Male);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(270, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 36);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Enabled = false;
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
            this.rb_Male.Enabled = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 251);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 236);
            this.dataGridView1.TabIndex = 53;
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
            this.panel3.Location = new System.Drawing.Point(23, 56);
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
            this.txt_SchoolID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchoolID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SchoolID.isPassword = false;
            this.txt_SchoolID.Location = new System.Drawing.Point(258, 56);
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
            this.txt_Firstname.Enabled = false;
            this.txt_Firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Firstname.isPassword = false;
            this.txt_Firstname.Location = new System.Drawing.Point(258, 86);
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
            this.txt_Lastname.Enabled = false;
            this.txt_Lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Lastname.isPassword = false;
            this.txt_Lastname.Location = new System.Drawing.Point(258, 114);
            this.txt_Lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(176, 22);
            this.txt_Lastname.TabIndex = 69;
            this.txt_Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(530, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 72);
            this.panel1.TabIndex = 70;
            // 
            // txt_ContactNum
            // 
            this.txt_ContactNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ContactNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_ContactNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ContactNum.BorderThickness = 1;
            this.txt_ContactNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ContactNum.Enabled = false;
            this.txt_ContactNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ContactNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_ContactNum.isPassword = false;
            this.txt_ContactNum.Location = new System.Drawing.Point(568, 148);
            this.txt_ContactNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ContactNum.Name = "txt_ContactNum";
            this.txt_ContactNum.Size = new System.Drawing.Size(147, 22);
            this.txt_ContactNum.TabIndex = 71;
            this.txt_ContactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdateorSave
            // 
            this.btnUpdateorSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdateorSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdateorSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateorSave.BorderRadius = 7;
            this.btnUpdateorSave.ButtonText = "UPDATE INFORMATION";
            this.btnUpdateorSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateorSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateorSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateorSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateorSave.Iconimage")));
            this.btnUpdateorSave.Iconimage_right = null;
            this.btnUpdateorSave.Iconimage_right_Selected = null;
            this.btnUpdateorSave.Iconimage_Selected = null;
            this.btnUpdateorSave.IconMarginLeft = 0;
            this.btnUpdateorSave.IconMarginRight = 0;
            this.btnUpdateorSave.IconRightVisible = false;
            this.btnUpdateorSave.IconRightZoom = 0D;
            this.btnUpdateorSave.IconVisible = true;
            this.btnUpdateorSave.IconZoom = 80D;
            this.btnUpdateorSave.IsTab = false;
            this.btnUpdateorSave.Location = new System.Drawing.Point(453, 193);
            this.btnUpdateorSave.Name = "btnUpdateorSave";
            this.btnUpdateorSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnUpdateorSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUpdateorSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateorSave.selected = false;
            this.btnUpdateorSave.Size = new System.Drawing.Size(128, 41);
            this.btnUpdateorSave.TabIndex = 74;
            this.btnUpdateorSave.Text = "UPDATE INFORMATION";
            this.btnUpdateorSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateorSave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnUpdateorSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUpdateorSave.Click += new System.EventHandler(this.btnUpdateorSave_Click_1);
            // 
            // link_ScanBrwr
            // 
            this.link_ScanBrwr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanBrwr.BackColor = System.Drawing.Color.Transparent;
            this.link_ScanBrwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_ScanBrwr.BorderRadius = 7;
            this.link_ScanBrwr.ButtonText = "Scan Borrower QR Code";
            this.link_ScanBrwr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ScanBrwr.DisabledColor = System.Drawing.Color.Gray;
            this.link_ScanBrwr.Iconcolor = System.Drawing.Color.Transparent;
            this.link_ScanBrwr.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_ScanBrwr.Iconimage")));
            this.link_ScanBrwr.Iconimage_right = null;
            this.link_ScanBrwr.Iconimage_right_Selected = null;
            this.link_ScanBrwr.Iconimage_Selected = null;
            this.link_ScanBrwr.IconMarginLeft = 0;
            this.link_ScanBrwr.IconMarginRight = 0;
            this.link_ScanBrwr.IconRightVisible = false;
            this.link_ScanBrwr.IconRightZoom = 0D;
            this.link_ScanBrwr.IconVisible = false;
            this.link_ScanBrwr.IconZoom = 110D;
            this.link_ScanBrwr.IsTab = false;
            this.link_ScanBrwr.Location = new System.Drawing.Point(12, 196);
            this.link_ScanBrwr.Name = "link_ScanBrwr";
            this.link_ScanBrwr.Normalcolor = System.Drawing.Color.Transparent;
            this.link_ScanBrwr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanBrwr.OnHoverTextColor = System.Drawing.Color.White;
            this.link_ScanBrwr.selected = false;
            this.link_ScanBrwr.Size = new System.Drawing.Size(176, 22);
            this.link_ScanBrwr.TabIndex = 77;
            this.link_ScanBrwr.Text = "Scan Borrower QR Code";
            this.link_ScanBrwr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ScanBrwr.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_ScanBrwr.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_ScanBrwr.Click += new System.EventHandler(this.link_ScanBrwr_Click);
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
            this.link_GoBack.Location = new System.Drawing.Point(642, 12);
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
            this.btnPrintLibCard.Location = new System.Drawing.Point(587, 193);
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 80;
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(736, 507);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPrintLibCard);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.link_ScanBrwr);
            this.Controls.Add(this.btnUpdateorSave);
            this.Controls.Add(this.txt_ContactNum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.txt_SchoolID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SchoolID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastname;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ContactNum;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateorSave;
        private Bunifu.Framework.UI.BunifuFlatButton link_ScanBrwr;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintLibCard;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}