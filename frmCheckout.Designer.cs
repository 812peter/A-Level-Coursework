namespace Coursework
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.lblShipping = new System.Windows.Forms.Label();
            this.cmbDeliveryAddr = new System.Windows.Forms.ComboBox();
            this.lblDeliveryAddr = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.picWeAccept = new System.Windows.Forms.PictureBox();
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.txtYY = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblShipFree = new System.Windows.Forms.Label();
            this.lblShip = new System.Windows.Forms.Label();
            this.lblVATValue = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblAnimation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(10, 9);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(93, 24);
            this.lblShipping.TabIndex = 28;
            this.lblShipping.Text = "Shipping";
            // 
            // cmbDeliveryAddr
            // 
            this.cmbDeliveryAddr.FormattingEnabled = true;
            this.cmbDeliveryAddr.Location = new System.Drawing.Point(17, 58);
            this.cmbDeliveryAddr.Name = "cmbDeliveryAddr";
            this.cmbDeliveryAddr.Size = new System.Drawing.Size(241, 21);
            this.cmbDeliveryAddr.TabIndex = 29;
            this.cmbDeliveryAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDeliveryAddr_KeyPress);
            // 
            // lblDeliveryAddr
            // 
            this.lblDeliveryAddr.AutoSize = true;
            this.lblDeliveryAddr.Location = new System.Drawing.Point(13, 40);
            this.lblDeliveryAddr.Name = "lblDeliveryAddr";
            this.lblDeliveryAddr.Size = new System.Drawing.Size(85, 13);
            this.lblDeliveryAddr.TabIndex = 30;
            this.lblDeliveryAddr.Text = "Delivery address";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(10, 107);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(90, 24);
            this.lblPayment.TabIndex = 31;
            this.lblPayment.Text = "Payment";
            // 
            // txtCardName
            // 
            this.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardName.Location = new System.Drawing.Point(17, 156);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(241, 20);
            this.txtCardName.TabIndex = 32;
            // 
            // picWeAccept
            // 
            this.picWeAccept.Image = ((System.Drawing.Image)(resources.GetObject("picWeAccept.Image")));
            this.picWeAccept.Location = new System.Drawing.Point(14, 287);
            this.picWeAccept.Name = "picWeAccept";
            this.picWeAccept.Size = new System.Drawing.Size(100, 50);
            this.picWeAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWeAccept.TabIndex = 33;
            this.picWeAccept.TabStop = false;
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(13, 138);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(61, 13);
            this.lblCardName.TabIndex = 34;
            this.lblCardName.Text = "Card holder";
            // 
            // txtMM
            // 
            this.txtMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMM.Location = new System.Drawing.Point(17, 252);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(25, 20);
            this.txtMM.TabIndex = 34;
            this.txtMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYY
            // 
            this.txtYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYY.Location = new System.Drawing.Point(59, 252);
            this.txtYY.Name = "txtYY";
            this.txtYY.Size = new System.Drawing.Size(25, 20);
            this.txtYY.TabIndex = 35;
            this.txtYY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.Location = new System.Drawing.Point(45, 252);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(13, 20);
            this.lblSlash.TabIndex = 37;
            this.lblSlash.Text = "/";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(13, 234);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(77, 13);
            this.lblExpDate.TabIndex = 38;
            this.lblExpDate.Text = "Expiration date";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(13, 186);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(67, 13);
            this.lblCardNumber.TabIndex = 40;
            this.lblCardNumber.Text = "Card number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNumber.Location = new System.Drawing.Point(17, 204);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(241, 20);
            this.txtCardNumber.TabIndex = 33;
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(105, 234);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(28, 13);
            this.lblCVC.TabIndex = 42;
            this.lblCVC.Text = "CVC";
            // 
            // txtCVC
            // 
            this.txtCVC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCVC.Location = new System.Drawing.Point(108, 252);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(48, 20);
            this.txtCVC.TabIndex = 36;
            this.txtCVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(329, 9);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(97, 24);
            this.lblSummary.TabIndex = 43;
            this.lblSummary.Text = "Summary";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(332, 40);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 44;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(400, 40);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(25, 13);
            this.lblSubtotalValue.TabIndex = 45;
            this.lblSubtotalValue.Text = "$$$";
            // 
            // lblShipFree
            // 
            this.lblShipFree.AutoSize = true;
            this.lblShipFree.Location = new System.Drawing.Point(400, 65);
            this.lblShipFree.Name = "lblShipFree";
            this.lblShipFree.Size = new System.Drawing.Size(35, 13);
            this.lblShipFree.TabIndex = 47;
            this.lblShipFree.Text = "FREE";
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Location = new System.Drawing.Point(332, 65);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(48, 13);
            this.lblShip.TabIndex = 46;
            this.lblShip.Text = "Shipping";
            // 
            // lblVATValue
            // 
            this.lblVATValue.AutoSize = true;
            this.lblVATValue.Location = new System.Drawing.Point(400, 90);
            this.lblVATValue.Name = "lblVATValue";
            this.lblVATValue.Size = new System.Drawing.Size(25, 13);
            this.lblVATValue.TabIndex = 49;
            this.lblVATValue.Text = "$$$";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(332, 90);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(28, 13);
            this.lblVAT.TabIndex = 48;
            this.lblVAT.Text = "VAT";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(400, 115);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(25, 13);
            this.lblTotalValue.TabIndex = 51;
            this.lblTotalValue.Text = "$$$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(332, 115);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "Total";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(300, 241);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(161, 43);
            this.btnPlaceOrder.TabIndex = 52;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimation.Location = new System.Drawing.Point(339, 251);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(85, 87);
            this.lblAnimation.TabIndex = 53;
            this.lblAnimation.Text = "...";
            this.lblAnimation.Visible = false;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 352);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVATValue);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblShipFree);
            this.Controls.Add(this.lblShip);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.txtYY);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.picWeAccept);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblDeliveryAddr);
            this.Controls.Add(this.cmbDeliveryAddr);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCheckout";
            this.Text = "Reinforcements - Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCheckout_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picWeAccept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ComboBox cmbDeliveryAddr;
        private System.Windows.Forms.Label lblDeliveryAddr;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.PictureBox picWeAccept;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.TextBox txtYY;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblShipFree;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Label lblVATValue;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblAnimation;
    }
}