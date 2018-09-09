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
    public partial class Book : Form
    {
        private string qrcode;
        public Book(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
        
        dcLMSDataContext db = new dcLMSDataContext();
        clsBook bk = new clsBook();
        private void Book_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            txt_BookIDNum.Text= bk.GenerateBookIDNum();
            cmbBookType.selectedIndex = 0;
            cmb_Status.selectedIndex = 0;
            cmb_SearchCategory.selectedIndex = 0;
            cmb_Status.Text = "Available";
            if (qrcode != "")
            {
                dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.Text, qrcode);
                AssignValuesToTextBox();
            }
            else
            {
                dgvBook.DataSource = db.sp_ViewBook();
            }
        }

        private void btnAddOrAddBookCopy_Click(object sender, EventArgs e)
        {
            if (btnAddOrAddBookCopy.Text == "ADD")
            {
                if (string.IsNullOrWhiteSpace(cmb_Status.selectedValue) || string.IsNullOrWhiteSpace(txt_AccessionNumber.Text) || string.IsNullOrWhiteSpace(txt_BookIDNum.Text) || string.IsNullOrWhiteSpace(txt_Title.Text) || string.IsNullOrWhiteSpace(txt_ISBN.Text) || string.IsNullOrWhiteSpace(txt_Publisher.Text) || string.IsNullOrWhiteSpace(txt_CopyrightYear.Text))
                {
                    MessageBox.Show("Incomplete Information!\nPlease enter values in textboxes that has (*) indicator.");
                }
                else
                {
                    if (bk.DoesBookCopyExist("ISBN",txt_ISBN.Text) == true)
                    {
                        MessageBox.Show("Book already exist in the database. Please add a copy instead.");
                        dgvBook.DataSource = db.sp_SearchBook("ISBN", txt_ISBN.Text);
                        AssignValuesToTextBox();
                    }
                    else
                    {
                        bk.BookIDNumber = txt_BookIDNum.Text;
                        bk.BookType = cmbBookType.selectedValue;
                        bk.ISBN = txt_ISBN.Text;
                        bk.AccessionNumber = int.Parse(txt_AccessionNumber.Text);
                        bk.CallNumber = txt_CallNumber.Text;
                        bk.DateReceived = DateTime.Parse(dtp_DateReceived.Text);
                        bk.Title = txt_Title.Text;
                        bk.Author = txt_Author.Text;
                        bk.Publisher = txt_Publisher.Text;
                        if (txt_CopyrightYear.Text != "") bk.CopyrightYear = int.Parse(txt_CopyrightYear.Text);
                        bk.Edition = txt_Edition.Text;
                        bk.Volume = txt_Volume.Text;
                        if (txt_Pages.Text != "") bk.Pages = int.Parse(txt_Pages.Text);
                        bk.Status = cmb_Status.selectedValue;
                        bk.Remarks = txt_Remarks.Text;
                        bk.AddRecord();
                        dgvBook.DataSource = db.sp_ViewBook(); ;
                        MessageBox.Show("Sucessfully Added!");
                        ClearText();
                        txt_BookIDNum.Text = bk.GenerateBookIDNum();
                        cmbBookType.selectedIndex = 0;
                        gb_Copy.Visible = true;
                    }
                    
                }            
            }
            else
            {
                BookCopy bc = new BookCopy(txt_BookIDNum.Text);
                bc.Show();
                this.Hide();
            }
        }
        
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignValuesToTextBox();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
            txt_BookIDNum.Text = bk.GenerateBookIDNum();
            cmbBookType.Text = "References";
            gb_Copy.Visible = true;
            btnUpdate.Visible = false;
            lbl_NumCopies.Visible = false;
            dgvBook.DataSource = db.sp_ViewBook();
        }
        

        private void txt_AccessionNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CopyrightYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt_CopyrightYear.MaxLength = 4;
            bk.SetMaximumLength(txt_CopyrightYear, 4);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cmb_SelectedCategory_onItemSelected(object sender, EventArgs e)
        {
            if (cmb_SearchCategory.selectedValue == "QR Code")
            {
                link_ScanQr.Visible = true;
                txt_Search.Visible = false;
            }
            else
            {
                txt_Search.Visible = true;
                link_ScanQr.Visible = false;
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BookIDNum.Text) || string.IsNullOrWhiteSpace(txt_Title.Text) || string.IsNullOrWhiteSpace(txt_Publisher.Text) || string.IsNullOrWhiteSpace(txt_CopyrightYear.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in textboxes that has (*) indicator.");
            }
            else
            {
                bk.BookIDNumber = txt_BookIDNum.Text;
                bk.BookType = cmbBookType.selectedValue;
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
                btnUpdate.Visible = false;
            }
        }

        private void txt_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            bk.SetMaximumLength(txt_ISBN, 13);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Hide();
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
             dgvBook.DataSource= db.sp_SearchBook(cmbBookType.selectedValue, txt_Search.Text);
        }

        private void link_ScanQr_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("book");
            scan.Show();
            this.Hide();
        }
        public void AssignValuesToTextBox()
        {
            btnAddOrAddBookCopy.Text = "ADD COPY";
            gb_Copy.Visible = false;
            btnUpdate.Visible = true;
            txt_BookIDNum.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            bk.setDrpText(cmbBookType, dgvBook.CurrentRow.Cells[1].Value.ToString());
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

            lbl_NumCopies.Visible = true;
            lbl_NumCopies.Text = "Total No. of Copies : " + db.sp_TotalBookCopy(txt_BookIDNum.Text).Count().ToString();
        }
        public void ClearText()
        {
            txt_ISBN.Text = "";
            txt_AccessionNumber.Text = "";
            txt_CallNumber.Text = "";
            txt_Title.Text = "";
            txt_Author.Text = "";
            txt_Publisher.Text = "";
            txt_CopyrightYear.Text = "";
            txt_Edition.Text = "";
            txt_Volume.Text = "";
            txt_Pages.Text = "";
            cmb_Status.Text = "";
            txt_Remarks.Text = "";
            btnAddOrAddBookCopy.Text = "ADD";
        }

    }
}
