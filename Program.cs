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
                    if (CheckIfManager() == true)
                    {
                        frmMain mainForm = new frmMain();
                        mainForm.FormClosed += MainForm_FormClosed;
                        mainForm.Show();
                    }
                    else
                    {
                        //form for customers
                    }
                }
                else
                {
                    frmSignIn frmSignIn = new frmSignIn();
                    frmSignIn.FormClosed += SignInForm_FormClosed;
                    frmSignIn.Show();
                }
            }

            private bool CheckIfManager()
            {
                StreamReader currentFile = new StreamReader("user details.txt");
                string email = currentFile.ReadLine();
                currentFile.Close();
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                string boolDB = "";
                dbConnector.Connect();
                sqlStr = "SELECT Manager" +
                         " FROM tblUser" +
                         $" WHERE Email = '{email}'";
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

            private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                frmMain mainForm = new frmMain();
                mainForm.FormClosed += MainForm_FormClosed;
                mainForm.Show();
            }

            private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
            }
        }
    }
}
