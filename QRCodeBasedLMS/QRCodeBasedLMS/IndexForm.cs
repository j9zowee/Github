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
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //Borrow sbi = new Borrow("borrow");
            //sbi.Show();
            //this.Hide();

            ScanQRCode scan = new ScanQRCode("index-borrow","");
            scan.Show();
            this.Hide();

        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void link_Attendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttendanceMonitoring am = new AttendanceMonitoring("");
            am.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void link_SignIn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void link_Attendance_Click(object sender, EventArgs e)
        {
            AttendanceMonitoring am = new AttendanceMonitoring("");
            am.Show();
            this.Hide();
        }
    }
}
