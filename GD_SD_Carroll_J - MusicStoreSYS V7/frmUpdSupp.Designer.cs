namespace MusicStoreSYS
{
    partial class frmUpdSupp
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
            this.btnUExit = new System.Windows.Forms.Button();
            this.btnUReg = new System.Windows.Forms.Button();
            this.txtUpdTownVillage = new System.Windows.Forms.TextBox();
            this.lblUpdTownVill = new System.Windows.Forms.Label();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.lblUpdEmail = new System.Windows.Forms.Label();
            this.txtUpdPhoneNo = new System.Windows.Forms.TextBox();
            this.lblUpdPhoneNo = new System.Windows.Forms.Label();
            this.lblUpdSuppName = new System.Windows.Forms.Label();
            this.cboUpdSuppliers = new System.Windows.Forms.ComboBox();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.lblUpdStreet = new System.Windows.Forms.Label();
            this.txtUpdStreet = new System.Windows.Forms.TextBox();
            this.lbluCounty = new System.Windows.Forms.Label();
            this.cboupdCounties = new System.Windows.Forms.ComboBox();
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mnuBack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUExit
            // 
            this.btnUExit.Location = new System.Drawing.Point(671, 0);
            this.btnUExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUExit.Name = "btnUExit";
            this.btnUExit.Size = new System.Drawing.Size(103, 29);
            this.btnUExit.TabIndex = 36;
            this.btnUExit.Text = "Exit";
            this.btnUExit.UseVisualStyleBackColor = true;
            this.btnUExit.Click += new System.EventHandler(this.btnUExit_Click);
            // 
            // btnUReg
            // 
            this.btnUReg.Location = new System.Drawing.Point(255, 498);
            this.btnUReg.Name = "btnUReg";
            this.btnUReg.Size = new System.Drawing.Size(168, 53);
            this.btnUReg.TabIndex = 35;
            this.btnUReg.Text = "Update";
            this.btnUReg.UseVisualStyleBackColor = true;
            this.btnUReg.Click += new System.EventHandler(this.btnUReg_Click);
            // 
            // txtUpdTownVillage
            // 
            this.txtUpdTownVillage.Location = new System.Drawing.Point(100, 307);
            this.txtUpdTownVillage.Name = "txtUpdTownVillage";
            this.txtUpdTownVillage.Size = new System.Drawing.Size(121, 20);
            this.txtUpdTownVillage.TabIndex = 33;
            // 
            // lblUpdTownVill
            // 
            this.lblUpdTownVill.AutoSize = true;
            this.lblUpdTownVill.Location = new System.Drawing.Point(24, 310);
            this.lblUpdTownVill.Name = "lblUpdTownVill";
            this.lblUpdTownVill.Size = new System.Drawing.Size(70, 13);
            this.lblUpdTownVill.TabIndex = 32;
            this.lblUpdTownVill.Text = "Town/Village";
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Location = new System.Drawing.Point(80, 195);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(182, 20);
            this.txtUpdEmail.TabIndex = 31;
            // 
            // lblUpdEmail
            // 
            this.lblUpdEmail.AutoSize = true;
            this.lblUpdEmail.Location = new System.Drawing.Point(28, 198);
            this.lblUpdEmail.Name = "lblUpdEmail";
            this.lblUpdEmail.Size = new System.Drawing.Size(32, 13);
            this.lblUpdEmail.TabIndex = 30;
            this.lblUpdEmail.Text = "Email";
            // 
            // txtUpdPhoneNo
            // 
            this.txtUpdPhoneNo.Location = new System.Drawing.Point(111, 149);
            this.txtUpdPhoneNo.Name = "txtUpdPhoneNo";
            this.txtUpdPhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtUpdPhoneNo.TabIndex = 29;
            // 
            // lblUpdPhoneNo
            // 
            this.lblUpdPhoneNo.AutoSize = true;
            this.lblUpdPhoneNo.Location = new System.Drawing.Point(28, 151);
            this.lblUpdPhoneNo.Name = "lblUpdPhoneNo";
            this.lblUpdPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.lblUpdPhoneNo.TabIndex = 28;
            this.lblUpdPhoneNo.Text = "Phone Number";
            // 
            // lblUpdSuppName
            // 
            this.lblUpdSuppName.AutoSize = true;
            this.lblUpdSuppName.Location = new System.Drawing.Point(16, 88);
            this.lblUpdSuppName.Name = "lblUpdSuppName";
            this.lblUpdSuppName.Size = new System.Drawing.Size(78, 13);
            this.lblUpdSuppName.TabIndex = 24;
            this.lblUpdSuppName.Text = "Select Supplier";
            // 
            // cboUpdSuppliers
            // 
            this.cboUpdSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdSuppliers.FormattingEnabled = true;
            this.cboUpdSuppliers.Items.AddRange(new object[] {
            "Jack Jones",
            "Billy Kelly",
            "Frank Lally",
            "John Adams",
            "Francis Flowers",
            "Sarah Kelly",
            "Niamh Walsh"});
            this.cboUpdSuppliers.Location = new System.Drawing.Point(109, 84);
            this.cboUpdSuppliers.Name = "cboUpdSuppliers";
            this.cboUpdSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cboUpdSuppliers.TabIndex = 23;
            this.cboUpdSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboUpdSuppliers_SelectedIndexChanged);
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.Location = new System.Drawing.Point(16, 27);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(46, 13);
            this.lblSuppID.TabIndex = 38;
            this.lblSuppID.Text = "Supp ID";
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(81, 24);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(67, 20);
            this.txtSuppID.TabIndex = 39;
            this.txtSuppID.Text = "001";
            this.txtSuppID.TextChanged += new System.EventHandler(this.txtSuppID_TextChanged);
            // 
            // lblUpdStreet
            // 
            this.lblUpdStreet.AutoSize = true;
            this.lblUpdStreet.Location = new System.Drawing.Point(31, 254);
            this.lblUpdStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdStreet.Name = "lblUpdStreet";
            this.lblUpdStreet.Size = new System.Drawing.Size(35, 13);
            this.lblUpdStreet.TabIndex = 40;
            this.lblUpdStreet.Text = "Street";
            // 
            // txtUpdStreet
            // 
            this.txtUpdStreet.Location = new System.Drawing.Point(79, 254);
            this.txtUpdStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdStreet.Name = "txtUpdStreet";
            this.txtUpdStreet.Size = new System.Drawing.Size(182, 20);
            this.txtUpdStreet.TabIndex = 41;
            // 
            // lbluCounty
            // 
            this.lbluCounty.AutoSize = true;
            this.lbluCounty.Location = new System.Drawing.Point(28, 359);
            this.lbluCounty.Name = "lbluCounty";
            this.lbluCounty.Size = new System.Drawing.Size(40, 13);
            this.lbluCounty.TabIndex = 63;
            this.lbluCounty.Text = "County";
            // 
            // cboupdCounties
            // 
            this.cboupdCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboupdCounties.FormattingEnabled = true;
            this.cboupdCounties.Items.AddRange(new object[] {
            "AH Armagh",
            "CK Cork",
            "DL Donegal",
            "KY Kerry",
            "MN Monaghan",
            "WW Wicklow"});
            this.cboupdCounties.Location = new System.Drawing.Point(105, 357);
            this.cboupdCounties.Name = "cboupdCounties";
            this.cboupdCounties.Size = new System.Drawing.Size(121, 21);
            this.cboupdCounties.TabIndex = 62;
            this.cboupdCounties.SelectedIndexChanged += new System.EventHandler(this.cboupdCounties_SelectedIndexChanged);
            // 
            // mnuBack
            // 
            this.mnuBack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBack.Size = new System.Drawing.Size(774, 24);
            this.mnuBack.TabIndex = 64;
            this.mnuBack.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.menuToolStripMenuItem.Text = "Back";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSuppID);
            this.groupBox1.Controls.Add(this.lbluCounty);
            this.groupBox1.Controls.Add(this.cboUpdSuppliers);
            this.groupBox1.Controls.Add(this.cboupdCounties);
            this.groupBox1.Controls.Add(this.lblUpdSuppName);
            this.groupBox1.Controls.Add(this.txtUpdStreet);
            this.groupBox1.Controls.Add(this.lblUpdPhoneNo);
            this.groupBox1.Controls.Add(this.lblUpdStreet);
            this.groupBox1.Controls.Add(this.txtUpdPhoneNo);
            this.groupBox1.Controls.Add(this.txtSuppID);
            this.groupBox1.Controls.Add(this.lblUpdEmail);
            this.groupBox1.Controls.Add(this.txtUpdEmail);
            this.groupBox1.Controls.Add(this.lblUpdTownVill);
            this.groupBox1.Controls.Add(this.txtUpdTownVillage);
            this.groupBox1.Location = new System.Drawing.Point(141, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(351, 410);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please choose the Supplier for its details to be updated:";
            // 
            // frmUpdSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUExit);
            this.Controls.Add(this.btnUReg);
            this.Controls.Add(this.mnuBack);
            this.MainMenuStrip = this.mnuBack;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpdSupp";
            this.Text = "Update Supplier Details";
            this.Load += new System.EventHandler(this.frmUpdSupp_Load);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUExit;
        private System.Windows.Forms.Button btnUReg;
        private System.Windows.Forms.TextBox txtUpdTownVillage;
        private System.Windows.Forms.Label lblUpdTownVill;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.Label lblUpdEmail;
        private System.Windows.Forms.TextBox txtUpdPhoneNo;
        private System.Windows.Forms.Label lblUpdPhoneNo;
        private System.Windows.Forms.Label lblUpdSuppName;
        private System.Windows.Forms.ComboBox cboUpdSuppliers;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.Label lblUpdStreet;
        private System.Windows.Forms.TextBox txtUpdStreet;
        private System.Windows.Forms.Label lbluCounty;
        private System.Windows.Forms.ComboBox cboupdCounties;
        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}