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
    public partial class BookCopy : Form
    {
        public BookCopy(string bookIDNum)
        {
            InitializeComponent();
            txt_BookIDNum.Text = bookIDNum;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsBook bk = new clsBook();
        private void BookCopy_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.sp_ViewBookCopy(txt_BookIDNum.Text);
            cmb_Status.selectedIndex = 0;
            ClearText();
        }

        private void txt_BookIDNum_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddOrUpdate.Text = "UPDATE";
            txt_BookIDNum.Enabled = false;
            txt_AccessionNumber.Enabled = false;
            dtp_DateReceived.Enabled = false;
            txt_AccessionNumber.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            dtp_DateReceived.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            bk.setDrpText(cmb_Status, dgvBook.CurrentRow.Cells[3].Value.ToString());
        }

        private void txt_AccessionNumber_OnValueChanged(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_AccessionNumber.Text);
            pb_QRBook.Image = bmp;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AccessionNumber.Text) || string.IsNullOrWhiteSpace(cmb_Status.selectedValue))
            {
                MessageBox.Show("Incomplete Data!");
            }
            else
            {
                if (btnAddOrUpdate.Text == "ADD")
                {
                    if(bk.DoesBookCopyExist("QR Code",txt_AccessionNumber.Text)== true)
                    {
                        MessageBox.Show("Copy already exist in the database.");
                    }
                    else
                    {
                        db.sp_AddBookCopy(txt_BookIDNum.Text, int.Parse(txt_AccessionNumber.Text), DateTime.Parse(dtp_DateReceived.Text), cmb_Status.Text);
                        dgvBook.DataSource = db.sp_ViewBookCopy(txt_BookIDNum.Text);
                        MessageBox.Show("Successfully Added a Copy!");
                        ClearText();
                    }
                }
                else
                {
                    db.sp_UpdateBookStatus(txt_AccessionNumber.Text, cmb_Status.selectedValue);
                    MessageBox.Show("Successfully Updated a Copy!");
                    dgvBook.DataSource = db.sp_ViewBookCopy(txt_BookIDNum.Text);
                    ClearText();
                }
                
            }
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            Book bk = new Book("");
            bk.Show();
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            txt_AccessionNumber.Text = "";
            cmb_Status.selectedIndex = 0;
        }
    }
}
