using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    public partial class Return : Form
    {
        public string Borrowerqrcode;
        public string Bookqrcode;
        public Return(string borrowerqrcode, string bookqrcode)
        {
            InitializeComponent();
            Borrowerqrcode = borrowerqrcode;
            Bookqrcode = bookqrcode;

        }
        dcLMSDataContext db = new dcLMSDataContext();
        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("return",txt_BorrowerID.Text);
            scan.Show();
            this.Hide();
        }

        private void txt_BookIDNum_TextChanged(object sender, EventArgs e)
        {
            txt_Title.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Title).FirstOrDefault();
        }
    }
}
