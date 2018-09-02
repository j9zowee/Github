using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    public partial class BorrowerInfoForLibraryCard : Form
    {
        public BorrowerInfoForLibraryCard()
        {
            InitializeComponent();
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private string sy;
        private void txt_SchoolID_TextChanged(object sender, EventArgs e)
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
            if(gender == "Male")
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("CONFIRM:\nPrint library card?", "Print Library Card", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
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
                db.sp_UpdateLibraryUser(txt_SchoolID.Text, txt_Firstname.Text, txt_Lastname.Text, gen, txt_Address.Text,txt_ContactNum.Text,sy,true);
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pbBorrowerQR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }
    }
}
