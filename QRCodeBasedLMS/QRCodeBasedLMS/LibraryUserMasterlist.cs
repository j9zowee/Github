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
                    string schoolyear = cmbStartYear.Text + "-" + txtEndYear.Text;
                    for (int i = 0; i < dgvList.RowCount; i++)
                    {
                        
                        db.sp_AddLibraryUser(dgvList.Rows[i].Cells[0].Value.ToString(), dgvList.Rows[i].Cells[1].Value.ToString(), dgvList.Rows[i].Cells[2].Value.ToString(),
                            dgvList.Rows[i].Cells[3].Value.ToString(), dgvList.Rows[i].Cells[4].Value.ToString(), dgvList.Rows[i].Cells[5].Value.ToString(),cmbLibraryUser.Text,schoolyear, false);
                        
                    }
                    MessageBox.Show("Successfully Saved to the database!");
                    dgvList.DataSource = db.sp_ViewLibraryUser(schoolyear);
                }
                else
                {
                    
                }
            }
        }

        
        private void cmbStartYear_Leave(object sender, EventArgs e)
        {
            int endyear = int.Parse(cmbStartYear.Text) + 1;
            txtEndYear.Text = endyear.ToString();
        }

        private void LibraryUserMasterlist_Load(object sender, EventArgs e)
        {

        }
    } 
}
