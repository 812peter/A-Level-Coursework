using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursework
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            PullData();
        }

        private void PullData()
        {
            string currentLine;
            StreamReader currentFile = new StreamReader("temp.txt");
            currentLine = currentFile.ReadLine();
            currentFile.Close();

        }
    }
}
