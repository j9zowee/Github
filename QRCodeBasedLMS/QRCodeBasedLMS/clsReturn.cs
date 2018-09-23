using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeBasedLMS
{
    class clsReturn : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();
        private string accessionNumber;
        public string AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
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
        private int noOfDaysUnreturned;
        public int NoOfDaysUnreturned
        {
            get { return noOfDaysUnreturned; }
            set { noOfDaysUnreturned = value; }
        }
        private double penaltyFee;
        public double PenaltyFee
        {
            get { return penaltyFee; }
            set { penaltyFee = value; }
        }

        public override string GenerateIDNumber()
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_LastReturnNumber().Count() + 1;
            string returnID = "RTN-" + x + "-" + dt.Day + dt.Month + dt.Year;
            return returnID;
        }
    }
}
