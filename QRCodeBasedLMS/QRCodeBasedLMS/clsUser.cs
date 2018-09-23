using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    class clsUser : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();

        //properties
        private string userIDNumber;
        public string UserIDNumber
        {
            get { return userIDNumber; }
            set { userIDNumber = value; }
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
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string secretQuestion;
        public string SecretQuestion
        {
            get { return secretQuestion; }
            set { secretQuestion = value; }
        }
        private string secretAnswer;
        public string SecretAnswer
        {
            get { return secretAnswer; }
            set { secretAnswer = value; }
        }
        private string usertype;
        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        //methods        
        public override void AddRecord()
        {
            db.sp_AddAccount(userIDNumber, firstname, lastname, username, password, secretQuestion, secretAnswer, usertype, status);
        }

        public override void UpdateRecord()
        {
            db.sp_UpdateAccount(userIDNumber, firstname, lastname, username, password, secretQuestion, secretAnswer, usertype, status);
        }
        public override string GenerateIDNumber()
        {
            DateTime dt = DateTime.Now;
            int x = db.sp_LastAcctIDNum().Count() + 1;
            string accID = "Acct-" + x + "-" + dt.Day + dt.Month + dt.Year;
            return accID;
        }

    }
}
