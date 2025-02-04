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
    public partial class frmEditDetails : Form
    {
        public frmEditDetails()
        {
            InitializeComponent();
        }

        private void frmEditDetails_Load(object sender, EventArgs e)
        {

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
    }
}
