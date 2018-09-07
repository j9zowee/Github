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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Lastname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_UserIDNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_Status = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 117;
            this.label9.Text = "User ID Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Lastname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Firstname :";
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
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Status :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.txt_Lastname.Location = new System.Drawing.Point(125, 189);
            this.txt_Lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(159, 22);
            this.txt_Lastname.TabIndex = 125;
            this.txt_Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Firstname.Location = new System.Drawing.Point(125, 157);
            this.txt_Firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(159, 22);
            this.txt_Firstname.TabIndex = 124;
            this.txt_Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_UserIDNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNum.BorderThickness = 1;
            this.txt_UserIDNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_UserIDNum.Enabled = false;
            this.txt_UserIDNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_UserIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_UserIDNum.isPassword = false;
            this.txt_UserIDNum.Location = new System.Drawing.Point(125, 125);
            this.txt_UserIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(159, 22);
            this.txt_UserIDNum.TabIndex = 123;
            this.txt_UserIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmb_Status
            // 
            this.cmb_Status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Status.BorderRadius = 3;
            this.cmb_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_Status.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_Status.Enabled = false;
            this.cmb_Status.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_Status.Items = new string[] {
        "Active",
        "Inactive",
        "Deactivate"};
            this.cmb_Status.Location = new System.Drawing.Point(125, 220);
            this.cmb_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_Status.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_Status.selectedIndex = -1;
            this.cmb_Status.Size = new System.Drawing.Size(159, 24);
            this.cmb_Status.TabIndex = 126;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 7;
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 85D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(13, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(79, 39);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.brnClear.IconZoom = 85D;
            this.brnClear.IsTab = false;
            this.brnClear.Location = new System.Drawing.Point(95, 301);
            this.brnClear.Name = "brnClear";
            this.brnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.brnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.brnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.brnClear.selected = false;
            this.brnClear.Size = new System.Drawing.Size(90, 39);
            this.brnClear.TabIndex = 131;
            this.brnClear.Text = "CLEAR";
            this.brnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnClear.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.brnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
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
            this.btnExit.IconZoom = 85D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(191, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(78, 39);
            this.btnExit.TabIndex = 132;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.txt_Search.Location = new System.Drawing.Point(346, 13);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(213, 22);
            this.txt_Search.TabIndex = 128;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 113;
            this.label15.Text = "Search :";
            // 
            // UnapprovedAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(707, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.txt_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnapprovedAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnapprovedAccounts";
            this.Load += new System.EventHandler(this.UnapprovedAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_UserIDNum;
        private Bunifu.Framework.UI.BunifuDropdown cmb_Status;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton brnClear;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
    }
}