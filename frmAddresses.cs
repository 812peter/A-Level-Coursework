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
using System.Text.RegularExpressions;

namespace Coursework
{
    public partial class frmAddresses : Form
    {

        public frmAddresses()
        {
            InitializeComponent();
        }

        class CLsUser
        {
            public int userid { get; set; }
            public string username { get; set; }
        }

        private void frmAddresses_Load(object sender, EventArgs e)
        {
            cmbCustomerID.Text = "Select";
        }

        private void ClearFields()
        {
            string emptyStr = "";
            txtFirstLine.Text = emptyStr;
            txtTown.Text = emptyStr;
            txtPostcode.Text = emptyStr;
        }

        private void cmbCustomerID_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbCustomerID.Text == "Select")
            {
                PopulateCombo();
            }
        }

        private void PopulateCombo()
        {
            List<CLsUser> userList = new List<CLsUser>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT UserID, (Surname & " + "', '" + "& FirstName) as username FROM tblUser";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                userList.Add(new CLsUser { userid = Convert.ToInt32(dr[0]), username = dr[1].ToString() });
            }
            cmbCustomerID.DisplayMember = "username";
            cmbCustomerID.ValueMember = "userid";
            cmbCustomerID.DataSource = userList;
            dbConnector.Close();
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedValue != null)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT AddressID, FirstLine, Town, Postcode" +
                         " FROM tblAddress" +
                         " WHERE UserID = " + cmbCustomerID.SelectedValue;
                dr = dbConnector.DoSQL(sqlStr);
                lstAddresses.Items.Clear();
                while (dr.Read())
                {
                    lstAddresses.Items.Add(dr[0].ToString());
                    lstAddresses.Items[lstAddresses.Items.Count - 1].SubItems.Add(dr[1].ToString());
                    lstAddresses.Items[lstAddresses.Items.Count - 1].SubItems.Add(dr[2].ToString());
                    lstAddresses.Items[lstAddresses.Items.Count - 1].SubItems.Add(dr[3].ToString());
                }
                dbConnector.Close();
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (cmbCustomerID.Text == "Select")
            {
                MessageBox.Show("You need to select a user first.");
            }
            else
            {
                if (CheckValid() == true)
                {
                    clsDBConnector dbConnector = new clsDBConnector();
                    string cmdStr = $"INSERT INTO tblAddress (UserID, FirstLine, Town, Postcode) " +
                                    $"VALUES ('{cmbCustomerID.SelectedValue}', '{txtFirstLine.Text}', '{txtTown.Text}', '{txtPostcode.Text}')";
                    dbConnector.Connect();
                    dbConnector.DoDML(cmdStr);
                    dbConnector.Close();
                    cmbCustomerID_SelectedIndexChanged(sender, e);
                }

            }
        }

        private bool CheckValid()
        {
            if (txtFirstLine.Text == "" || txtTown.Text == "" || txtPostcode.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.");
                return false;
            }
            string pattern = @"^\d+[A-Za-z]?\s([A-Z][a-z]*)(\s([A-Z][a-z]*))*";
            Match tryToMatch = Regex.Match(txtFirstLine.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid first line of address (e.g., 1a Alexander Road).");
                return false;
            }
            pattern = @"^[A-Z][a-z]+(?:[\s-][a-zA-Z]+)*$";
            tryToMatch = Regex.Match(txtTown.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid town (e.g., North London).");
                return false;
            }
            pattern = @"^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})$";
            tryToMatch = Regex.Match(txtPostcode.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid postcode (e.g., BH2 7JP).");
                return false;
            }
            return true;
        }

        internal void SetUpNewCustomer()
        {
            PopulateCombo();
            int highestUserID = FindHighestID();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string username = "";
            dbConnector.Connect();
            sqlStr = "SELECT (Surname & " + "', '" + $"& FirstName) FROM tblUser WHERE UserID = {highestUserID}";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                username = dr[0].ToString();
            }
            dbConnector.Close();
            cmbCustomerID.Text = username;
            cmbCustomerID.SelectedValue = highestUserID;
        }

        private int FindHighestID()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT MAX(UserID) FROM tblUser";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                return Convert.ToInt32(dr[0]);
            }
            dbConnector.Close();
            return 0;
        }
    }
}
