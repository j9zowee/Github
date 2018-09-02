namespace QRCodeBasedLMS
{
    partial class UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.Link_ScanQR = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.brnClear = new System.Windows.Forms.Button();
            this.pbUserQR = new System.Windows.Forms.PictureBox();
            this.cmb_SecretQuestion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UserIDNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SecretAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Staff = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.link_deactivate = new System.Windows.Forms.LinkLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_SecretAnswers = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_SecretQuestions = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_ConfirmPasswords = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Passwords = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Usernames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Lastnames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstnames = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_UserIDNums = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddOrUpdates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brnClears = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Link_ScanQRs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_SearchCategorys = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Searchs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.link_deactivates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(181, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(16, 460);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnAddOrUpdate.TabIndex = 13;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.Location = new System.Drawing.Point(335, 49);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(563, 460);
            this.dgvAccount.TabIndex = 84;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // Link_ScanQR
            // 
            this.Link_ScanQR.AutoSize = true;
            this.Link_ScanQR.Location = new System.Drawing.Point(485, 19);
            this.Link_ScanQR.Name = "Link_ScanQR";
            this.Link_ScanQR.Size = new System.Drawing.Size(79, 13);
            this.Link_ScanQR.TabIndex = 23;
            this.Link_ScanQR.TabStop = true;
            this.Link_ScanQR.Text = "Scan QR Code";
            this.Link_ScanQR.Visible = false;
            this.Link_ScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ScanQR_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(485, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 22);
            this.txt_Search.TabIndex = 24;
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
            this.cmb_SearchCategory.Location = new System.Drawing.Point(358, 12);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 22;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(299, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "Search by :";
            // 
            // brnClear
            // 
            this.brnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClear.Location = new System.Drawing.Point(100, 460);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(75, 40);
            this.brnClear.TabIndex = 14;
            this.brnClear.Text = "CLEAR";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // pbUserQR
            // 
            this.pbUserQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pbUserQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserQR.Location = new System.Drawing.Point(1, 1);
            this.pbUserQR.Name = "pbUserQR";
            this.pbUserQR.Size = new System.Drawing.Size(130, 130);
            this.pbUserQR.TabIndex = 89;
            this.pbUserQR.TabStop = false;
            // 
            // cmb_SecretQuestion
            // 
            this.cmb_SecretQuestion.FormattingEnabled = true;
            this.cmb_SecretQuestion.Items.AddRange(new object[] {
            "Favorite food",
            "favorite pet"});
            this.cmb_SecretQuestion.Location = new System.Drawing.Point(125, 337);
            this.cmb_SecretQuestion.Name = "cmb_SecretQuestion";
            this.cmb_SecretQuestion.Size = new System.Drawing.Size(136, 21);
            this.cmb_SecretQuestion.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 105;
            this.label9.Text = "User ID Number :";
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserIDNum.Location = new System.Drawing.Point(124, 167);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(137, 22);
            this.txt_UserIDNum.TabIndex = 1;
            this.txt_UserIDNum.TextChanged += new System.EventHandler(this.txt_UserIDNum_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 104;
            this.label8.Text = "Secret Answer :";
            // 
            // txt_SecretAnswer
            // 
            this.txt_SecretAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SecretAnswer.Location = new System.Drawing.Point(125, 363);
            this.txt_SecretAnswer.Name = "txt_SecretAnswer";
            this.txt_SecretAnswer.Size = new System.Drawing.Size(137, 22);
            this.txt_SecretAnswer.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 103;
            this.label7.Text = "Secret Question :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "Confirm Password :";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(140, 307);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(122, 22);
            this.txt_ConfirmPassword.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = "Password :";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(91, 279);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(171, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Username :";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(91, 251);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(171, 22);
            this.txt_Username.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Lastname :";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(91, 223);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(171, 22);
            this.txt_Lastname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Firstname :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(91, 195);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(171, 22);
            this.txt_Firstname.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Staff);
            this.groupBox1.Controls.Add(this.rb_Admin);
            this.groupBox1.Location = new System.Drawing.Point(91, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 33);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // rb_Staff
            // 
            this.rb_Staff.AutoSize = true;
            this.rb_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Staff.Location = new System.Drawing.Point(18, 10);
            this.rb_Staff.Name = "rb_Staff";
            this.rb_Staff.Size = new System.Drawing.Size(52, 20);
            this.rb_Staff.TabIndex = 10;
            this.rb_Staff.TabStop = true;
            this.rb_Staff.Text = "Staff";
            this.rb_Staff.UseVisualStyleBackColor = true;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Admin.Location = new System.Drawing.Point(90, 10);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(64, 20);
            this.rb_Admin.TabIndex = 9;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "User Type :";
            // 
            // link_deactivate
            // 
            this.link_deactivate.AutoSize = true;
            this.link_deactivate.Location = new System.Drawing.Point(19, 433);
            this.link_deactivate.Name = "link_deactivate";
            this.link_deactivate.Size = new System.Drawing.Size(102, 13);
            this.link_deactivate.TabIndex = 108;
            this.link_deactivate.TabStop = true;
            this.link_deactivate.Text = "Deactivate Account";
            this.link_deactivate.Visible = false;
            this.link_deactivate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_deactivate_LinkClicked);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_SecretAnswers
            // 
            this.txt_SecretAnswers.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SecretAnswers.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SecretAnswers.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SecretAnswers.BorderThickness = 1;
            this.txt_SecretAnswers.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SecretAnswers.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SecretAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SecretAnswers.isPassword = false;
            this.txt_SecretAnswers.Location = new System.Drawing.Point(230, 369);
            this.txt_SecretAnswers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SecretAnswers.Name = "txt_SecretAnswers";
            this.txt_SecretAnswers.Size = new System.Drawing.Size(189, 22);
            this.txt_SecretAnswers.TabIndex = 116;
            this.txt_SecretAnswers.Text = "for txt_SecretAnswer";
            this.txt_SecretAnswers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmb_SecretQuestions
            // 
            this.cmb_SecretQuestions.BackColor = System.Drawing.Color.Transparent;
            this.cmb_SecretQuestions.BorderRadius = 3;
            this.cmb_SecretQuestions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_SecretQuestions.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_SecretQuestions.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_SecretQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_SecretQuestions.Items = new string[] {
        "for cmb_SecretQuestion(DELETE ME)",
        "Favorite food",
        "favorite pet"};
            this.cmb_SecretQuestions.Location = new System.Drawing.Point(230, 342);
            this.cmb_SecretQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SecretQuestions.Name = "cmb_SecretQuestions";
            this.cmb_SecretQuestions.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SecretQuestions.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SecretQuestions.selectedIndex = 0;
            this.cmb_SecretQuestions.Size = new System.Drawing.Size(284, 24);
            this.cmb_SecretQuestions.TabIndex = 115;
            // 
            // txt_ConfirmPasswords
            // 
            this.txt_ConfirmPasswords.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ConfirmPasswords.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_ConfirmPasswords.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ConfirmPasswords.BorderThickness = 1;
            this.txt_ConfirmPasswords.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ConfirmPasswords.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConfirmPasswords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_ConfirmPasswords.isPassword = false;
            this.txt_ConfirmPasswords.Location = new System.Drawing.Point(230, 311);
            this.txt_ConfirmPasswords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ConfirmPasswords.Name = "txt_ConfirmPasswords";
            this.txt_ConfirmPasswords.Size = new System.Drawing.Size(189, 22);
            this.txt_ConfirmPasswords.TabIndex = 114;
            this.txt_ConfirmPasswords.Text = "for txt_ConfirmPassword";
            this.txt_ConfirmPasswords.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Passwords
            // 
            this.txt_Passwords.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Passwords.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Passwords.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Passwords.BorderThickness = 1;
            this.txt_Passwords.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Passwords.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Passwords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Passwords.isPassword = false;
            this.txt_Passwords.Location = new System.Drawing.Point(230, 279);
            this.txt_Passwords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Passwords.Name = "txt_Passwords";
            this.txt_Passwords.Size = new System.Drawing.Size(189, 22);
            this.txt_Passwords.TabIndex = 113;
            this.txt_Passwords.Text = "for txt_Password";
            this.txt_Passwords.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Usernames
            // 
            this.txt_Usernames.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Usernames.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Usernames.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Usernames.BorderThickness = 1;
            this.txt_Usernames.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Usernames.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Usernames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Usernames.isPassword = false;
            this.txt_Usernames.Location = new System.Drawing.Point(230, 251);
            this.txt_Usernames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Usernames.Name = "txt_Usernames";
            this.txt_Usernames.Size = new System.Drawing.Size(189, 22);
            this.txt_Usernames.TabIndex = 112;
            this.txt_Usernames.Text = "for txt_Username";
            this.txt_Usernames.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Lastnames.Location = new System.Drawing.Point(230, 223);
            this.txt_Lastnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastnames.Name = "txt_Lastnames";
            this.txt_Lastnames.Size = new System.Drawing.Size(189, 22);
            this.txt_Lastnames.TabIndex = 111;
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
            this.txt_Firstnames.Location = new System.Drawing.Point(230, 195);
            this.txt_Firstnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstnames.Name = "txt_Firstnames";
            this.txt_Firstnames.Size = new System.Drawing.Size(189, 22);
            this.txt_Firstnames.TabIndex = 110;
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
            this.txt_UserIDNums.Location = new System.Drawing.Point(230, 167);
            this.txt_UserIDNums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserIDNums.Name = "txt_UserIDNums";
            this.txt_UserIDNums.Size = new System.Drawing.Size(189, 22);
            this.txt_UserIDNums.TabIndex = 109;
            this.txt_UserIDNums.Text = "for txt_UserIDNum";
            this.txt_UserIDNums.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnExits.Location = new System.Drawing.Point(494, 458);
            this.btnExits.Name = "btnExits";
            this.btnExits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExits.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExits.selected = false;
            this.btnExits.Size = new System.Drawing.Size(110, 41);
            this.btnExits.TabIndex = 119;
            this.btnExits.Text = "EXIT";
            this.btnExits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExits.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnExits.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.btnAddOrUpdates.Location = new System.Drawing.Point(262, 458);
            this.btnAddOrUpdates.Name = "btnAddOrUpdates";
            this.btnAddOrUpdates.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdates.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdates.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrUpdates.selected = false;
            this.btnAddOrUpdates.Size = new System.Drawing.Size(110, 41);
            this.btnAddOrUpdates.TabIndex = 117;
            this.btnAddOrUpdates.Text = "ADD";
            this.btnAddOrUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrUpdates.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrUpdates.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.brnClears.Location = new System.Drawing.Point(378, 458);
            this.brnClears.Name = "brnClears";
            this.brnClears.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.brnClears.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.brnClears.OnHoverTextColor = System.Drawing.Color.White;
            this.brnClears.selected = false;
            this.brnClears.Size = new System.Drawing.Size(110, 41);
            this.brnClears.TabIndex = 118;
            this.brnClears.Text = "CLEAR";
            this.brnClears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnClears.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.brnClears.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.Link_ScanQRs.Location = new System.Drawing.Point(654, 42);
            this.Link_ScanQRs.Name = "Link_ScanQRs";
            this.Link_ScanQRs.Normalcolor = System.Drawing.Color.Transparent;
            this.Link_ScanQRs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.Link_ScanQRs.OnHoverTextColor = System.Drawing.Color.White;
            this.Link_ScanQRs.selected = false;
            this.Link_ScanQRs.Size = new System.Drawing.Size(176, 22);
            this.Link_ScanQRs.TabIndex = 132;
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
            this.cmb_SearchCategorys.Location = new System.Drawing.Point(332, 41);
            this.cmb_SearchCategorys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategorys.Name = "cmb_SearchCategorys";
            this.cmb_SearchCategorys.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategorys.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategorys.selectedIndex = 0;
            this.cmb_SearchCategorys.Size = new System.Drawing.Size(211, 21);
            this.cmb_SearchCategorys.TabIndex = 130;
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
            this.txt_Searchs.Location = new System.Drawing.Point(628, 12);
            this.txt_Searchs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Searchs.Name = "txt_Searchs";
            this.txt_Searchs.Size = new System.Drawing.Size(119, 22);
            this.txt_Searchs.TabIndex = 131;
            this.txt_Searchs.Text = "for txt_Search";
            this.txt_Searchs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // link_deactivates
            // 
            this.link_deactivates.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_deactivates.BackColor = System.Drawing.Color.Transparent;
            this.link_deactivates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_deactivates.BorderRadius = 7;
            this.link_deactivates.ButtonText = "Change \"Deactivate Account\"";
            this.link_deactivates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_deactivates.DisabledColor = System.Drawing.Color.Gray;
            this.link_deactivates.Iconcolor = System.Drawing.Color.Transparent;
            this.link_deactivates.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_deactivates.Iconimage")));
            this.link_deactivates.Iconimage_right = null;
            this.link_deactivates.Iconimage_right_Selected = null;
            this.link_deactivates.Iconimage_Selected = null;
            this.link_deactivates.IconMarginLeft = 0;
            this.link_deactivates.IconMarginRight = 0;
            this.link_deactivates.IconRightVisible = false;
            this.link_deactivates.IconRightZoom = 0D;
            this.link_deactivates.IconVisible = false;
            this.link_deactivates.IconZoom = 110D;
            this.link_deactivates.IsTab = false;
            this.link_deactivates.Location = new System.Drawing.Point(140, 430);
            this.link_deactivates.Name = "link_deactivates";
            this.link_deactivates.Normalcolor = System.Drawing.Color.Transparent;
            this.link_deactivates.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_deactivates.OnHoverTextColor = System.Drawing.Color.White;
            this.link_deactivates.selected = false;
            this.link_deactivates.Size = new System.Drawing.Size(205, 22);
            this.link_deactivates.TabIndex = 133;
            this.link_deactivates.Text = "Change \"Deactivate Account\"";
            this.link_deactivates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_deactivates.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_deactivates.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pbUserQR);
            this.panel3.Location = new System.Drawing.Point(100, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 134;
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(910, 521);
            this.Controls.Add(this.link_deactivates);
            this.Controls.Add(this.Link_ScanQRs);
            this.Controls.Add(this.cmb_SearchCategorys);
            this.Controls.Add(this.txt_Searchs);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnAddOrUpdates);
            this.Controls.Add(this.brnClears);
            this.Controls.Add(this.txt_SecretAnswers);
            this.Controls.Add(this.cmb_SecretQuestions);
            this.Controls.Add(this.txt_ConfirmPasswords);
            this.Controls.Add(this.txt_Passwords);
            this.Controls.Add(this.txt_Usernames);
            this.Controls.Add(this.txt_Lastnames);
            this.Controls.Add(this.txt_Firstnames);
            this.Controls.Add(this.txt_UserIDNums);
            this.Controls.Add(this.link_deactivate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_SecretQuestion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SecretAnswer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.Link_ScanQR);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInformation";
            this.Text = "UserInformation";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.LinkLabel Link_ScanQR;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.PictureBox pbUserQR;
        private System.Windows.Forms.ComboBox cmb_SecretQuestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UserIDNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SecretAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Staff;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_deactivate;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SecretAnswers;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SecretQuestions;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ConfirmPasswords;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Passwords;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Usernames;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastnames;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstnames;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_UserIDNums;
        private Bunifu.Framework.UI.BunifuFlatButton btnExits;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrUpdates;
        private Bunifu.Framework.UI.BunifuFlatButton brnClears;
        private Bunifu.Framework.UI.BunifuFlatButton Link_ScanQRs;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategorys;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Searchs;
        private Bunifu.Framework.UI.BunifuFlatButton link_deactivates;
        private System.Windows.Forms.Panel panel3;
    }
}