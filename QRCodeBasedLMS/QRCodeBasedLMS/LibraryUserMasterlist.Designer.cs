namespace QRCodeBasedLMS
{
    partial class LibraryUserMasterlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryUserMasterlist));
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStartYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLibraryUser = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbLibraryUsers = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbStartYears = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtEndYears = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFilePaths = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnChooses = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndYear
            // 
            this.txtEndYear.Enabled = false;
            this.txtEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndYear.Location = new System.Drawing.Point(225, 47);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(55, 22);
            this.txtEndYear.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "__";
            // 
            // cmbStartYear
            // 
            this.cmbStartYear.FormattingEnabled = true;
            this.cmbStartYear.ItemHeight = 13;
            this.cmbStartYear.Location = new System.Drawing.Point(136, 47);
            this.cmbStartYear.Name = "cmbStartYear";
            this.cmbStartYear.Size = new System.Drawing.Size(55, 21);
            this.cmbStartYear.TabIndex = 28;
            this.cmbStartYear.Leave += new System.EventHandler(this.cmbStartYear_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter School Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Library User :";
            // 
            // cmbLibraryUser
            // 
            this.cmbLibraryUser.FormattingEnabled = true;
            this.cmbLibraryUser.ItemHeight = 13;
            this.cmbLibraryUser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmbLibraryUser.Location = new System.Drawing.Point(136, 10);
            this.cmbLibraryUser.Name = "cmbLibraryUser";
            this.cmbLibraryUser.Size = new System.Drawing.Size(144, 21);
            this.cmbLibraryUser.TabIndex = 32;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 135);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(716, 349);
            this.dgvList.TabIndex = 33;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(11, 92);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(93, 34);
            this.btnChoose.TabIndex = 34;
            this.btnChoose.Text = "CHOOSE FILE";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(110, 98);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(310, 22);
            this.txtFilePath.TabIndex = 35;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmbLibraryUsers
            // 
            this.cmbLibraryUsers.BackColor = System.Drawing.Color.Transparent;
            this.cmbLibraryUsers.BorderRadius = 3;
            this.cmbLibraryUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbLibraryUsers.DisabledColor = System.Drawing.Color.Gray;
            this.cmbLibraryUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbLibraryUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbLibraryUsers.Items = new string[] {
        "(for cmbLibraryUser)",
        "Student",
        "Teacher"};
            this.cmbLibraryUsers.Location = new System.Drawing.Point(287, 10);
            this.cmbLibraryUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLibraryUsers.Name = "cmbLibraryUsers";
            this.cmbLibraryUsers.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbLibraryUsers.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbLibraryUsers.selectedIndex = 0;
            this.cmbLibraryUsers.Size = new System.Drawing.Size(189, 24);
            this.cmbLibraryUsers.TabIndex = 62;
            // 
            // cmbStartYears
            // 
            this.cmbStartYears.BackColor = System.Drawing.Color.Transparent;
            this.cmbStartYears.BorderRadius = 3;
            this.cmbStartYears.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbStartYears.DisabledColor = System.Drawing.Color.Gray;
            this.cmbStartYears.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbStartYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbStartYears.Items = new string[] {
        "(for cmbStartYear)"};
            this.cmbStartYears.Location = new System.Drawing.Point(287, 47);
            this.cmbStartYears.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStartYears.Name = "cmbStartYears";
            this.cmbStartYears.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbStartYears.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbStartYears.selectedIndex = 0;
            this.cmbStartYears.Size = new System.Drawing.Size(189, 24);
            this.cmbStartYears.TabIndex = 63;
            // 
            // txtEndYears
            // 
            this.txtEndYears.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtEndYears.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtEndYears.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtEndYears.BorderThickness = 1;
            this.txtEndYears.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEndYears.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtEndYears.isPassword = false;
            this.txtEndYears.Location = new System.Drawing.Point(484, 49);
            this.txtEndYears.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndYears.Name = "txtEndYears";
            this.txtEndYears.Size = new System.Drawing.Size(189, 22);
            this.txtEndYears.TabIndex = 64;
            this.txtEndYears.Text = "for txtEndYear";
            this.txtEndYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFilePaths
            // 
            this.txtFilePaths.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFilePaths.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtFilePaths.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFilePaths.BorderThickness = 1;
            this.txtFilePaths.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFilePaths.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFilePaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtFilePaths.isPassword = false;
            this.txtFilePaths.Location = new System.Drawing.Point(427, 98);
            this.txtFilePaths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePaths.Name = "txtFilePaths";
            this.txtFilePaths.Size = new System.Drawing.Size(189, 22);
            this.txtFilePaths.TabIndex = 65;
            this.txtFilePaths.Text = "for txtFilePath";
            this.txtFilePaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnChooses
            // 
            this.btnChooses.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnChooses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnChooses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooses.BorderRadius = 7;
            this.btnChooses.ButtonText = "CHOOSE FILE";
            this.btnChooses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooses.DisabledColor = System.Drawing.Color.Gray;
            this.btnChooses.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChooses.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChooses.Iconimage")));
            this.btnChooses.Iconimage_right = null;
            this.btnChooses.Iconimage_right_Selected = null;
            this.btnChooses.Iconimage_Selected = null;
            this.btnChooses.IconMarginLeft = 0;
            this.btnChooses.IconMarginRight = 0;
            this.btnChooses.IconRightVisible = false;
            this.btnChooses.IconRightZoom = 0D;
            this.btnChooses.IconVisible = true;
            this.btnChooses.IconZoom = 80D;
            this.btnChooses.IsTab = false;
            this.btnChooses.Location = new System.Drawing.Point(46, 117);
            this.btnChooses.Name = "btnChooses";
            this.btnChooses.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnChooses.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnChooses.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChooses.selected = false;
            this.btnChooses.Size = new System.Drawing.Size(132, 41);
            this.btnChooses.TabIndex = 76;
            this.btnChooses.Text = "CHOOSE FILE";
            this.btnChooses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChooses.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnChooses.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // LibraryUserMasterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(740, 496);
            this.Controls.Add(this.btnChooses);
            this.Controls.Add(this.txtFilePaths);
            this.Controls.Add(this.txtEndYears);
            this.Controls.Add(this.cmbStartYears);
            this.Controls.Add(this.cmbLibraryUsers);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.cmbLibraryUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStartYear);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryUserMasterlist";
            this.Text = "LibraryUserMasterlist";
            this.Load += new System.EventHandler(this.LibraryUserMasterlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStartYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLibraryUser;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtFilePath;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown cmbLibraryUsers;
        private Bunifu.Framework.UI.BunifuDropdown cmbStartYears;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEndYears;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilePaths;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooses;
    }
}