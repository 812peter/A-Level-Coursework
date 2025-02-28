using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Coursework
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        string userID;
        string email;
        string firstName;
        string surname;
        string phoneNumber;
        string companyName;
        bool manager = false;
        bool ordered = false;

        public bool frmEditOpen = false;
        public bool frmAddrOpen = false;

        private frmAddresses frmAddresses = null;
        private frmEditDetails frmEditDetails = null;

        public void frmAccount_Load(object sender, EventArgs e)
        {
            PullData();
            lblAccountType.Text = " Customer ";
            if (manager)
            {
                lblAccountType.Text = " Manager ";
            }
            lblName.Text = $"{firstName} {surname}";
        }

        private void PullData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            StreamReader currentFile = new StreamReader("temp.txt");
            email = currentFile.ReadLine();
            currentFile.Close();
            dbConnector.Connect();
            sqlStr = $"SELECT FirstName, Surname, PhoneNumber, CompanyName, Manager, UserID FROM tblUser WHERE Email = '{email}'";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                firstName = dr[0].ToString();
                surname = dr[1].ToString();
                phoneNumber = dr[2].ToString();
                companyName = dr[3].ToString();
                if (dr[4].ToString() == "True")
                {
                    manager = true;
                }
                userID = dr[5].ToString();
            }

            sqlStr = $"SELECT OrderID FROM tblOrder WHERE UserID = '{userID}'";
            dbConnector.Close();
            while (dr.Read())
            {
                if (dr[0] != DBNull.Value)
                {
                    ordered = true;
                }
            }
            dbConnector.Close();
            //
            //!!!!FINISH ORDERS BY CUSTOMERS!!!!!!!!
            //
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to sign out?", "Signing Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete("user details.txt");
                File.Delete("temp.txt");
                Application.Restart();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!frmEditOpen)
            {
                frmEditOpen = true;
                frmEditDetails = new frmEditDetails();
                frmEditDetails.Show();
                frmEditDetails.LoadDetails(userID, firstName, surname, email, phoneNumber, companyName);
            }
            else
            {
                frmEditDetails.BringToFront();
                frmEditDetails.WindowState = FormWindowState.Normal;
            }
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            if (!frmAddrOpen)
            {
                frmAddrOpen = true;
                frmAddresses = new frmAddresses();
                frmAddresses.Show();
                frmAddresses.EditAccountAddress(userID);
            }
            else
            {
                frmAddresses.BringToFront();
                frmAddresses.WindowState = FormWindowState.Normal;
            }
        }

        private void frmAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmMain"] as frmMain != null)
            {
                (Application.OpenForms["frmMain"] as frmMain).frmAccOpen = false;
            }
        }

        private void frmAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmMain"] as frmMain != null)
            {
                (Application.OpenForms["frmMain"] as frmMain).frmAccOpen = false;
            }
        }
    }
}
