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
    }
}
