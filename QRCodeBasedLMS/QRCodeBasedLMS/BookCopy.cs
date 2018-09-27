﻿using System;
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
    public partial class BookCopy : Form
    {
        private string usertype;
        public BookCopy(string type, string bookIDNum)
        {
            InitializeComponent();
            usertype = type;
            txt_BookIDNum.Text = bookIDNum;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsBook bk = new clsBook();
        private void BookCopy_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.sp_ViewBookCopy(txt_BookIDNum.Text);
            cmb_Status.selectedIndex = 0;
            ClearText();
            btnPrintQR.Enabled = false;
        }
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddOrUpdate.Text = "UPDATE";
            txt_BookIDNum.Enabled = false;
            txt_AccessionNumber.Enabled = false;
            dtp_DateReceived.Enabled = false;
            txt_AccessionNumber.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            dtp_DateReceived.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            bk.SetDropdownText(cmb_Status, dgvBook.CurrentRow.Cells[3].Value.ToString());
        }

        private void txt_AccessionNumber_OnValueChanged(object sender, EventArgs e)
        {
            pb_QRBook.Image = bk.GenerateQRCode(txt_AccessionNumber.Text);
            if (txt_AccessionNumber.Text == "") btnPrintQR.Enabled = false;
            else btnPrintQR.Enabled = true;
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
            Book bk = new Book(usertype,"");
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
        
        private void btnPrintQR_Click(object sender, EventArgs e)
        {
            if (usertype == "Staff")
            {
                MessageBox.Show("Only administrators can print QR codes.");
            }
            else
            {
                //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                //{
                //    sfd.FileName = txt_AccessionNumber.Text;
                //    if (sfd.ShowDialog() == DialogResult.OK)
                //    {
                //        pb_QRBook.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                //    }
                //}
                printPreviewDialog1.ShowDialog();
                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pb_QRBook.Image, 25, 40, 130, 130);
            e.Graphics.DrawString("Accession No.: " + txt_AccessionNumber.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));
        }
    }
}
