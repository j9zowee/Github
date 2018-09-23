﻿using MessagingToolkit.QRCode.Codec.Data;
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
        private string usertype;
        public UserInformation(string type)
        {
            InitializeComponent();
            usertype = type;
        }
        clsUser user = new clsUser();
        dcLMSDataContext db = new dcLMSDataContext();

        private void UserInformation_Load(object sender, EventArgs e)
        {
            txt_UserIDNum.Text = user.GenerateIDNumber();
            cmb_SecretQuestion.selectedIndex = 0;
            dgvAccount.DataSource = db.sp_ViewAccount("Active", usertype);
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //transferring data from the dgv to the textboxes
            btnAddOrUpdate.Text = "Update";
            link_deactivate.Visible = true;
            txt_UserIDNum.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            txt_Firstname.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            txt_Lastname.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            txt_Username.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            setDrpText(cmb_SecretQuestion, (from s in db.tblUserAccounts where s.user_UserNum == txt_UserIDNum.Text select s.user_SecretQuestion).FirstOrDefault());
            txt_SecretAnswer.Text = (from s in db.tblUserAccounts where s.user_UserNum == txt_UserIDNum.Text select s.user_SecretAnswer).FirstOrDefault();
            txt_Password.Text = (from s in db.tblUserAccounts where s.user_UserNum == txt_UserIDNum.Text select s.user_Password).FirstOrDefault();
            string utype = (from s in db.tblUserAccounts where s.user_UserNum == txt_UserIDNum.Text select s.user_UserType).FirstOrDefault();
            if (utype == "Admin") rb_Admin.Checked = true;
            else rb_Staff.Checked = true;

        }
        private void link_deactivate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to deactivate this account?", "Deactivate Account", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                db.sp_UpdateAccountStatus(txt_UserIDNum.Text, "Inactive");
                MessageBox.Show("Successfully deactivated account!");
                dgvAccount.DataSource = db.sp_ViewAccount("Active", usertype);
                ClearText();
                txt_UserIDNum.Text = user.GenerateIDNumber();
            }
                
        }

        private void btnAddOrUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UserIDNum.Text) || string.IsNullOrWhiteSpace(txt_Firstname.Text) || string.IsNullOrWhiteSpace(txt_Lastname.Text) || string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text) ||
               string.IsNullOrWhiteSpace(txt_SecretAnswer.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in all of the textboxes.");
            }
            else
            {
                if (db.sp_CheckUsername(txt_Username.Text).Count() != 0)
                {
                    MessageBox.Show("The username you entered is already taken.\nPlease use other username.");
                }
                else
                {
                    //store values to properties found inside the clsUser
                    string utype;
                    if (rb_Admin.Checked == true) utype = "Admin";
                    else utype = "Staff";

                    user.UserIDNumber = txt_UserIDNum.Text;
                    user.Firstname = txt_Firstname.Text;
                    user.Lastname = txt_Lastname.Text;
                    user.Username = txt_Username.Text;
                    user.Password = txt_Password.Text;
                    user.SecretQuestion = cmb_SecretQuestion.selectedValue;
                    user.SecretAnswer = txt_SecretAnswer.Text;
                    user.Usertype = utype;
                    user.Status = "Active";

                    if (btnAddOrUpdate.Text == "ADD")
                    {
                        //adding of User
                        user.AddRecord();
                        MessageBox.Show("Successfully Registered!");
                        dgvAccount.DataSource = db.sp_ViewAccount("Active", usertype);
                        ClearText();
                    }
                    else
                    {
                        user.UpdateRecord();
                        ClearText();
                        MessageBox.Show("Successfully Registered!");
                        dgvAccount.DataSource = db.sp_ViewAccount("Active", usertype);

                    }
                }
            }
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        
        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = db.sp_SearchAccount("Active", txt_Search.Text);
        }

        private void setDrpText(Bunifu.Framework.UI.BunifuDropdown drpCombo, string text)
        {
            foreach (Control ctl in drpCombo.Controls)
            {
                if (ctl.GetType() == typeof(ComboBox))
                {
                    var cmb = (ComboBox)ctl;
                    cmb.Text = text;

                    // Set other properties & events here...
                }
            }
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(usertype);
            mf.Show();
            this.Hide();
        }

        //clearing texts in textboxes
        public void ClearText()
        {

            txt_UserIDNum.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
            cmb_SecretQuestion.Text = "";
            txt_SecretAnswer.Text = "";
            rb_Staff.Checked = true;
            cmb_SecretQuestion.selectedIndex = 0;
            btnAddOrUpdate.Text = "ADD";
        }

    }
}
