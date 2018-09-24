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
        private string usertype;
        public Return(string type)
        {
            InitializeComponent();
            usertype = type;
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
                txt_AccNum.Enabled = false;
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

            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
            else FinalFrame.Stop();
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.selectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            if (dgvReturn.Rows.Count == 0) btnReturn.Enabled = false;
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
            txt_Title.Text = (from book in db.tblBooks join copy in db.tblBookCopies on book.book_BookID equals copy.book_BookID where copy.copy_AccNum == txt_AccNum.Text select book.book_Title).FirstOrDefault();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
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
                    db.sp_ReturnBook(r.GenerateIDNumber(), txt_BorrowerID.Text, dgvReturn.Rows[i].Cells[1].Value.ToString(), dt, int.Parse(dgvReturn.Rows[i].Cells[4].Value.ToString()), decimal.Parse(dgvReturn.Rows[i].Cells[5].Value.ToString()), remarks);
                    db.sp_UpdateBookStatus(dgvReturn.Rows[i].Cells[1].Value.ToString(), "Available");
                }

                MessageBox.Show("Successully Returned Books!");

                txt_AccNum.Text = null;
                txt_BorrowerID.Text = null;
                MainForm main = new MainForm(usertype);
                main.Show();
                this.Hide();
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
                        var fname = (from s in db.tblLibraryUsers where s.lib_SchoolID == decoded select s.lib_Firstname).FirstOrDefault();
                        var lname = (from s in db.tblLibraryUsers where s.lib_SchoolID == decoded select s.lib_Lastname).FirstOrDefault();
                        if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname))
                        {
                            MessageBox.Show("Invalid SchoolID.");
                        }
                        else
                        {
                            txt_BorrowerID.Text = decoded;
                            btnScan.Text = "Scan Book";
                        }
                    }
                    else
                    {
                        var title = (from book in db.tblBooks join copy in db.tblBookCopies on book.book_BookID equals copy.book_BookID where copy.copy_AccNum == decoded select book.book_Title).FirstOrDefault();
                        if (string.IsNullOrWhiteSpace(title))
                        {
                            MessageBox.Show("Invalid Accession Number!");
                        }
                        else
                        {
                            txt_AccNum.Text = decoded;

                            int borrowID = db.sp_GetBorrowIDForReturn(txt_BorrowerID.Text, txt_AccNum.Text);
                            DateTime due = (from s in db.tblBorrows where s.borrow_BorrowID == borrowID select s.borrow_DueDate).FirstOrDefault();
                            DateTime dt = DateTime.Now;
                            int diff = (dt - due).Days;
                            if (diff < 0) { diff = 0; }
                            double penalty = 0;
                            if ((diff * 3) < 0) { penalty = 0; }
                            else { penalty = diff * 3; }

                            //-----
                            clsReturnBindingSource.Add(new clsReturn() { AccessionNumber = txt_AccNum.Text, BookTitle = txt_Title.Text, DueDate = due, NoOfDaysUnreturned = diff, PenaltyFee = penalty });
                            GetTotalPenalty();
                            btnScan.Text = "Scan Another Book";
                        }
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
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
            else FinalFrame.Stop();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
            else FinalFrame.Stop();
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
                    if (dgvReturn.Rows.Count == 0) btnReturn.Enabled = false;
                }
            }
        }
        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usertype);
            main.Show();
            this.Hide();
        }
    }
}
