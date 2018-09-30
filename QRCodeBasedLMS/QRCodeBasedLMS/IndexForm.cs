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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void link_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm("");
            mf.Show();
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow sbi = new Borrow("index","brwr");
            sbi.ShowDialog();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
           
        }

        private void link_Attendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttendanceMonitoring am = new AttendanceMonitoring("");
            am.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm("");
            mf.Show();
            this.Hide();
        }

        private void link_SignIn_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Hide();
        }

        private void link_Attendance_Click(object sender, EventArgs e)
        {
            AttendanceMonitoring am = new AttendanceMonitoring("");
            am.Show();
            this.Hide();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("brwr","inquiry");
            scan.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BookSearch bs = new BookSearch("brwr","");
            bs.Show();
            this.Hide();
        }
    }
}
