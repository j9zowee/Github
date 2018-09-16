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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        clsUser user = new clsUser();
        dcLMSDataContext db = new dcLMSDataContext();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int sq = cmb_SecretQuestion.selectedIndex;
            if (string.IsNullOrWhiteSpace(txt_UserIDNum.Text) || string.IsNullOrWhiteSpace(txt_Firstname.Text) || string.IsNullOrWhiteSpace(txt_Lastname.Text) || string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text) ||
                string.IsNullOrWhiteSpace(txt_SecretAnswer.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in all of the textboxes.");

            }
            else
            {
                if(db.sp_CheckUsername(txt_Username.Text).Count() != 0)
                {
                    MessageBox.Show("The username you entered is already taken.\nPlease use other username.");
                }
                else
                {
                    user.UserIDNumber = txt_UserIDNum.Text;
                    user.Firstname = txt_Firstname.Text;
                    user.Lastname = txt_Lastname.Text;
                    user.Username = txt_Username.Text;
                    user.Password = txt_Password.Text;
                    user.SecretQuestion = cmb_SecretQuestion.selectedValue;
                    user.SecretAnswer = txt_SecretAnswer.Text;


                    if (txt_ConfirmPassword.Text != txt_Password.Text)
                    {
                        MessageBox.Show("Passwords does not match!");
                    }
                    else
                    {
                        if (db.sp_LastAcctIDNum().Count() == 0)
                        {
                            user.Usertype = "SuperAdmin";
                            user.Status = "Active";
                            MessageBox.Show("You have successfully created the Super Admin account!");
                        }
                        else
                        {
                            user.Usertype = "Staff";
                            user.Status = "Inactive";
                            MessageBox.Show("Successfully Registered!\nPlease wait for the Admin to approve your registration.");
                        }
                        user.AddRecord();
                        txt_UserIDNum.Text = user.GenerateAccountIDNum();
                        ClearText();
                    }
                }                
            }
        }

        //method for clearing texts
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
        }
        private void txt_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            //check if passwords match
            if (txt_ConfirmPassword.Text != txt_Password.Text)
            {
                MessageBox.Show("Passwords does not match!");
            }
        }
        
        private void Registration_Load(object sender, EventArgs e)
        {
            txt_UserIDNum.Text = user.GenerateAccountIDNum();
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Hide();
        }
    }
}
