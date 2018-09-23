using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeBasedLMS
{
    class clsBorrow : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();

        private string accessionIDNumber;
        public string AccessionIDNumber
        {
            get { return accessionIDNumber; }
            set { accessionIDNumber = value; }
        }
        private string bookTitle;
        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }
        private DateTime dueDate;
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        
        public override string GenerateIDNumber()
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_LastBorrowNumber().Count() + 1;
            string borrowID = "BRW-" + x + "-" + dt.Day + dt.Month + dt.Year;
            return borrowID;
        }
        public Boolean DoesBorrowerHaveCard(string brwr)
        {
            DateTime dt = DateTime.Now;
            string currentSY = (from s in db.tblLibraryUsers select s.lib_SchoolYear).Max();
            Boolean withcard = Boolean.Parse((from s in db.tblLibraryUsers where s.lib_SchoolID == brwr && s.lib_SchoolYear == currentSY select s.lib_WithCard).FirstOrDefault().ToString());

            if (withcard == true) return true;
            else return false;
        }
        public Boolean DidBorrowerLoggedInForAttendance(string brwr)
        {
            DateTime dt = DateTime.Now;
            DateTime lastlogin = DateTime.Parse((from s in db.tblAttendances where s.attendance_StudentIDNum == brwr select s.attendance_LoginTime).Max().ToString());
            if (dt.Date == lastlogin.Date) return true;
            else return false;
        }
        public Boolean checkNumberofBorrowedBooksIsValid(string brwr, int rowCount)
        {
            if ((db.sp_BorrowedBooks(brwr).Count() + rowCount) <= 3) return true;
            else return false;
        }
    }
}
