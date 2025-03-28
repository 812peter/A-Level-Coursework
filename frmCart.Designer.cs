namespace Coursework
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.lblCart = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblPriceExVAT = new System.Windows.Forms.Label();
            this.lblPriceIncVAT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(62, 9);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(135, 24);
            this.lblCart.TabIndex = 27;
            this.lblCart.Text = "Cart Contents";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(159, 40);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(54, 13);
            this.lblQty.TabIndex = 29;
            this.lblQty.Text = "Quantity";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(270, 40);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 13);
            this.lblLength.TabIndex = 30;
            this.lblLength.Text = "Length";
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(64, 40);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(51, 13);
            this.lblproduct.TabIndex = 28;
            this.lblproduct.Text = "Product";
            // 
            // lblPriceExVAT
            // 
            this.lblPriceExVAT.AutoSize = true;
            this.lblPriceExVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceExVAT.Location = new System.Drawing.Point(500, 40);
            this.lblPriceExVAT.Name = "lblPriceExVAT";
            this.lblPriceExVAT.Size = new System.Drawing.Size(89, 13);
            this.lblPriceExVAT.TabIndex = 31;
            this.lblPriceExVAT.Text = "Price (ex VAT)";
            // 
            // lblPriceIncVAT
            // 
            this.lblPriceIncVAT.AutoSize = true;
            this.lblPriceIncVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceIncVAT.Location = new System.Drawing.Point(650, 40);
            this.lblPriceIncVAT.Name = "lblPriceIncVAT";
            this.lblPriceIncVAT.Size = new System.Drawing.Size(93, 13);
            this.lblPriceIncVAT.TabIndex = 32;
            this.lblPriceIncVAT.Text = "Price (inc VAT)";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.lblPriceIncVAT);
            this.Controls.Add(this.lblPriceExVAT);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblproduct);
            this.Controls.Add(this.lblCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCart";
            this.Text = "Reinforcements - Cart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCart_FormClosed);
            this.Load += new System.EventHandler(this.frmCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblPriceExVAT;
        private System.Windows.Forms.Label lblPriceIncVAT;
    }
}