using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }
        class CLsAddress
        {
            public int addressID { get; set; }
            public string address { get; set; }
        }

        string cardName;
        string cardNumber;
        string expirationMM;
        string expirationYY;
        string CVC;
        double total;

        internal void LoadDetails(string currentUserID, double subtotal)
        {
            List<CLsAddress> addressList = new List<CLsAddress>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT AddressID, FirstLine, Town, Postcode" +
                     " FROM tblAddress" +
                     " WHERE UserID = " + currentUserID;
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                addressList.Add(new CLsAddress { addressID = Convert.ToInt32(dr[0]), address = $"{dr[1]}, {dr[2]}, {dr[3]}" });
            }
            dbConnector.Close();
            cmbDeliveryAddr.DisplayMember = "address";
            cmbDeliveryAddr.ValueMember = "addressID";
            cmbDeliveryAddr.DataSource = addressList;

            lblSubtotalValue.Text = $"£{Math.Round(subtotal, 2)}";
            lblVATValue.Text = $"£{Math.Round(1.2 * subtotal - subtotal, 2)}";
            total = Math.Round(1.2 * subtotal, 2);
            lblTotalValue.Text = $"£{total}";
        }

        private bool CheckValid()
        {
            if (txtCardName.Text == "" || txtCardNumber.Text == "" || txtMM.Text == "" || txtYY.Text == "" || txtCVC.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.", "Error");
                return false;
            }
            cardName = txtCardName.Text;
            string pattern = @"^[A-Za-z]+(?: [A-Za-z]+)*$";
            Match tryToMatch = Regex.Match(txtCardName.Text, pattern);
            if (!tryToMatch.Success || txtCardName.Text.Length < 2)
            {
                MessageBox.Show("Invalid cardholder name. It must contain only letters and spaces.", "Error");
                return false;
            }
            cardNumber = txtCardNumber.Text.Replace(" ", "");
            if (!long.TryParse(cardNumber, out _) || cardNumber.Length != 16)
            {
                MessageBox.Show("Invalid card number. It must be exactly 16 digits.", "Error");
                return false;
            }
            expirationMM = txtMM.Text.Replace(" ", "");
            expirationYY = txtYY.Text.Replace(" ", "");
            if (!long.TryParse(expirationMM, out _) || expirationMM.Length != 2 || !long.TryParse(expirationYY, out _) || expirationYY.Length != 2 || expirationMM == "00" || Convert.ToInt32(expirationMM) > 12)
            {
                MessageBox.Show("Invalid expiration date. Both fields must contain exactly 2 digits.", "Error");
                return false;
            }
            CVC = txtCVC.Text.Replace(" ", "");
            if (!long.TryParse(CVC, out _) || (CVC.Length != 3 && CVC.Length != 4))
            {
                MessageBox.Show("Invalid card verification code (CVC). It must contain 3 or 4 digits.", "Error");
                return false;
            }
            return true;
        }

        Timer timer = new Timer();

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (TakeMoney(total, cardName, cardNumber, expirationMM, expirationYY, CVC))
                {
                    lblAnimation.Text = ".";
                    lblAnimation.Visible = true;
                    timer.Interval = 1000;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("There has been a problem, try using different payment method.", "Payment Failure");
                }    
            }
        }

        private bool TakeMoney(double total, string cardName, string cardNumber, string expirationMM, string expirationYY, string cVC)
        {
            string today = DateTime.Now.ToString("MM/yyyy");
            string currentMonth = today[0] + "" + today[1];
            string currentYear = today[5] + "" + today[6];
            if (Convert.ToInt32(expirationYY) < Convert.ToInt32(currentYear))
            {
                return false;
            }
            if (Convert.ToInt32(expirationYY) == Convert.ToInt32(currentYear) && Convert.ToInt32(expirationMM) < Convert.ToInt32(currentMonth))
            {
                return false;
            }
            if (true)
            {
                //other validations
            }
            return true;
        }

        int count = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (lblAnimation.Text != "...")
            {
                lblAnimation.Text += ".";
            }
            else
            {
                lblAnimation.Text = ".";
            }
            if (count == 5)
            {
                timer.Stop();
                lblAnimation.Visible = false;
                MessageBox.Show("Order completed. Thank you!");
                (Application.OpenForms["frmCart"] as frmCart).OrderCompleted(cmbDeliveryAddr.SelectedValue.ToString());
                this.Close();
                Form frmCart = Application.OpenForms["frmCart"];
                if (frmCart != null)
                {
                    frmCart.Close();
                    (Application.OpenForms["frmMain"] as frmMain).frmCartOpen = false;
                }
                (Application.OpenForms["frmMain"] as frmMain).DisplayData(false);
            }
            count++;
        }

        private void frmCheckout_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmCart"] as frmCart != null)
            {
                (Application.OpenForms["frmCart"] as frmCart).frmCheckoutOpen = false;
            }
        }

        private void cmbDeliveryAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
