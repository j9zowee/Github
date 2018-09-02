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
        public string Borrowerqrcode;
        public string Bookqrcode;
        public Borrow(string brwrqr,string bkqr)
        {
            InitializeComponent();
            Borrowerqrcode = brwrqr;
            Bookqrcode = bkqr;
            
        }
        
        dcLMSDataContext db = new dcLMSDataContext();

        
        private void Borrow_Load(object sender, EventArgs e)
        {
            txt_BorrowerID.Text = Borrowerqrcode;
            txt_BookIDNum.Text = Bookqrcode;
            
            if (txt_BookIDNum.Text != "")
            {
                DateTime dt = DateTime.Now;
                DateTime due = dt.AddDays(3);
                db.sp_SelectBooks(txt_BookIDNum.Text, txt_Title.Text, due);

                dgvBorrow.DataSource = db.sp_ViewSelectedBooks();
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                
                btn.Text = "Delete";
                btn.Name = "Delete";
                btn.UseColumnTextForButtonValue = true;
                dgvBorrow.Columns.Add(btn);
                btnScan.Text = "Scan Another Book";
            }

            
            
        }



        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("borrowform",txt_BorrowerID.Text);
            scan.Show();
            this.Hide();
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                txt_BookIDNum.Text = dgvBorrow.CurrentRow.Cells[0].Value.ToString();
            DialogResult res = MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                db.sp_DeleteSelectedBooks(txt_BookIDNum.Text);
                dgvBorrow.DataSource = db.sp_ViewSelectedBooks();
                
                btnScan.Text = "Scan Another Book";
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_BorrowIDnumber() + 1;
            string borrowID = "BRW-" + x + "-" + dt.Day + dt.Month + dt.Year;
            DialogResult res = MessageBox.Show("CONFIRM:\nDo you want to borrow all the books in the table?", "Borrow Book", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < dgvBorrow.RowCount; i++)
                {
                    db.sp_BorrowBook(borrowID, txt_BorrowerID.Text, dgvBorrow.Rows[i].Cells[0].Value.ToString(), dt, DateTime.Parse(dgvBorrow.Rows[i].Cells[2].Value.ToString()));
                }
                    
                MessageBox.Show("Successully Borrowed!");
                for (int i = 0; i < dgvBorrow.RowCount; i++)
                {

                    db.sp_DeleteSelectedBooks(dgvBorrow.Rows[i].Cells[0].Value.ToString());
                }
                txt_BookIDNum.Text = null;
                txt_BorrowerID.Text = null;
                IndexForm index = new IndexForm();
                index.Show();
                this.Close();
            }
            else
            {
                IndexForm index = new IndexForm();
                index.Show();
                this.Close();
            }
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to cancel?", "Cancel Borrowing of Book", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < dgvBorrow.RowCount; i++)
                {
                    db.sp_DeleteSelectedBooks(dgvBorrow.Rows[i].Cells[0].Value.ToString());
                }
                IndexForm index = new IndexForm();
                index.Show();
                this.Close();
            }
        }

        private void txt_BorrowerID_TextChanged(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_BorrowerID.Text);
            pb_QRCode.Image = bmp;

            var fname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers where s.lib_SchoolID == txt_BorrowerID.Text select s.lib_Lastname).FirstOrDefault();
            txt_Name.Text = lname + ", " + fname;
        }

        private void txt_BookIDNum_TextChanged(object sender, EventArgs e)
        {
            txt_Title.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Title).FirstOrDefault();
        }
    }
}
