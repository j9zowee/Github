namespace QRCodeBasedLMS
{
    partial class btnScanQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnScanQRCode));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCamera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbDevice = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnScan = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_ScanQR.Location = new System.Drawing.Point(12, 60);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(442, 323);
            this.pb_ScanQR.TabIndex = 38;
            this.pb_ScanQR.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnCamera
            // 
            this.btnCamera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.BorderRadius = 7;
            this.btnCamera.ButtonText = "Start Camera";
            this.btnCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamera.DisabledColor = System.Drawing.Color.Gray;
            this.btnCamera.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCamera.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCamera.Iconimage")));
            this.btnCamera.Iconimage_right = null;
            this.btnCamera.Iconimage_right_Selected = null;
            this.btnCamera.Iconimage_Selected = null;
            this.btnCamera.IconMarginLeft = 0;
            this.btnCamera.IconMarginRight = 0;
            this.btnCamera.IconRightVisible = false;
            this.btnCamera.IconRightZoom = 0D;
            this.btnCamera.IconVisible = true;
            this.btnCamera.IconZoom = 80D;
            this.btnCamera.IsTab = false;
            this.btnCamera.Location = new System.Drawing.Point(317, 12);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCamera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCamera.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCamera.selected = false;
            this.btnCamera.Size = new System.Drawing.Size(129, 41);
            this.btnCamera.TabIndex = 59;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCamera.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnCamera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCameras_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.BackColor = System.Drawing.Color.Transparent;
            this.cmbDevice.BorderRadius = 3;
            this.cmbDevice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbDevice.DisabledColor = System.Drawing.Color.Gray;
            this.cmbDevice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbDevice.Items = new string[0];
            this.cmbDevice.Location = new System.Drawing.Point(12, 22);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbDevice.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbDevice.selectedIndex = -1;
            this.cmbDevice.Size = new System.Drawing.Size(298, 24);
            this.cmbDevice.TabIndex = 62;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.ButtonText = "CANCEL";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = false;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 80D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(232, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(110, 41);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnScan
            // 
            this.btnScan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.BorderRadius = 7;
            this.btnScan.ButtonText = "SCAN";
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.DisabledColor = System.Drawing.Color.Gray;
            this.btnScan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnScan.Iconimage")));
            this.btnScan.Iconimage_right = null;
            this.btnScan.Iconimage_right_Selected = null;
            this.btnScan.Iconimage_Selected = null;
            this.btnScan.IconMarginLeft = 0;
            this.btnScan.IconMarginRight = 0;
            this.btnScan.IconRightVisible = false;
            this.btnScan.IconRightZoom = 0D;
            this.btnScan.IconVisible = true;
            this.btnScan.IconZoom = 80D;
            this.btnScan.IsTab = false;
            this.btnScan.Location = new System.Drawing.Point(100, 400);
            this.btnScan.Name = "btnScan";
            this.btnScan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScan.selected = false;
            this.btnScan.Size = new System.Drawing.Size(110, 41);
            this.btnScan.TabIndex = 79;
            this.btnScan.Text = "SCAN";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnScan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnScanQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(472, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.pb_ScanQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnScanQRCode";
            this.Text = "ScanQRCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanQRCode_FormClosing);
            this.Load += new System.EventHandler(this.ScanQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCamera;
        private Bunifu.Framework.UI.BunifuDropdown cmbDevice;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnScan;
    }
}