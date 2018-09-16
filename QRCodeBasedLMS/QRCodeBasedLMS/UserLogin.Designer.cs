namespace QRCodeBasedLMS
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link_ForgotPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grpCreateSuperAdmin = new System.Windows.Forms.GroupBox();
            this.btnCreateSuperAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grpCreateSuperAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(131, 90);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(131, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 7;
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = false;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 40D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(202, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(108, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(47, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Username :";
            // 
            // link_ForgotPassword
            // 
            this.link_ForgotPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.link_ForgotPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_ForgotPassword.BorderRadius = 7;
            this.link_ForgotPassword.ButtonText = "Forgot Password?";
            this.link_ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ForgotPassword.DisabledColor = System.Drawing.Color.Gray;
            this.link_ForgotPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.link_ForgotPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_ForgotPassword.Iconimage")));
            this.link_ForgotPassword.Iconimage_right = null;
            this.link_ForgotPassword.Iconimage_right_Selected = null;
            this.link_ForgotPassword.Iconimage_Selected = null;
            this.link_ForgotPassword.IconMarginLeft = 0;
            this.link_ForgotPassword.IconMarginRight = 0;
            this.link_ForgotPassword.IconRightVisible = false;
            this.link_ForgotPassword.IconRightZoom = 0D;
            this.link_ForgotPassword.IconVisible = false;
            this.link_ForgotPassword.IconZoom = 110D;
            this.link_ForgotPassword.IsTab = false;
            this.link_ForgotPassword.Location = new System.Drawing.Point(50, 205);
            this.link_ForgotPassword.Name = "link_ForgotPassword";
            this.link_ForgotPassword.Normalcolor = System.Drawing.Color.Transparent;
            this.link_ForgotPassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ForgotPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.link_ForgotPassword.selected = false;
            this.link_ForgotPassword.Size = new System.Drawing.Size(107, 22);
            this.link_ForgotPassword.TabIndex = 4;
            this.link_ForgotPassword.Text = "Forgot Password?";
            this.link_ForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ForgotPassword.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_ForgotPassword.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ForgotPassword.Click += new System.EventHandler(this.link_ForgotPassword_Click);
            // 
            // linkSignUp
            // 
            this.linkSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.linkSignUp.BackColor = System.Drawing.Color.Transparent;
            this.linkSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.linkSignUp.BorderRadius = 7;
            this.linkSignUp.ButtonText = "Sign Up";
            this.linkSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkSignUp.DisabledColor = System.Drawing.Color.Gray;
            this.linkSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.linkSignUp.Iconimage = ((System.Drawing.Image)(resources.GetObject("linkSignUp.Iconimage")));
            this.linkSignUp.Iconimage_right = null;
            this.linkSignUp.Iconimage_right_Selected = null;
            this.linkSignUp.Iconimage_Selected = null;
            this.linkSignUp.IconMarginLeft = 0;
            this.linkSignUp.IconMarginRight = 0;
            this.linkSignUp.IconRightVisible = false;
            this.linkSignUp.IconRightZoom = 0D;
            this.linkSignUp.IconVisible = false;
            this.linkSignUp.IconZoom = 110D;
            this.linkSignUp.IsTab = false;
            this.linkSignUp.Location = new System.Drawing.Point(192, 12);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Normalcolor = System.Drawing.Color.Transparent;
            this.linkSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.linkSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.linkSignUp.selected = false;
            this.linkSignUp.Size = new System.Drawing.Size(72, 22);
            this.linkSignUp.TabIndex = 6;
            this.linkSignUp.Text = "Sign Up";
            this.linkSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkSignUp.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.linkSignUp.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.Click += new System.EventHandler(this.linkSignUp_Click);
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
            this.link_GoBack.Location = new System.Drawing.Point(270, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(72, 22);
            this.link_GoBack.TabIndex = 5;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // grpCreateSuperAdmin
            // 
            this.grpCreateSuperAdmin.Controls.Add(this.btnCreateSuperAdmin);
            this.grpCreateSuperAdmin.Location = new System.Drawing.Point(38, 64);
            this.grpCreateSuperAdmin.Name = "grpCreateSuperAdmin";
            this.grpCreateSuperAdmin.Size = new System.Drawing.Size(272, 125);
            this.grpCreateSuperAdmin.TabIndex = 44;
            this.grpCreateSuperAdmin.TabStop = false;
            // 
            // btnCreateSuperAdmin
            // 
            this.btnCreateSuperAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCreateSuperAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCreateSuperAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateSuperAdmin.BorderRadius = 7;
            this.btnCreateSuperAdmin.ButtonText = "CREATE SUPER ADMIN ACCOUNT";
            this.btnCreateSuperAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSuperAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreateSuperAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreateSuperAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreateSuperAdmin.Iconimage")));
            this.btnCreateSuperAdmin.Iconimage_right = null;
            this.btnCreateSuperAdmin.Iconimage_right_Selected = null;
            this.btnCreateSuperAdmin.Iconimage_Selected = null;
            this.btnCreateSuperAdmin.IconMarginLeft = 0;
            this.btnCreateSuperAdmin.IconMarginRight = 0;
            this.btnCreateSuperAdmin.IconRightVisible = false;
            this.btnCreateSuperAdmin.IconRightZoom = 0D;
            this.btnCreateSuperAdmin.IconVisible = true;
            this.btnCreateSuperAdmin.IconZoom = 50D;
            this.btnCreateSuperAdmin.IsTab = false;
            this.btnCreateSuperAdmin.Location = new System.Drawing.Point(29, 37);
            this.btnCreateSuperAdmin.Name = "btnCreateSuperAdmin";
            this.btnCreateSuperAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCreateSuperAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCreateSuperAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreateSuperAdmin.selected = false;
            this.btnCreateSuperAdmin.Size = new System.Drawing.Size(204, 62);
            this.btnCreateSuperAdmin.TabIndex = 45;
            this.btnCreateSuperAdmin.Text = "CREATE SUPER ADMIN ACCOUNT";
            this.btnCreateSuperAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateSuperAdmin.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnCreateSuperAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCreateSuperAdmin.Click += new System.EventHandler(this.btnCreateSuperAdmin_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(354, 271);
            this.Controls.Add(this.grpCreateSuperAdmin);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.link_ForgotPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.grpCreateSuperAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton link_ForgotPassword;
        private Bunifu.Framework.UI.BunifuFlatButton linkSignUp;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
        private System.Windows.Forms.GroupBox grpCreateSuperAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreateSuperAdmin;
    }
}