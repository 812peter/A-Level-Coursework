namespace Coursework
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmailReg = new System.Windows.Forms.Label();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPasswordReg1 = new System.Windows.Forms.Label();
            this.txtPasswordReg1 = new System.Windows.Forms.TextBox();
            this.lblPasswordReg2 = new System.Windows.Forms.Label();
            this.txtPasswordReg2 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.picViewPassword = new System.Windows.Forms.PictureBox();
            this.picViewPassword2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picViewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewPassword2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(353, 66);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(75, 24);
            this.lblSignIn.TabIndex = 34;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEmail.Location = new System.Drawing.Point(287, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email address";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(284, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "No account?";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPassword.Location = new System.Drawing.Point(287, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(284, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(219, 20);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(346, 159);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(62, 13);
            this.lblRegister.TabIndex = 40;
            this.lblRegister.Text = "Create one!";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(428, 153);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 41;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.White;
            this.lblCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCompanyName.Location = new System.Drawing.Point(287, 288);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(80, 13);
            this.lblCompanyName.TabIndex = 51;
            this.lblCompanyName.Text = "Company name";
            this.lblCompanyName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Location = new System.Drawing.Point(284, 286);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(219, 20);
            this.txtCompanyName.TabIndex = 50;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPhoneNumber.Location = new System.Drawing.Point(287, 262);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lblPhoneNumber.TabIndex = 49;
            this.lblPhoneNumber.Text = "Phone number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(284, 260);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(219, 20);
            this.txtPhoneNumber.TabIndex = 48;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblEmailReg
            // 
            this.lblEmailReg.AutoSize = true;
            this.lblEmailReg.BackColor = System.Drawing.Color.White;
            this.lblEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmailReg.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEmailReg.Location = new System.Drawing.Point(287, 236);
            this.lblEmailReg.Name = "lblEmailReg";
            this.lblEmailReg.Size = new System.Drawing.Size(32, 13);
            this.lblEmailReg.TabIndex = 47;
            this.lblEmailReg.Text = "Email";
            this.lblEmailReg.Click += new System.EventHandler(this.lblEmailReg_Click);
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailReg.Location = new System.Drawing.Point(284, 234);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(219, 20);
            this.txtEmailReg.TabIndex = 46;
            this.txtEmailReg.TextChanged += new System.EventHandler(this.txtEmailReg_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.White;
            this.lblSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSurname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSurname.Location = new System.Drawing.Point(287, 210);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 45;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Location = new System.Drawing.Point(284, 208);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(219, 20);
            this.txtSurname.TabIndex = 44;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFirstName.Location = new System.Drawing.Point(287, 184);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 43;
            this.lblFirstName.Text = "First name";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(284, 182);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 20);
            this.txtFirstName.TabIndex = 42;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblPasswordReg1
            // 
            this.lblPasswordReg1.AutoSize = true;
            this.lblPasswordReg1.BackColor = System.Drawing.Color.White;
            this.lblPasswordReg1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPasswordReg1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPasswordReg1.Location = new System.Drawing.Point(287, 314);
            this.lblPasswordReg1.Name = "lblPasswordReg1";
            this.lblPasswordReg1.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordReg1.TabIndex = 53;
            this.lblPasswordReg1.Text = "Password";
            this.lblPasswordReg1.Click += new System.EventHandler(this.lblPasswordReg1_Click);
            // 
            // txtPasswordReg1
            // 
            this.txtPasswordReg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordReg1.Location = new System.Drawing.Point(284, 312);
            this.txtPasswordReg1.Name = "txtPasswordReg1";
            this.txtPasswordReg1.PasswordChar = '*';
            this.txtPasswordReg1.Size = new System.Drawing.Size(219, 20);
            this.txtPasswordReg1.TabIndex = 52;
            this.txtPasswordReg1.TextChanged += new System.EventHandler(this.txtPasswordReg1_TextChanged);
            // 
            // lblPasswordReg2
            // 
            this.lblPasswordReg2.AutoSize = true;
            this.lblPasswordReg2.BackColor = System.Drawing.Color.White;
            this.lblPasswordReg2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPasswordReg2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPasswordReg2.Location = new System.Drawing.Point(287, 340);
            this.lblPasswordReg2.Name = "lblPasswordReg2";
            this.lblPasswordReg2.Size = new System.Drawing.Size(90, 13);
            this.lblPasswordReg2.TabIndex = 55;
            this.lblPasswordReg2.Text = "Confirm password";
            this.lblPasswordReg2.Click += new System.EventHandler(this.lblPasswordReg2_Click);
            // 
            // txtPasswordReg2
            // 
            this.txtPasswordReg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordReg2.Location = new System.Drawing.Point(284, 338);
            this.txtPasswordReg2.Name = "txtPasswordReg2";
            this.txtPasswordReg2.PasswordChar = '*';
            this.txtPasswordReg2.Size = new System.Drawing.Size(219, 20);
            this.txtPasswordReg2.TabIndex = 54;
            this.txtPasswordReg2.TextChanged += new System.EventHandler(this.txtPasswordReg2_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegister.Location = new System.Drawing.Point(428, 364);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 56;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // picViewPassword
            // 
            this.picViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picViewPassword.Image = ((System.Drawing.Image)(resources.GetObject("picViewPassword.Image")));
            this.picViewPassword.Location = new System.Drawing.Point(507, 127);
            this.picViewPassword.Name = "picViewPassword";
            this.picViewPassword.Size = new System.Drawing.Size(22, 19);
            this.picViewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewPassword.TabIndex = 57;
            this.picViewPassword.TabStop = false;
            this.picViewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picViewPassword_MouseDown);
            this.picViewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picViewPassword_MouseUp);
            // 
            // picViewPassword2
            // 
            this.picViewPassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picViewPassword2.Image = ((System.Drawing.Image)(resources.GetObject("picViewPassword2.Image")));
            this.picViewPassword2.Location = new System.Drawing.Point(507, 312);
            this.picViewPassword2.Name = "picViewPassword2";
            this.picViewPassword2.Size = new System.Drawing.Size(22, 19);
            this.picViewPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewPassword2.TabIndex = 58;
            this.picViewPassword2.TabStop = false;
            this.picViewPassword2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picViewPassword2_MouseDown);
            this.picViewPassword2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picViewPassword2_MouseUp);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picViewPassword2);
            this.Controls.Add(this.picViewPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPasswordReg2);
            this.Controls.Add(this.txtPasswordReg2);
            this.Controls.Add(this.lblPasswordReg1);
            this.Controls.Add(this.txtPasswordReg1);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblEmailReg);
            this.Controls.Add(this.txtEmailReg);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reinforcements - Sign In";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picViewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewPassword2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailReg;
        private System.Windows.Forms.TextBox txtEmailReg;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPasswordReg1;
        private System.Windows.Forms.TextBox txtPasswordReg1;
        private System.Windows.Forms.Label lblPasswordReg2;
        private System.Windows.Forms.TextBox txtPasswordReg2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox picViewPassword;
        private System.Windows.Forms.PictureBox picViewPassword2;
    }
}