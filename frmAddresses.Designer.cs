namespace Coursework
{
    partial class frmAddresses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddresses));
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lstAddresses = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAddressManagement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblFirstLine = new System.Windows.Forms.Label();
            this.txtFirstLine = new System.Windows.Forms.TextBox();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(220, 304);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddress.TabIndex = 35;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // lstAddresses
            // 
            this.lstAddresses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2});
            this.lstAddresses.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAddresses.FullRowSelect = true;
            this.lstAddresses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstAddresses.HideSelection = false;
            this.lstAddresses.Location = new System.Drawing.Point(483, 149);
            this.lstAddresses.Name = "lstAddresses";
            this.lstAddresses.Size = new System.Drawing.Size(318, 178);
            this.lstAddresses.TabIndex = 34;
            this.lstAddresses.UseCompatibleStateImageBehavior = false;
            this.lstAddresses.View = System.Windows.Forms.View.Details;
            this.lstAddresses.SelectedIndexChanged += new System.EventHandler(this.lstAddresses_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 24;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "First Line";
            this.columnHeader9.Width = 98;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Town";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Postcode";
            this.columnHeader2.Width = 98;
            // 
            // lblAddressManagement
            // 
            this.lblAddressManagement.AutoSize = true;
            this.lblAddressManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressManagement.Location = new System.Drawing.Point(135, 141);
            this.lblAddressManagement.Name = "lblAddressManagement";
            this.lblAddressManagement.Size = new System.Drawing.Size(214, 24);
            this.lblAddressManagement.TabIndex = 33;
            this.lblAddressManagement.Text = "Address Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Postcode";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostcode.Location = new System.Drawing.Point(238, 254);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(219, 20);
            this.txtPostcode.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTown.Location = new System.Drawing.Point(238, 228);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(219, 20);
            this.txtTown.TabIndex = 29;
            // 
            // lblFirstLine
            // 
            this.lblFirstLine.AutoSize = true;
            this.lblFirstLine.Location = new System.Drawing.Point(136, 204);
            this.lblFirstLine.Name = "lblFirstLine";
            this.lblFirstLine.Size = new System.Drawing.Size(49, 13);
            this.lblFirstLine.TabIndex = 28;
            this.lblFirstLine.Text = "First Line";
            // 
            // txtFirstLine
            // 
            this.txtFirstLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstLine.Location = new System.Drawing.Point(238, 202);
            this.txtFirstLine.Name = "txtFirstLine";
            this.txtFirstLine.Size = new System.Drawing.Size(219, 20);
            this.txtFirstLine.TabIndex = 27;
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.Location = new System.Drawing.Point(136, 178);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(62, 13);
            this.lblSelectCustomer.TabIndex = 37;
            this.lblSelectCustomer.Text = "Select User";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(238, 175);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(219, 21);
            this.cmbCustomerID.TabIndex = 36;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            this.cmbCustomerID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCustomerID_MouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(382, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(301, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFirstLine);
            this.Controls.Add(this.txtFirstLine);
            this.Controls.Add(this.lblSelectCustomer);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.lstAddresses);
            this.Controls.Add(this.lblAddressManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddresses";
            this.Text = "Reinforcements - Address Management";
            this.Load += new System.EventHandler(this.frmAddresses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.ListView lstAddresses;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblAddressManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblFirstLine;
        private System.Windows.Forms.TextBox txtFirstLine;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
    }
}