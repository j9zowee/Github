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
        public string schoolyear;
        public string brwrtype;
        private string origin;
        private string usertype;
        public ScanQRCode(string type,string org)
        {
            InitializeComponent();
            usertype = type;
            origin = org;
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private string decoded;
        private void ScanQRCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbDevice.AddItem(Device.Name);
            }
            cmbDevice.selectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            btnCamera.Visible = false;
            
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.selectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pb_ScanQR.Image = (Image)eventArgs.Frame.Clone();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //BarcodeReader Reader = new BarcodeReader();
            //Result result = Reader.Decode((Bitmap)pb_ScanQR.Image);
            try
            {
                Bitmap bitmap = new Bitmap(pb_ScanQR.Image);
                BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryInverted = true };
                Result result = reader.Decode(bitmap);
                decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    timer.Stop();
                    if (origin == "book")
                    {

                        Book bk = new Book(usertype, decoded);
                        bk.Show();
                        this.Close();
                    }
                    else if (origin == "booksearch")
                    {
                        BookSearch bs = new BookSearch(usertype,decoded);
                        bs.Show();
                        this.Close();
                    }
                    else if (origin == "brwr")
                    {
                        Borrower br = new Borrower(usertype, decoded);
                        br.sy = schoolyear;
                        br.bt = brwrtype;
                        br.Show();
                        this.Close();
                    }
                    else if (origin == "inquiry")
                    {
                        Inquiry inq = new Inquiry(decoded);
                        inq.Show();
                        this.Close();
                    }
                    else if (origin == "attendance")
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
                timer.Stop();
                MessageBox.Show("No QR code detected.");
            }
        }
        
        private void ScanQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }
        
        private void cmbDevice_TextChanged(object sender, EventArgs e)
        {
            btnCamera.Visible = true;
        }

        private void btnCameras_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.selectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btnCamera.Visible = false;
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
                if(origin== "inquiry")
                {
                    IndexForm index = new IndexForm();
                    index.Show();
                    this.Hide();
                }
            }
        }
    }
}
