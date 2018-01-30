namespace MusicStoreSYS
{
    partial class frmSuppReg
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
            this.btnReg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuppId = new System.Windows.Forms.TextBox();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtTownVillage = new System.Windows.Forms.TextBox();
            this.lblTownVill = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.mnuMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(221, 479);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(168, 53);
            this.btnReg.TabIndex = 21;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(650, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(752, 24);
            this.mnuMenu.TabIndex = 48;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSuppId);
            this.groupBox1.Controls.Add(this.lblSuppID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.txtTownVillage);
            this.groupBox1.Controls.Add(this.lblTownVill);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.lblPhoneNo);
            this.groupBox1.Controls.Add(this.lblSuppName);
            this.groupBox1.Controls.Add(this.cboCounties);
            this.groupBox1.Location = new System.Drawing.Point(34, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 354);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Supplier Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "County";
            // 
            // txtSuppId
            // 
            this.txtSuppId.Enabled = false;
            this.txtSuppId.Location = new System.Drawing.Point(141, 39);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(46, 20);
            this.txtSuppId.TabIndex = 60;
            this.txtSuppId.Text = "011";
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.Location = new System.Drawing.Point(59, 42);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(59, 13);
            this.lblSuppID.TabIndex = 59;
            this.lblSuppID.Text = "Supplier ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 58;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(107, 213);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(182, 20);
            this.txtStreet.TabIndex = 57;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(59, 213);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 56;
            this.lblStreet.Text = "Street";
            // 
            // txtTownVillage
            // 
            this.txtTownVillage.Location = new System.Drawing.Point(132, 261);
            this.txtTownVillage.Name = "txtTownVillage";
            this.txtTownVillage.Size = new System.Drawing.Size(121, 20);
            this.txtTownVillage.TabIndex = 55;
            // 
            // lblTownVill
            // 
            this.lblTownVill.AutoSize = true;
            this.lblTownVill.Location = new System.Drawing.Point(56, 262);
            this.lblTownVill.Name = "lblTownVill";
            this.lblTownVill.Size = new System.Drawing.Size(70, 13);
            this.lblTownVill.TabIndex = 54;
            this.lblTownVill.Text = "Town/Village";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(59, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(141, 103);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtPhoneNo.TabIndex = 51;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(57, 106);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNo.TabIndex = 50;
            this.lblPhoneNo.Text = "Phone Number";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Location = new System.Drawing.Point(59, 68);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(35, 13);
            this.lblSuppName.TabIndex = 49;
            this.lblSuppName.Text = "Name";
            // 
            // cboCounties
            // 
            this.cboCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounties.FormattingEnabled = true;
            this.cboCounties.Items.AddRange(new object[] {
            "AH Armagh",
            "CK Cork",
            "DL Donegal",
            "KY Kerry",
            "MN Monaghan",
            "WW Wicklow"});
            this.cboCounties.Location = new System.Drawing.Point(132, 289);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(121, 21);
            this.cboCounties.TabIndex = 48;
            this.cboCounties.SelectedIndexChanged += new System.EventHandler(this.cboCounties_SelectedIndexChanged);
            // 
            // frmSuppReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmSuppReg";
            this.Text = "Register Supplier";
            this.Load += new System.EventHandler(this.frmSuppReg_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuppId;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtTownVillage;
        private System.Windows.Forms.Label lblTownVill;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.ComboBox cboCounties;
    }
}

