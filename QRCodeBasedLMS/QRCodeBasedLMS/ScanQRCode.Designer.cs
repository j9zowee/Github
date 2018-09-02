namespace QRCodeBasedLMS
{
    partial class ScanQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanQRCode));
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCameras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbDevices = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCancels = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnScans = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(116, 389);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 29);
            this.btnScan.TabIndex = 37;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(12, 12);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(298, 21);
            this.cmbDevice.TabIndex = 36;
            this.cmbDevice.TextChanged += new System.EventHandler(this.cmbDevice_TextChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(329, 7);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(90, 29);
            this.btnCamera.TabIndex = 40;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_ScanQR.Location = new System.Drawing.Point(12, 49);
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
            // btnCameras
            // 
            this.btnCameras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCameras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCameras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCameras.BorderRadius = 7;
            this.btnCameras.ButtonText = "Start Camera";
            this.btnCameras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCameras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCameras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCameras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCameras.Iconimage")));
            this.btnCameras.Iconimage_right = null;
            this.btnCameras.Iconimage_right_Selected = null;
            this.btnCameras.Iconimage_Selected = null;
            this.btnCameras.IconMarginLeft = 0;
            this.btnCameras.IconMarginRight = 0;
            this.btnCameras.IconRightVisible = false;
            this.btnCameras.IconRightZoom = 0D;
            this.btnCameras.IconVisible = true;
            this.btnCameras.IconZoom = 80D;
            this.btnCameras.IsTab = false;
            this.btnCameras.Location = new System.Drawing.Point(325, 29);
            this.btnCameras.Name = "btnCameras";
            this.btnCameras.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCameras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCameras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCameras.selected = false;
            this.btnCameras.Size = new System.Drawing.Size(129, 41);
            this.btnCameras.TabIndex = 59;
            this.btnCameras.Text = "Start Camera";
            this.btnCameras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCameras.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnCameras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // cmbDevices
            // 
            this.cmbDevices.BackColor = System.Drawing.Color.Transparent;
            this.cmbDevices.BorderRadius = 3;
            this.cmbDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmbDevices.DisabledColor = System.Drawing.Color.Gray;
            this.cmbDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmbDevices.Items = new string[] {
        "for cmbDevice"};
            this.cmbDevices.Location = new System.Drawing.Point(12, 29);
            this.cmbDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmbDevices.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmbDevices.selectedIndex = 0;
            this.cmbDevices.Size = new System.Drawing.Size(298, 24);
            this.cmbDevices.TabIndex = 62;
            // 
            // btnCancels
            // 
            this.btnCancels.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCancels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCancels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancels.BorderRadius = 7;
            this.btnCancels.ButtonText = "CANCEL";
            this.btnCancels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancels.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancels.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancels.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancels.Iconimage")));
            this.btnCancels.Iconimage_right = null;
            this.btnCancels.Iconimage_right_Selected = null;
            this.btnCancels.Iconimage_Selected = null;
            this.btnCancels.IconMarginLeft = 0;
            this.btnCancels.IconMarginRight = 0;
            this.btnCancels.IconRightVisible = false;
            this.btnCancels.IconRightZoom = 0D;
            this.btnCancels.IconVisible = true;
            this.btnCancels.IconZoom = 80D;
            this.btnCancels.IsTab = false;
            this.btnCancels.Location = new System.Drawing.Point(229, 354);
            this.btnCancels.Name = "btnCancels";
            this.btnCancels.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnCancels.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnCancels.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancels.selected = false;
            this.btnCancels.Size = new System.Drawing.Size(110, 41);
            this.btnCancels.TabIndex = 80;
            this.btnCancels.Text = "CANCEL";
            this.btnCancels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancels.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnCancels.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btnScans
            // 
            this.btnScans.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScans.BorderRadius = 7;
            this.btnScans.ButtonText = "SCAN";
            this.btnScans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScans.DisabledColor = System.Drawing.Color.Gray;
            this.btnScans.Iconcolor = System.Drawing.Color.Transparent;
            this.btnScans.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnScans.Iconimage")));
            this.btnScans.Iconimage_right = null;
            this.btnScans.Iconimage_right_Selected = null;
            this.btnScans.Iconimage_Selected = null;
            this.btnScans.IconMarginLeft = 0;
            this.btnScans.IconMarginRight = 0;
            this.btnScans.IconRightVisible = false;
            this.btnScans.IconRightZoom = 0D;
            this.btnScans.IconVisible = true;
            this.btnScans.IconZoom = 80D;
            this.btnScans.IsTab = false;
            this.btnScans.Location = new System.Drawing.Point(105, 354);
            this.btnScans.Name = "btnScans";
            this.btnScans.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnScans.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnScans.OnHoverTextColor = System.Drawing.Color.White;
            this.btnScans.selected = false;
            this.btnScans.Size = new System.Drawing.Size(110, 41);
            this.btnScans.TabIndex = 79;
            this.btnScans.Text = "SCAN";
            this.btnScans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScans.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnScans.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // ScanQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(473, 433);
            this.Controls.Add(this.btnCancels);
            this.Controls.Add(this.btnScans);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.btnCameras);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pb_ScanQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScanQRCode";
            this.Text = "ScanQRCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanQRCode_FormClosing);
            this.Load += new System.EventHandler(this.ScanQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCameras;
        private Bunifu.Framework.UI.BunifuDropdown cmbDevices;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancels;
        private Bunifu.Framework.UI.BunifuFlatButton btnScans;
    }
}