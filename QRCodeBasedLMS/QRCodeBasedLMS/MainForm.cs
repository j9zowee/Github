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
        private string usertype;
        public MainForm(string type)
        {
            InitializeComponent();
            usertype = type;
        }
        dcLMSDataContext db = new dcLMSDataContext();
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
        private void unapprovedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnapprovedAccounts ua = new UnapprovedAccounts(usertype);
            ua.Show();
            this.Hide();
        }

        private void otherUserAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void libraryUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryUserMasterlist lum = new LibraryUserMasterlist();
            lum.Show();
            this.Hide();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow brw = new Borrow("main");
            brw.Show();
            this.Hide();
        }
        
        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return r = new Return();
            r.Show();
            this.Hide();
        }

        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation ui = new UserInformation(usertype);
            ui.Show();
            this.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book bk = new Book(usertype,"");
            bk.Show();
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow brw = new Borrow("main");
            brw.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return ret = new Return();
            ret.Show();
            this.Hide();
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            Borrower brwr = new Borrower(usertype,"");
            brwr.Show();
            this.Hide();
        }

        private void nonReadingMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NonReadingMaterials nrm = new NonReadingMaterials();
            nrm.Show();
            this.Hide();
        }

        private void borrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower brwr = new Borrower(usertype,"");
            brwr.Show();
            this.Hide();
        }

        private void bookListingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookListings bl = new BookListings();
            bl.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(usertype);
            if (usertype == "Staff")
            {
                ms_accountsManager.Visible = false;
                ms_Reports.Visible = false;
            }
        }
    }
}
