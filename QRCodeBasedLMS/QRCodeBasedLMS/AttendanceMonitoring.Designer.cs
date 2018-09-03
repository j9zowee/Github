namespace QRCodeBasedLMS
{
    partial class AttendanceMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceMonitoring));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_SchoolID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.link_ScanQR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Student ID Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name :";
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Back.Location = new System.Drawing.Point(274, 9);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(60, 16);
            this.link_Back.TabIndex = 33;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Go Back";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ScanQR.Location = new System.Drawing.Point(1, 1);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(130, 130);
            this.pb_ScanQR.TabIndex = 36;
            this.pb_ScanQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "OR";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Submit.BorderRadius = 7;
            this.btn_Submit.ButtonText = "SUBMIT";
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Submit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Submit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Submit.Iconimage")));
            this.btn_Submit.Iconimage_right = null;
            this.btn_Submit.Iconimage_right_Selected = null;
            this.btn_Submit.Iconimage_Selected = null;
            this.btn_Submit.IconMarginLeft = 0;
            this.btn_Submit.IconMarginRight = 0;
            this.btn_Submit.IconRightVisible = false;
            this.btn_Submit.IconRightZoom = 0D;
            this.btn_Submit.IconVisible = true;
            this.btn_Submit.IconZoom = 40D;
            this.btn_Submit.IsTab = false;
            this.btn_Submit.Location = new System.Drawing.Point(215, 283);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btn_Submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btn_Submit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Submit.selected = false;
            this.btn_Submit.Size = new System.Drawing.Size(108, 40);
            this.btn_Submit.TabIndex = 39;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Submit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btn_Submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Name.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Name.BorderThickness = 1;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Name.isPassword = false;
            this.txt_Name.Location = new System.Drawing.Point(70, 244);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(253, 22);
            this.txt_Name.TabIndex = 40;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SchoolID
            // 
            this.txt_SchoolID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SchoolID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolID.BorderThickness = 1;
            this.txt_SchoolID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SchoolID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchoolID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SchoolID.isPassword = false;
            this.txt_SchoolID.Location = new System.Drawing.Point(144, 215);
            this.txt_SchoolID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SchoolID.Name = "txt_SchoolID";
            this.txt_SchoolID.Size = new System.Drawing.Size(179, 22);
            this.txt_SchoolID.TabIndex = 41;
            this.txt_SchoolID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SchoolID.OnValueChanged += new System.EventHandler(this.txt_SchoolID_OnValueChanged);
            // 
            // link_ScanQR
            // 
            this.link_ScanQR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanQR.BackColor = System.Drawing.Color.Transparent;
            this.link_ScanQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_ScanQR.BorderRadius = 7;
            this.link_ScanQR.ButtonText = "Scan Library Card";
            this.link_ScanQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ScanQR.DisabledColor = System.Drawing.Color.Gray;
            this.link_ScanQR.Iconcolor = System.Drawing.Color.Transparent;
            this.link_ScanQR.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_ScanQR.Iconimage")));
            this.link_ScanQR.Iconimage_right = null;
            this.link_ScanQR.Iconimage_right_Selected = null;
            this.link_ScanQR.Iconimage_Selected = null;
            this.link_ScanQR.IconMarginLeft = 0;
            this.link_ScanQR.IconMarginRight = 0;
            this.link_ScanQR.IconRightVisible = false;
            this.link_ScanQR.IconRightZoom = 0D;
            this.link_ScanQR.IconVisible = false;
            this.link_ScanQR.IconZoom = 110D;
            this.link_ScanQR.IsTab = false;
            this.link_ScanQR.Location = new System.Drawing.Point(85, 367);
            this.link_ScanQR.Name = "link_ScanQR";
            this.link_ScanQR.Normalcolor = System.Drawing.Color.Transparent;
            this.link_ScanQR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanQR.OnHoverTextColor = System.Drawing.Color.White;
            this.link_ScanQR.selected = false;
            this.link_ScanQR.Size = new System.Drawing.Size(176, 22);
            this.link_ScanQR.TabIndex = 42;
            this.link_ScanQR.Text = "Scan Library Card";
            this.link_ScanQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ScanQR.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_ScanQR.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.link_ScanQR.Click += new System.EventHandler(this.link_ScanQR_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.pb_ScanQR);
            this.panel3.Location = new System.Drawing.Point(111, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 132);
            this.panel3.TabIndex = 66;
            // 
            // AttendanceMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(346, 407);
            this.Controls.Add(this.link_ScanQR);
            this.Controls.Add(this.txt_SchoolID);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceMonitoring";
            this.Load += new System.EventHandler(this.AttendanceMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Submit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SchoolID;
        private Bunifu.Framework.UI.BunifuFlatButton link_ScanQR;
        private System.Windows.Forms.Panel panel3;
    }
}