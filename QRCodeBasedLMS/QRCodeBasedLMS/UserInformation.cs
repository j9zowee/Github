using MessagingToolkit.QRCode.Codec.Data;
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
    public partial class UserInformation : Form
    {
        private string qrcode;
        public UserInformation(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
        clsUser user = new clsUser();
        dcLMSDataContext db = new dcLMSDataContext();
        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UserIDNum.Text) || string.IsNullOrWhiteSpace(txt_Firstname.Text) || string.IsNullOrWhiteSpace(txt_Lastname.Text) || string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text) ||
                string.IsNullOrWhiteSpace(cmb_SecretQuestion.Text) || string.IsNullOrWhiteSpace(txt_SecretAnswer.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in all of the textboxes.");
            }
            else
            {
                //store values to properties found inside the clsUser
                string usertype;
                if (rb_Admin.Checked == true)
                {
                    usertype = "Admin";
                }
                else
                {
                    usertype = "Staff";
                }
               

                user.UserIDNumber = txt_UserIDNum.Text;
                user.Firstname = txt_Firstname.Text;
                user.Lastname = txt_Lastname.Text;
                user.Username = txt_Username.Text;
                user.Password = txt_Password.Text;
                user.SecretQuestion = cmb_SecretQuestion.Text;
                user.SecretAnswer = txt_SecretAnswer.Text;
                user.Usertype = usertype;
                user.Status = "Active";

                if (btnAddOrUpdate.Text == "ADD")
                {
                    if (txt_ConfirmPassword.Text != txt_Password.Text)
                    {
                        MessageBox.Show("Passwords does not match!");
                    }
                    else
                    {
                        //adding of User
                        user.AddRecord();

                        //saving qr code of a user
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                pbUserQR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                            }
                        }

                        MessageBox.Show("Successfully Registered!");
                        //dgvAccount.DataSource = db.sp_ViewActiveAccount();
                        ClearText();
                    }
                }
                else
                {
                    user.UpdateRecord();
                    ClearText();
                    MessageBox.Show("Successfully Registered!");
                    //dgvAccount.DataSource = db.sp_ViewActiveAccount();
                    
                }
                
            }
        }

        //clearing texts in textboxes
        public void ClearText()
        {
           
            txt_UserIDNum.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_ConfirmPassword.Text = "";
            cmb_SecretQuestion.Text = "";
            txt_SecretAnswer.Text = "";
            rb_Staff.Checked = true;
            btnAddOrUpdate.Text = "ADD";
        }
        private void txt_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            //checking if passwords match
            if (txt_ConfirmPassword.Text != txt_Password.Text)
            {
                MessageBox.Show("Passwords does not match!");
            }
        }

        

        private void UserInformation_Load(object sender, EventArgs e)
        {
            txt_UserIDNum.Text = user.GenerateAccountIDNum();
            cmb_SearchCategory.Text = "QR Code";
            //dgvAccount.DataSource = db.sp_ViewActiveAccount();
            if (qrcode != "")
            {
                //dgvAccount.DataSource = db.sp_SearchActiveAccount(cmb_SearchCategory.Text, qrcode);
            }
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search
            if (cmb_SearchCategory.Text == "QR Code")
            {
                txt_Search.Visible = false;
                Link_ScanQR.Visible = true;
            }
            else
            {
                txt_Search.Visible = true;
                Link_ScanQR.Visible = false;
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //transferring data from the dgv to the textboxes
            txt_ConfirmPassword.Enabled = false;
            btnAddOrUpdate.Text = "Update";
            link_deactivate.Visible = true;
            txt_UserIDNum.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            txt_Firstname.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            txt_Lastname.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            txt_Username.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            txt_Password.Text = dgvAccount.CurrentRow.Cells[4].Value.ToString();
            cmb_SecretQuestion.Text = dgvAccount.CurrentRow.Cells[5].Value.ToString();
            txt_SecretAnswer.Text = dgvAccount.CurrentRow.Cells[6].Value.ToString();
            string usertype = dgvAccount.CurrentRow.Cells[7].Value.ToString();
            if (usertype == "Admin")
            {
                rb_Admin.Checked = true;
            }
            else
            {
                rb_Staff.Checked = true;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //searching using lastname or firstname
            //dgvAccount.DataSource = db.sp_SearchActiveAccount(cmb_SearchCategory.Text, txt_Search.Text);
        }

        
        private void txt_UserIDNum_TextChanged_1(object sender, EventArgs e)
        {
            //generating qr code
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_UserIDNum.Text);
            pbUserQR.Image = bmp;
        }

        private void Link_ScanQR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //searching using qr code
            btnScanQRCode scan = new btnScanQRCode("userinfo","");
            scan.Show();
            this.Close();
        }

        private void link_deactivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            db.sp_UpdateAccountStatus(txt_UserIDNum.Text, "Deactivate");
            MessageBox.Show("Successfully deactivated account!");
            //dgvAccount.DataSource = db.sp_ViewActiveAccount();
            ClearText();
        }
    }
}
