using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Coursework
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyAppContext());
        }

        public class MyAppContext : ApplicationContext
        {
            public MyAppContext()
            {
                bool rememberMe = File.Exists("user details.txt");
                if (rememberMe)
                {
                    frmMain mainForm = new frmMain();
                    mainForm.FormClosed += MainForm_FormClosed;
                    mainForm.Show();
                }
                else
                {
                    frmSignIn frmSignIn = new frmSignIn();
                    frmSignIn.FormClosed += SignInForm_FormClosed;
                    frmSignIn.Show();
                }
            }

            private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                frmMain mainForm = new frmMain();
                mainForm.FormClosed += MainForm_FormClosed;
                mainForm.Show();
            }

            private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                ExitApp();
            }
        }

        internal static void ExitApp()
        {
            Application.Exit();
        }
    }
}
