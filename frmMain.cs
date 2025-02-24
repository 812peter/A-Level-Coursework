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

        private const int MaxColumnWidth = 200;

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

        public void DisplayData(bool v)
        {
            checkBox1.Checked = v;
            dbConnector.Connect();
            sqlStr = "SELECT OrderID, UserID, DateOfOrder, TotalPaid, Completed, DateOfCompletion, AddressID FROM tblOrder";
            dr = dbConnector.DoSQL(sqlStr);
            lstOrders.Items.Clear();
            while (dr.Read())
            {
                lstOrders.Items.Add(dr[0].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(GetDateOnly(dr[2]));
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add("£" + dr[3].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[4].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(GetDateOnly(dr[5]));
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[6].ToString());
            }

            sqlStr = $"SELECT UserID, FirstName, Surname, Email, PhoneNumber, CompanyName FROM tblUser WHERE Manager = {v}";
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

        private string GetDateOnly(object originalDBDate)
        {
            DateTime fullDate = Convert.ToDateTime(originalDBDate);
            return fullDate.ToString("dd/MM/yyyy");
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
                frmManageUsers frmManageUsers = new frmManageUsers();
                frmManageUsers.Show();
            }
            //FINISH (focus if open) + EVERY FORM
        }

        private void btnAddresses_Click(object sender, EventArgs e)
        {
            frmAddresses frmAddresses = new frmAddresses();
            frmAddresses.Show();
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

        private void picAccount_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount();
            frmAccount.Show();
        }
    }
}
