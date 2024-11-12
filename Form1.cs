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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrdersList frmOrdersList = new frmOrdersList();
            frmOrdersList.Show();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            frmCustomersList frmCustomersList = new frmCustomersList();
            frmCustomersList.Show();
        }
    }
}
