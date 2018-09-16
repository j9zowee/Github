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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Staff = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_SecretAnswer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Lastname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_UserIDNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddOrUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.link_deactivate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_SecretQuestion = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvAccount.Size = new System.Drawing.Size(563, 339);
            this.dgvAccount.TabIndex = 84;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 105;
            this.label9.Text = "User ID Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 104;
            this.label8.Text = "Secret Answer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 103;
            this.label7.Text = "Secret Question :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Lastname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Firstname :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Staff);
            this.groupBox1.Controls.Add(this.rb_Admin);
            this.groupBox1.Location = new System.Drawing.Point(97, 267);
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
            this.label2.Location = new System.Drawing.Point(19, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "User Type :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_SecretAnswer
            // 
            this.txt_SecretAnswer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SecretAnswer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SecretAnswer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SecretAnswer.BorderThickness = 1;
            this.txt_SecretAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SecretAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SecretAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SecretAnswer.isPassword = false;
            this.txt_SecretAnswer.Location = new System.Drawing.Point(135, 246);
            this.txt_SecretAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SecretAnswer.Name = "txt_SecretAnswer";
            this.txt_SecretAnswer.Size = new System.Drawing.Size(189, 22);
            this.txt_SecretAnswer.TabIndex = 116;
            this.txt_SecretAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Password.BorderThickness = 1;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Password.isPassword = true;
            this.txt_Password.Location = new System.Drawing.Point(135, 163);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(189, 22);
            this.txt_Password.TabIndex = 113;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Username.BorderThickness = 1;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Username.isPassword = false;
            this.txt_Username.Location = new System.Drawing.Point(135, 135);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(189, 22);
            this.txt_Username.TabIndex = 112;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Lastname.Location = new System.Drawing.Point(135, 107);
            this.txt_Lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(189, 22);
            this.txt_Lastname.TabIndex = 111;
            this.txt_Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Firstname.Location = new System.Drawing.Point(135, 79);
            this.txt_Firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(189, 22);
            this.txt_Firstname.TabIndex = 110;
            this.txt_Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_UserIDNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNum.BorderThickness = 1;
            this.txt_UserIDNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_UserIDNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_UserIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_UserIDNum.isPassword = false;
            this.txt_UserIDNum.Location = new System.Drawing.Point(135, 51);
            this.txt_UserIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(189, 22);
            this.txt_UserIDNum.TabIndex = 109;
            this.txt_UserIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 7;
            this.btnExit.ButtonText = "EXIT";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = false;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 80D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(224, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(100, 41);
            this.btnExit.TabIndex = 119;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnAddOrUpdate.Location = new System.Drawing.Point(12, 347);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddOrUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddOrUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOrUpdate.selected = false;
            this.btnAddOrUpdate.Size = new System.Drawing.Size(100, 41);
            this.btnAddOrUpdate.TabIndex = 117;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddOrUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAddOrUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click_1);
            // 
            // brnClear
            // 
            this.brnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.brnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.brnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnClear.BorderRadius = 7;
            this.brnClear.ButtonText = "CLEAR";
            this.brnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnClear.DisabledColor = System.Drawing.Color.Gray;
            this.brnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.brnClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("brnClear.Iconimage")));
            this.brnClear.Iconimage_right = null;
            this.brnClear.Iconimage_right_Selected = null;
            this.brnClear.Iconimage_Selected = null;
            this.brnClear.IconMarginLeft = 0;
            this.brnClear.IconMarginRight = 0;
            this.brnClear.IconRightVisible = false;
            this.brnClear.IconRightZoom = 0D;
            this.brnClear.IconVisible = true;
            this.brnClear.IconZoom = 80D;
            this.brnClear.IsTab = false;
            this.brnClear.Location = new System.Drawing.Point(118, 347);
            this.brnClear.Name = "brnClear";
            this.brnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.brnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.brnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.brnClear.selected = false;
            this.brnClear.Size = new System.Drawing.Size(100, 41);
            this.brnClear.TabIndex = 118;
            this.brnClear.Text = "CLEAR";
            this.brnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnClear.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.brnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
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
            this.txt_Search.Location = new System.Drawing.Point(386, 14);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(241, 22);
            this.txt_Search.TabIndex = 131;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            // 
            // link_deactivate
            // 
            this.link_deactivate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_deactivate.BackColor = System.Drawing.Color.Transparent;
            this.link_deactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_deactivate.BorderRadius = 7;
            this.link_deactivate.ButtonText = "Deactivate Account";
            this.link_deactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_deactivate.DisabledColor = System.Drawing.Color.Gray;
            this.link_deactivate.Iconcolor = System.Drawing.Color.Transparent;
            this.link_deactivate.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_deactivate.Iconimage")));
            this.link_deactivate.Iconimage_right = null;
            this.link_deactivate.Iconimage_right_Selected = null;
            this.link_deactivate.Iconimage_Selected = null;
            this.link_deactivate.IconMarginLeft = 0;
            this.link_deactivate.IconMarginRight = 0;
            this.link_deactivate.IconRightVisible = false;
            this.link_deactivate.IconRightZoom = 0D;
            this.link_deactivate.IconVisible = false;
            this.link_deactivate.IconZoom = 110D;
            this.link_deactivate.IsTab = false;
            this.link_deactivate.Location = new System.Drawing.Point(2, 321);
            this.link_deactivate.Name = "link_deactivate";
            this.link_deactivate.Normalcolor = System.Drawing.Color.Transparent;
            this.link_deactivate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_deactivate.OnHoverTextColor = System.Drawing.Color.White;
            this.link_deactivate.selected = false;
            this.link_deactivate.Size = new System.Drawing.Size(159, 22);
            this.link_deactivate.TabIndex = 133;
            this.link_deactivate.Text = "Deactivate Account";
            this.link_deactivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_deactivate.Textcolor = System.Drawing.Color.Red;
            this.link_deactivate.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_deactivate.Click += new System.EventHandler(this.link_deactivate_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "Search :";
            // 
            // cmb_SecretQuestion
            // 
            this.cmb_SecretQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cmb_SecretQuestion.BorderRadius = 3;
            this.cmb_SecretQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_SecretQuestion.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_SecretQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_SecretQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_SecretQuestion.Items = new string[] {
        "What was your favorite food as a child?",
        "What is your favorite color?",
        "What is the title of your favorite movie?",
        "What is your mother\'s maiden name?",
        "In what city or town did your mother and father meet?",
        "In what town was your first job?",
        "What school did you attend for sixth grade?"};
            this.cmb_SecretQuestion.Location = new System.Drawing.Point(135, 194);
            this.cmb_SecretQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SecretQuestion.Name = "cmb_SecretQuestion";
            this.cmb_SecretQuestion.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SecretQuestion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SecretQuestion.selectedIndex = -1;
            this.cmb_SecretQuestion.Size = new System.Drawing.Size(189, 45);
            this.cmb_SecretQuestion.TabIndex = 135;
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(910, 402);
            this.Controls.Add(this.cmb_SecretQuestion);
            this.Controls.Add(this.link_deactivate);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.txt_SecretAnswer);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInformation";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Staff;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SecretAnswer;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Username;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_UserIDNum;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddOrUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton brnClear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuFlatButton link_deactivate;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SecretQuestion;
    }
}