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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.link_Scan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_SearchCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rb_Lost = new System.Windows.Forms.RadioButton();
            this.rb_Damaged = new System.Windows.Forms.RadioButton();
            this.rb_Borrowed = new System.Windows.Forms.RadioButton();
            this.rb_Available = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 370);
            this.dataGridView1.TabIndex = 0;
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
        "Title",
        "Author"};
            this.cmb_SearchCategory.Location = new System.Drawing.Point(90, 33);
            this.cmb_SearchCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SearchCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SearchCategory.selectedIndex = -1;
            this.cmb_SearchCategory.Size = new System.Drawing.Size(153, 21);
            this.cmb_SearchCategory.TabIndex = 76;
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
            this.txt_Search.Size = new System.Drawing.Size(147, 22);
            this.txt_Search.TabIndex = 77;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rb_Lost
            // 
            this.rb_Lost.AutoSize = true;
            this.rb_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Lost.Location = new System.Drawing.Point(350, 28);
            this.rb_Lost.Name = "rb_Lost";
            this.rb_Lost.Size = new System.Drawing.Size(51, 20);
            this.rb_Lost.TabIndex = 83;
            this.rb_Lost.TabStop = true;
            this.rb_Lost.Text = "Lost";
            this.rb_Lost.UseVisualStyleBackColor = true;
            // 
            // rb_Damaged
            // 
            this.rb_Damaged.AutoSize = true;
            this.rb_Damaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Damaged.Location = new System.Drawing.Point(257, 28);
            this.rb_Damaged.Name = "rb_Damaged";
            this.rb_Damaged.Size = new System.Drawing.Size(87, 20);
            this.rb_Damaged.TabIndex = 82;
            this.rb_Damaged.TabStop = true;
            this.rb_Damaged.Text = "Damaged";
            this.rb_Damaged.UseVisualStyleBackColor = true;
            // 
            // rb_Borrowed
            // 
            this.rb_Borrowed.AutoSize = true;
            this.rb_Borrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Borrowed.Location = new System.Drawing.Point(165, 28);
            this.rb_Borrowed.Name = "rb_Borrowed";
            this.rb_Borrowed.Size = new System.Drawing.Size(84, 20);
            this.rb_Borrowed.TabIndex = 81;
            this.rb_Borrowed.TabStop = true;
            this.rb_Borrowed.Text = "Borrowed";
            this.rb_Borrowed.UseVisualStyleBackColor = true;
            // 
            // rb_Available
            // 
            this.rb_Available.AutoSize = true;
            this.rb_Available.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Available.Location = new System.Drawing.Point(76, 29);
            this.rb_Available.Name = "rb_Available";
            this.rb_Available.Size = new System.Drawing.Size(83, 20);
            this.rb_Available.TabIndex = 80;
            this.rb_Available.TabStop = true;
            this.rb_Available.Text = "Available";
            this.rb_Available.UseVisualStyleBackColor = true;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_All.Location = new System.Drawing.Point(29, 30);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(41, 20);
            this.rb_All.TabIndex = 79;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "All";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_All);
            this.groupBox1.Controls.Add(this.rb_Available);
            this.groupBox1.Controls.Add(this.rb_Lost);
            this.groupBox1.Controls.Add(this.rb_Borrowed);
            this.groupBox1.Controls.Add(this.rb_Damaged);
            this.groupBox1.Location = new System.Drawing.Point(513, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 67);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(944, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.link_Scan);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton link_Scan;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SearchCategory;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private System.Windows.Forms.RadioButton rb_Lost;
        private System.Windows.Forms.RadioButton rb_Damaged;
        private System.Windows.Forms.RadioButton rb_Borrowed;
        private System.Windows.Forms.RadioButton rb_Available;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}