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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbLibraryUser = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbSchoolYear = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnChoose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFilePath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter School Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Library User :";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 180);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(716, 304);
            this.dgvList.TabIndex = 33;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.cmbLibraryUser.Location = new System.Drawing.Point(142, 46);
            this.cmbLibraryUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLibraryUser.Name = "cmbLibraryUser";
            this.cmbLibraryUser.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbLibraryUser.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbLibraryUser.selectedIndex = 0;
            this.cmbLibraryUser.Size = new System.Drawing.Size(189, 24);
            this.cmbLibraryUser.TabIndex = 62;
            this.cmbLibraryUser.onItemSelected += new System.EventHandler(this.cmbLibraryUser_onItemSelected);
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
            this.cmbSchoolYear.Location = new System.Drawing.Point(142, 83);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbSchoolYear.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbSchoolYear.selectedIndex = -1;
            this.cmbSchoolYear.Size = new System.Drawing.Size(189, 24);
            this.cmbSchoolYear.TabIndex = 63;
            this.cmbSchoolYear.onItemSelected += new System.EventHandler(this.cmbSchoolYear_onItemSelected);
            // 
            // btnChoose
            // 
            this.btnChoose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoose.BorderRadius = 7;
            this.btnChoose.ButtonText = "CHOOSE FILE";
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.DisabledColor = System.Drawing.Color.Gray;
            this.btnChoose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChoose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChoose.Iconimage")));
            this.btnChoose.Iconimage_right = null;
            this.btnChoose.Iconimage_right_Selected = null;
            this.btnChoose.Iconimage_Selected = null;
            this.btnChoose.IconMarginLeft = 0;
            this.btnChoose.IconMarginRight = 0;
            this.btnChoose.IconRightVisible = false;
            this.btnChoose.IconRightZoom = 0D;
            this.btnChoose.IconVisible = true;
            this.btnChoose.IconZoom = 80D;
            this.btnChoose.IsTab = false;
            this.btnChoose.Location = new System.Drawing.Point(16, 133);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnChoose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnChoose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChoose.selected = false;
            this.btnChoose.Size = new System.Drawing.Size(132, 41);
            this.btnChoose.TabIndex = 76;
            this.btnChoose.Text = "CHOOSE FILE";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChoose.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnChoose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
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
            this.link_GoBack.Location = new System.Drawing.Point(668, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(60, 22);
            this.link_GoBack.TabIndex = 98;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.txtFilePath.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFilePath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtFilePath.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFilePath.BorderThickness = 1;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtFilePath.isPassword = false;
            this.txtFilePath.Location = new System.Drawing.Point(155, 133);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(395, 39);
            this.txtFilePath.TabIndex = 99;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LibraryUserMasterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(740, 496);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLibraryUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryUserMasterlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryUserMasterlist";
            this.Load += new System.EventHandler(this.LibraryUserMasterlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvList;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown cmbLibraryUser;
        private Bunifu.Framework.UI.BunifuDropdown cmbSchoolYear;
        private Bunifu.Framework.UI.BunifuFlatButton btnChoose;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilePath;
    }
}