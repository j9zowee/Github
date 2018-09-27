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
        public string sy;
        public string bt;
        private string qrcode;
        static string usertype;
        public Borrower(string type, string qr)
        {
            InitializeComponent();
            usertype = type;
            qrcode = qr;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        ScanQRCode scan = new ScanQRCode(usertype,"brwr");
        clsBorrower brwr = new clsBorrower();
        private Boolean withcard;
        
        private void Borrower_Load(object sender, EventArgs e)
        {
            for (int x = DateTime.Today.Year; x >= (DateTime.Today.Year - 10); x--)
            {
                cmbSchoolYear.AddItem(x + " - " + (x + 1));
            }
            cmb_SearchCategory.selectedIndex = 0;
            DisableControls();
            ClearText();
            if (qrcode != "")
            {
                brwr.SetDropdownText(cmbLibraryUser, bt);
                brwr.SetDropdownText(cmbSchoolYear, sy);
                dgvBorrowers.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.selectedValue, sy, bt, qrcode);
                AssignValuesToTextboxes();
            }
            else
            {
                cmbSchoolYear.selectedIndex = 0;
                cmbLibraryUser.selectedIndex = 0;
                cmb_Penalty.selectedIndex = 0;
                dgvBorrowers.DataSource = db.sp_ViewLibraryUser(false,cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
        }
        private void link_ScanBrwr_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode(usertype,"borrower_brwr");
            scan.Show();
            this.Close();
        }

        private void txt_SchoolID_OnValueChanged(object sender, EventArgs e)
        {
            pbBorrowerQR.Image = brwr.GenerateQRCode(txt_SchoolID.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AssignValuesToClassProperties();
            brwr.WithCard = withcard;
            brwr.UpdateRecord();
            if (cmb_Penalty.selectedIndex == 0) dgvBorrowers.DataSource = db.sp_ViewLibraryUser(false, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            else dgvBorrowers.DataSource = db.sp_ViewLibraryUser(true, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            
            MessageBox.Show("Sucessfully Updated!");
            ClearText();
            
        }
        
        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usertype);
            main.Show();
            this.Hide();
        }

        private void cmb_SearchCategory_onItemSelected(object sender, EventArgs e)
        {
            if (cmb_SearchCategory.selectedValue == "QR Code")
            {
                link_ScanQr.Visible = true;
                txt_Search.Visible = false;
            }
            else if(cmb_SearchCategory.selectedValue == "Name")
            {
                txt_Search.Visible = true;
                link_ScanQr.Visible = false;
            }
        }

        private void cmbLibraryUser_onItemSelected(object sender, EventArgs e)
        {
            if (cmbSchoolYear.selectedIndex != -1)
            {
                if (cmb_Penalty.selectedIndex == 0) dgvBorrowers.DataSource = db.sp_ViewLibraryUser(false, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                else dgvBorrowers.DataSource = db.sp_ViewLibraryUser(true, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            ClearText();
        }
        private void cmb_Penalty_onItemSelected(object sender, EventArgs e)
        {
            if (cmbSchoolYear.selectedIndex != -1)
            {
                if(cmb_Penalty.selectedIndex == 0) dgvBorrowers.DataSource = db.sp_ViewLibraryUser(false,cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                else dgvBorrowers.DataSource = db.sp_ViewLibraryUser(true, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            ClearText();
        }
        private void cmbSchoolYear_onItemSelected(object sender, EventArgs e)
        {
            if (cmbSchoolYear.selectedIndex != -1)
            {
                if (cmb_Penalty.selectedIndex == 0) dgvBorrowers.DataSource = db.sp_ViewLibraryUser(false, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                else dgvBorrowers.DataSource = db.sp_ViewLibraryUser(true, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
        }

        private void dgvBorrowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmb_Penalty.selectedIndex == 0) AssignValuesToTextboxes();
            else
            {
                DialogResult res = MessageBox.Show("Did the borrower paid his/her penalty?", "Paid Penalty", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    db.sp_PaidPenalty(dgvBorrowers.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(dgvBorrowers.CurrentRow.Cells[1].Value.ToString() + " " + dgvBorrowers.CurrentRow.Cells[2].Value.ToString() + " had paid the penalty.");
                    if (cmbSchoolYear.selectedIndex != -1)
                    {
                        if (cmb_Penalty.selectedIndex == 0) dgvBorrowers.DataSource = db.sp_ViewLibraryUser(false, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                        else dgvBorrowers.DataSource = db.sp_ViewLibraryUser(true, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                    }
                }
            }
        }
        
        private void link_ScanQr_Click(object sender, EventArgs e)
        {            
            scan.schoolyear = cmbSchoolYear.selectedValue;
            scan.brwrtype = cmbLibraryUser.selectedValue;
            scan.Show();
            this.Hide();
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            dgvBorrowers.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.selectedValue, cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue, txt_Search.Text);
        }
        private void btnPrintLibCard_Click(object sender, EventArgs e)
        {
            AssignValuesToClassProperties();
            brwr.WithCard = true;
            brwr.UpdateRecord();

            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pbBorrowerQR.Image, 25, 40, 130, 130);
            e.Graphics.DrawString("School ID : " + txt_SchoolID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(160, 80));
            e.Graphics.DrawString("Name : " + txt_Lastname.Text + ", " + txt_Firstname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(160, 100));
            e.Graphics.DrawString("School Year : " + cmbSchoolYear.selectedValue, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(160, 120));
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

        public void DisableControls()
        {
            btnUpdate.Enabled = false;
            btnPrintLibCard.Enabled = false;
            txt_SchoolID.Enabled = false;
            txt_Lastname.Enabled = false;
            txt_Firstname.Enabled = false;
            rb_Male.Enabled = false;
            rb_Female.Enabled = false;
            txt_Address.Enabled = false;
            txt_ContactNum.Enabled = false;
        }
        public void EnableControls()
        {
            btnUpdate.Enabled = true;
            btnPrintLibCard.Enabled = true;
            txt_SchoolID.Enabled = false;
            txt_Lastname.Enabled = true;
            txt_Firstname.Enabled = true;
            rb_Male.Enabled = true;
            rb_Female.Enabled = true;
            txt_Address.Enabled = true;
            txt_ContactNum.Enabled = true;
        }
        public void AssignValuesToTextboxes()
        {
            EnableControls();
            txt_SchoolID.Text = dgvBorrowers.CurrentRow.Cells[0].Value.ToString();
            txt_Firstname.Text = dgvBorrowers.CurrentRow.Cells[1].Value.ToString();
            txt_Lastname.Text = dgvBorrowers.CurrentRow.Cells[2].Value.ToString();
            string gen = dgvBorrowers.CurrentRow.Cells[3].Value.ToString();
            if (gen == "Male") rb_Male.Checked = true;
            else rb_Female.Checked = true;
            txt_Address.Text = dgvBorrowers.CurrentRow.Cells[4].Value.ToString();
            txt_ContactNum.Text = dgvBorrowers.CurrentRow.Cells[5].Value.ToString();
            withcard = Boolean.Parse(dgvBorrowers.CurrentRow.Cells[6].Value.ToString());
        }
        public void AssignValuesToClassProperties()
        {
            string gen;
            if (rb_Male.Checked) gen = "Male"; else gen = "Female";
            brwr.SchoolID = txt_SchoolID.Text;
            brwr.Firstname = txt_Firstname.Text;
            brwr.Lastname = txt_Lastname.Text;
            brwr.Gender = gen;
            brwr.Address = txt_Address.Text;
            brwr.ContactNumber = txt_ContactNum.Text;
            brwr.Usertype = cmbLibraryUser.selectedValue;
            brwr.SchoolYear = cmbSchoolYear.selectedValue;
        }

       
    }
}
