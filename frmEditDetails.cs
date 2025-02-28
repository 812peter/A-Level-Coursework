using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Coursework
{
    public partial class frmEditDetails : Form
    {
        public frmEditDetails()
        {
            InitializeComponent();
        }

        private void frmEditDetails_Load(object sender, EventArgs e)
        {

        }

        private string GetHashSHA256(string plainText)
        {
            string hashText = "";
            Encoding enc = Encoding.UTF8;
            SHA256Managed hash = new SHA256Managed();
            byte[] result = hash.ComputeHash(enc.GetBytes(plainText));
            foreach (Byte item in result)
            {
                hashText = hashText + item.ToString("X");
            }
            return hashText;
        }

        string userID;

        internal void LoadDetails(string v, string firstName, string surname, string email, string phoneNumber, string companyName)
        {
            userID = v;
            txtFirstName.Text = firstName;
            txtSurname.Text = surname;
            txtEmail.Text = email;
            txtPhoneNumber.Text = phoneNumber;
            txtCompanyName.Text = companyName;
        }

        private void picViewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
            picViewPassword.Image = Image.FromFile("view_password.png");
        }

        private void picViewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = Convert.ToChar(0);
            picViewPassword.Image = Image.FromFile("hide_password.png");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValid() == true)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to update your details?", "Updating Details", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clsDBConnector dbConnector = new clsDBConnector();
                    string cmdStr = "UPDATE tblUser " +
                                    $"SET FirstName = '{txtFirstName.Text}'," +
                                    $"Surname = '{txtSurname.Text}'," +
                                    $"Email = '{txtEmail.Text}'," +
                                    $"PhoneNumber = '{txtPhoneNumber.Text}'," +
                                    $"CompanyName = '{txtCompanyName.Text}'";
                    if (txtPassword.Text != "")
                    {

                        cmdStr = cmdStr + $", [Password] = '{GetHashSHA256(txtPassword.Text)}' ";
                    }
                    cmdStr = cmdStr + $"WHERE (UserID = {userID})";
                    dbConnector.Connect();
                    dbConnector.DoDML(cmdStr);
                    dbConnector.Close();
                    (Application.OpenForms["frmMain"] as frmMain).DisplayData(false);
                    (Application.OpenForms["frmAccount"] as frmAccount).frmAccount_Load(sender, e);
                }
            }
        }
        private bool CheckValid()
        {
            if (txtFirstName.Text == "" || txtSurname.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.", "Error");
                return false;
            }
            string pattern = @"[A-Z][a-z]+";
            Match tryToMatch = Regex.Match(txtFirstName.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid first name (e.g., Charlie).", "Error");
                return false;
            }
            pattern = @"[A-Z][a-z]+";
            tryToMatch = Regex.Match(txtSurname.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid surname (e.g., Black).", "Error");
                return false;
            }
            pattern = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            tryToMatch = Regex.Match(txtEmail.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid email address (e.g., charli3black999@gmail.com).", "Error");
                return false;
            }
            pattern = @"^(?:(?:\(?(?:0(?:0|11)\)?[\s-]?\(?|\+)44\)?[\s-]?(?:\(?0\)?[\s-]?)?)|(?:\(?0))(?:(?:\d{5}\)?[\s-]?\d{4,5})|(?:\d{4}\)?[\s-]?(?:\d{5}|\d{3}[\s-]?\d{3}))|(?:\d{3}\)?[\s-]?\d{3}[\s-]?\d{3,4})|(?:\d{2}\)?[\s-]?\d{4}[\s-]?\d{4}))(?:[\s-]?(?:x|ext\.?|\#)\d{3,4})?$";
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid phone number. (e.g., 07635483912)", "Error");
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The passwords you have entered do not match.", "Error");
                return false;
            }

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $"SELECT UserID FROM tblUser WHERE Email = '{txtEmail.Text}'";
            dr = dbConnector.DoSQL(sqlStr);
            int i = 0;
            while (dr.Read())
            {
                if (dr[i].ToString() != userID)
                {
                    MessageBox.Show("The email address you have entered is already used.", "Error");
                    return false;
                }
                i++;
            }
            return true;
        }

        private void frmEditDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmMain"] as frmMain != null && Application.OpenForms["frmAccount"] as frmAccount != null)
            {
                (Application.OpenForms["frmAccount"] as frmAccount).frmEditOpen = false;
            }
        }
    }
}
