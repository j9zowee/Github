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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbLibraryUser = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbStartYear = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtEndYear = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFilePath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnChoose = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "__";
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
            this.label3.Location = new System.Drawing.Point(46, 17);
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
            this.dgvList.Location = new System.Drawing.Point(12, 135);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(716, 349);
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
            this.cmbLibraryUser.Location = new System.Drawing.Point(140, 11);
            this.cmbLibraryUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLibraryUser.Name = "cmbLibraryUser";
            this.cmbLibraryUser.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbLibraryUser.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbLibraryUser.selectedIndex = 0;
            this.cmbLibraryUser.Size = new System.Drawing.Size(189, 24);
            this.cmbLibraryUser.TabIndex = 62;
            // 
            // cmbStartYear
            // 
            this.cmbStartYear.BackColor = System.Drawing.Color.Transparent;
            this.cmbStartYear.BorderRadius = 3;
            this.cmbStartYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbStartYear.DisabledColor = System.Drawing.Color.Gray;
            this.cmbStartYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbStartYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbStartYear.Items = new string[0];
            this.cmbStartYear.Location = new System.Drawing.Point(140, 48);
            this.cmbStartYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStartYear.Name = "cmbStartYear";
            this.cmbStartYear.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbStartYear.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbStartYear.selectedIndex = -1;
            this.cmbStartYear.Size = new System.Drawing.Size(189, 24);
            this.cmbStartYear.TabIndex = 63;
            this.cmbStartYear.Leave += new System.EventHandler(this.cmbStartYear_Leave);
            // 
            // txtEndYear
            // 
            this.txtEndYear.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtEndYear.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtEndYear.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtEndYear.BorderThickness = 1;
            this.txtEndYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEndYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtEndYear.isPassword = false;
            this.txtEndYear.Location = new System.Drawing.Point(366, 50);
            this.txtEndYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(189, 22);
            this.txtEndYear.TabIndex = 64;
            this.txtEndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFilePath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtFilePath.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFilePath.BorderThickness = 1;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFilePath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtFilePath.isPassword = false;
            this.txtFilePath.Location = new System.Drawing.Point(153, 97);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(309, 22);
            this.txtFilePath.TabIndex = 65;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnChoose.Location = new System.Drawing.Point(14, 88);
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
            // LibraryUserMasterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(740, 496);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.cmbStartYear);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvList;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown cmbLibraryUser;
        private Bunifu.Framework.UI.BunifuDropdown cmbStartYear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEndYear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilePath;
        private Bunifu.Framework.UI.BunifuFlatButton btnChoose;
    }
}