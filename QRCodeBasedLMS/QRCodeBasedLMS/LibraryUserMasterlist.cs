﻿using System;
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
        private string usertype;
        public LibraryUserMasterlist(string type)
        {
            InitializeComponent();
            usertype = type;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsBorrower brwr = new clsBorrower();
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
                    if(brwr.DoesBorrowerExist(cmbSchoolYear.selectedValue,cmbLibraryUser.selectedValue) == true)
                    {
                        MessageBox.Show("This record of library users already exists in the database.");
                    }
                    else
                    {
                        for (int i = 0; i < dgvList.RowCount; i++)
                        {
                            brwr.SchoolID = dgvList.Rows[i].Cells[0].Value.ToString();
                            brwr.Firstname = dgvList.Rows[i].Cells[1].Value.ToString();
                            brwr.Lastname = dgvList.Rows[i].Cells[2].Value.ToString();
                            brwr.Gender = dgvList.Rows[i].Cells[3].Value.ToString();
                            brwr.Address = dgvList.Rows[i].Cells[4].Value.ToString();
                            brwr.ContactNumber = dgvList.Rows[i].Cells[5].Value.ToString();
                            brwr.Usertype = cmbLibraryUser.selectedValue;
                            brwr.SchoolYear = cmbSchoolYear.selectedValue;
                            brwr.WithCard = false;
                            brwr.AddRecord();                            
                        }
                        MessageBox.Show("Successfully Saved to the database!");
                        dgvList.DataSource = db.sp_ViewLibraryUser(false,cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
                    }
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

            dgvList.DataSource = db.sp_ViewLibraryUser(false,cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
        }

        private void cmbLibraryUser_onItemSelected(object sender, EventArgs e)
        {
            if(cmbLibraryUser.selectedIndex != -1)
            {
                dgvList.DataSource = db.sp_ViewLibraryUser(false,cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
            
        }

        private void cmbSchoolYear_onItemSelected(object sender, EventArgs e)
        {
            if (cmbSchoolYear.selectedIndex != -1)
            {
                dgvList.DataSource = db.sp_ViewLibraryUser(false,cmbSchoolYear.selectedValue, cmbLibraryUser.selectedValue);
            }
        }

        private void link_GoBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usertype);
            main.Show();
            this.Hide();
        }
    } 
}
