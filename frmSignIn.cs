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
using System.Security.Cryptography;
using System.IO;

namespace Coursework
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            File.Delete("user details.txt");
            File.Delete("temp.txt");
            RegVisability(false);
        }

        bool successfullSignIn = false;
        bool regVisible = false;

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


        private void RegVisability(bool v)
        {
            txtFirstName.Visible = v;
            lblFirstName.Visible = v;
            txtSurname.Visible = v;
            lblSurname.Visible = v;
            txtEmailReg.Visible = v;
            lblEmailReg.Visible = v;
            txtPhoneNumber.Visible = v;
            lblPhoneNumber.Visible = v;
            txtCompanyName.Visible = v;
            lblCompanyName.Visible = v;
            txtPasswordReg1.Visible = v;
            lblPasswordReg1.Visible = v;
            txtPasswordReg2.Visible = v;
            lblPasswordReg2.Visible = v;
            btnRegister.Visible = v;
            picViewPassword2.Visible = v;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (CheckValid() == true)
            {
                successfullSignIn = true;
                if (chkRemember.Checked == true)
                {
                    RememberMe();

                }
                CreateTempFile();
                this.Close();
            }
        }

        private void CreateTempFile()
        {
            StreamWriter currentFile = new StreamWriter("temp.txt");
            File.SetAttributes("temp.txt", FileAttributes.Hidden);
            currentFile.WriteLine(txtEmail.Text);
            currentFile.WriteLine(isManager().ToString());
            currentFile.Close();
        }

        private bool isManager()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string boolDB = "";
            dbConnector.Connect();
            sqlStr = "SELECT Manager" +
                     " FROM tblUser" +
                     $" WHERE Email = '{txtEmail.Text}'";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                boolDB = dr[0].ToString();
            }
            dbConnector.Close();
            if (boolDB == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RememberMe()
        {
            StreamWriter currentFile = new StreamWriter("user details.txt");
            File.SetAttributes("user details.txt", FileAttributes.Hidden);
            currentFile.WriteLine(txtEmail.Text);
            currentFile.WriteLine(GetHashSHA256(txtPassword.Text));
            currentFile.Close();
        }

        private bool CheckValid()
        {
            if (txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.", "Error");
                return false;
            }
            if (ExistingEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("We couldn't find an account with that email. Try creating an account.", "Error");
                return false;
            }
            if (GetCorrectPassword() == "")
            {
                MessageBox.Show("It seems like your account has been created by a manager. Please give us a call to set up a password.", "Error");
                return false;
            }
            if (GetHashSHA256(txtPassword.Text) != GetCorrectPassword())
            {
                MessageBox.Show("Incorrect password.", "Error");
                return false;
            }
            return true;
        }

        private string GetCorrectPassword()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            string correctPassword = "";
            dbConnector.Connect();
            sqlStr = "SELECT [Password]" +
                     " FROM tblUser" +
                     $" WHERE Email = '{txtEmail.Text}'";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                correctPassword = dr[0].ToString();
            }
            dbConnector.Close();
            return correctPassword;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if (regVisible == false)
            {
                RegVisability(true);
            }
            regVisible = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblEmail.Visible = true;
            }
            else
            {
                lblEmail.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblPassword.Visible = true;
            }
            else
            {
                lblPassword.Visible = false;
            }
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                lblFirstName.Visible = true;
            }
            else
            {
                lblFirstName.Visible = false;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text == "")
            {
                lblSurname.Visible = true;
            }
            else
            {
                lblSurname.Visible = false;
            }
        }

        private void txtEmailReg_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailReg.Text == "")
            {
                lblEmailReg.Visible = true;
            }
            else
            {
                lblEmailReg.Visible = false;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "")
            {
                lblPhoneNumber.Visible = true;
            }
            else
            {
                lblPhoneNumber.Visible = false;
            }
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                lblCompanyName.Visible = true;
            }
            else
            {
                lblCompanyName.Visible = false;
            }
        }

        private void txtPasswordReg1_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordReg1.Text == "")
            {
                lblPasswordReg1.Visible = true;
            }
            else
            {
                lblPasswordReg1.Visible = false;
            }
        }

        private void txtPasswordReg2_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordReg2.Text == "")
            {
                lblPasswordReg2.Visible = true;
            }
            else
            {
                lblPasswordReg2.Visible = false;
            }
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

        private void picViewPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPasswordReg1.PasswordChar = '*';
            picViewPassword2.Image = Image.FromFile("view_password.png");
        }

        private void picViewPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPasswordReg1.PasswordChar = Convert.ToChar(0);
            picViewPassword2.Image = Image.FromFile("hide_password.png");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckValidReg() == true)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string hashedPassword = GetHashSHA256(txtPasswordReg1.Text);
                string cmdStr = $"INSERT INTO tblUser (FirstName, Surname, Email, PhoneNumber, CompanyName, [Password]) " +
                                $"VALUES ('{txtFirstName.Text}', '{txtSurname.Text}', '{txtEmailReg.Text}', '{txtPhoneNumber.Text}', '{txtCompanyName.Text}', '{hashedPassword}')";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                MessageBox.Show("Account created successfully. You can sign in now.", "Registration completed");
            }
        }

        private bool CheckValidReg()
        {
            if (txtFirstName.Text == "" || txtSurname.Text == "" || txtEmailReg.Text == "" || txtPhoneNumber.Text == "" || txtPasswordReg1.Text == "" || txtPasswordReg2.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.", "Error");
                return false;
            }
            if (ExistingEmail(txtEmailReg.Text) == true)
            {
                MessageBox.Show("This email address is already used. Try to sign in.", "Error");
                return false;
            }
            string pattern = @"[A-Z][a-z]+";
            Match tryToMatch = Regex.Match(txtFirstName.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid first name (e.g., Charlie).", "Error");
                return false;
            }
            tryToMatch = Regex.Match(txtSurname.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid surname (e.g., Black).", "Error");
                return false;
            }
            pattern = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            tryToMatch = Regex.Match(txtEmailReg.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid email address (e.g., charli3black999@gmail.com).", "Error");
                return false;
            }
            pattern = @"^(?:(?:\(?(?:0(?:0|11)\)?[\s-]?\(?|\+)44\)?[\s-]?(?:\(?0\)?[\s-]?)?)|(?:\(?0))(?:(?:\d{5}\)?[\s-]?\d{4,5})|(?:\d{4}\)?[\s-]?(?:\d{5}|\d{3}[\s-]?\d{3}))|(?:\d{3}\)?[\s-]?\d{3}[\s-]?\d{3,4})|(?:\d{2}\)?[\s-]?\d{4}[\s-]?\d{4}))(?:[\s-]?(?:x|ext\.?|\#)\d{3,4})?$";
            tryToMatch = Regex.Match(txtPhoneNumber.Text, pattern);
            if (!tryToMatch.Success)
            {
                MessageBox.Show("Invalid phone number. (e.g., 07635483912)", "Error");
                return false;
            }
            if (txtPasswordReg1.Text != txtPasswordReg2.Text)
            {
                MessageBox.Show("The passwords you have entered do not match.", "Error");
                return false;
            }
            return true;
        }

        private bool ExistingEmail(string email)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            int userExists = 0;
            dbConnector.Connect();
            sqlStr = $"SELECT UserID FROM tblUser WHERE Email = '{email}'";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                if (dr[0] != DBNull.Value)
                {
                    userExists = 1;
                }
            }
            dbConnector.Close();
            if (userExists == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void lblSurname_Click(object sender, EventArgs e)
        {
            txtSurname.Focus();
        }

        private void lblEmailReg_Click(object sender, EventArgs e)
        {
            txtEmailReg.Focus();
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Focus();
        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {
            txtCompanyName.Focus();
        }

        private void lblPasswordReg1_Click(object sender, EventArgs e)
        {
            txtPasswordReg1.Focus();
        }

        private void lblPasswordReg2_Click(object sender, EventArgs e)
        {
            txtPasswordReg2.Focus();
        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (successfullSignIn == false)
            {
                Application.ExitThread();
            }
        }
    }
}
