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
    public partial class AttendanceMonitoring : Form
    {
        private string qrcode;
        public AttendanceMonitoring(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
    
        dcLMSDataContext db = new dcLMSDataContext();
        
        private void AttendanceMonitoring_Load(object sender, EventArgs e)
        {
            if (qrcode != "")
            {
                txt_SchoolID.Text = qrcode;
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Lastname).FirstOrDefault();
            
            if (fname != null && lname != null)
            {
                txt_Name.Text = lname + ", " + fname;
                MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                encode.QRCodeScale = 6;
                Bitmap bmp = encode.Encode(txt_SchoolID.Text);
                pb_ScanQR.Image = bmp;
            }
        }

        
        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Close();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            db.sp_Attendance(txt_SchoolID.Text, txt_Name.Text, dt);
            txt_SchoolID.Clear();
            txt_Name.Clear();
        }

        private void link_ScanQR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("attendance","");
            scan.Show();
            this.Hide();
        }
    }
}
