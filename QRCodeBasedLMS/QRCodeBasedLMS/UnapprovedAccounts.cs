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
    public partial class UnapprovedAccounts : Form
    {
        private string usertype;
        public UnapprovedAccounts(string type)
        {
            InitializeComponent();
            usertype = type;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private void UnapprovedAccounts_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = db.sp_ViewAccount("Inactive", usertype);
            cmb_Status.selectedIndex = 0;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_Status.Enabled = true;
            txt_UserIDNum.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            txt_Firstname.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            txt_Lastname.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            cmb_Status.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.sp_UpdateAccountStatus(txt_UserIDNum.Text, cmb_Status.selectedValue);
            dgvAccount.DataSource = db.sp_ViewAccount("Inactive", usertype);
            MessageBox.Show("Saved!");
            ClearText();
        }
        
        private void ClearText()
        {
            txt_UserIDNum.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            cmb_Status.selectedIndex = -1;
            cmb_Status.Enabled = false;
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            dgvAccount.DataSource = db.sp_ViewAccount(usertype,"Inactive");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(usertype);
            mf.Show();
            this.Hide();
        }
        
        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = db.sp_SearchAccount("Inactive", txt_Search.Text);
            
        }

        //private void setEnability(Bunifu.Framework.UI.BunifuDropdown cmb, Boolean bln)
        //{
        //    foreach (Control ctl in cmb.Controls)
        //    {
        //        if (ctl.GetType() == typeof(ComboBox))
        //        {
        //            var drp = (ComboBox)ctl;
        //            drp.Enabled = bln;
        //        }
        //    }
        //}
    }
}
