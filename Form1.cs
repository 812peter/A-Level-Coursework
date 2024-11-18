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
    public partial class Main : Form
    {
        clsDBConnector dbConnector = new clsDBConnector();
        OleDbDataReader dr;
        string sqlStr;
        
        private const int MaxColumnWidth = 200;

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
          DisplayData();
        }

        public void DisplayData()
        {
            dbConnector.Connect();
            sqlStr = "SELECT OrderID, CustomerID, DateOfOrder, TotalPaid, Completed, DateOfCompletion, AddressID FROM tblOrder";
            dr = dbConnector.DoSQL(sqlStr);
            lstOrders.Items.Clear();
            while (dr.Read())
            {
                lstOrders.Items.Add(dr[0].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add("£" + dr[3].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[4].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[5].ToString());
                lstOrders.Items[lstOrders.Items.Count - 1].SubItems.Add(dr[6].ToString());
            }

            sqlStr = "SELECT CustomerID, FirstName, Surname, Email, PhoneNumber, CompanyName, AddressID FROM tblCustomer";
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
                lstCustomers.Items[lstCustomers.Items.Count - 1].SubItems.Add(dr[6].ToString());
            }
            dbConnector.Close();
        }

        private void lstCustomers_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (lstCustomers.Columns[e.ColumnIndex].Width > MaxColumnWidth)
            {
                lstCustomers.Columns[e.ColumnIndex].Width = MaxColumnWidth;
            }
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            frmManageCustomers frmManageCustomers = new frmManageCustomers();
            frmManageCustomers.Show();
        }
    }
}
