using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    class clsBorrower : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();

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
        private string contactNumber;
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        private string usertype;
        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }
        private string schoolYear;
        public string SchoolYear
        {
            get { return schoolYear; }
            set { schoolYear = value; }
        }
        private Boolean withCard;
        public Boolean WithCard
        {
            get { return withCard; }
            set { withCard = value; }
        }

        public override void AddRecord()
        {
            db.sp_AddLibraryUser(schoolID, firstname, lastname, gender, address, contactNumber, usertype, schoolYear, withCard);
        }
        public override void UpdateRecord()
        {
            db.sp_UpdateLibraryUser(schoolID, firstname, lastname, gender, address, contactNumber, schoolYear, withCard);
        }
        public Boolean DoesBorrowerExist(string sy, string brwrtype)
        {
            if (db.sp_ViewLibraryUser(sy, brwrtype).Count() != 0) return true;
            else return false;
        }
        

    }
}
