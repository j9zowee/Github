namespace QRCodeBasedLMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ms_Mainform = new System.Windows.Forms.MenuStrip();
            this.mASTERFILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonReadingMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERACCOUNTSMANAGERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unapprovedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnBorrow = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReturn = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBorrower = new Bunifu.Framework.UI.BunifuTileButton();
            this.bookListingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Mainform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_Mainform
            // 
            this.ms_Mainform.BackColor = System.Drawing.Color.LightGray;
            this.ms_Mainform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ms_Mainform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_Mainform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTERFILESToolStripMenuItem,
            this.uSERACCOUNTSMANAGERToolStripMenuItem,
            this.tRANSACTIONSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.ms_Mainform.Location = new System.Drawing.Point(0, 0);
            this.ms_Mainform.Name = "ms_Mainform";
            this.ms_Mainform.Size = new System.Drawing.Size(1350, 33);
            this.ms_Mainform.TabIndex = 0;
            this.ms_Mainform.Text = "menuStrip1";
            // 
            // mASTERFILESToolStripMenuItem
            // 
            this.mASTERFILESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.borrowersToolStripMenuItem,
            this.nonReadingMaterialsToolStripMenuItem,
            this.libraryUsersToolStripMenuItem});
            this.mASTERFILESToolStripMenuItem.Name = "mASTERFILESToolStripMenuItem";
            this.mASTERFILESToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.mASTERFILESToolStripMenuItem.Text = "MASTERFILES";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // borrowersToolStripMenuItem
            // 
            this.borrowersToolStripMenuItem.Name = "borrowersToolStripMenuItem";
            this.borrowersToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.borrowersToolStripMenuItem.Text = "Borrowers";
            this.borrowersToolStripMenuItem.Click += new System.EventHandler(this.borrowersToolStripMenuItem_Click);
            // 
            // nonReadingMaterialsToolStripMenuItem
            // 
            this.nonReadingMaterialsToolStripMenuItem.Name = "nonReadingMaterialsToolStripMenuItem";
            this.nonReadingMaterialsToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.nonReadingMaterialsToolStripMenuItem.Text = "Non-Reading Materials";
            this.nonReadingMaterialsToolStripMenuItem.Click += new System.EventHandler(this.nonReadingMaterialsToolStripMenuItem_Click);
            // 
            // libraryUsersToolStripMenuItem
            // 
            this.libraryUsersToolStripMenuItem.Name = "libraryUsersToolStripMenuItem";
            this.libraryUsersToolStripMenuItem.Size = new System.Drawing.Size(304, 30);
            this.libraryUsersToolStripMenuItem.Text = "Library Users";
            this.libraryUsersToolStripMenuItem.Click += new System.EventHandler(this.libraryUsersToolStripMenuItem_Click);
            // 
            // uSERACCOUNTSMANAGERToolStripMenuItem
            // 
            this.uSERACCOUNTSMANAGERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountsToolStripMenuItem,
            this.unapprovedUsersToolStripMenuItem});
            this.uSERACCOUNTSMANAGERToolStripMenuItem.Name = "uSERACCOUNTSMANAGERToolStripMenuItem";
            this.uSERACCOUNTSMANAGERToolStripMenuItem.Size = new System.Drawing.Size(253, 29);
            this.uSERACCOUNTSMANAGERToolStripMenuItem.Text = "ACCOUNTS MANAGER";
            // 
            // userAccountsToolStripMenuItem
            // 
            this.userAccountsToolStripMenuItem.Name = "userAccountsToolStripMenuItem";
            this.userAccountsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.userAccountsToolStripMenuItem.Text = "User Accounts";
            this.userAccountsToolStripMenuItem.Click += new System.EventHandler(this.userAccountsToolStripMenuItem_Click);
            // 
            // unapprovedUsersToolStripMenuItem
            // 
            this.unapprovedUsersToolStripMenuItem.Name = "unapprovedUsersToolStripMenuItem";
            this.unapprovedUsersToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.unapprovedUsersToolStripMenuItem.Text = "Unapproved Users";
            this.unapprovedUsersToolStripMenuItem.Click += new System.EventHandler(this.unapprovedUsersToolStripMenuItem_Click);
            // 
            // tRANSACTIONSToolStripMenuItem
            // 
            this.tRANSACTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBookToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.tRANSACTIONSToolStripMenuItem.Name = "tRANSACTIONSToolStripMenuItem";
            this.tRANSACTIONSToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.tRANSACTIONSToolStripMenuItem.Text = "TRANSACTIONS";
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.borrowBookToolStripMenuItem.Text = "Borrow Book";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListingsToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(156, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1182, 670);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrow.color = System.Drawing.Color.Transparent;
            this.btnBorrow.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.ImagePosition = 20;
            this.btnBorrow.ImageZoom = 50;
            this.btnBorrow.LabelPosition = 40;
            this.btnBorrow.LabelText = "BORROW";
            this.btnBorrow.Location = new System.Drawing.Point(8, 57);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(6);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(141, 139);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.color = System.Drawing.Color.Transparent;
            this.btnReturn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImagePosition = 20;
            this.btnReturn.ImageZoom = 50;
            this.btnReturn.LabelPosition = 40;
            this.btnReturn.LabelText = "RETURN";
            this.btnReturn.Location = new System.Drawing.Point(8, 224);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 139);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrower
            // 
            this.btnBorrower.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrower.color = System.Drawing.Color.Transparent;
            this.btnBorrower.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBorrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrower.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBorrower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnBorrower.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrower.Image")));
            this.btnBorrower.ImagePosition = 20;
            this.btnBorrower.ImageZoom = 50;
            this.btnBorrower.LabelPosition = 40;
            this.btnBorrower.LabelText = "BORROWERS";
            this.btnBorrower.Location = new System.Drawing.Point(8, 375);
            this.btnBorrower.Margin = new System.Windows.Forms.Padding(6);
            this.btnBorrower.Name = "btnBorrower";
            this.btnBorrower.Size = new System.Drawing.Size(141, 139);
            this.btnBorrower.TabIndex = 9;
            this.btnBorrower.Click += new System.EventHandler(this.btnBorrower_Click);
            // 
            // bookListingsToolStripMenuItem
            // 
            this.bookListingsToolStripMenuItem.Name = "bookListingsToolStripMenuItem";
            this.bookListingsToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.bookListingsToolStripMenuItem.Text = "Book Listings";
            this.bookListingsToolStripMenuItem.Click += new System.EventHandler(this.bookListingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnBorrower);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ms_Mainform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.ms_Mainform;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ms_Mainform.ResumeLayout(false);
            this.ms_Mainform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Mainform;
        private System.Windows.Forms.ToolStripMenuItem mASTERFILESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonReadingMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERACCOUNTSMANAGERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unapprovedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryUsersToolStripMenuItem;

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuTileButton btnBorrow;
        private Bunifu.Framework.UI.BunifuTileButton btnBorrower;
        private Bunifu.Framework.UI.BunifuTileButton btnReturn;
        private System.Windows.Forms.ToolStripMenuItem bookListingsToolStripMenuItem;
    }
}