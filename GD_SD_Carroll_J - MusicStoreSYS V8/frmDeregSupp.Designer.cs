namespace MusicStoreSYS
{
    partial class frmDeregSupp
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
            this.lblDeregSuppName = new System.Windows.Forms.Label();
            this.cboDeregSuppliers = new System.Windows.Forms.ComboBox();
            this.lblDeregTownVill = new System.Windows.Forms.Label();
            this.lblDeregEmail = new System.Windows.Forms.Label();
            this.lblDeregPhoneNo = new System.Windows.Forms.Label();
            this.btnExitDeregSupp = new System.Windows.Forms.Button();
            this.txtderegTownVillage = new System.Windows.Forms.TextBox();
            this.txtderegEmail = new System.Windows.Forms.TextBox();
            this.txtderegPhoneNo = new System.Windows.Forms.TextBox();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.lblDeregSuppID = new System.Windows.Forms.Label();
            this.btnDereg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldCounty = new System.Windows.Forms.Label();
            this.grpDeselectSupp = new System.Windows.Forms.GroupBox();
            this.txtDeregStreet = new System.Windows.Forms.TextBox();
            this.lblUpdStreet = new System.Windows.Forms.Label();
            this.txtDeregCounty = new System.Windows.Forms.TextBox();
            this.txtDeregName = new System.Windows.Forms.TextBox();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpDeselectSupp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeregSuppName
            // 
            this.lblDeregSuppName.AutoSize = true;
            this.lblDeregSuppName.Location = new System.Drawing.Point(63, 27);
            this.lblDeregSuppName.Name = "lblDeregSuppName";
            this.lblDeregSuppName.Size = new System.Drawing.Size(48, 13);
            this.lblDeregSuppName.TabIndex = 3;
            this.lblDeregSuppName.Text = " Supplier";
            // 
            // cboDeregSuppliers
            // 
            this.cboDeregSuppliers.FormattingEnabled = true;
            this.cboDeregSuppliers.Location = new System.Drawing.Point(123, 27);
            this.cboDeregSuppliers.Name = "cboDeregSuppliers";
            this.cboDeregSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cboDeregSuppliers.TabIndex = 2;
            this.cboDeregSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboDeregSuppliers_SelectedIndexChanged);
            // 
            // lblDeregTownVill
            // 
            this.lblDeregTownVill.AutoSize = true;
            this.lblDeregTownVill.Location = new System.Drawing.Point(11, 260);
            this.lblDeregTownVill.Name = "lblDeregTownVill";
            this.lblDeregTownVill.Size = new System.Drawing.Size(70, 13);
            this.lblDeregTownVill.TabIndex = 18;
            this.lblDeregTownVill.Text = "Town/Village";
            // 
            // lblDeregEmail
            // 
            this.lblDeregEmail.AutoSize = true;
            this.lblDeregEmail.Location = new System.Drawing.Point(11, 179);
            this.lblDeregEmail.Name = "lblDeregEmail";
            this.lblDeregEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDeregEmail.TabIndex = 17;
            this.lblDeregEmail.Text = "Email";
            // 
            // lblDeregPhoneNo
            // 
            this.lblDeregPhoneNo.AutoSize = true;
            this.lblDeregPhoneNo.Location = new System.Drawing.Point(5, 132);
            this.lblDeregPhoneNo.Name = "lblDeregPhoneNo";
            this.lblDeregPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.lblDeregPhoneNo.TabIndex = 16;
            this.lblDeregPhoneNo.Text = "Phone Number";
            // 
            // btnExitDeregSupp
            // 
            this.btnExitDeregSupp.Location = new System.Drawing.Point(385, 0);
            this.btnExitDeregSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitDeregSupp.Name = "btnExitDeregSupp";
            this.btnExitDeregSupp.Size = new System.Drawing.Size(87, 24);
            this.btnExitDeregSupp.TabIndex = 20;
            this.btnExitDeregSupp.Text = "Exit";
            this.btnExitDeregSupp.UseVisualStyleBackColor = true;
            this.btnExitDeregSupp.Click += new System.EventHandler(this.btnExitDeregSupp_Click);
            // 
            // txtderegTownVillage
            // 
            this.txtderegTownVillage.Location = new System.Drawing.Point(92, 260);
            this.txtderegTownVillage.Name = "txtderegTownVillage";
            this.txtderegTownVillage.Size = new System.Drawing.Size(121, 20);
            this.txtderegTownVillage.TabIndex = 42;
            // 
            // txtderegEmail
            // 
            this.txtderegEmail.Location = new System.Drawing.Point(65, 179);
            this.txtderegEmail.Name = "txtderegEmail";
            this.txtderegEmail.Size = new System.Drawing.Size(182, 20);
            this.txtderegEmail.TabIndex = 40;
            // 
            // txtderegPhoneNo
            // 
            this.txtderegPhoneNo.Location = new System.Drawing.Point(92, 132);
            this.txtderegPhoneNo.Name = "txtderegPhoneNo";
            this.txtderegPhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtderegPhoneNo.TabIndex = 38;
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(80, 23);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(67, 20);
            this.txtSuppID.TabIndex = 45;
            // 
            // lblDeregSuppID
            // 
            this.lblDeregSuppID.AutoSize = true;
            this.lblDeregSuppID.Location = new System.Drawing.Point(15, 27);
            this.lblDeregSuppID.Name = "lblDeregSuppID";
            this.lblDeregSuppID.Size = new System.Drawing.Size(46, 13);
            this.lblDeregSuppID.TabIndex = 44;
            this.lblDeregSuppID.Text = "Supp ID";
            // 
            // btnDereg
            // 
            this.btnDereg.Location = new System.Drawing.Point(39, 360);
            this.btnDereg.Name = "btnDereg";
            this.btnDereg.Size = new System.Drawing.Size(204, 42);
            this.btnDereg.TabIndex = 46;
            this.btnDereg.Text = "Deregister";
            this.btnDereg.UseVisualStyleBackColor = true;
            this.btnDereg.Click += new System.EventHandler(this.btnDereg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(44, 20);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // lbldCounty
            // 
            this.lbldCounty.AutoSize = true;
            this.lbldCounty.Location = new System.Drawing.Point(15, 314);
            this.lbldCounty.Name = "lbldCounty";
            this.lbldCounty.Size = new System.Drawing.Size(40, 13);
            this.lbldCounty.TabIndex = 65;
            this.lbldCounty.Text = "County";
            // 
            // grpDeselectSupp
            // 
            this.grpDeselectSupp.Controls.Add(this.txtDeregStreet);
            this.grpDeselectSupp.Controls.Add(this.lblUpdStreet);
            this.grpDeselectSupp.Controls.Add(this.txtDeregCounty);
            this.grpDeselectSupp.Controls.Add(this.txtDeregName);
            this.grpDeselectSupp.Controls.Add(this.btnDereg);
            this.grpDeselectSupp.Controls.Add(this.lblSuppName);
            this.grpDeselectSupp.Controls.Add(this.lbldCounty);
            this.grpDeselectSupp.Controls.Add(this.lblDeregPhoneNo);
            this.grpDeselectSupp.Controls.Add(this.lblDeregEmail);
            this.grpDeselectSupp.Controls.Add(this.txtSuppID);
            this.grpDeselectSupp.Controls.Add(this.lblDeregTownVill);
            this.grpDeselectSupp.Controls.Add(this.lblDeregSuppID);
            this.grpDeselectSupp.Controls.Add(this.txtderegPhoneNo);
            this.grpDeselectSupp.Controls.Add(this.txtderegTownVillage);
            this.grpDeselectSupp.Controls.Add(this.txtderegEmail);
            this.grpDeselectSupp.Location = new System.Drawing.Point(27, 74);
            this.grpDeselectSupp.Name = "grpDeselectSupp";
            this.grpDeselectSupp.Size = new System.Drawing.Size(326, 408);
            this.grpDeselectSupp.TabIndex = 66;
            this.grpDeselectSupp.TabStop = false;
            this.grpDeselectSupp.Text = "Deselecting Supplier";
            this.grpDeselectSupp.Visible = false;
            // 
            // txtDeregStreet
            // 
            this.txtDeregStreet.Location = new System.Drawing.Point(59, 220);
            this.txtDeregStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeregStreet.Name = "txtDeregStreet";
            this.txtDeregStreet.Size = new System.Drawing.Size(147, 20);
            this.txtDeregStreet.TabIndex = 70;
            // 
            // lblUpdStreet
            // 
            this.lblUpdStreet.AutoSize = true;
            this.lblUpdStreet.Location = new System.Drawing.Point(11, 220);
            this.lblUpdStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdStreet.Name = "lblUpdStreet";
            this.lblUpdStreet.Size = new System.Drawing.Size(35, 13);
            this.lblUpdStreet.TabIndex = 69;
            this.lblUpdStreet.Text = "Street";
            // 
            // txtDeregCounty
            // 
            this.txtDeregCounty.Location = new System.Drawing.Point(92, 311);
            this.txtDeregCounty.Name = "txtDeregCounty";
            this.txtDeregCounty.Size = new System.Drawing.Size(100, 20);
            this.txtDeregCounty.TabIndex = 68;
            // 
            // txtDeregName
            // 
            this.txtDeregName.Location = new System.Drawing.Point(95, 74);
            this.txtDeregName.Name = "txtDeregName";
            this.txtDeregName.Size = new System.Drawing.Size(136, 20);
            this.txtDeregName.TabIndex = 66;
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Location = new System.Drawing.Point(13, 77);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(35, 13);
            this.lblSuppName.TabIndex = 67;
            this.lblSuppName.Text = "Name";
            // 
            // frmDeregSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 505);
            this.Controls.Add(this.lblDeregSuppName);
            this.Controls.Add(this.grpDeselectSupp);
            this.Controls.Add(this.cboDeregSuppliers);
            this.Controls.Add(this.btnExitDeregSupp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeregSupp";
            this.Text = "Deregister Supplier";
            this.Load += new System.EventHandler(this.frmDeregSupp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDeselectSupp.ResumeLayout(false);
            this.grpDeselectSupp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeregSuppName;
        private System.Windows.Forms.ComboBox cboDeregSuppliers;
        private System.Windows.Forms.Label lblDeregTownVill;
        private System.Windows.Forms.Label lblDeregEmail;
        private System.Windows.Forms.Label lblDeregPhoneNo;
        private System.Windows.Forms.Button btnExitDeregSupp;
        private System.Windows.Forms.TextBox txtderegTownVillage;
        private System.Windows.Forms.TextBox txtderegEmail;
        private System.Windows.Forms.TextBox txtderegPhoneNo;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.Label lblDeregSuppID;
        private System.Windows.Forms.Button btnDereg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenu;
        private System.Windows.Forms.Label lbldCounty;
        private System.Windows.Forms.GroupBox grpDeselectSupp;
        private System.Windows.Forms.TextBox txtDeregName;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.TextBox txtDeregCounty;
        private System.Windows.Forms.TextBox txtDeregStreet;
        private System.Windows.Forms.Label lblUpdStreet;
    }
}