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
using System.Text.RegularExpressions;

namespace Coursework
{
    public partial class frmManageCustomers : Form
    {
        public frmManageCustomers()
        {
            InitializeComponent();
        }
        class CLsCustomer
        {
            public int customerid { get; set; }
            public string customername { get; set; }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (CheckValid() == true)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = $"INSERT INTO tblUser (FirstName, Surname, Email, PhoneNumber, CompanyName) " +
                                $"VALUES ('{txtFirstName.Text}', '{txtSurname.Text}', '{txtEmail.Text}', '{txtPhoneNumber.Text}', '{txtCompanyName.Text}')";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["Main"] as Main).DisplayData();
                DialogResult dialogResult = MessageBox.Show($"Do you want to associate an address with {txtFirstName.Text}?", "Adding Address", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    frmAddresses frmAddresses = new frmAddresses();
                    frmAddresses.SetUpNewCustomer(txtEmail.Text);
                    frmAddresses.Show();
                }
                frmManageCustomers_Load(sender, e);
            }
        }

        private bool CheckValid()
        {
            if (txtFirstName.Text == "" || txtSurname.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.");
                return false;
            }
            string pattern = @"[A-Z][a-z]+";
            Match tryToMatch = Regex.Match(txtFirstName.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid first name (e.g., Charlie).");
                return false;
            }
            pattern = @"[A-Z][a-z]+";
            tryToMatch = Regex.Match(txtSurname.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid surname (e.g., Black).");
                return false;
            }
            pattern = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            tryToMatch = Regex.Match(txtEmail.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid email address (e.g., charli3black999@gmail.com).");
                return false;
            }
            pattern = @"^(?:(?:\(?(?:0(?:0|11)\)?[\s-]?\(?|\+)44\)?[\s-]?(?:\(?0\)?[\s-]?)?)|(?:\(?0))(?:(?:\d{5}\)?[\s-]?\d{4,5})|(?:\d{4}\)?[\s-]?(?:\d{5}|\d{3}[\s-]?\d{3}))|(?:\d{3}\)?[\s-]?\d{3}[\s-]?\d{3,4})|(?:\d{2}\)?[\s-]?\d{4}[\s-]?\d{4}))(?:[\s-]?(?:x|ext\.?|\#)\d{3,4})?$";
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid phone number. (e.g., 07635483912)");
                return false;
            }
            return true;
        }

        private void frmManageCustomers_Load(object sender, EventArgs e)
        {
            ClearFields();
            cmbCustomerID.Text = "Select";
        }

        private void ClearFields()
        {
            string emptyStr = "";
            txtFirstName.Text = emptyStr;
            txtSurname.Text = emptyStr;
            txtEmail.Text = emptyStr;
            txtPhoneNumber.Text = emptyStr;
            txtCompanyName.Text = emptyStr;
        }

        private void PopulateCombo()
        {
            List<CLsCustomer> customerList = new List<CLsCustomer>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT UserID, (Surname & " + "', '" + "& FirstName) as customername FROM tblUser";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                customerList.Add(new CLsCustomer { customerid = Convert.ToInt32(dr[0]), customername = dr[1].ToString() });
            }
            cmbCustomerID.DisplayMember = "customername";
            cmbCustomerID.ValueMember = "customerid";
            cmbCustomerID.DataSource = customerList;
            dbConnector.Close();
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedValue != null)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT UserID, FirstName, Surname, Email, PhoneNumber, CompanyName" +
                         " FROM tblUser" +
                         " WHERE UserID = " + cmbCustomerID.SelectedValue;
                dr = dbConnector.DoSQL(sqlStr);
                while (dr.Read())
                {
                    txtFirstName.Text = dr[1].ToString();
                    txtSurname.Text = dr[2].ToString();
                    txtEmail.Text = dr[3].ToString();
                    txtPhoneNumber.Text = dr[4].ToString();
                    txtCompanyName.Text = dr[5].ToString();
                }
                dbConnector.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValid() == true)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "UPDATE tblUser " +
                                $"SET FirstName = '{txtFirstName.Text}'," +
                                $"Surname = '{txtSurname.Text}'," +
                                $"Email ='{txtEmail.Text}'," +
                                $"PhoneNumber ='{txtPhoneNumber.Text}'," +
                                $"CompanyName ='{txtCompanyName.Text}'" +
                                $"WHERE (UserID = {cmbCustomerID.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["Main"] as Main).DisplayData();
                frmManageCustomers_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCustomerID.Text == "Select")
            {
                MessageBox.Show($"You have not selected a customer to delete.");
            }
            else
            {
                clsDBConnector dbConnector = new clsDBConnector();
                DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to delete {txtFirstName.Text}?", "Deleting Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string cmdStr = "DELETE FROM tblUser " +
                                    $"WHERE UserID = {cmbCustomerID.SelectedValue}";
                    dbConnector.Connect();
                    dbConnector.DoDML(cmdStr);
                    dbConnector.Close();
                    (Application.OpenForms["Main"] as Main).DisplayData();
                    frmManageCustomers_Load(sender, e);
                }
            }
        }

        private void cmbCustomerID_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbCustomerID.Text == "Select")
            {
                PopulateCombo();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmManageCustomers_Load(sender, e);
        }

        private void btnAddresses_Click(object sender, EventArgs e)
        {
            frmAddresses frmAddresses = new frmAddresses();
            frmAddresses.Show();
        }
    }
}
