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
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        internal void LoadDetails(string selectedOrderID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblOrder.UserID, tblOrder.DateOfOrder, tblOrder.TotalPaid, tblOrder.Completed, tblOrder.DateOfCompletion, (tblAddress.FirstLine & ', ' & tblAddress.Town & ', ' & tblAddress.Postcode) AS address " +
                     "FROM (tblOrder INNER JOIN tblAddress ON tblOrder.AddressID = tblAddress.AddressID) " +
                    $"WHERE tblOrder.OrderID = {selectedOrderID}";
            dr = dbConnector.DoSQL(sqlStr);
            dr.Read();
            int userID = Convert.ToInt32(dr[0]);
            string dateOfOrder = (Application.OpenForms["frmMain"] as frmMain).GetDateOnly(dr[1]).ToString();
            lblDateOfOrder.Text += dateOfOrder;
            double subtotal = Convert.ToDouble(dr[2]) / 1.2;
            double total = Convert.ToDouble(dr[2]);
            double VAT = total - subtotal;
            lblTotalPaidNoVAT.Text += "£" + subtotal.ToString();
            lblVAT.Text += "£" + VAT.ToString();
            lblTotalPaid.Text += "£" + total.ToString();
            if (dr[3].ToString() == "True")
            {
                chkCompleted.Checked = true;
            }
            lblDateOfCompletion.Text += (Application.OpenForms["frmMain"] as frmMain).GetDateOnly(dr[4]).ToString();
            lblAddress.Text += dr[5].ToString();

            sqlStr = "SELECT Quantity, ProductName, DiameterInMM, Material, PricePerMeter FROM tblProductOrder, tblProduct " +
                     $"WHERE OrderID = {selectedOrderID} AND tblProductOrder.ProductID = tblProduct.ProductID";
            dr = dbConnector.DoSQL(sqlStr);
            lstProducts.Items.Clear();
            while (dr.Read())
            {
                lstProducts.Items.Add(dr[0].ToString());
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add((dr[1]).ToString());
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add(dr[3].ToString());
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add("£" + (Convert.ToDouble(dr[4]) * Convert.ToDouble(dr[0])));
            }

            dbConnector.Close();
            //add totalpaid (+vat), products and user info
        }

    }
}
