using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework
{
    public partial class frmMain : Form
    {
        clsDBConnector dbConnector = new clsDBConnector();
        OleDbDataReader dr;
        string sqlStr;

        public bool frmMUOpen = false;
        public bool frmAddrOpen = false;
        public bool frmAccOpen = false;

        private frmManageUsers frmManageUsers = null;
        private frmAddresses frmAddresses = null;
        private frmAccount frmAccount = null;

        private const int MaxColumnWidth = 200;
        string selectedOrderID = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (true)
            {
                //tabControl1.TabPages.Remove(tabPage1); some pages are hidden from customers
            }
            DisplayData(false);
            panel1.Visible = false;
        }

        public string GetBoolEmoji(string boolean)
        {
            if (boolean.ToLower() == "true")
            {
                return "✔";
            }
            return "❌";
        }

        public void DisplayData(bool v)
        {
            selectedOrderID = "";
            dbConnector.Connect();
            sqlStr = "SELECT OrderID, UserID, DateOfOrder, TotalPaid, Completed, DateOfCompletion, AddressID FROM tblOrder ORDER BY Completed DESC";
            dr = dbConnector.DoSQL(sqlStr);
            lstOrders.Items.Clear();
            while (dr.Read())
            {
                lstOrders.Items.Add(dr[0].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(GetDateOnly(dr[2]));
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add("£" + dr[3].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(GetBoolEmoji(dr[4].ToString()));
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(GetDateOnly(dr[5]));
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[6].ToString());
            }

            sqlStr = $"SELECT UserID, FirstName, Surname, Email, PhoneNumber, CompanyName FROM tblUser WHERE Manager = {v} ORDER BY UserID DESC";
            dr = dbConnector.DoSQL(sqlStr);
            lstCustomers.Items.Clear();
            while (dr.Read())
            {
                lstCustomers.Items.Add(dr[0].ToString());
                lstCustomers.Items[lstCustomers.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstCustomers.Items[lstCustomers.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstCustomers.Items[lstCustomers.Items.Count - 1].SubItems.Add(dr[3].ToString());
                lstCustomers.Items[lstCustomers.Items.Count - 1].SubItems.Add(dr[4].ToString());
                lstCustomers.Items[lstCustomers.Items.Count - 1].SubItems.Add(dr[5].ToString());
            }
            dbConnector.Close();
        }

        public string GetDateOnly(object originalDBDate)
        {
            if (originalDBDate != DBNull.Value)
            {
                DateTime fullDate = Convert.ToDateTime(originalDBDate);
                return fullDate.ToString("dd/MM/yyyy");
            }
            return "❌";
        }

        private void lstCustomers_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (lstCustomers.Columns[e.ColumnIndex].Width > MaxColumnWidth)
            {
                lstCustomers.Columns[e.ColumnIndex].Width = MaxColumnWidth;
            }
        }
        private void lstOrders_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (lstOrders.Columns[e.ColumnIndex].Width > MaxColumnWidth)
            {
                lstOrders.Columns[e.ColumnIndex].Width = MaxColumnWidth;
            }
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            if (!frmMUOpen)
            {
                frmMUOpen = true;
                frmManageUsers = new frmManageUsers();
                frmManageUsers.Show();
            }
            else
            {
                frmManageUsers.BringToFront();
                frmManageUsers.WindowState = FormWindowState.Normal;
            }
        }

        private void btnAddresses_Click(object sender, EventArgs e)
        {
            if (!frmAddrOpen)
            {
                frmAddrOpen = true;
                frmAddresses = new frmAddresses();
                frmAddresses.Show();
            }
            else
            {
                frmAddresses.BringToFront();
                frmAddresses.WindowState = FormWindowState.Normal;
            }
        }
        private void picAccount_Click(object sender, EventArgs e)
        {
            if (!frmAccOpen)
            {
                frmAccOpen = true;
                frmAccount = new frmAccount();
                frmAccount.Show();
            }
            else
            {
                frmAccount.BringToFront();
                frmAccount.WindowState = FormWindowState.Normal;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                DisplayData(true);
            }
            else
            {
                DisplayData(false);
            }
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstOrders.SelectedItems[0];
                selectedOrderID = selectedItem.SubItems[0].Text;
            }
            else
            {
                selectedOrderID = "";
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedOrderID == "")
            {
                MessageBox.Show("You have not selected an order to view.", "Error");
            }
            else
            {
                frmOrderDetails frmOrderDetails = new frmOrderDetails();
                frmOrderDetails.Show();
                frmOrderDetails.LoadDetails(selectedOrderID);
            }
        }

        private void lstOrders_DoubleClick(object sender, EventArgs e)
        {
            if (selectedOrderID != "")
            {
                frmOrderDetails frmOrderDetails = new frmOrderDetails();
                frmOrderDetails.Show();
                frmOrderDetails.LoadDetails(selectedOrderID);
            }
        }
    }
}
