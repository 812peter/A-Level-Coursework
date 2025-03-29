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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void frmCheckout_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmCart"] as frmCart != null)
            {
                (Application.OpenForms["frmCart"] as frmCart).frmCheckoutOpen = false;
            }
        }
    }
}
