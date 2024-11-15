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
    public partial class frmOrdersList : Form
    {
        public frmOrdersList()
        {
            InitializeComponent();
        }
        private void frmOrdersList_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
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
            dbConnector.Close();
        }
    }
}
