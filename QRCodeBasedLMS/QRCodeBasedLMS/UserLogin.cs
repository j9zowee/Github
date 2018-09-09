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
                user.UserIDNumber = user.GenerateAccountIDNum();
                user.Firstname = "SuperAdmin";
                user.Lastname = "";
                user.Username = "SuperAdmin";
                user.Password = "JaneDoe";
                user.SecretQuestion = "";
                user.SecretAnswer = "";
                user.Usertype = "SuperAdmin";
                user.Status = "Active";

                user.AddRecord();
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
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
            }     
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            IndexForm i = new IndexForm();
            i.Show();
            this.Hide();
        }
    }
}
