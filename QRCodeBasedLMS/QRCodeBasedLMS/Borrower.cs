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
        private string z;
        public Borrower(string qr, string x)
        {
            InitializeComponent();
            qrcode = qr;
            z = x;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsBorrower brwr = new clsBorrower();
        

        private void Borrower_Load(object sender, EventArgs e)
        {
            
            cmb_SearchCategory.Text = "QR Code";
            if(z == "borrower_brwr")
            {
                if(qrcode != "")
                {
                    txt_SchoolIDNumber.Text = qrcode;
                }
                else
                {
                    //dgvBorrower.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.Text, qrcode);
                }
                
            }
        }

        private void btnUpdateorSave_Click(object sender, EventArgs e)
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
                db.sp_UpdateLibraryUser(txt_SchoolIDNumber.Text, txt_Firstname.Text, txt_Lastname.Text, gen, txt_Address.Text, txt_ContactNum.Text, sy, true);
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
        public void ClearText()
        {
            txt_SchoolIDNumber.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Address.Text = "";
            txt_ContactNum.Text = "";
            rb_Male.Checked = true;
        }
        
        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search
            if(cmb_SearchCategory.Text == "Book QR Code")
            {
                txt_Search.Visible = false;
                Link_Scan.Visible = true;
            }
            else
            {
                txt_Search.Visible = true;
                Link_Scan.Visible = false;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //searching using the lastname and firstname
            //dgvBorrower.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.Text, txt_Search.Text);
        }

        

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Link_Scan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnScanQRCode scan = new btnScanQRCode("borrower_bk","");
            scan.Show();
            this.Close();
        }

        private void link_ScanBrwr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnScanQRCode scan = new btnScanQRCode("borrower_brwr","");
            scan.Show();
            this.Close();
        }
        private string sy;
        private void txt_SchoolIDNumber_TextChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolIDNumber.Text
                         select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolIDNumber.Text
                         select s.lib_Lastname).FirstOrDefault();
            var gender = (from s in db.tblLibraryUsers
                          where s.lib_SchoolID == txt_SchoolIDNumber.Text
                          select s.lib_Gender).FirstOrDefault();
            var address = (from s in db.tblLibraryUsers
                           where s.lib_SchoolID == txt_SchoolIDNumber.Text
                           select s.lib_Address).FirstOrDefault();
            var contact = (from s in db.tblLibraryUsers
                           where s.lib_SchoolID == txt_SchoolIDNumber.Text
                           select s.lib_ContactNumber).FirstOrDefault();
            sy = (from s in db.tblLibraryUsers
                  where s.lib_SchoolID == txt_SchoolIDNumber.Text
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
                Bitmap bmp = encode.Encode(txt_SchoolIDNumber.Text);
                pbBorrowerQR.Image = bmp;
            }
        }
    }
}
