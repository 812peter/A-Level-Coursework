using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

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
        public bool frmCartOpen = false;

        private frmManageUsers frmManageUsers = null;
        private frmAddresses frmAddresses = null;
        private frmAccount frmAccount = null;
        private frmCart frmCart = null;

        private const int MaxColumnWidth = 200;
        string selectedOrderID = "";

        private string documentContents;
        private string stringToPrint;
        private string header;
        private string startDate;
        private string endDate;
        private DateTime selectedMonth = DateTime.Now;

        private int productInStock;
        private string productID;
        private string userID;
        private bool manager = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DisplayData(false);
            if (!manager)
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage4);
            }
            VisibleProductLbls(false);
            LoadDynamicBtns();
            LoadChart();
            dateStart.Value = GetOrderDate("MIN");
            dateEnd.Value = GetOrderDate("MAX");
        }

        private void LoadChart()
        {
            int daysInMonth = DateTime.DaysInMonth(selectedMonth.Year, selectedMonth.Month);
            Dictionary<int, double> salesData = new Dictionary<int, double>();
            for (int i = 1; i <= daysInMonth; i++)
            {
                salesData[i] = 0;
            }
            chartSales.Series.Clear();
            chartSales.Series.Add("Sales");
            chartSales.Series["Sales"].Color = Color.Red;
            chartSales.ChartAreas[0].AxisX.Title = "Day";
            chartSales.ChartAreas[0].AxisY.Title = "Total Sales / £";
            chartSales.BorderWidth = 2;
            if ((int)selectedMonth.Month < 10)
            {
                lblDate.Text = $"Selected: 0{selectedMonth.Month}/{selectedMonth.Year}";
                chartSales.Series["Sales"].ToolTip = $"#VALX/0{selectedMonth.Month}/{selectedMonth.Year}: £#VALY";
            }
            else
            {
                lblDate.Text = $"Selected: {selectedMonth.Month}/{selectedMonth.Year}";
                chartSales.Series["Sales"].ToolTip = $"#VALX/{selectedMonth.Month}/{selectedMonth.Year}: £#VALY";
            }

            dbConnector.Connect();
            sqlStr = "SELECT DAY(DateOfOrder), SUM(TotalPaid) " +
                     "FROM tblOrder " +
                     $"WHERE YEAR(DateOfOrder) = '{selectedMonth.Year}' AND MONTH(DateOfOrder) = '{selectedMonth.Month}' " +
                     "GROUP BY DAY(DateOfOrder) ORDER BY DAY(DateOfOrder)";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                int orderDay = Convert.ToInt32(dr[0]);
                double totalPaid = Convert.ToDouble(dr[1]);

                salesData[orderDay] = totalPaid;
            }
            dbConnector.Close();
            foreach (var entry in salesData)
            {
                chartSales.Series["Sales"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        private void VisibleProductLbls(bool v)
        {
            lblProductName.Visible = v;
            lblDiameter.Visible = v;
            lblMaterial.Visible = v;
            lblPricePM.Visible = v;
            lblPriceVAT.Visible = v;
            lblTotal.Visible = v;
            lblStock.Visible = v;
            lblCstLength.Visible = v;
            txtLength.Visible = v;
            lblLengthMeters.Visible = v;
            lblQuantity.Visible = v;
            txtQuantity.Visible = v;
            lblValidLength.Visible = v;
            lblValidQuantity.Visible = v;
            btnAdd2Cart.Visible = v;
        }

        private void LoadDynamicBtns()
        {
            int i = 0;
            int y = 10;
            int x = 10;
            dbConnector.Connect();
            sqlStr = "SELECT ProductID, ProductName, DiameterInMM, Material, PricePerMeter, AmountInStock FROM tblProduct ORDER BY DiameterInMM";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Button btn = new Button();
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.LimeGreen;
                if (Convert.ToInt32(dr[5]) == 0)
                {
                    btn.ForeColor = Color.Red;
                }
                btn.Size = new Size(100, 100);
                if (x > 1000)
                {
                    y += 100;
                    x = 10;
                }
                btn.Location = new Point(x, y);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                Font font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                btn.Font = font;
                btn.Text = $"{dr[1].ToString()}\n{dr[2].ToString()}mm\n{dr[3].ToString()}\n£{dr[4].ToString()}";
                if (Convert.ToInt32(dr[5]) == 0)
                {
                    btn.Text += "\nUNAVLIABLE";
                }
                btn.Name = "btn_ " + i;
                i++;
                x += 110;
                btn.Image = SelectImage(dr[1].ToString(), dr[3].ToString());
                btn.Click += btn_Click;
                tabPage3.Controls.Add(btn);
            }
            dbConnector.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            VisibleProductLbls(true);
            ShowProductInfo((sender as Button).Tag.ToString());
        }

        double price;

        private void ShowProductInfo(string productid)
        {
            productID = productid;
            dbConnector.Connect();
            sqlStr = $"SELECT ProductName, DiameterInMM, Material, PricePerMeter, AmountInStock FROM tblProduct WHERE ProductID = {productID}";
            dr = dbConnector.DoSQL(sqlStr);
            dr.Read();
            lblProductName.Text = dr[0].ToString();
            lblDiameter.Text = dr[1].ToString() + "mm";
            lblMaterial.Text = dr[2].ToString();
            price = Convert.ToDouble(dr[3]);
            double priceVAT = Math.Round(price * 1.2, 2);
            lblPricePM.Text = $"£{price}";
            lblPriceVAT.Text = $"£{priceVAT} inc VAT";
            productInStock = Convert.ToInt32(dr[4]);
            lblStock.Text = $"Stock: {productInStock}";
            dbConnector.Close();
            txtLength.Text = "1000";
            txtQuantity.Text = "1";
            if (productInStock == 0)
            {
                btnAdd2Cart.Enabled = false;
                lblValidQuantity.ForeColor = Color.Red;
                lblValidQuantity.Text = "OUT OF STOCK!";
            }
            else
            {
                btnAdd2Cart.Enabled = true;
                lblValidQuantity.ForeColor = Color.Black;
                lblValidQuantity.Text = $"(1 - {productInStock * 12})";
            }
            lblTotal.Text = $"Total: £{priceVAT}";
            lblValidLength.ForeColor = Color.Black;
        }

        private Image SelectImage(string productName, string material)
        {
            if (productName.ToLower() == "rebar")
            {
                if (material.ToLower() == "mild steel")
                {
                    return Image.FromFile("rebar_mild_steel.png");
                }
                if (material.ToLower() == "stainless steel")
                {
                    return Image.FromFile("rebar_stainless_steel.png");
                }
            }
            return null;
        }

        private DateTime GetOrderDate(string maxOrMin)
        {
            dbConnector.Connect();
            sqlStr = $"SELECT {maxOrMin}(DateOfOrder) FROM tblOrder";
            dr = dbConnector.DoSQL(sqlStr);
            dr.Read();
            DateTime date = Convert.ToDateTime(dr[0]);
            dbConnector.Close();
            return date;
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
            try
            {
                StreamReader currentFile = new StreamReader("temp.txt");
                dbConnector.Connect();
                sqlStr = $"SELECT UserID, Manager FROM tblUser WHERE Email = '{currentFile.ReadLine()}'";
                currentFile.Close();
                dr = dbConnector.DoSQL(sqlStr);
                dr.Read();
                userID = dr[0].ToString();
                if (dr[1].ToString() == "True")
                {
                    manager = true;
                }

                selectedOrderID = "";
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
            catch (Exception ex)
            {

                MessageBox.Show("Error occured: " + ex.Message, "Error");
            }
            
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

        private void picCart_Click(object sender, EventArgs e)
        {
            if (!frmCartOpen)
            {
                frmCartOpen = true;
                frmCart = new frmCart();
                frmCart.Show();
                frmCart.LoadDetails(userID);
            }
            else
            {
                frmCart.BringToFront();
                frmCart.WindowState = FormWindowState.Normal;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            header = string.Format("{0,-11}{1,-20}{2, -20}{3,-5}", "Order ID", "Customer", "Date", "Paid") + "\n";
            doc.PrintPage += Doc_PrintPage;
            stringToPrint = GetData();
            documentContents = stringToPrint;
            printPreviewDialog1.Document = doc;
            printPreviewDialog1.ShowDialog();
        }

        private string GetData()
        {
            double totalSales = 0;
            string dataToPrint = "";
            dbConnector.Connect();
            sqlStr = "SELECT tblOrder.OrderID, tblUser.FirstName, tblUser.Surname, tblOrder.DateOfOrder, tblOrder.TotalPaid " +
                     "FROM tblOrder, tblUser " +
                     "WHERE tblOrder.UserID = tblUser.UserID " +
                    $"AND tblOrder.DateOfOrder >= {startDate} AND tblOrder.DateOfOrder <= {endDate} " +
                     "ORDER BY tblOrder.DateOfOrder";
            dr = dbConnector.DoSQL(sqlStr);
            dataToPrint = header;
            while (dr.Read())
            {
                totalSales += Convert.ToDouble(dr[4]);
                dataToPrint = dataToPrint + string.Format("{0,-11}{1,-20}{2, -20}{3,-5}", dr[0].ToString(), dr[1].ToString() + ", " + dr[2].ToString(), GetDateOnly(dr[3]), "£" + dr[4].ToString()) + "\n";
            }
            if (dataToPrint == header)
            {
                dataToPrint += "\n                        NO DATA FOUND!";
            }
            else
            {
                dataToPrint += string.Format("{0,-11}{1,-18}{2, -20}{3,-5}", "\nTotal Sales: ", "", "", "£" + totalSales.ToString());
            }
            dbConnector.Close();
            return dataToPrint;
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            Font myFont1 = new Font("Courier New", 12.0f);
            Font myFont2 = new Font("Cooper", 18, FontStyle.Bold);
            e.Graphics.DrawString("REINFORCEMENTS: ORDERS REPORT", myFont2, Brushes.Black, 170, 35);
            e.Graphics.DrawString($"Between {dateStart.Value.ToString("dd/MM/yyyy")} and {dateEnd.Value.ToString("dd/MM/yyyy")} inclusive", myFont1, Brushes.Black, 190, 70);
            e.Graphics.MeasureString(stringToPrint, myFont1, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
            e.Graphics.DrawString(stringToPrint, myFont1, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            stringToPrint = stringToPrint.Substring(charactersOnPage);
            e.HasMorePages = (stringToPrint.Length > 0);
            if (!e.HasMorePages)
            {
                stringToPrint = documentContents;
            }
            else
            {
                stringToPrint = header + stringToPrint;
            }
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateStart.Value.ToString("#MM/dd/yyyy#");
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            endDate = dateEnd.Value.ToString("#MM/dd/yyyy#");
        }
        private bool CheckValidTxt(int max, string input)
        {
            if (input == "length")
            {
                try
                {
                    int length = Convert.ToInt32(txtLength.Text);
                    if (length >= 300 && length <= max)
                    {
                        UpdateMaxQuantity();
                        UpdateTotal();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else if (input == "quantity")
            {
                try
                {
                    int MMInStock = max * 12000;
                    int maxQuantity = MMInStock / Convert.ToInt32(txtLength.Text);
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    if (quantity >= 1 && quantity <= maxQuantity)
                    {
                        UpdateTotal();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        double total;

        private void UpdateTotal()
        {
            double length = Convert.ToDouble(txtLength.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            total = Math.Round(1.2 * (price * (length / 1000) * quantity), 2);
            lblTotal.Text = $"Total: £{total}";
        }

        private void UpdateMaxQuantity()
        {
            if (productInStock != 0)
            {
                int maxQuantity = (productInStock * 12000) / Convert.ToInt32(txtLength.Text);
                lblValidQuantity.Text = $"(1 - {maxQuantity})";
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidTxt(6000, "length"))
            {
                lblValidLength.ForeColor = Color.Red;
            }
            else
            {
                lblValidLength.ForeColor = Color.Black;
            }
        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!CheckValidTxt(productInStock, "quantity"))
            {
                lblValidQuantity.ForeColor = Color.Red;
            }
            else
            {
                lblValidQuantity.ForeColor = Color.Black;
            }
        }

        private void btnAdd2Cart_Click(object sender, EventArgs e)
        {
            if (CheckValidTxt(6000, "length") && CheckValidTxt(productInStock, "quantity"))
            {
                dbConnector.Connect();
                string cmdStr = $"INSERT INTO tblCart (UserID, ProductID, Quantity, LengthInM) " +
                                $"VALUES ('{userID}', '{productID}', '{txtQuantity.Text}', '{Convert.ToDouble(txtLength.Text) / 1000}')";
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                MessageBox.Show($"Successfully added to cart. You can edit the contents of your cart anytime.", "Product added to cart");
                if (frmCartOpen == true)
                {
                    frmCart.Close();
                    frmCart = new frmCart();
                    frmCart.Show();
                    frmCart.LoadDetails(userID);
                }
            }
            else
            {
                MessageBox.Show("Invalid values for length/quantity or both.", "Invalid values");
            }
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            selectedMonth = selectedMonth.AddMonths(1);
            LoadChart();
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            selectedMonth = selectedMonth.AddMonths(-1);
            LoadChart();
        }
    }
}
