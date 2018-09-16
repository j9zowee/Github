using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QRCodeBasedLMS
{
    public partial class LibraryUserMasterlist : Form
    {
        public LibraryUserMasterlist()
        {
            InitializeComponent();
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Excel Files | *.xlsx; *.xls; *.xlsm";

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = fd.FileName;
            }

            string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                        txtFilePath.Text + ";Extended Properties='Excel 12.0;HDR=YES;';";
            OleDbConnection con = new OleDbConnection(constr);
            if (txtFilePath.Text == "")
            {
                MessageBox.Show("Select a file.");
            }
            else
            {
                OleDbDataAdapter sda = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvList.DataSource = dt;


                DialogResult res = MessageBox.Show("Do you want to import this table to the database?", "Save table", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if(db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue).Count() != 0)
                    {
                        MessageBox.Show("This record of library users already exists in the database.");
                    }
                    else
                    {
                        for (int i = 0; i < dgvList.RowCount; i++)
                        {

                            db.sp_AddLibraryUser(dgvList.Rows[i].Cells[0].Value.ToString(), dgvList.Rows[i].Cells[1].Value.ToString(), dgvList.Rows[i].Cells[2].Value.ToString(),
                                dgvList.Rows[i].Cells[3].Value.ToString(), dgvList.Rows[i].Cells[4].Value.ToString(), dgvList.Rows[i].Cells[5].Value.ToString(), cmbLibraryUser.selectedValue, cmbSchoolYear.selectedValue, false);

                        }
                        MessageBox.Show("Successfully Saved to the database!");
                        dgvList.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                    }
                }
                else
                {

                }
            }
        }
        
        private void LibraryUserMasterlist_Load(object sender, EventArgs e)
        {
            for (int x = DateTime.Today.Year; x >= (DateTime.Today.Year -10); x--)
            {
                cmbSchoolYear.AddItem(x + " - " + (x + 1));
            }
            cmbLibraryUser.selectedIndex = 0;
            cmbSchoolYear.selectedIndex = 0;

            dgvList.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
        }

        private void cmbLibraryUser_onItemSelected(object sender, EventArgs e)
        {
            if(cmbLibraryUser.selectedIndex != -1)
            {
                dgvList.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            
        }

        private void cmbSchoolYear_onItemSelected(object sender, EventArgs e)
        {
            if (cmbSchoolYear.selectedIndex != -1)
            {
                dgvList.DataSource = db.sp_ViewLibraryUser(cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm("");
            main.Show();
            this.Hide();
        }
    } 
}
