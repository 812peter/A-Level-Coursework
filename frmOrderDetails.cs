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

        bool chkCompletedEvent = false;
        int orderID;

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
            orderID = Convert.ToInt32(selectedOrderID);
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
                     $"WHERE OrderID = {selectedOrderID} AND tblProductOrder.ProductID = tblProduct.ProductID ORDER BY Quantity DESC";
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

            sqlStr = $"SELECT FirstName, Surname, Email, PhoneNumber, CompanyName FROM tblUser WHERE UserID = {userID}";
            dr = dbConnector.DoSQL(sqlStr);
            dr.Read();
            lblName.Text = dr[0].ToString() + " " + dr[1].ToString();
            lblEmail.Text = dr[2].ToString();
            lblPhoneNumber.Text = dr[3].ToString();
            lblCompanyName.Text = dr[4].ToString();
            dbConnector.Close();
            chkCompletedEvent = true;
        }

        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompletedEvent)
            {
                if (chkCompleted.Checked)
                {
                    DialogResult dialogResult = MessageBox.Show($"Mark order #{orderID} as complete?", "Completing Order", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UpdateCompleteness(true);
                    }
                    else
                    {
                        chkCompletedEvent = false;
                        chkCompleted.Checked = false;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Mark order #{orderID} as uncomplete?", "Completing Order", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UpdateCompleteness(false);
                    }
                    else
                    {
                        chkCompletedEvent = false;
                        chkCompleted.Checked = true;
                    }
                }
            }
            else
            {
                chkCompletedEvent = true;
            }
        }

        private void UpdateCompleteness(bool completed)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"UPDATE tblOrder SET Completed = {completed}, ";
            if (completed)
            {
                string today = DateTime.Now.ToString("dd/MM/yyyy");
                cmdStr += $"DateOfCompletion = '{today}'";
                lblDateOfCompletion.Text = "Date of completion: " + today;
            }
            else
            {
                cmdStr += $"DateOfCompletion = null";
                lblDateOfCompletion.Text = "Date of completion: ❌";
            }
            cmdStr += $" WHERE OrderID = {orderID}";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["frmMain"] as frmMain).DisplayData(false);
        }
    }
}

