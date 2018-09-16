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
    public partial class BookSearch : Form
    {
        private string usertype;
        private string qrcode;
        public BookSearch(string type,string qr)
        {
            InitializeComponent();
            usertype = type;
            qrcode = qr;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private void BookSearch_Load(object sender, EventArgs e)
        {
            if(qrcode != "")
            {
                cmb_SearchCategory.selectedIndex = 0;
                dgvBook.DataSource = db.sp_SearchBook("QR Code",qrcode);
            }
            else
            {
                dgvBook.DataSource = db.sp_ViewBook();
                cmb_SearchCategory.selectedIndex = 1;
            }
        }

        private void cmb_SearchCategory_onItemSelected(object sender, EventArgs e)
        {
            if (cmb_SearchCategory.selectedValue == "QR Code")
            {
                link_Scan.Visible = true;
                txt_Search.Visible = false;
            }
            else
            {
                txt_Search.Visible = true;
                link_Scan.Visible = false;
            }
            dgvBook.DataSource = db.sp_ViewBook();
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.selectedValue, txt_Search.Text);
        }

        private void link_Scan_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode(usertype,"booksearch");
            scan.Show();
            this.Hide();
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Hide();
        }
    }
}
