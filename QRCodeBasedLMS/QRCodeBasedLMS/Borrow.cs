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
    public partial class Borrow : Form
    {
        private string origin;
        public Borrow(string org)
        {
            InitializeComponent();
            origin = org;
        }
        
        dcLMSDataContext db = new dcLMSDataContext();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private string decoded;
        private void Borrow_Load(object sender, EventArgs e)
        {
            this.Refresh();
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
            if (dgvBorrow.Rows.Count == 0) btnBorrows.Enabled = false;
        }
        private void FinalFrame_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pb_ScanQR.Image = (Image)eventArgs.Frame.Clone();
        }
        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBorrow.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    clsBorrowBindingSource.RemoveCurrent();
                    btnScan.Text = "Scan Another Book";
                    if(dgvBorrow.Rows.Count == 0) btnBorrows.Enabled = false;
                }
            }
        }
        
        private void txt_BorrowerIDs_OnValueChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Lastname).FirstOrDefault();
            txt_Name.Text = lname + ", " + fname;
        }
        private void btnScans_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string currentSY = (from s in db.tblLibraryUsers select s.lib_SchoolYear).Max();
            Boolean withcard = Boolean.Parse((from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text && s.lib_SchoolYear == currentSY select s.lib_WithCard).FirstOrDefault().ToString());
            DateTime lastlogin = DateTime.Parse((from s in db.tblAttendances where s.attendance_StudentIDNum == txt_BorrowerID.Text select s.attendance_LoginTime).Max().ToString());
            if (withcard == false)
            {
                MessageBox.Show("You are using an invalid library card. Please print a new one.");
            }
            else
            {
                if (lastlogin.Date != dt.Date)
                {
                    MessageBox.Show("Your library attendance should be taken first before you can borrow a book from the library.\n Please proceed to the library entrance to scan your card.");
                }
                else
                {
                    if ((db.sp_BorrowedBooks(txt_BorrowerID.Text).Count() + dgvBorrow.Rows.Count) <= 3)
                    {
                        int x = db.sp_LastBorrowNumber().Count() + 1;
                        string borrowID = "BRW-" + x + "-" + dt.Day + dt.Month + dt.Year;
                        DialogResult res = MessageBox.Show("CONFIRM:\nDo you want to borrow all the books in the table?", "Borrow Book", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            for (int i = 0; i < dgvBorrow.RowCount; i++)
                            {
                                db.sp_BorrowBook(borrowID, txt_BorrowerID.Text, dgvBorrow.Rows[i].Cells[1].Value.ToString(), dt, DateTime.Parse(dgvBorrow.Rows[i].Cells[3].Value.ToString()), currentSY);
                                db.sp_UpdateBookStatus(dgvBorrow.Rows[i].Cells[1].Value.ToString(), "Borrowed");
                            }

                            MessageBox.Show("Successully Borrowed!");
                            txtAccNumber.Text = "";
                            txt_BorrowerID.Text = "";
                            if (origin == "index")
                            {
                                IndexForm index = new IndexForm();
                                index.Show();
                                this.Hide();
                            }
                            else
                            {
                                MainForm main = new MainForm("");
                                main.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can only borrow 3 books at a time. You already have " + db.sp_BorrowedBooks(txt_BorrowerID.Text) + " borrowed books.\nIf you wish to borrow more books, please return some of the borrowed books to the librarian.");
                    }
                }
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
                    if(txt_Name.Text == "")
                    {
                        var fname = (from s in db.tblLibraryUsers where s.lib_SchoolID == decoded select s.lib_Firstname).FirstOrDefault();
                        var lname = (from s in db.tblLibraryUsers where s.lib_SchoolID == decoded select s.lib_Lastname).FirstOrDefault();
                        if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname))
                        {
                            MessageBox.Show("Invalid SchoolID.");
                        }
                        else
                        {
                            txt_Name.Text = lname + ", " + fname;
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
                            txtAccNumber.Text = decoded;
                            DateTime dt = DateTime.Now;
                            DateTime due = dt.AddDays(3);
                            btnScan.Text = "Scan Another Book";
                            var bkStatus = (from s in db.tblBookCopies where s.copy_AccNum == decoded select s.copy_Status).FirstOrDefault();
                            if (bkStatus == "Available")
                            {
                                if (CheckIfBookExistInTheDGV() == 0)
                                {                                    
                                    clsBorrowBindingSource.Add(new clsBorrow() { AccessionIDNumber = txtAccNumber.Text, BookTitle = txtTitle.Text, DueDate = due });
                                    btnBorrows.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Book already exists in the table.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("This book is unavailable");
                            }

                        }


                    }
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Borrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void cmbDevice_onItemSelected(object sender, EventArgs e)
        {
            btnCamera.Visible = true;
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
        
        private void txtAccNumber_OnValueChanged(object sender, EventArgs e)
        {
            txtTitle.Text = (from book in db.tblBooks join copy in db.tblBookCopies on book.book_BookID equals copy.book_BookID where copy.copy_AccNum == txtAccNumber.Text select book.book_Title).FirstOrDefault();
        }
        public int CheckIfBookExistInTheDGV()
        {
            int ctr = 0;
            for (int i = 0; i < dgvBorrow.Rows.Count; i++)
            {
                if (txtAccNumber.Text == dgvBorrow.Rows[i].Cells[1].Value.ToString())
                {
                    ctr++;
                }
                else { }
            }
            return ctr;

        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            if(origin == "index")
            {
                IndexForm index = new IndexForm();
                index.Show();
                this.Hide();
            }
            else
            {
                MainForm main = new MainForm("");
                main.Show();
                this.Hide();
            }
        }
    }
}
