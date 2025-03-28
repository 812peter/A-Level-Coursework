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

        List<string> productNameLst = new List<string>();
        List<int> diamLst = new List<int>();
        List<string> materialLst = new List<string>();
        List<int> qtyLst = new List<int>();
        List<double> lengthLst = new List<double>();
        List<string> cartIDLst = new List<string>();
        List<int> stockLst = new List<int>();
        List<double> priceLst = new List<double>();


        Font font = new Font("Microsoft Sans Serif", 8.25f);
        Font font2 = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);

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
            sqlStr = $"SELECT ProductName, Quantity, DiameterInMM, Material, tblCart.LengthInM, CartID, AmountInStock, PricePerMeter FROM tblCart, tblProduct " +
                     $"WHERE UserID = {userID} AND tblCart.ProductID = tblProduct.ProductID ORDER BY Quantity DESC";
            dr = dbConnector.DoSQL(sqlStr);
            int heightMultiplier = 1;
            while (dr.Read())
            {
                if (dr[0] == DBNull.Value)
                {
                    MessageBox.Show("123");
                }
                else
                {
                    productNameLst.Add(dr[0].ToString());
                    qtyLst.Add(Convert.ToInt32(dr[1]));
                    diamLst.Add(Convert.ToInt32(dr[2]));
                    materialLst.Add(dr[3].ToString());
                    lengthLst.Add(Convert.ToDouble(dr[4]));
                    cartIDLst.Add(dr[5].ToString());
                    stockLst.Add(Convert.ToInt32(dr[6]));
                    priceLst.Add(Convert.ToDouble(dr[7]));
                    heightMultiplier += 1;
                }
            }
            this.Size = new Size(820, 100 + 60 * heightMultiplier);
            LoadControls();
            dbConnector.Close();
        }

        private void LoadControls()
        {
            int i = 0;
            int x = 15;
            int y = 57;
            foreach (var material in materialLst)
            {
                PictureBox pic = new PictureBox();
                pic.Visible = true;
                if (material.ToLower() == "mild steel")
                {
                    pic.Image = Image.FromFile("rebar_mild_steel.png");
                }
                else if (material.ToLower() == "stainless steel")
                {
                    pic.Image = Image.FromFile("rebar_stainless_steel.png");
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new Size(40, 40);
                pic.Location = new Point(x, y);
                pic.Name = "picBox_" + i;
                this.Controls.Add(pic);

                PictureBox outline = new PictureBox();
                outline.Visible = true;
                outline.BackColor = Color.DarkSlateGray;
                outline.Size = new Size(42, 42);
                outline.Location = new Point(x - 1, y - 1);
                outline.Name = "outline_" + i;
                this.Controls.Add(outline);
                i++;
                y += 60;
            }

            i = 0;
            x += 49;
            y = 57;
            foreach (var product in productNameLst)
            {
                Label lbl = new Label();
                lbl.Visible = true;
                lbl.ForeColor = SystemColors.ControlText;
                lbl.BackColor = SystemColors.Control;
                lbl.AutoSize = true;
                lbl.Size = new Size(64, 13);
                lbl.Location = new Point(x, y);
                lbl.Name = "lblProduct_" + i;
                lbl.Text = $"{product}\n{diamLst[i]}mm\n{materialLst[i]}";
                lbl.Font = font;
                i++;
                y += 60;
                this.Controls.Add(lbl);
            }

            i = 0;
            x += (2 * 49);
            y = 67;
            foreach (var qty in qtyLst)
            {
                NumericUpDown qtyPicker = new NumericUpDown();
                qtyPicker.Visible = true;
                qtyPicker.BorderStyle = BorderStyle.FixedSingle;
                qtyPicker.Font = font;
                qtyPicker.TextAlign = HorizontalAlignment.Center;
                qtyPicker.AutoSize = true;
                qtyPicker.Size = new Size(60, 15);
                qtyPicker.Location = new Point(x, y);
                qtyPicker.Maximum = Convert.ToInt32((stockLst[i] * 12) / lengthLst[i]);
                qtyPicker.Value = Convert.ToInt32(qty);
                qtyPicker.Minimum = 1;
                qtyPicker.Name = "qtyPicker_" + i;
                qtyPicker.Tag = i;
                qtyPicker.ValueChanged += qtyPicker_ValueChanged;
                this.Controls.Add(qtyPicker);
                i++;
                y += 60;
            }

            i = 0;
            x += (49 + 60);
            y = 69;
            foreach (var length in lengthLst)
            {
                Label lblLength = new Label();
                lblLength.Visible = true;
                lblLength.ForeColor = SystemColors.ControlText;
                lblLength.BackColor = SystemColors.Control;
                lblLength.AutoSize = true;
                lblLength.Size = new Size(64, 13);
                lblLength.Location = new Point(x, y);
                lblLength.Name = "lblLength_" + i;
                lblLength.Text = $"ength: {length}m ({length * 1000}mm)";
                if (length == 1)
                {
                    lblLength.Text = "L" + lblLength.Text;
                }
                else
                {
                    lblLength.Text = "Custom l" + lblLength.Text;
                }
                lblLength.Font = font;
                lblLength.Tag = i;
                i++;
                y += 60;
                this.Controls.Add(lblLength);
            }
            LoadPrices();
        }

        int totalYcoord;
        double totalNoVat = 0;
        double totalIncVat = 0;

        private void LoadPrices()
        {
            int i = 0;
            int x = 500;
            int y = 69;
            foreach (var price in priceLst)
            {
                Label lblPriceNoVat = new Label();
                lblPriceNoVat.Visible = true;
                lblPriceNoVat.ForeColor = SystemColors.ControlText;
                lblPriceNoVat.BackColor = SystemColors.Control;
                lblPriceNoVat.AutoSize = true;
                lblPriceNoVat.Size = new Size(64, 13);
                lblPriceNoVat.Location = new Point(x, y);
                lblPriceNoVat.Name = "lblPriceNoVat_" + i;
                totalNoVat += Math.Round(price * lengthLst[i] * qtyLst[i], 2);
                lblPriceNoVat.Text = $"£{Math.Round(price * lengthLst[i] * qtyLst[i], 2)}";
                lblPriceNoVat.Font = font;
                i++;
                y += 60;
                this.Controls.Add(lblPriceNoVat);
            }
            i = 0;
            x = 650;
            y = 69;
            foreach (var price in priceLst)
            {
                Label lblPriceIncVat = new Label();
                lblPriceIncVat.Visible = true;
                lblPriceIncVat.ForeColor = SystemColors.ControlText;
                lblPriceIncVat.BackColor = SystemColors.Control;
                lblPriceIncVat.AutoSize = true;
                lblPriceIncVat.Size = new Size(64, 13);
                lblPriceIncVat.Location = new Point(x, y);
                lblPriceIncVat.Name = "lblPriceIncVat_" + i;
                totalIncVat += Math.Round(1.2 * (price * lengthLst[i] * qtyLst[i]), 2);
                lblPriceIncVat.Text = $"£{Math.Round(1.2 * (price * lengthLst[i] * qtyLst[i]), 2)}";
                lblPriceIncVat.Font = font;
                i++;
                y += 60;
                this.Controls.Add(lblPriceIncVat);
            }
            totalYcoord = y;
            LoadTotal();
        }

        private void LoadTotal()
        {
            Label lblTotal = new Label();
            lblTotal.ForeColor = SystemColors.ControlText;
            lblTotal.BackColor = SystemColors.Control;
            lblTotal.AutoSize = true;
            lblTotal.Size = new Size(64, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Font = font2;
            lblTotal.Location = new Point(62, totalYcoord);
            lblTotal.Visible = true;
            lblTotal.Text = $"Total:";
            this.Controls.Add(lblTotal);

            Label lblTotalNoVat = new Label();
            lblTotalNoVat.ForeColor = SystemColors.ControlText;
            lblTotalNoVat.BackColor = SystemColors.Control;
            lblTotalNoVat.AutoSize = true;
            lblTotalNoVat.Size = new Size(64, 13);
            lblTotalNoVat.Name = "lblTotalNoVat";
            lblTotalNoVat.Font = font;
            lblTotalNoVat.Location = new Point(500, totalYcoord);
            lblTotalNoVat.Visible = true;
            lblTotalNoVat.Text = $"£{Math.Round(totalNoVat, 2)}";
            this.Controls.Add(lblTotalNoVat);

            Label lblTotalIncVat = new Label();
            lblTotalIncVat.ForeColor = SystemColors.ControlText;
            lblTotalIncVat.BackColor = SystemColors.Control;
            lblTotalIncVat.AutoSize = true;
            lblTotalIncVat.Size = new Size(64, 13);
            lblTotalIncVat.Name = "lblTotalIncVat";
            lblTotalIncVat.Font = font;
            lblTotalIncVat.Location = new Point(650, totalYcoord);
            lblTotalIncVat.Visible = true;
            lblTotalIncVat.Text = $"£{Math.Round(totalIncVat, 2)}";
            this.Controls.Add(lblTotalIncVat);
        }

        private void qtyPicker_ValueChanged(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            int i = Convert.ToInt32((sender as NumericUpDown).Tag);
            string cmdStr = $"UPDATE tblCart SET Quantity = '{(sender as NumericUpDown).Value}' WHERE CartID = {cartIDLst[i]}";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            qtyLst[i] = (int)(sender as NumericUpDown).Value;

            foreach (Control c in this.Controls)
            {
                if (c is Label lblPriceNoVat && lblPriceNoVat.Name == "lblPriceNoVat_" + i)
                {
                    lblPriceNoVat.Text = $"£{Math.Round(priceLst[i] * lengthLst[i] * qtyLst[i], 2)}";
                    break;
                }
            }

            foreach (Control c in this.Controls)
            {
                if (c is Label lblPriceIncVat && lblPriceIncVat.Name == "lblPriceIncVat_" + i)
                {
                    lblPriceIncVat.Text = $"£{Math.Round(1.2 * (priceLst[i] * lengthLst[i] * qtyLst[i]), 2)}";
                    break;
                }
            }
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            Label lblTotalNoVat = new Label();
            lblTotalNoVat.Visible = false;
            lblTotalNoVat.ForeColor = SystemColors.ControlText;
            lblTotalNoVat.BackColor = SystemColors.Control;
            lblTotalNoVat.AutoSize = true;
            lblTotalNoVat.Size = new Size(64, 13);
            lblTotalNoVat.Name = "lblTotalNoVat";
            lblTotalNoVat.Font = font;
            this.Controls.Add(lblTotalNoVat);

            Label lblTotalExVat = new Label();
            lblTotalExVat.Visible = false;
            lblTotalExVat.ForeColor = SystemColors.ControlText;
            lblTotalExVat.BackColor = SystemColors.Control;
            lblTotalExVat.AutoSize = true;
            lblTotalExVat.Size = new Size(64, 13);
            lblTotalExVat.Name = "lblTotalExVat";
            lblTotalExVat.Font = font;
            this.Controls.Add(lblTotalExVat);
        }
    }
}
