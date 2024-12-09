using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            RegVisability(false);
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
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (CheckValid() == true)
            {

            }
        }

        private bool CheckValid()
        {
            if (txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("You have not entered anything for one or many fields.");
                return false;
            }
            if (CheckEmail() == false)
            {
                MessageBox.Show("We couldn't find an account with that email. Try creating an account.");
                return false;
            }
            return true;
        }

        private bool CheckEmail()
        {
            return true;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegVisability(true);
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
    }
}
