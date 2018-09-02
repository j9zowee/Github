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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_SchoolID = new System.Windows.Forms.TextBox();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.link_ScanQR = new System.Windows.Forms.LinkLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Names = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_SchoolIDs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.link_ScanQRs = new Bunifu.Framework.UI.BunifuFlatButton();
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
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(82, 247);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(194, 22);
            this.txt_Name.TabIndex = 25;
            // 
            // txt_SchoolID
            // 
            this.txt_SchoolID.Location = new System.Drawing.Point(82, 220);
            this.txt_SchoolID.Name = "txt_SchoolID";
            this.txt_SchoolID.Size = new System.Drawing.Size(121, 20);
            this.txt_SchoolID.TabIndex = 32;
            this.txt_SchoolID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 40);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // link_ScanQR
            // 
            this.link_ScanQR.AutoSize = true;
            this.link_ScanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ScanQR.Location = new System.Drawing.Point(119, 371);
            this.link_ScanQR.Name = "link_ScanQR";
            this.link_ScanQR.Size = new System.Drawing.Size(115, 16);
            this.link_ScanQR.TabIndex = 38;
            this.link_ScanQR.TabStop = true;
            this.link_ScanQR.Text = "Scan Library Card";
            this.link_ScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ScanQR_LinkClicked);
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
            this.btn_Submit.Location = new System.Drawing.Point(170, 294);
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
            // 
            // txt_Names
            // 
            this.txt_Names.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Names.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Names.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Names.BorderThickness = 1;
            this.txt_Names.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Names.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Names.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Names.isPassword = false;
            this.txt_Names.Location = new System.Drawing.Point(144, 250);
            this.txt_Names.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Names.Name = "txt_Names";
            this.txt_Names.Size = new System.Drawing.Size(189, 22);
            this.txt_Names.TabIndex = 40;
            this.txt_Names.Text = "for txt_Name";
            this.txt_Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SchoolIDs
            // 
            this.txt_SchoolIDs.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolIDs.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SchoolIDs.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SchoolIDs.BorderThickness = 1;
            this.txt_SchoolIDs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SchoolIDs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SchoolIDs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SchoolIDs.isPassword = false;
            this.txt_SchoolIDs.Location = new System.Drawing.Point(144, 220);
            this.txt_SchoolIDs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SchoolIDs.Name = "txt_SchoolIDs";
            this.txt_SchoolIDs.Size = new System.Drawing.Size(189, 22);
            this.txt_SchoolIDs.TabIndex = 41;
            this.txt_SchoolIDs.Text = "for txt_SchoolID";
            this.txt_SchoolIDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // link_ScanQRs
            // 
            this.link_ScanQRs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanQRs.BackColor = System.Drawing.Color.Transparent;
            this.link_ScanQRs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_ScanQRs.BorderRadius = 7;
            this.link_ScanQRs.ButtonText = "Scan Library Card";
            this.link_ScanQRs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ScanQRs.DisabledColor = System.Drawing.Color.Gray;
            this.link_ScanQRs.Iconcolor = System.Drawing.Color.Transparent;
            this.link_ScanQRs.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_ScanQRs.Iconimage")));
            this.link_ScanQRs.Iconimage_right = null;
            this.link_ScanQRs.Iconimage_right_Selected = null;
            this.link_ScanQRs.Iconimage_Selected = null;
            this.link_ScanQRs.IconMarginLeft = 0;
            this.link_ScanQRs.IconMarginRight = 0;
            this.link_ScanQRs.IconRightVisible = false;
            this.link_ScanQRs.IconRightZoom = 0D;
            this.link_ScanQRs.IconVisible = false;
            this.link_ScanQRs.IconZoom = 110D;
            this.link_ScanQRs.IsTab = false;
            this.link_ScanQRs.Location = new System.Drawing.Point(163, 381);
            this.link_ScanQRs.Name = "link_ScanQRs";
            this.link_ScanQRs.Normalcolor = System.Drawing.Color.Transparent;
            this.link_ScanQRs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_ScanQRs.OnHoverTextColor = System.Drawing.Color.White;
            this.link_ScanQRs.selected = false;
            this.link_ScanQRs.Size = new System.Drawing.Size(176, 22);
            this.link_ScanQRs.TabIndex = 42;
            this.link_ScanQRs.Text = "Scan Library Card";
            this.link_ScanQRs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ScanQRs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_ScanQRs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.Controls.Add(this.link_ScanQRs);
            this.Controls.Add(this.txt_SchoolIDs);
            this.Controls.Add(this.txt_Names);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.link_ScanQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.txt_SchoolID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
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
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_SchoolID;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_ScanQR;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Submit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Names;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SchoolIDs;
        private Bunifu.Framework.UI.BunifuFlatButton link_ScanQRs;
        private System.Windows.Forms.Panel panel3;
    }
}