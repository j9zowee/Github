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
                setDrpText(cmbLibraryUser, bt);
                setDrpText(cmbSchoolYear, sy);
                dgvBorrowers.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.selectedValue, sy, bt, qrcode);
                AssignValuesToTextboxes();
            }
            else
            {
                cmbSchoolYear.selectedIndex = 0;
                cmbLibraryUser.selectedIndex = 0;     
                dgvBorrowers.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            

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
            ScanQRCode scan = new ScanQRCode(usertype,"borrower_brwr");
            scan.Show();
            this.Close();
        }

        private void txt_SchoolID_OnValueChanged(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_SchoolID.Text);
            pbBorrowerQR.Image = bmp;
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
            db.sp_UpdateLibraryUser(txt_SchoolID.Text, txt_Firstname.Text, txt_Lastname.Text, gen, txt_Address.Text, txt_ContactNum.Text, cmbSchoolYear.selectedValue, withcard);
            dgvBorrowers.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            MessageBox.Show("Sucessfully Updated!");
            
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
            else
            {
                txt_Search.Visible = true;
                link_ScanQr.Visible = false;
            }
        }

        private void cmbLibraryUser_onItemSelected(object sender, EventArgs e)
        {
            if (cmbLibraryUser.selectedIndex != -1)
            {
                dgvBorrowers.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            ClearText();
        }

        private void cmbSchoolYear_onItemSelected(object sender, EventArgs e)
        {
            if (cmbSchoolYear.selectedIndex != -1)
            {
                dgvBorrowers.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            ClearText();
        }

        private void dgvBorrowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignValuesToTextboxes();
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

        private void btnPrintLibCard_Click(object sender, EventArgs e)
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
            db.sp_UpdateLibraryUser(txt_SchoolID.Text, txt_Firstname.Text, txt_Lastname.Text, gen, txt_Address.Text, txt_ContactNum.Text, cmbSchoolYear.selectedValue, true);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pbBorrowerQR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
            ClearText();
            dgvBorrowers.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            MessageBox.Show("Printing!");
            DisableControls();
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
        public void setDrpText(Bunifu.Framework.UI.BunifuDropdown drpCombo, string text)
        {
            foreach (Control ctl in drpCombo.Controls)
            {
                if (ctl.GetType() == typeof(ComboBox))
                {
                    var cmb = (ComboBox)ctl;
                    cmb.Text = text;                    
                }
            }
        }
    }
}
