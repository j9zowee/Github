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
                txt_SchoolIDNumber.Text = qrcode;
                DateTime dt = DateTime.Now;
                db.sp_Attendance(txt_SchoolIDNumber.Text, txt_Name.Text, dt);
                MessageBox.Show("Successfully recorded your attendance.");
                txt_SchoolIDNumber.Text = "";
                txt_Name.Text = "";
            }
        }
        
        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Close();
        }
        
        private void txt_SchoolID_OnValueChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolIDNumber.Text
                         select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolIDNumber.Text
                         select s.lib_Lastname).FirstOrDefault();

            if (fname != null && lname != null)
            {
                txt_Name.Text = lname + ", " + fname;
                MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                encode.QRCodeScale = 6;
                Bitmap bmp = encode.Encode(txt_SchoolIDNumber.Text);
                pb_ScanQR.Image = bmp;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            db.sp_Attendance(txt_SchoolIDNumber.Text, txt_Name.Text, dt);
            txt_SchoolIDNumber.Text = "";
            txt_Name.Text = "";
        }

        private void link_ScanQR_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("attendance");
            scan.Show();
            this.Hide();
        }
        
    }
}
