using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    class clsBook:clsLibrary
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
        public override void UpdateRecord()
        {
            db.sp_UpdateBook(bookIDNumber, bookType,isbn, callNumber, title, author, publisher, copyrightYear, edition, volume, pages, remarks);
        }
        public override string GenerateIDNumber()
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_LastBookIDNum().Count()+1;
            string bookID = "BK-"+x+"-"+dt.Day+dt.Month+dt.Year;
            return bookID;
        }
        public Boolean DoesBookCopyExist(string category, string searchkey)
        {
            if (db.sp_SearchBook(category, searchkey).Count() != 0) return true;
            else return false;
        }
        public Boolean HasNullValues()
        {
            if (string.IsNullOrWhiteSpace(status) ||
                accessionNumber == 0 ||
                string.IsNullOrWhiteSpace(bookIDNumber) ||
                string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(isbn) ||
                string.IsNullOrWhiteSpace(publisher) ||
                copyrightYear == 0) return true;
            else return false;
            
        }
        public clsBook()
        {
            bookIDNumber = "";
            bookType = "";
            isbn = "";
            accessionNumber = 0;
            callNumber = "";
            dateReceived = DateTime.Now;
            title = "";
            author = "";
            publisher = "";
            copyrightYear = 0;
            edition = "";
            volume = "";
            pages = 0;
            status = "";
            remarks = "";
        }
    }
}
