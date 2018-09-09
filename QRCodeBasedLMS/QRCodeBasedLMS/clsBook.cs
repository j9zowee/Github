using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    class clsBook : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();

        //properties
        private string bookIDNumber;
        public string BookIDNumber
        {
            get { return bookIDNumber; }
            set { bookIDNumber = value; }
        }
        private string bookType;
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private int accessionNumber;
        public int AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }
        private string callNumber;
        public string CallNumber
        {
            get { return callNumber; }
            set { callNumber = value; }
        }
        private DateTime dateReceived;
        public DateTime DateReceived
        {
            get { return dateReceived; }
            set { dateReceived = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private int copyrightYear;
        public int CopyrightYear
        {
            get { return copyrightYear; }
            set { copyrightYear = value; }
        }
        private string edition;
        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }
        private string volume;
        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private int pages;
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        //methods
        public override void AddRecord()
        {
                db.sp_AddBook(bookIDNumber, bookType, isbn, accessionNumber, callNumber, dateReceived, title, author, publisher, copyrightYear, edition, volume, pages, status, remarks);
            
        }
        public Boolean DoesBookCopyExist(string category,string searchkey)
        {
            if (db.sp_SearchBook(category,searchkey).Count() !=0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override void UpdateRecord()
        {
            db.sp_UpdateBook(bookIDNumber, bookType,isbn, callNumber, title, author, publisher, copyrightYear, edition, volume, pages, remarks);
        }
        public string GenerateBookIDNum()
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_LastBookIDNum().Count()+1;
            string bookID = "BK-"+x+"-"+dt.Day+dt.Month+dt.Year;
            return bookID;
        }
        public void SetMaximumLength(Bunifu.Framework.UI.BunifuMetroTextbox metroTextbox, int maximumLength)
        {
            foreach (Control ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;

                    // Set other properties & events here...
                }
            }
        }
        public void setDrpText(Bunifu.Framework.UI.BunifuDropdown drpCombo, string text)
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

    }
}
