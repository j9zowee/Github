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
        private void btnExit_Click(object sender, EventArgs e)
        {
            Book bk = new Book("");
            bk.Show();
            this.Hide();
        }

        private void BookCopy_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource= db.sp_ViewBookCopy(txt_BookIDNum.Text);
            cmb_Status.Text = "On Shelf";
        }

        private void txt_BookIDNum_OnValueChanged(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_BookIDNum.Text);
            pb_QRBook.Image = bmp;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_AccessionNumber.Text))
            {
                MessageBox.Show("Incomplete Data!");
            }
            else
            {
                if (btnAddOrUpdate.Text == "ADD")
                {
                    db.sp_AddBookCopy(txt_BookIDNum.Text, int.Parse(txt_AccessionNumber.Text), DateTime.Parse(dtp_DateReceived.Text), cmb_Status.Text);
                    dgvBook.DataSource = db.sp_ViewBookCopy(txt_BookIDNum.Text);
                    MessageBox.Show("Successfully Added a Copy!");
                    txt_AccessionNumber.Text = "";
                }
                else
                {
                    //db.sp_UpdateBookCopy(txt_BookIDNum.Text, int.Parse(txt_AccessionNumber.Text), DateTime.Parse(dtp_DateReceived.Text), cmb_Status.Text);
                    //dgvBook.DataSource = db.sp_ViewBookCopy(txt_BookIDNum.Text);
                    //MessageBox.Show("Successfully Updated a Copy!");
                    //txt_AccessionNumber.Text = "";
                    //btnAddOrUpdate.Text = "ADD";
                }

            }

        }

        private void txt_AccessionNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnAddOrUpdate.Text = "UPDATE";
            //txt_AccessionNumber.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            //dtp_DateReceived.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            //cmb_Status.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
        }

        
    }
}
