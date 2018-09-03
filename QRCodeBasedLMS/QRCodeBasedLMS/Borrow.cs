﻿using System;
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
        public Borrow()
        {
            InitializeComponent();
            
        }
        
        dcLMSDataContext db = new dcLMSDataContext();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private string decoded;

        private void Borrow_Load(object sender, EventArgs e)
        {
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
        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBorrow.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    clsBorrowBindingSource.RemoveCurrent();
                    btnScan.Text = "Scan Another Book";
                }
            }
        }
        
        private void txt_BorrowerIDs_OnValueChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Lastname).FirstOrDefault();
            txt_Name.Text = lname + ", " + fname;
        }
        private void txt_BookIDNums_OnValueChanged(object sender, EventArgs e)
        {
            txt_Title.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Title).FirstOrDefault();
        }

        private void btnScans_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_BorrowIDnumber() + 1;
            string borrowID = "BRW-" + x + "-" + dt.Day + dt.Month + dt.Year;
            DialogResult res = MessageBox.Show("CONFIRM:\nDo you want to borrow all the books in the table?", "Borrow Book", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < dgvBorrow.RowCount; i++)
                {
                    db.sp_BorrowBook(borrowID, txt_BorrowerID.Text, dgvBorrow.Rows[i].Cells[1].Value.ToString(), dt, DateTime.Parse(dgvBorrow.Rows[i].Cells[3].Value.ToString()));
                }

                MessageBox.Show("Successully Borrowed!");
                txt_BookIDNum.Text = "";
                txt_BorrowerID.Text = "";
                IndexForm index = new IndexForm();
                index.Show();
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
                    if(txt_Name.Text == "")
                    {
                        txt_BorrowerID.Text = decoded;
                    }
                    else
                    {
                        txt_BookIDNum.Text = decoded;
                        DateTime dt = DateTime.Now;
                        DateTime due = dt.AddDays(3);
                        clsBorrowBindingSource.Add(new clsBorrow() {BookIDNum = txt_BookIDNum.Text, BookTitle = txt_Title.Text, DueDate = due});
                        btnScan.Text = "Scan Another Book";
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
            //IndexForm index = new IndexForm();
            //index.Show();
            //this.Close();
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("asd");
        }
    }
}
