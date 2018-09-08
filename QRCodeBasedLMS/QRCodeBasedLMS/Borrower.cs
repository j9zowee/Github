using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QRCodeBasedLMS
{
    public partial class Borrower : Form
    {
        private string qrcode;
        private string sy;
        public Borrower(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsBorrower brwr = new clsBorrower();
        

        private void Borrower_Load(object sender, EventArgs e)
        {
            
            
        }
        public void ClearText()
        {
            txt_SchoolID.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Address.Text = "";
            txt_ContactNum.Text = "";
            rb_Male.Checked = true;
        }
        private void link_ScanBrwr_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("borrower_brwr");
            scan.Show();
            this.Close();
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
        }

        private void btnUpdateorSave_Click_1(object sender, EventArgs e)
        {
            if (btnUpdateorSave.Text == "UPDATE")
            {
                btnUpdateorSave.Text = "Save";
                txt_Lastname.Enabled = true;
                txt_Firstname.Enabled = true;
                rb_Male.Enabled = true;
                rb_Female.Enabled = true;
                txt_Address.Enabled = true;
                txt_ContactNum.Enabled = true;
            }
            else
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
                btnUpdateorSave.Text = "Update";
                txt_Lastname.Enabled = false;
                txt_Firstname.Enabled = false;
                rb_Male.Enabled = false;
                rb_Female.Enabled = false;
                txt_Address.Enabled = false;
                txt_ContactNum.Enabled = false;
            }
        }
        
        private void link_GoBack_Click(object sender, EventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Hide();
        }
    }
}
