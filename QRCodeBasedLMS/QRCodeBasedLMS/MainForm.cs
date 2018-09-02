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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book bk = new Book("");
            bk.Show();
            this.Hide();
        }
        private void RegistrationToolStripMenu_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Hide();
        }

        private void updateBookInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBookInfo upbk = new UpdateBookInfo();
            upbk.Show();
            this.Hide();
        }

        
        private void unapprovedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnapprovedAccounts ua = new UnapprovedAccounts("");
            ua.Show();
            this.Hide();
        }

        private void otherUserAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation ui = new UserInformation("");
            ui.Show();
            this.Hide();
        }

        private void libraryUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryUserMasterlist lum = new LibraryUserMasterlist();
            lum.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow brw = new Borrow("borrow","");
            brw.Show();
            this.Hide();
        }

        private void borrowersInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower b = new Borrower("","");
            b.Show();
            this.Hide();

        }

        private void printLibraryCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowerInfoForLibraryCard b = new BorrowerInfoForLibraryCard();
            b.Show();
            this.Hide();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow br = new Borrow("return","");
            br.Show();
            this.Hide();
        }
    }
}
