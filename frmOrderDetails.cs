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
using System.Drawing.Printing;

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
        List<string> products = new List<string>();

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
                string material = dr[3].ToString();
                string materialShortVer = "";
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add(material);
                for (int i = 0; i < material.Length; i++)
                {
                    string original = material[i].ToString();
                    string upper = material[i].ToString().ToUpper();
                    if (original == upper && original != " ")
                    {
                        materialShortVer += original;
                    }
                }
                double pricePP = Convert.ToDouble(dr[4]) * Convert.ToDouble(dr[0]);
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add("£" + pricePP.ToString());
                products.Add($"{(dr[1]).ToString().ToUpper()}{materialShortVer.ToLower()}{dr[2].ToString()}mm");
                products.Add(dr[0].ToString());
                products.Add($"£{pricePP.ToString()}");
                //products.Add($"{(dr[1]).ToString().ToUpper()}{materialShortVer.ToLower()}{dr[2].ToString()}mm                              {dr[0].ToString()}         £{pricePP.ToString()}");
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

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            PrintDocument receipt;
            receipt = new PrintDocument();
            receipt.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 350, 800);
            receipt.DocumentName = $"Order #{orderID} Receipt";
            receipt.PrintPage += new PrintPageEventHandler(this.PrintReceiptPage);
            printPreviewDialog1.Document = receipt;
            printPreviewDialog1.ShowDialog();
            receipt.Dispose();
        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            int y;
            int x;
            Font myFont1 = new Font("Cooper", 18, FontStyle.Bold);
            Font myFont2 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font myFont3 = new Font("Times New Roman", 8);
            x = e.MarginBounds.X - 50;
            y = e.MarginBounds.Y - 70;
            e.Graphics.DrawString("REINFORCEMENTS", myFont1, Brushes.Black, x, y);
            y += 35;
            e.Graphics.DrawString("            120 St Georges Ave, Poole, BH12 4ND\n                             0-7927-369-011", myFont3, Brushes.Black, x, y);
            y += 38;
            e.Graphics.DrawString("*****************************************************************", myFont3, Brushes.Black, 0, y);
            y += 30;
            e.Graphics.DrawString("NAME                               QTY         PRICE", myFont2, Brushes.Black, x, y);
            y += 15;
            int count = 0;
            foreach (var product in products)
            {
                e.Graphics.DrawString(product, myFont3, Brushes.Black, x, y);
                if (count % 2 == 0)
                {
                    y += 15;
                    x += 70;
                }
                else if (count % 3 == 0)
                {
                    x = e.MarginBounds.X - 50;
                    count = 0;
                }
                else
                {
                    x += 100;
                }
                count++;
            }
        }
    }
}

