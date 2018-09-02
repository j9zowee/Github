using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace QRCodeBasedLMS
{
    public partial class ScanQRCode : Form
    {
        private string gikan;
        private string Z;
        public ScanQRCode(string ginikanan, string x)
        {
            InitializeComponent();
            gikan = ginikanan;
            Z = x;
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private string decoded;
        private void ScanQRCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbDevice.Items.Add(Device.Name);
            }
            cmbDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            btnCamera.Visible = false;

            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pb_ScanQR.Image = (Image)eventArgs.Frame.Clone();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pb_ScanQR.Image);
            try
            {
                decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    timer.Stop();
                    MessageBox.Show("Success");
                    if (gikan == "book")
                    {

                        Book bk = new Book(decoded);
                        bk.Show();
                        this.Close();
                    }
                    else if (gikan == "index-borrow")
                    {
                        Borrow br = new Borrow(decoded,"");
                        br.Show();
                        this.Close();
                    }
                    else if (gikan == "borrowform")
                    {
                        Borrow br = new Borrow(Z,decoded);
                        br.Show();
                        this.Close();
                    }
                    else if (gikan == "borrower_bk")
                    {
                        Borrower br = new Borrower(decoded, "borrower_bk");
                        br.Show();
                        this.Close();
                    }
                    else if (gikan == "borrower_brwr")
                    {
                        Borrower br = new Borrower(decoded, "borrower_brwr");
                        br.Show();
                        this.Close();
                    }
                    else if (gikan == "userinfo")
                    {
                        UserInformation ui = new UserInformation(decoded);
                        ui.Show();
                        this.Close();
                    }
                    else if (gikan == "inactiveusers")
                    {
                        UnapprovedAccounts ua = new UnapprovedAccounts(decoded);
                        ua.Show();
                        this.Close();
                    }
                    else if (gikan == "attendance")
                    {
                        AttendanceMonitoring am = new AttendanceMonitoring(decoded);
                        am.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Destination");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to cancel? ", "Borrow Book", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void ScanQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btnCamera.Visible = false;
        }

        private void cmbDevice_TextChanged(object sender, EventArgs e)
        {
            btnCamera.Visible = true;
        }
    }
}
