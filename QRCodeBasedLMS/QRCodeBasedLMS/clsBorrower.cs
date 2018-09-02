using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeBasedLMS
{
    class clsBorrower : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();

        //properties
        private string borrowerIDNumber;
        public string BorrowerIDNumber
        {
            get { return borrowerIDNumber; }
            set { borrowerIDNumber = value; }
        }
        private string schoolID;
        public string SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private string section;
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string contactnumber;
        public string ContactNumber
        {
            get { return contactnumber; }
            set { contactnumber = value; }
        }


        //methods
        public override void AddRecord()
        {
            db.sp_AddBorrower(borrowerIDNumber, schoolID, firstname, lastname, section, gender, address, contactnumber);
        }

        public override void UpdateRecord()
        {
            db.sp_UpdateBorrower(borrowerIDNumber, schoolID, firstname, lastname, section, gender, address, contactnumber);
        }
        
    }
}
