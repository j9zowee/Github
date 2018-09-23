using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeBasedLMS
{
    class clsNonReadingMaterials : clsLibrary
    {
        dcLMSDataContext db = new dcLMSDataContext();
        private string materialIDNumber;
        public string MaterialIDNumber
        {
            get { return materialIDNumber; }
            set { materialIDNumber = value; }
        }
        private string materialType;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string volume;
        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private string issue;
        public string Issue
        {
            get { return issue; }
            set { issue = value; }
        }
        private int copyrightYear;
        public int CopyrightYear
        {
            get { return copyrightYear; }
            set { copyrightYear = value; }
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
        private int page;
        public int Page
        {
            get { return page; }
            set { page = value; }
        }
        private int numberOfCopies;
        public int NumberOfCopies
        {
            get { return numberOfCopies; }
            set { numberOfCopies = value; }
        }

        public override string GenerateIDNumber()
        {
            DateTime dt = DateTime.Now;
            string materialnum = "NRM-" + (db.sp_LastNonReadingIDNumber().Count() + 1) + "-" + dt.Day + dt.Month + dt.Year;
            return materialnum;
        }
        public override void AddRecord()
        {
            db.sp_AddNonReadingMaterial(materialIDNumber,materialType,title,volume,issue,copyrightYear,author,publisher,page,numberOfCopies);
        }
        public override void UpdateRecord()
        {
            db.sp_UpdateNonReadingMaterial(materialIDNumber, materialType, title, volume, issue, copyrightYear, author, publisher, page, numberOfCopies);
        }
    }
}
