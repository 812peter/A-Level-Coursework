using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        internal void LoadDetails(string userID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $"SELECT ProductName, Quantity, DiameterInMM, Material, tblCart.LengthInM, Price FROM tblCart, tblProduct " +
                     $"WHERE UserID = {userID} AND tblCart.ProductID = tblProduct.ProductID ORDER BY Quantity DESC";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                if (dr[0] == DBNull.Value)
                {
                    //no products in cart
                }
                else
                {
                    //MessageBox.Show($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]} {dr[5]}");
                }
            }
            dbConnector.Close();
        }
    }
}
