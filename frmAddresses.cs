using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class frmAddresses : Form
    {
        public frmAddresses()
        {
            InitializeComponent();
        }
            //sqlStr = "SELECT AddressID, FirstLine, Town, Postcode" +
            //    " FROM tblAddress" +
            //    " WHERE CustomerID = " + cmbCustomerID.SelectedValue;
            //dr = dbConnector.DoSQL(sqlStr);
            //lstAddresses.Items.Clear();
            //while (dr.Read())
            //{
            //    lstAddresses.Items.Add(dr[0].ToString());
            //    lstAddresses.Items[lstAddresses.Items.Count - 1].SubItems.Add(dr[1].ToString());
            //    lstAddresses.Items[lstAddresses.Items.Count - 1].SubItems.Add(dr[2].ToString());
            //    lstAddresses.Items[lstAddresses.Items.Count - 1].SubItems.Add(dr[3].ToString());
            //}
}
}
