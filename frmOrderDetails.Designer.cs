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
            this.SuspendLayout();
            // 
            // lblDateOfOrder
            // 
            this.lblDateOfOrder.AutoSize = true;
            this.lblDateOfOrder.Location = new System.Drawing.Point(12, 85);
            this.lblDateOfOrder.Name = "lblDateOfOrder";
            this.lblDateOfOrder.Size = new System.Drawing.Size(75, 13);
            this.lblDateOfOrder.TabIndex = 0;
            this.lblDateOfOrder.Text = "Date of order: ";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Location = new System.Drawing.Point(699, 307);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(37, 13);
            this.lblTotalPaid.TabIndex = 1;
            this.lblTotalPaid.Text = "Total: ";
            // 
            // lblTotalPaidNoVAT
            // 
            this.lblTotalPaidNoVAT.AutoSize = true;
            this.lblTotalPaidNoVAT.Location = new System.Drawing.Point(684, 281);
            this.lblTotalPaidNoVAT.Name = "lblTotalPaidNoVAT";
            this.lblTotalPaidNoVAT.Size = new System.Drawing.Size(52, 13);
            this.lblTotalPaidNoVAT.TabIndex = 2;
            this.lblTotalPaidNoVAT.Text = "Subtotal: ";
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCompleted.Location = new System.Drawing.Point(10, 148);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(76, 17);
            this.chkCompleted.TabIndex = 3;
            this.chkCompleted.Text = "Completed";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // lblDateOfCompletion
            // 
            this.lblDateOfCompletion.AutoSize = true;
            this.lblDateOfCompletion.Location = new System.Drawing.Point(7, 168);
            this.lblDateOfCompletion.Name = "lblDateOfCompletion";
            this.lblDateOfCompletion.Size = new System.Drawing.Size(102, 13);
            this.lblDateOfCompletion.TabIndex = 4;
            this.lblDateOfCompletion.Text = "Date of completion: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 192);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Delivery address: ";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(702, 294);
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
            this.columnHeader5});
            this.lstProducts.FullRowSelect = true;
            this.lstProducts.HideSelection = false;
            this.lstProducts.Location = new System.Drawing.Point(340, 12);
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
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Diameter";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Material";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Label lblDateOfCompletion;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.ListView lstProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}