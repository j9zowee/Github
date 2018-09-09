namespace QRCodeBasedLMS
{
    partial class BookSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSearch));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.link_Scan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_SearchCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(12, 74);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.Size = new System.Drawing.Size(607, 371);
            this.dgvBook.TabIndex = 0;
            // 
            // link_Scan
            // 
            this.link_Scan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_Scan.BackColor = System.Drawing.Color.Transparent;
            this.link_Scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_Scan.BorderRadius = 7;
            this.link_Scan.ButtonText = "Scan QR Code";
            this.link_Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_Scan.DisabledColor = System.Drawing.Color.Gray;
            this.link_Scan.Iconcolor = System.Drawing.Color.Transparent;
            this.link_Scan.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_Scan.Iconimage")));
            this.link_Scan.Iconimage_right = null;
            this.link_Scan.Iconimage_right_Selected = null;
            this.link_Scan.Iconimage_Selected = null;
            this.link_Scan.IconMarginLeft = 0;
            this.link_Scan.IconMarginRight = 0;
            this.link_Scan.IconRightVisible = false;
            this.link_Scan.IconRightZoom = 0D;
            this.link_Scan.IconVisible = false;
            this.link_Scan.IconZoom = 110D;
            this.link_Scan.IsTab = false;
            this.link_Scan.Location = new System.Drawing.Point(254, 33);
            this.link_Scan.Name = "link_Scan";
            this.link_Scan.Normalcolor = System.Drawing.Color.Transparent;
            this.link_Scan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_Scan.OnHoverTextColor = System.Drawing.Color.White;
            this.link_Scan.selected = false;
            this.link_Scan.Size = new System.Drawing.Size(144, 22);
            this.link_Scan.TabIndex = 78;
            this.link_Scan.Text = "Scan QR Code";
            this.link_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_Scan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_Scan.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_Scan.Visible = false;
            this.link_Scan.Click += new System.EventHandler(this.link_Scan_Click);
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
        "Title"};
            this.cmb_SearchCategory.Location = new System.Drawing.Point(90, 33);
            this.cmb_SearchCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategory.selectedIndex = -1;
            this.cmb_SearchCategory.Size = new System.Drawing.Size(153, 21);
            this.cmb_SearchCategory.TabIndex = 76;
            this.cmb_SearchCategory.onItemSelected += new System.EventHandler(this.cmb_SearchCategory_onItemSelected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 75;
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
            this.txt_Search.Location = new System.Drawing.Point(251, 33);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(208, 22);
            this.txt_Search.TabIndex = 77;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.Visible = false;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
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
            this.link_GoBack.Location = new System.Drawing.Point(552, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(72, 22);
            this.link_GoBack.TabIndex = 97;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(636, 462);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.link_Scan);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgvBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSearch";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgvBook;
        private Bunifu.Framework.UI.BunifuFlatButton link_Scan;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategory;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
    }
}