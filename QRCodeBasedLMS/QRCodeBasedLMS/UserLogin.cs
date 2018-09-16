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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsUser user = new clsUser();
        private void UserLogin_Load(object sender, EventArgs e)
        {
            if(db.sp_LastAcctIDNum().Count() == 0)
            {
                link_ForgotPassword.Visible = false;
                linkSignUp.Visible = false;
                grpCreateSuperAdmin.Visible = true;
            }
            else
            {
                link_ForgotPassword.Visible = true;
                linkSignUp.Visible = true;
                grpCreateSuperAdmin.Visible = false;
            }
        }

        private void linkSignUp_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("You entered an incomplete information to sign in. \nPlease enter your username and password.");
            }
            else
            {
                if (db.sp_Login(txtUsername.Text, txtPassword.Text).Count() != 1)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                else
                {
                    string status = (from s in db.tblUserAccounts where s.user_Username == txtUsername.Text select s.user_Status).FirstOrDefault();
                    if(status == "Inactive")
                    {
                        MessageBox.Show("This account is currently deactivated.");
                    }
                    else
                    {
                        string usertype = (from s in db.tblUserAccounts where s.user_Username == txtUsername.Text select s.user_UserType).FirstOrDefault();
                        MainForm main = new MainForm(usertype);
                        main.Show();
                        this.Hide();
                    }                    
                }
            }     
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            IndexForm i = new IndexForm();
            i.Show();
            this.Hide();
        }

        private void link_ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }

        private void btnCreateSuperAdmin_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}
