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
            this.txtUpdTownVillage = new System.Windows.Forms.TextBox();
            this.lblUpdTownVill = new System.Windows.Forms.Label();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.lblUpdEmail = new System.Windows.Forms.Label();
            this.txtUpdPhoneNo = new System.Windows.Forms.TextBox();
            this.lblUpdPhoneNo = new System.Windows.Forms.Label();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.lblUpdStreet = new System.Windows.Forms.Label();
            this.txtUpdStreet = new System.Windows.Forms.TextBox();
            this.lbluCounty = new System.Windows.Forms.Label();
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSupp = new System.Windows.Forms.GroupBox();
            this.txtAccBal = new System.Windows.Forms.TextBox();
            this.lblAccBal = new System.Windows.Forms.Label();
            this.txtUpdCounties = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUReg = new System.Windows.Forms.Button();
            this.cboUpdSuppliers = new System.Windows.Forms.ComboBox();
            this.lblUpdSuppName = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.grpSupp.SuspendLayout();
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
            // txtUpdTownVillage
            // 
            this.txtUpdTownVillage.Location = new System.Drawing.Point(90, 224);
            this.txtUpdTownVillage.Name = "txtUpdTownVillage";
            this.txtUpdTownVillage.Size = new System.Drawing.Size(121, 20);
            this.txtUpdTownVillage.TabIndex = 33;
            // 
            // lblUpdTownVill
            // 
            this.lblUpdTownVill.AutoSize = true;
            this.lblUpdTownVill.Location = new System.Drawing.Point(14, 227);
            this.lblUpdTownVill.Name = "lblUpdTownVill";
            this.lblUpdTownVill.Size = new System.Drawing.Size(70, 13);
            this.lblUpdTownVill.TabIndex = 32;
            this.lblUpdTownVill.Text = "Town/Village";
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Location = new System.Drawing.Point(69, 126);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(130, 20);
            this.txtUpdEmail.TabIndex = 31;
            this.txtUpdEmail.TextChanged += new System.EventHandler(this.txtUpdEmail_TextChanged);
            // 
            // lblUpdEmail
            // 
            this.lblUpdEmail.AutoSize = true;
            this.lblUpdEmail.Location = new System.Drawing.Point(20, 129);
            this.lblUpdEmail.Name = "lblUpdEmail";
            this.lblUpdEmail.Size = new System.Drawing.Size(32, 13);
            this.lblUpdEmail.TabIndex = 30;
            this.lblUpdEmail.Text = "Email";
            // 
            // txtUpdPhoneNo
            // 
            this.txtUpdPhoneNo.Location = new System.Drawing.Point(95, 86);
            this.txtUpdPhoneNo.Name = "txtUpdPhoneNo";
            this.txtUpdPhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtUpdPhoneNo.TabIndex = 29;
            // 
            // lblUpdPhoneNo
            // 
            this.lblUpdPhoneNo.AutoSize = true;
            this.lblUpdPhoneNo.Location = new System.Drawing.Point(5, 89);
            this.lblUpdPhoneNo.Name = "lblUpdPhoneNo";
            this.lblUpdPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.lblUpdPhoneNo.TabIndex = 28;
            this.lblUpdPhoneNo.Text = "Phone Number";
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
            this.txtSuppID.TextChanged += new System.EventHandler(this.txtSuppID_TextChanged);
            // 
            // lblUpdStreet
            // 
            this.lblUpdStreet.AutoSize = true;
            this.lblUpdStreet.Location = new System.Drawing.Point(21, 171);
            this.lblUpdStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdStreet.Name = "lblUpdStreet";
            this.lblUpdStreet.Size = new System.Drawing.Size(35, 13);
            this.lblUpdStreet.TabIndex = 40;
            this.lblUpdStreet.Text = "Street";
            // 
            // txtUpdStreet
            // 
            this.txtUpdStreet.Location = new System.Drawing.Point(69, 171);
            this.txtUpdStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdStreet.Name = "txtUpdStreet";
            this.txtUpdStreet.Size = new System.Drawing.Size(147, 20);
            this.txtUpdStreet.TabIndex = 41;
            // 
            // lbluCounty
            // 
            this.lbluCounty.AutoSize = true;
            this.lbluCounty.Location = new System.Drawing.Point(18, 276);
            this.lbluCounty.Name = "lbluCounty";
            this.lbluCounty.Size = new System.Drawing.Size(40, 13);
            this.lbluCounty.TabIndex = 63;
            this.lbluCounty.Text = "County";
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
            // grpSupp
            // 
            this.grpSupp.Controls.Add(this.txtAccBal);
            this.grpSupp.Controls.Add(this.lblAccBal);
            this.grpSupp.Controls.Add(this.txtUpdCounties);
            this.grpSupp.Controls.Add(this.label1);
            this.grpSupp.Controls.Add(this.txtName);
            this.grpSupp.Controls.Add(this.btnUReg);
            this.grpSupp.Controls.Add(this.lblSuppID);
            this.grpSupp.Controls.Add(this.lbluCounty);
            this.grpSupp.Controls.Add(this.txtUpdStreet);
            this.grpSupp.Controls.Add(this.lblUpdPhoneNo);
            this.grpSupp.Controls.Add(this.lblUpdStreet);
            this.grpSupp.Controls.Add(this.txtUpdPhoneNo);
            this.grpSupp.Controls.Add(this.txtSuppID);
            this.grpSupp.Controls.Add(this.lblUpdEmail);
            this.grpSupp.Controls.Add(this.txtUpdEmail);
            this.grpSupp.Controls.Add(this.lblUpdTownVill);
            this.grpSupp.Controls.Add(this.txtUpdTownVillage);
            this.grpSupp.Location = new System.Drawing.Point(134, 66);
            this.grpSupp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSupp.Name = "grpSupp";
            this.grpSupp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSupp.Size = new System.Drawing.Size(351, 424);
            this.grpSupp.TabIndex = 65;
            this.grpSupp.TabStop = false;
            this.grpSupp.Text = "Please choose the Supplier for its details to be updated:";
            this.grpSupp.Visible = false;
            // 
            // txtAccBal
            // 
            this.txtAccBal.Location = new System.Drawing.Point(81, 329);
            this.txtAccBal.Name = "txtAccBal";
            this.txtAccBal.Size = new System.Drawing.Size(100, 20);
            this.txtAccBal.TabIndex = 69;
            // 
            // lblAccBal
            // 
            this.lblAccBal.AutoSize = true;
            this.lblAccBal.Location = new System.Drawing.Point(5, 332);
            this.lblAccBal.Name = "lblAccBal";
            this.lblAccBal.Size = new System.Drawing.Size(65, 13);
            this.lblAccBal.TabIndex = 68;
            this.lblAccBal.Text = "Account Bal";
            // 
            // txtUpdCounties
            // 
            this.txtUpdCounties.Location = new System.Drawing.Point(81, 273);
            this.txtUpdCounties.Name = "txtUpdCounties";
            this.txtUpdCounties.Size = new System.Drawing.Size(39, 20);
            this.txtUpdCounties.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 66;
            // 
            // btnUReg
            // 
            this.btnUReg.Location = new System.Drawing.Point(80, 391);
            this.btnUReg.Name = "btnUReg";
            this.btnUReg.Size = new System.Drawing.Size(135, 21);
            this.btnUReg.TabIndex = 64;
            this.btnUReg.Text = "Update";
            this.btnUReg.UseVisualStyleBackColor = true;
            this.btnUReg.Click += new System.EventHandler(this.btnUReg_Click_1);
            // 
            // cboUpdSuppliers
            // 
            this.cboUpdSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdSuppliers.FormattingEnabled = true;
            this.cboUpdSuppliers.Location = new System.Drawing.Point(134, 29);
            this.cboUpdSuppliers.Name = "cboUpdSuppliers";
            this.cboUpdSuppliers.Size = new System.Drawing.Size(227, 21);
            this.cboUpdSuppliers.TabIndex = 66;
            this.cboUpdSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboUpdSuppliers_SelectedIndexChanged_1);
            // 
            // lblUpdSuppName
            // 
            this.lblUpdSuppName.AutoSize = true;
            this.lblUpdSuppName.Location = new System.Drawing.Point(41, 33);
            this.lblUpdSuppName.Name = "lblUpdSuppName";
            this.lblUpdSuppName.Size = new System.Drawing.Size(78, 13);
            this.lblUpdSuppName.TabIndex = 67;
            this.lblUpdSuppName.Text = "Select Supplier";
            // 
            // frmUpdSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 509);
            this.Controls.Add(this.cboUpdSuppliers);
            this.Controls.Add(this.lblUpdSuppName);
            this.Controls.Add(this.grpSupp);
            this.Controls.Add(this.btnUExit);
            this.Controls.Add(this.mnuBack);
            this.MainMenuStrip = this.mnuBack;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpdSupp";
            this.Text = "Update Supplier Details";
            this.Load += new System.EventHandler(this.frmUpdSupp_Load);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.grpSupp.ResumeLayout(false);
            this.grpSupp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUExit;
        private System.Windows.Forms.TextBox txtUpdTownVillage;
        private System.Windows.Forms.Label lblUpdTownVill;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.Label lblUpdEmail;
        private System.Windows.Forms.TextBox txtUpdPhoneNo;
        private System.Windows.Forms.Label lblUpdPhoneNo;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.Label lblUpdStreet;
        private System.Windows.Forms.TextBox txtUpdStreet;
        private System.Windows.Forms.Label lbluCounty;
        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSupp;
        private System.Windows.Forms.Button btnUReg;
        private System.Windows.Forms.ComboBox cboUpdSuppliers;
        private System.Windows.Forms.Label lblUpdSuppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUpdCounties;
        private System.Windows.Forms.TextBox txtAccBal;
        private System.Windows.Forms.Label lblAccBal;
    }
}