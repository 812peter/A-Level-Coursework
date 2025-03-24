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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmMain"] as frmMain != null)
            {
                (Application.OpenForms["frmMain"] as frmMain).frmCartOpen = false;
            }
        }
    }
}
