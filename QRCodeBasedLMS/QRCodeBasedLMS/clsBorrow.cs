using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeBasedLMS
{
    class clsBorrow
    {
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
    }
}
