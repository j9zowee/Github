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
        clsBorrower brwr = new clsBorrower();
        string sy;
        private void Inquiry_Load(object sender, EventArgs e)
        {
            if (qrcode != "")
            {
                txt_SchoolID.Text = qrcode;
            }
            dgvBorrowed.DataSource = db.sp_BorrowedBooks(txt_SchoolID.Text);
        }

        private void txt_SchoolID_OnValueChanged(object sender, EventArgs e)
        {
            SetValuesToTextBoxes();
            if (txt_Firstname.Text != null && txt_Lastname != null)
            {
                pbBorrowerQR.Image = brwr.GenerateQRCode(txt_SchoolID.Text);
            }
            
            dgvBorrowed.DataSource = db.sp_BorrowedBooks(txt_SchoolID.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gen;
            if (rb_Male.Checked) gen = "Male"; else gen = "Female";
            brwr.SchoolID = txt_SchoolID.Text;
            brwr.Firstname = txt_Firstname.Text;
            brwr.Lastname = txt_Lastname.Text;
            brwr.Gender = gen;
            brwr.Address = txt_Address.Text;
            brwr.ContactNumber = txt_ContactNum.Text;
            brwr.Usertype = "";
            brwr.SchoolYear = sy;
            brwr.WithCard = true;
            brwr.UpdateRecord();
            MessageBox.Show("Sucessfully Updated!");
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Hide();
        }
        public void SetValuesToTextBoxes()
        {
            txt_Firstname.Text = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Firstname).FirstOrDefault();
            txt_Lastname.Text = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Lastname).FirstOrDefault();
            var gender = (from s in db.tblLibraryUsers
                          where s.lib_SchoolID == txt_SchoolID.Text
                          select s.lib_Gender).FirstOrDefault();
            if (gender == "Male") rb_Male.Checked = true; else rb_Female.Checked = true;
            txt_Address.Text= (from s in db.tblLibraryUsers
                           where s.lib_SchoolID == txt_SchoolID.Text
                           select s.lib_Address).FirstOrDefault();
            txt_ContactNum.Text = (from s in db.tblLibraryUsers
                           where s.lib_SchoolID == txt_SchoolID.Text
                           select s.lib_ContactNumber).FirstOrDefault();
            sy = (from s in db.tblLibraryUsers
                  where s.lib_SchoolID == txt_SchoolID.Text
                  select s.lib_SchoolYear).FirstOrDefault();
        }
    }
}
