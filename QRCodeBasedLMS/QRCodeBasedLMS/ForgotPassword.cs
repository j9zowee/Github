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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private string ans;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords don't match!");
            }
            else
            {
                db.sp_UpdatePassword(txtUsername.Text,txtPassword.Text);
                MessageBox.Show("Successfully Updated Password!");
                UserLogin login = new UserLogin();
                login.Show();
                this.Hide();
            }
            
        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.Size = new Size(324, 154);
        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblUserAccounts
                         where s.user_Username == txtUsername.Text
                         select s.user_Firstname).FirstOrDefault();
            var lname = (from s in db.tblUserAccounts
                         where s.user_Username == txtUsername.Text
                         select s.user_Lastname).FirstOrDefault();

            var ques = (from s in db.tblUserAccounts
                        where s.user_Username == txtUsername.Text
                        select s.user_SecretQuestion).FirstOrDefault();
            if (fname != null && lname != null)
            {
                txtName.Text = fname +" "+ lname;
                this.Size = new Size(324, 275);
                txtQuestion.Text = ques;
            }
            else
            {
                this.Size = new Size(324, 154);
                txtName.Text = "";
            }
            
        }

        private void txtAnswer_OnValueChanged(object sender, EventArgs e)
        {
            
            ans = (from s in db.tblUserAccounts
                        where s.user_Username == txtUsername.Text
                        select s.user_SecretAnswer).FirstOrDefault();

            if(txtAnswer.Text == ans)
            {
                this.Size = new Size(324, 447);
            }
            else
            {
                if (txtAnswer.Text != ans)
                {
                    this.Size = new Size(324, 275);
                }
            }
        }

        private void txtAnswer_Leave(object sender, EventArgs e)
        {
            if (txtAnswer.Text != ans)
            {
                this.Size = new Size(324, 257);
                MessageBox.Show("Incorrect Answer!");
            }
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Hide();
        }
    }
}
