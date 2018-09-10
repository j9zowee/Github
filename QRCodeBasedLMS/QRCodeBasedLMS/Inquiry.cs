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
    public partial class Inquiry : Form
    {
        private string qrcode;
        public Inquiry(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        string sy;
        private void Inquiry_Load(object sender, EventArgs e)
        {
            if (qrcode != "")
            {
                txt_SchoolID.Text = qrcode;
            }

        }

        private void txt_SchoolID_OnValueChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Lastname).FirstOrDefault();
            var gender = (from s in db.tblLibraryUsers
                          where s.lib_SchoolID == txt_SchoolID.Text
                          select s.lib_Gender).FirstOrDefault();
            var address = (from s in db.tblLibraryUsers
                           where s.lib_SchoolID == txt_SchoolID.Text
                           select s.lib_Address).FirstOrDefault();
            var contact = (from s in db.tblLibraryUsers
                           where s.lib_SchoolID == txt_SchoolID.Text
                           select s.lib_ContactNumber).FirstOrDefault();
            sy = (from s in db.tblLibraryUsers
                  where s.lib_SchoolID == txt_SchoolID.Text
                  select s.lib_SchoolYear).FirstOrDefault();

            txt_Firstname.Text = fname;
            txt_Lastname.Text = lname;
            if (gender == "Male")
            {
                rb_Male.Checked = true;
            }
            else
            {
                rb_Female.Checked = true;
            }
            txt_Address.Text = address;
            txt_ContactNum.Text = contact;
            if (fname != null && lname != null)
            {

                MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                encode.QRCodeScale = 6;
                Bitmap bmp = encode.Encode(txt_SchoolID.Text);
                pbBorrowerQR.Image = bmp;
            }

            // usbunon ang name sa db since giusab ang column name
            //dgvBorrowed.DataSource = db.sp_ViewBorrowedBooks(txt_SchoolID.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gen;
            if (rb_Male.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            db.sp_UpdateLibraryUser(txt_SchoolID.Text, txt_Firstname.Text, txt_Lastname.Text, gen, txt_Address.Text, txt_ContactNum.Text, sy, true);
            MessageBox.Show("Sucessfully Updated!");
        }
    }
}
