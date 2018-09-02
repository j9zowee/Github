using MessagingToolkit.QRCode.Codec.Data;
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
    public partial class UpdateBookInfo : Form
    {
        public UpdateBookInfo()
        {
            InitializeComponent();
        }
        clsBook bk = new clsBook();
        dcLMSDataContext db = new dcLMSDataContext();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BookIDNum.Text) || string.IsNullOrWhiteSpace(txt_Title.Text) || string.IsNullOrWhiteSpace(txt_Publisher.Text) || string.IsNullOrWhiteSpace(txt_CopyrightYear.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in textboxes that has (*) indicator.");
            }
            else
            {
                if (bk.CheckValidCopyrightYear() == false)
                {
                    MessageBox.Show("Invalid Copyright Year!");
                }
                else
                {
                    bk.BookIDNumber = txt_BookIDNum.Text;
                    bk.BookType = cmbBookType.Text;
                    bk.ISBN = txt_ISBN.Text;
                    bk.CallNumber = txt_CallNumber.Text;
                    bk.Title = txt_Title.Text;
                    bk.Author = txt_Author.Text;
                    bk.Publisher = txt_Publisher.Text;
                    bk.CopyrightYear = int.Parse(txt_CopyrightYear.Text);
                    bk.Edition = txt_Edition.Text;
                    bk.Volume = txt_Volume.Text;
                    bk.Pages = int.Parse(txt_Pages.Text);
                    bk.Remarks = txt_Remarks.Text;

                    
                    bk.UpdateRecord();
                    dgvBook.DataSource = db.sp_ViewBook();
                    MessageBox.Show("Sucessfully Updated!");
                    ClearText();
                    DisableTextboxes();
                    btnUpdate.Enabled = false;
                   
                }

            }
        }
        public void ClearText()
        {
            txt_BookIDNum.Text = "";
            cmbBookType.Text = "References";
            txt_ISBN.Text = "";
            txt_CallNumber.Text = "";
            txt_Title.Text = "";
            txt_Author.Text = "";
            txt_Publisher.Text = "";
            txt_CopyrightYear.Text = "";
            txt_Edition.Text = "";
            txt_Volume.Text = "";
            txt_Pages.Text = "";
            txt_Remarks.Text = "";
        }

        private void UpdateBookInfo_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource= db.sp_ViewBook();
            cmbBookType.Text = "References";
            btnUpdate.Enabled = false;
            DisableTextboxes();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableTextboxes();
            btnUpdate.Enabled = true;
            txt_BookIDNum.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            cmbBookType.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            txt_ISBN.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_ISBN).FirstOrDefault();
            txt_CallNumber.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            txt_Title.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            txt_Author.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
            txt_Publisher.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Publisher).FirstOrDefault();
            txt_CopyrightYear.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();
            txt_Edition.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Edition).FirstOrDefault();
            txt_Volume.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Volume).FirstOrDefault();
            txt_Pages.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Pages).FirstOrDefault().ToString();
            txt_Remarks.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Remarks).FirstOrDefault();

        }
        public void DisableTextboxes()
        {
            cmbBookType.Enabled = false;
            txt_ISBN.Enabled = false;
            txt_CallNumber.Enabled = false;
            txt_Title.Enabled = false;
            txt_Author.Enabled = false;
            txt_Publisher.Enabled = false;
            txt_CopyrightYear.Enabled = false;
            txt_Edition.Enabled = false;
            txt_Volume.Enabled = false;
            txt_Pages.Enabled = false;
            txt_Remarks.Enabled = false;
        }
        public void EnableTextboxes()
        {
            cmbBookType.Enabled = true;
            txt_ISBN.Enabled = true;
            txt_CallNumber.Enabled = true;
            txt_Title.Enabled = true;
            txt_Author.Enabled = true;
            txt_Publisher.Enabled = true;
            txt_CopyrightYear.Enabled = true;
            txt_Edition.Enabled = true;
            txt_Volume.Enabled = true;
            txt_Pages.Enabled = true;
            txt_Remarks.Enabled = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
            DisableTextboxes();
            btnUpdate.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void txt_BookIDNum_TextChanged(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_BookIDNum.Text);
            pb_QRBook.Image = bmp;
        }

        private void Link_Scan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pb_QRBook.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decode = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.Text, decode.Decode(new QRCodeBitmapImage(pb_QRBook.Image as Bitmap)));
                }
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.Text, txt_Search.Text);
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SearchCategory.Text == "QR Code")
            {
                Link_Scan.Visible = true;
                txt_Search.Visible = false;
            }
            else
            {
                txt_Search.Visible = true;
                Link_Scan.Visible = false;
            }
        }
    }
}
