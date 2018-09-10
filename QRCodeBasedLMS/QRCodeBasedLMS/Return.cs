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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsReturn r = new clsReturn();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private string decoded;
        private void btnReturn_Load(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                txt_BookIDNum.Enabled = false;
                btnScan.Text = "Scan Borrower";
            }
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbDevice.AddItem(Device.Name);
            }
            cmbDevice.selectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            btnCamera.Visible = false;

            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.selectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pb_ScanQR.Image = (Image)eventArgs.Frame.Clone();
        }

        private void txt_BorrowerID_OnValueChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Lastname).FirstOrDefault();
            txt_Name.Text = lname + ", " + fname;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }

        private void txt_BookIDNum_OnValueChanged(object sender, EventArgs e)
        {
            txt_Title.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Title).FirstOrDefault();
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_LastBorrowNumber().Count() + 1;
            string returnID = "RTN-" + x + "-" + dt.Day + dt.Month + dt.Year;
            string remarks = "";
            if (lblTotalFee.Text == "0")
            {
                remarks = "No Fee";
            }
            else
            {
                remarks = "Unpaid";
            }
            DialogResult res = MessageBox.Show("CONFIRM:\nReturn all books in the table?", "Return Book", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < dgvReturn.RowCount; i++)
                {
                    db.sp_ReturnBook(returnID, txt_BorrowerID.Text, dgvReturn.Rows[i].Cells[1].Value.ToString(), dt, int.Parse(dgvReturn.Rows[i].Cells[4].Value.ToString()), decimal.Parse(dgvReturn.Rows[i].Cells[5].Value.ToString()), remarks);
                }

                MessageBox.Show("Successully Returned Books!");

                txt_BookIDNum.Text = null;
                txt_BorrowerID.Text = null;
                MainForm main = new MainForm();
                main.Show();
                this.Close();
            }
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
                    if (txt_Name.Text == "")
                    {
                        txt_BorrowerID.Text = decoded;
                        if (txt_Name.Text != "") { btnScan.Text = "Scan Book"; }
                    }
                    else
                    {
                        txt_BookIDNum.Text = decoded;

                        // usbunon ang name sa db since giusab ang column name
                        //int borrowID = db.sp_GetBorrowIDForReturn(txt_BorrowerID.Text, txt_BookIDNum.Text);
                        //DateTime due = (from s in db.tblBorrows where s.borrow_BorrowID == borrowID select s.borrow_DueDate).FirstOrDefault();
                        //DateTime dt = DateTime.Now;
                        //int diff = (dt - due).Days;
                        //if (diff < 0) { diff = 0; }
                        //double penalty = 0;
                        //if ((diff * 3) < 0) { penalty = 0; }
                        //else { penalty = diff * 3; }

                        ////-----
                        //clsReturnBindingSource.Add(new clsReturn() {BookIDNum = txt_BookIDNum.Text, BookTitle = txt_Title.Text, DueDate = due, NoOfDaysUnreturned = diff, PenaltyFee = penalty });
                        //GetTotalPenalty();
                        //btnScan.Text = "Scan Another Book";
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
        public void GetTotalPenalty()
        {
            int sum = 0;
            for (int i = 0; i < dgvReturn.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvReturn.Rows[i].Cells[5].Value);
            }
            lblTotalFee.Text = sum.ToString();
        }

        private void btnReturn_FormClosing(object sender, FormClosingEventArgs e)
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
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.selectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btnCamera.Visible = false;
        }

        private void cmbDevice_onItemSelected(object sender, EventArgs e)
        {
            btnCamera.Visible = true;
        }

        private void dgvReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvReturn.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    clsReturnBindingSource.RemoveCurrent();
                    btnScan.Text = "Scan Another Book";
                    GetTotalPenalty();
                }
            }
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
    }
}
