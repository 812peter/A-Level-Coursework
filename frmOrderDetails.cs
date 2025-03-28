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

        Random rnd = new Random();
        bool chkCompletedEvent = false;
        int orderID;
        double subtotal;
        double total;
        double VAT;
        string dateOfOrder;
        List<string> productsList = new List<string>();
        List<string> qtyList = new List<string>();
        List<string> priceList = new List<string>();

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
            dateOfOrder = (Application.OpenForms["frmMain"] as frmMain).GetDateOnly(dr[1]).ToString();
            lblDateOfOrder.Text += dateOfOrder;
            subtotal = Convert.ToDouble(dr[2]) / 1.2;
            total = Convert.ToDouble(dr[2]);
            VAT = total - subtotal;
            lblTotalPaidNoVAT.Text += "£" + subtotal.ToString();
            lblVAT.Text += "£" + VAT.ToString();
            lblTotalPaid.Text += "£" + total.ToString();
            if (dr[3].ToString() == "True")
            {
                chkCompleted.Checked = true;
            }
            lblDateOfCompletion.Text += (Application.OpenForms["frmMain"] as frmMain).GetDateOnly(dr[4]).ToString();
            lblAddress.Text += dr[5].ToString();

            sqlStr = "SELECT Quantity, ProductName, DiameterInMM, Material, PricePerMeter, LengthInM FROM tblProductOrder, tblProduct " +
                     $"WHERE OrderID = {selectedOrderID} AND tblProductOrder.ProductID = tblProduct.ProductID ORDER BY Quantity DESC";
            dr = dbConnector.DoSQL(sqlStr);
            lstProducts.Items.Clear();
            while (dr.Read())
            {
                lstProducts.Items.Add(dr[0].ToString());
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add((dr[1]).ToString());
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add(dr[2].ToString() + " mm");
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
                double pricePP = Convert.ToDouble(dr[4]) * Convert.ToDouble(dr[0]) * Convert.ToDouble(dr[5]);
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add(dr[5].ToString() + " m");
                lstProducts.Items[lstProducts.Items.Count - 1].SubItems.Add("£" + pricePP.ToString());
                productsList.Add($"{(dr[1]).ToString().ToUpper()}{materialShortVer.ToLower()}{dr[2].ToString()}mm{dr[5].ToString()}m");
                qtyList.Add(dr[0].ToString());
                priceList.Add($"£{pricePP.ToString()}");
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
            int receiptLength = 450;
            foreach (var item in productsList)
            {
                receiptLength += 15;
            }
            PrintDocument receipt;
            receipt = new PrintDocument();
            receipt.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 350, receiptLength);
            receipt.DocumentName = $"Order #{orderID} Receipt";
            receipt.PrintPage += new PrintPageEventHandler(this.PrintReceiptPage);
            printPreviewDialog1.Document = receipt;
            printPreviewDialog1.ShowDialog();
            receipt.Dispose();
        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            Font myFont1 = new Font("Cooper", 18, FontStyle.Bold);
            Font myFont2 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font myFont3 = new Font("Times New Roman", 8);
            int x = e.MarginBounds.X - 50;
            int y = e.MarginBounds.Y - 70;
            e.Graphics.DrawString("REINFORCEMENTS", myFont1, Brushes.Black, x, y);
            y += 35;
            e.Graphics.DrawString("            120 St Georges Ave, Poole, BH12 4ND\n                             0-7927-369-011", myFont3, Brushes.Black, x, y);
            y += 58;
            e.Graphics.DrawString($"ORDER: #{orderID}   DATE: {dateOfOrder}   CARD: xxxx {GetRandom(1000, 9999)}", myFont3, Brushes.Black, x + 5, y);
            y += 18;
            e.Graphics.DrawString("========================================================", myFont3, Brushes.Black, -2, y);
            y += 30;
            e.Graphics.DrawString("NAME", myFont2, Brushes.Black, x, y);
            x = e.MarginBounds.X + 98;
            e.Graphics.DrawString("QTY", myFont2, Brushes.Black, x, y);
            x = e.MarginBounds.X + 158;
            e.Graphics.DrawString("PRICE", myFont2, Brushes.Black, x, y);
            y += 20;
            x = e.MarginBounds.X - 50;
            foreach (var product in productsList)
            {
                e.Graphics.DrawString(product, myFont3, Brushes.Black, x, y);
                y += 15;
            }
            x = e.MarginBounds.X + 98;
            y = 191;
            foreach (var qty in qtyList)
            {
                e.Graphics.DrawString(qty, myFont3, Brushes.Black, x, y);
                y += 15;
            }
            x = e.MarginBounds.X + 158;
            y = 191;
            priceList.Add(null);
            foreach (var price in priceList)
            {
                e.Graphics.DrawString(price, myFont3, Brushes.Black, x, y);
                if (price != null)
                {
                    y += 15;
                }
            }
            y += 20;
            e.Graphics.DrawString("========================================================", myFont3, Brushes.Black, -2, y);
            y += 30;
            x = e.MarginBounds.X - 50;
            e.Graphics.DrawString($"SUBTOTAL", myFont3, Brushes.Black, x, y);
            y += 15;
            e.Graphics.DrawString($"VAT", myFont3, Brushes.Black, x, y);
            y += 15;
            e.Graphics.DrawString($"TOTAL", myFont2, Brushes.Black, x, y);
            y -= 30;
            x = e.MarginBounds.X + 158;
            e.Graphics.DrawString($"£{subtotal}", myFont3, Brushes.Black, x, y);
            y += 15;
            e.Graphics.DrawString($"£{VAT}", myFont3, Brushes.Black, x, y);
            y += 15;
            e.Graphics.DrawString($"£{total}", myFont2, Brushes.Black, x, y);
            y += 50;
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(40, y), new Point(40, y + 30));
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(310, y), new Point(310, y + 30));
            for (int i = 0; i < 125; i++)
            {
                x = GetRandom(43, 308);
                int width = GetRandom(1, 2);
                e.Graphics.DrawLine(new Pen(Color.Black, width), new Point(x, y), new Point(x, y + 30));
            }
            e.Graphics.DrawString("THANK YOU!", myFont1, Brushes.Black, e.MarginBounds.X - 7, y + 60);
        }

        private int GetRandom(int min, int max)
        {
            return Convert.ToInt32(rnd.Next(min, max));
        }
    }
}

