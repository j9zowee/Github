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
        private string qrcode;
        public UnapprovedAccounts(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private void UnapprovedAccounts_Load(object sender, EventArgs e)
        {
            //dgvAccount.DataSource = db.sp_ViewInactiveAccount();
            cmb_SearchCategory.Text = "QR Code";
            if (qrcode != "")
            {
                MessageBox.Show(qrcode);
                //dgvAccount.DataSource = db.sp_SearchInactiveAccount(cmb_SearchCategory.Text, qrcode);
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_Status.Enabled = true;
            txt_UserIDNum.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            txt_Firstname.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            txt_Lastname.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            cmb_Status.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmb_Status.Text == "Active")
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pbUserQR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                }
            }
            db.sp_UpdateAccountStatus(txt_UserIDNum.Text, cmb_Status.Text);
            //dgvAccount.DataSource = db.sp_ViewInactiveAccount();
            MessageBox.Show("Saved!");
            ClearText();
        }

        private void txt_UserIDNum_TextChanged(object sender, EventArgs e)
        {

            //generating qr code
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_UserIDNum.Text);
            pbUserQR.Image = bmp;
        }
        private void ClearText()
        {
            txt_UserIDNum.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            cmb_Status.Text = "";
            cmb_Status.Enabled = false;
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Link_ScanQR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //searching using qr code
            ScanQRCode scan = new ScanQRCode("inactiveusers","");
            scan.Show();
            this.Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //dgvAccount.DataSource = db.sp_SearchInactiveAccount(cmb_SearchCategory.Text, txt_Search.Text);
        }
    }
}
