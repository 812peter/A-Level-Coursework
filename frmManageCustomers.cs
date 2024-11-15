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
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblCustomer (FirstName, Surname, Email, PhoneNumber, CompanyName) " +
                $"VALUES ('{txtFirstName.Text}' , '{txtSurname.Text}', '{txtEmail.Text}', '{txtPhoneNumber.Text}', '{txtCompanyName.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["frmCustomersList"] as frmCustomersList).DisplayData();
            frmManageCustomers_Load(sender, e);
        }

        private void frmManageCustomers_Load(object sender, EventArgs e)
        {
            List<CLsCustomer> customerList = new List<CLsCustomer>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT CustomerID, (Surname & " + "', '" + "& FirstName) as customername FROM tblCustomer";
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
                sqlStr = "SELECT CustomerID, FirstName, Surname, Email, PhoneNumber, CompanyName" +
                    " FROM tblCustomer" +
                    " WHERE CustomerID = " + cmbCustomerID.SelectedValue;
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
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "UPDATE tblCustomer " +
                            $"SET FirstName = '{txtFirstName.Text}'," +
                            $"Surname = '{txtSurname.Text}'," +
                            $"Email ='{txtEmail.Text}'," +
                            $"PhoneNumber ='{txtPhoneNumber.Text}'," +
                            $"CompanyName ='{txtCompanyName.Text}'" +
                            $"WHERE (CustomerID = {cmbCustomerID.SelectedValue})";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["frmCustomersList"] as frmCustomersList).DisplayData();
            frmManageCustomers_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to delete {txtFirstName.Text}?", "Deleting Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cmdStr = "DELETE FROM tblCustomer " +
                                    $"WHERE CustomerID = {cmbCustomerID.SelectedValue}";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmCustomersList"] as frmCustomersList).DisplayData();
                frmManageCustomers_Load(sender, e);
            }
        }
    }
}
