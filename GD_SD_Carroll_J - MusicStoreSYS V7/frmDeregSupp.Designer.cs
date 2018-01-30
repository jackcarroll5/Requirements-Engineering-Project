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
            this.cboderegCounties = new System.Windows.Forms.ComboBox();
            this.grpDeselectSupp = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpDeselectSupp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeregSuppName
            // 
            this.lblDeregSuppName.AutoSize = true;
            this.lblDeregSuppName.Location = new System.Drawing.Point(28, 25);
            this.lblDeregSuppName.Name = "lblDeregSuppName";
            this.lblDeregSuppName.Size = new System.Drawing.Size(48, 13);
            this.lblDeregSuppName.TabIndex = 3;
            this.lblDeregSuppName.Text = " Supplier";
            // 
            // cboDeregSuppliers
            // 
            this.cboDeregSuppliers.FormattingEnabled = true;
            this.cboDeregSuppliers.Items.AddRange(new object[] {
            "Jack Jones",
            "Billy Kelly",
            "Frank Lally",
            "John Adams",
            "Francis Flowers",
            "Sarah Kelly",
            "Niamh Walsh"});
            this.cboDeregSuppliers.Location = new System.Drawing.Point(88, 25);
            this.cboDeregSuppliers.Name = "cboDeregSuppliers";
            this.cboDeregSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cboDeregSuppliers.TabIndex = 2;
            this.cboDeregSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboDeregSuppliers_SelectedIndexChanged);
            // 
            // lblDeregTownVill
            // 
            this.lblDeregTownVill.AutoSize = true;
            this.lblDeregTownVill.Location = new System.Drawing.Point(34, 248);
            this.lblDeregTownVill.Name = "lblDeregTownVill";
            this.lblDeregTownVill.Size = new System.Drawing.Size(70, 13);
            this.lblDeregTownVill.TabIndex = 18;
            this.lblDeregTownVill.Text = "Town/Village";
            // 
            // lblDeregEmail
            // 
            this.lblDeregEmail.AutoSize = true;
            this.lblDeregEmail.Location = new System.Drawing.Point(34, 190);
            this.lblDeregEmail.Name = "lblDeregEmail";
            this.lblDeregEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDeregEmail.TabIndex = 17;
            this.lblDeregEmail.Text = "Email";
            // 
            // lblDeregPhoneNo
            // 
            this.lblDeregPhoneNo.AutoSize = true;
            this.lblDeregPhoneNo.Location = new System.Drawing.Point(28, 143);
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
            this.btnExitDeregSupp.Size = new System.Drawing.Size(87, 28);
            this.btnExitDeregSupp.TabIndex = 20;
            this.btnExitDeregSupp.Text = "Exit";
            this.btnExitDeregSupp.UseVisualStyleBackColor = true;
            this.btnExitDeregSupp.Click += new System.EventHandler(this.btnExitDeregSupp_Click);
            // 
            // txtderegTownVillage
            // 
            this.txtderegTownVillage.Location = new System.Drawing.Point(115, 248);
            this.txtderegTownVillage.Name = "txtderegTownVillage";
            this.txtderegTownVillage.Size = new System.Drawing.Size(121, 20);
            this.txtderegTownVillage.TabIndex = 42;
            // 
            // txtderegEmail
            // 
            this.txtderegEmail.Location = new System.Drawing.Point(88, 190);
            this.txtderegEmail.Name = "txtderegEmail";
            this.txtderegEmail.Size = new System.Drawing.Size(182, 20);
            this.txtderegEmail.TabIndex = 40;
            // 
            // txtderegPhoneNo
            // 
            this.txtderegPhoneNo.Location = new System.Drawing.Point(115, 143);
            this.txtderegPhoneNo.Name = "txtderegPhoneNo";
            this.txtderegPhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtderegPhoneNo.TabIndex = 38;
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(97, 78);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(67, 20);
            this.txtSuppID.TabIndex = 45;
            this.txtSuppID.Text = "104";
            // 
            // lblDeregSuppID
            // 
            this.lblDeregSuppID.AutoSize = true;
            this.lblDeregSuppID.Location = new System.Drawing.Point(32, 82);
            this.lblDeregSuppID.Name = "lblDeregSuppID";
            this.lblDeregSuppID.Size = new System.Drawing.Size(46, 13);
            this.lblDeregSuppID.TabIndex = 44;
            this.lblDeregSuppID.Text = "Supp ID";
            // 
            // btnDereg
            // 
            this.btnDereg.Location = new System.Drawing.Point(114, 477);
            this.btnDereg.Name = "btnDereg";
            this.btnDereg.Size = new System.Drawing.Size(204, 70);
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
            this.lbldCounty.Location = new System.Drawing.Point(38, 302);
            this.lbldCounty.Name = "lbldCounty";
            this.lbldCounty.Size = new System.Drawing.Size(40, 13);
            this.lbldCounty.TabIndex = 65;
            this.lbldCounty.Text = "County";
            // 
            // cboderegCounties
            // 
            this.cboderegCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboderegCounties.FormattingEnabled = true;
            this.cboderegCounties.Items.AddRange(new object[] {
            "AH Armagh",
            "CK Cork",
            "DL Donegal",
            "KY Kerry",
            "MN Monaghan",
            "WW Wicklow"});
            this.cboderegCounties.Location = new System.Drawing.Point(115, 300);
            this.cboderegCounties.Name = "cboderegCounties";
            this.cboderegCounties.Size = new System.Drawing.Size(121, 21);
            this.cboderegCounties.TabIndex = 64;
            // 
            // grpDeselectSupp
            // 
            this.grpDeselectSupp.Controls.Add(this.lblDeregSuppName);
            this.grpDeselectSupp.Controls.Add(this.lbldCounty);
            this.grpDeselectSupp.Controls.Add(this.cboDeregSuppliers);
            this.grpDeselectSupp.Controls.Add(this.cboderegCounties);
            this.grpDeselectSupp.Controls.Add(this.lblDeregPhoneNo);
            this.grpDeselectSupp.Controls.Add(this.lblDeregEmail);
            this.grpDeselectSupp.Controls.Add(this.txtSuppID);
            this.grpDeselectSupp.Controls.Add(this.lblDeregTownVill);
            this.grpDeselectSupp.Controls.Add(this.lblDeregSuppID);
            this.grpDeselectSupp.Controls.Add(this.txtderegPhoneNo);
            this.grpDeselectSupp.Controls.Add(this.txtderegTownVillage);
            this.grpDeselectSupp.Controls.Add(this.txtderegEmail);
            this.grpDeselectSupp.Location = new System.Drawing.Point(26, 54);
            this.grpDeselectSupp.Name = "grpDeselectSupp";
            this.grpDeselectSupp.Size = new System.Drawing.Size(326, 397);
            this.grpDeselectSupp.TabIndex = 66;
            this.grpDeselectSupp.TabStop = false;
            this.grpDeselectSupp.Text = "Deselecting Supplier";
            // 
            // frmDeregSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 548);
            this.Controls.Add(this.grpDeselectSupp);
            this.Controls.Add(this.btnDereg);
            this.Controls.Add(this.btnExitDeregSupp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeregSupp";
            this.Text = "Deregister Supplier";
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
        private System.Windows.Forms.ComboBox cboderegCounties;
        private System.Windows.Forms.GroupBox grpDeselectSupp;
    }
}