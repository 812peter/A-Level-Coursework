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

namespace Coursework
{
    public partial class frmCustomersList : Form
    {
        public frmCustomersList()
        {
            InitializeComponent();
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
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

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmManageCustomers frmManageCustomers = new frmManageCustomers();
            frmManageCustomers.Show();
        }
    }
}
