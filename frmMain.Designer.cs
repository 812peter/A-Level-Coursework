using System;
using System.Windows.Forms;

namespace Coursework
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAddresses = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblLengthMeters = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCstLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPriceVAT = new System.Windows.Forms.Label();
            this.lblPricePM = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.salesPerMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblOrderReport = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.picMore = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblValidLength = new System.Windows.Forms.Label();
            this.lblValidQuantity = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrders.FullRowSelect = true;
            this.lstOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstOrders.HideSelection = false;
            this.lstOrders.Location = new System.Drawing.Point(0, 0);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(1164, 657);
            this.lstOrders.TabIndex = 3;
            this.lstOrders.UseCompatibleStateImageBehavior = false;
            this.lstOrders.View = System.Windows.Forms.View.Details;
            this.lstOrders.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lstOrders_ColumnWidthChanged);
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            this.lstOrders.DoubleClick += new System.EventHandler(this.lstOrders_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User ID";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Order";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Paid";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Completed";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date of Completion";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Address ID";
            this.columnHeader7.Width = 65;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1273, 684);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnViewDetails);
            this.tabPage1.Controls.Add(this.lstOrders);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1265, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnViewDetails.Location = new System.Drawing.Point(1175, 3);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(75, 23);
            this.btnViewDetails.TabIndex = 7;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(1132, -25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 695);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.btnAddresses);
            this.tabPage2.Controls.Add(this.btnManageCustomers);
            this.tabPage2.Controls.Add(this.lstCustomers);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1265, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox1.Location = new System.Drawing.Point(1178, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Managers";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAddresses
            // 
            this.btnAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddresses.Location = new System.Drawing.Point(1175, 43);
            this.btnAddresses.Name = "btnAddresses";
            this.btnAddresses.Size = new System.Drawing.Size(75, 21);
            this.btnAddresses.TabIndex = 7;
            this.btnAddresses.Text = "Addresses";
            this.btnAddresses.UseVisualStyleBackColor = true;
            this.btnAddresses.Click += new System.EventHandler(this.btnAddresses_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.Location = new System.Drawing.Point(1175, 21);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(75, 21);
            this.btnManageCustomers.TabIndex = 6;
            this.btnManageCustomers.Text = "Manage";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FullRowSelect = true;
            this.lstCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCustomers.HideSelection = false;
            this.lstCustomers.Location = new System.Drawing.Point(0, 0);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(1164, 657);
            this.lstCustomers.TabIndex = 5;
            this.lstCustomers.UseCompatibleStateImageBehavior = false;
            this.lstCustomers.View = System.Windows.Forms.View.Details;
            this.lstCustomers.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lstCustomers_ColumnWidthChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "User ID";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "First Name";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Surname";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Email";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Phone Number";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Company Name";
            this.columnHeader13.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1162, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 722);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblValidQuantity);
            this.tabPage3.Controls.Add(this.lblValidLength);
            this.tabPage3.Controls.Add(this.lblLengthMeters);
            this.tabPage3.Controls.Add(this.lblQuantity);
            this.tabPage3.Controls.Add(this.txtQuantity);
            this.tabPage3.Controls.Add(this.lblCstLength);
            this.tabPage3.Controls.Add(this.txtLength);
            this.tabPage3.Controls.Add(this.lblStock);
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.lblPriceVAT);
            this.tabPage3.Controls.Add(this.lblPricePM);
            this.tabPage3.Controls.Add(this.lblMaterial);
            this.tabPage3.Controls.Add(this.lblDiameter);
            this.tabPage3.Controls.Add(this.lblProductName);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1265, 655);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblLengthMeters
            // 
            this.lblLengthMeters.AutoSize = true;
            this.lblLengthMeters.BackColor = System.Drawing.SystemColors.Control;
            this.lblLengthMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLengthMeters.Location = new System.Drawing.Point(1213, 139);
            this.lblLengthMeters.Name = "lblLengthMeters";
            this.lblLengthMeters.Size = new System.Drawing.Size(23, 13);
            this.lblLengthMeters.TabIndex = 21;
            this.lblLengthMeters.Text = "mm";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblQuantity.Location = new System.Drawing.Point(1170, 194);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 20;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtQuantity.Location = new System.Drawing.Point(1173, 209);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(40, 20);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblCstLength
            // 
            this.lblCstLength.AutoSize = true;
            this.lblCstLength.BackColor = System.Drawing.SystemColors.Control;
            this.lblCstLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCstLength.Location = new System.Drawing.Point(1170, 122);
            this.lblCstLength.Name = "lblCstLength";
            this.lblCstLength.Size = new System.Drawing.Size(77, 13);
            this.lblCstLength.TabIndex = 18;
            this.lblCstLength.Text = "Custom length:";
            // 
            // txtLength
            // 
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLength.Location = new System.Drawing.Point(1173, 137);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(40, 20);
            this.txtLength.TabIndex = 17;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.Control;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStock.Location = new System.Drawing.Point(1170, 88);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 13);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "lblStock";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1170, 266);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblPriceVAT
            // 
            this.lblPriceVAT.AutoSize = true;
            this.lblPriceVAT.BackColor = System.Drawing.SystemColors.Control;
            this.lblPriceVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPriceVAT.Location = new System.Drawing.Point(1170, 71);
            this.lblPriceVAT.Name = "lblPriceVAT";
            this.lblPriceVAT.Size = new System.Drawing.Size(62, 13);
            this.lblPriceVAT.TabIndex = 14;
            this.lblPriceVAT.Text = "lblPriceVAT";
            // 
            // lblPricePM
            // 
            this.lblPricePM.AutoSize = true;
            this.lblPricePM.BackColor = System.Drawing.SystemColors.Control;
            this.lblPricePM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPricePM.Location = new System.Drawing.Point(1170, 54);
            this.lblPricePM.Name = "lblPricePM";
            this.lblPricePM.Size = new System.Drawing.Size(57, 13);
            this.lblPricePM.TabIndex = 13;
            this.lblPricePM.Text = "lblPricePM";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMaterial.Location = new System.Drawing.Point(1170, 37);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(54, 13);
            this.lblMaterial.TabIndex = 12;
            this.lblMaterial.Text = "lblMaterial";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDiameter.Location = new System.Drawing.Point(1170, 20);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(59, 13);
            this.lblDiameter.TabIndex = 11;
            this.lblDiameter.Text = "lblDiameter";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProductName.Location = new System.Drawing.Point(1170, 3);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(82, 13);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "lblProductName";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(1164, -52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 722);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.salesPerMonth);
            this.tabPage4.Controls.Add(this.lblEnd);
            this.tabPage4.Controls.Add(this.lblStart);
            this.tabPage4.Controls.Add(this.lblOrderReport);
            this.tabPage4.Controls.Add(this.btnPrint);
            this.tabPage4.Controls.Add(this.dateEnd);
            this.tabPage4.Controls.Add(this.dateStart);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1265, 655);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistics";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // salesPerMonth
            // 
            chartArea3.Name = "ChartArea1";
            this.salesPerMonth.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.salesPerMonth.Legends.Add(legend3);
            this.salesPerMonth.Location = new System.Drawing.Point(498, 65);
            this.salesPerMonth.Name = "salesPerMonth";
            this.salesPerMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.salesPerMonth.Series.Add(series3);
            this.salesPerMonth.Size = new System.Drawing.Size(300, 300);
            this.salesPerMonth.TabIndex = 29;
            this.salesPerMonth.Text = "chart1";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEnd.Location = new System.Drawing.Point(13, 65);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(32, 13);
            this.lblEnd.TabIndex = 28;
            this.lblEnd.Text = "End: ";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStart.Location = new System.Drawing.Point(13, 40);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Start: ";
            // 
            // lblOrderReport
            // 
            this.lblOrderReport.AutoSize = true;
            this.lblOrderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderReport.Location = new System.Drawing.Point(10, 9);
            this.lblOrderReport.Name = "lblOrderReport";
            this.lblOrderReport.Size = new System.Drawing.Size(132, 24);
            this.lblOrderReport.TabIndex = 26;
            this.lblOrderReport.Text = "Order Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrint.Location = new System.Drawing.Point(84, 89);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(51, 63);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(107, 20);
            this.dateEnd.TabIndex = 12;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(51, 37);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(107, 20);
            this.dateStart.TabIndex = 11;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(1164, -52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 722);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // picAccount
            // 
            this.picAccount.BackColor = System.Drawing.SystemColors.Control;
            this.picAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAccount.Image = ((System.Drawing.Image)(resources.GetObject("picAccount.Image")));
            this.picAccount.Location = new System.Drawing.Point(1183, 643);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(30, 30);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccount.TabIndex = 5;
            this.picAccount.TabStop = false;
            this.picAccount.Click += new System.EventHandler(this.picAccount_Click);
            // 
            // picMore
            // 
            this.picMore.BackColor = System.Drawing.SystemColors.Control;
            this.picMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMore.Image = ((System.Drawing.Image)(resources.GetObject("picMore.Image")));
            this.picMore.Location = new System.Drawing.Point(1229, 647);
            this.picMore.Name = "picMore";
            this.picMore.Size = new System.Drawing.Size(22, 22);
            this.picMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMore.TabIndex = 6;
            this.picMore.TabStop = false;
            this.picMore.Click += new System.EventHandler(this.picMore_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1178, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 63);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(750, 1000);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Reinforcements - Print Preview";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblValidLength
            // 
            this.lblValidLength.AutoSize = true;
            this.lblValidLength.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblValidLength.Location = new System.Drawing.Point(1170, 160);
            this.lblValidLength.Name = "lblValidLength";
            this.lblValidLength.Size = new System.Drawing.Size(64, 13);
            this.lblValidLength.TabIndex = 22;
            this.lblValidLength.Text = "(300 - 6000)";
            // 
            // lblValidQuantity
            // 
            this.lblValidQuantity.AutoSize = true;
            this.lblValidQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblValidQuantity.Location = new System.Drawing.Point(1170, 232);
            this.lblValidQuantity.Name = "lblValidQuantity";
            this.lblValidQuantity.Size = new System.Drawing.Size(33, 13);
            this.lblValidQuantity.TabIndex = 23;
            this.lblValidQuantity.Text = "(1 - x)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picMore);
            this.Controls.Add(this.picAccount);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Reinforcements - Main Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private Button btnManageCustomers;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAddresses;
        public CheckBox checkBox1;
        private PictureBox picAccount;
        private PictureBox picMore;
        private Panel panel1;
        private TabPage tabPage3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private Button btnViewDetails;
        private TabPage tabPage4;
        private PictureBox pictureBox4;
        private DateTimePicker dateStart;
        private DateTimePicker dateEnd;
        private Button btnPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblOrderReport;
        private Label lblStart;
        private Label lblEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesPerMonth;
        private Label lblDiameter;
        private Label lblProductName;
        private Label lblTotal;
        private Label lblPriceVAT;
        private Label lblPricePM;
        private Label lblMaterial;
        private Label lblStock;
        private TextBox txtLength;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblCstLength;
        private Label lblLengthMeters;
        private Label lblValidLength;
        private Label lblValidQuantity;
    }
}

