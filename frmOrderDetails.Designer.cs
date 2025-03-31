using System.Windows.Forms;

namespace Coursework
{
    partial class frmOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderDetails));
            this.lblDateOfOrder = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblTotalPaidNoVAT = new System.Windows.Forms.Label();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.lblDateOfCompletion = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblCustDetails = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblDateOfOrder
            // 
            this.lblDateOfOrder.AutoSize = true;
            this.lblDateOfOrder.Location = new System.Drawing.Point(13, 33);
            this.lblDateOfOrder.Name = "lblDateOfOrder";
            this.lblDateOfOrder.Size = new System.Drawing.Size(75, 13);
            this.lblDateOfOrder.TabIndex = 0;
            this.lblDateOfOrder.Text = "Date of order: ";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaid.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPaid.Location = new System.Drawing.Point(700, 335);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(37, 13);
            this.lblTotalPaid.TabIndex = 1;
            this.lblTotalPaid.Text = "Total: ";
            // 
            // lblTotalPaidNoVAT
            // 
            this.lblTotalPaidNoVAT.AutoSize = true;
            this.lblTotalPaidNoVAT.Location = new System.Drawing.Point(685, 305);
            this.lblTotalPaidNoVAT.Name = "lblTotalPaidNoVAT";
            this.lblTotalPaidNoVAT.Size = new System.Drawing.Size(52, 13);
            this.lblTotalPaidNoVAT.TabIndex = 2;
            this.lblTotalPaidNoVAT.Text = "Subtotal: ";
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCompleted.Location = new System.Drawing.Point(13, 49);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(76, 17);
            this.chkCompleted.TabIndex = 3;
            this.chkCompleted.Text = "Completed";
            this.chkCompleted.UseVisualStyleBackColor = true;
            this.chkCompleted.CheckedChanged += new System.EventHandler(this.chkCompleted_CheckedChanged);
            // 
            // lblDateOfCompletion
            // 
            this.lblDateOfCompletion.AutoSize = true;
            this.lblDateOfCompletion.Location = new System.Drawing.Point(13, 67);
            this.lblDateOfCompletion.Name = "lblDateOfCompletion";
            this.lblDateOfCompletion.Size = new System.Drawing.Size(102, 13);
            this.lblDateOfCompletion.TabIndex = 4;
            this.lblDateOfCompletion.Text = "Date of completion: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Delivery address: ";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(703, 320);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(34, 13);
            this.lblVAT.TabIndex = 6;
            this.lblVAT.Text = "VAT: ";
            // 
            // lstProducts
            // 
            this.lstProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstProducts.FullRowSelect = true;
            this.lstProducts.HideSelection = false;
            this.lstProducts.Location = new System.Drawing.Point(340, 38);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(448, 255);
            this.lstProducts.TabIndex = 7;
            this.lstProducts.UseCompatibleStateImageBehavior = false;
            this.lstProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Diameter";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Material";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Length";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price (ex VAT)";
            this.columnHeader6.Width = 80;
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.Location = new System.Drawing.Point(10, 9);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(132, 24);
            this.lblCustomerDetails.TabIndex = 25;
            this.lblCustomerDetails.Text = "Order Details";
            // 
            // lblCustDetails
            // 
            this.lblCustDetails.AutoSize = true;
            this.lblCustDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustDetails.Location = new System.Drawing.Point(10, 130);
            this.lblCustDetails.Name = "lblCustDetails";
            this.lblCustDetails.Size = new System.Drawing.Size(167, 24);
            this.lblCustDetails.TabIndex = 26;
            this.lblCustDetails.Text = "Customer Details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 188);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(46, 13);
            this.lblPhoneNumber.TabIndex = 29;
            this.lblPhoneNumber.Text = "PhoneN";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(13, 205);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(59, 13);
            this.lblCompanyName.TabIndex = 30;
            this.lblCompanyName.Text = "CompanyN";
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.Location = new System.Drawing.Point(336, 9);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(150, 24);
            this.lblProductDetails.TabIndex = 31;
            this.lblProductDetails.Text = "Product Details";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(16, 324);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(75, 23);
            this.btnReceipt.TabIndex = 32;
            this.btnReceipt.Text = "View receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(600, 600);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Reinforcements - Print Preview";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCustDetails);
            this.Controls.Add(this.lblCustomerDetails);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDateOfCompletion);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.lblTotalPaidNoVAT);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.lblDateOfOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOrderDetails";
            this.Text = "Reinforcements - Order Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateOfOrder;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblTotalPaidNoVAT;
        public System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Label lblDateOfCompletion;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.ListView lstProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Label lblCustDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}