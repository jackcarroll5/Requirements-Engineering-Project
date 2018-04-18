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
            this.txtAccBal = new System.Windows.Forms.TextBox();
            this.lblAccBal = new System.Windows.Forms.Label();
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
            this.lblDeregSuppName.Location = new System.Drawing.Point(84, 33);
            this.lblDeregSuppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeregSuppName.Name = "lblDeregSuppName";
            this.lblDeregSuppName.Size = new System.Drawing.Size(64, 17);
            this.lblDeregSuppName.TabIndex = 3;
            this.lblDeregSuppName.Text = " Supplier";
            // 
            // cboDeregSuppliers
            // 
            this.cboDeregSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeregSuppliers.FormattingEnabled = true;
            this.cboDeregSuppliers.Location = new System.Drawing.Point(164, 33);
            this.cboDeregSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeregSuppliers.Name = "cboDeregSuppliers";
            this.cboDeregSuppliers.Size = new System.Drawing.Size(160, 24);
            this.cboDeregSuppliers.TabIndex = 2;
            this.cboDeregSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboDeregSuppliers_SelectedIndexChanged);
            // 
            // lblDeregTownVill
            // 
            this.lblDeregTownVill.AutoSize = true;
            this.lblDeregTownVill.Location = new System.Drawing.Point(15, 320);
            this.lblDeregTownVill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeregTownVill.Name = "lblDeregTownVill";
            this.lblDeregTownVill.Size = new System.Drawing.Size(88, 17);
            this.lblDeregTownVill.TabIndex = 18;
            this.lblDeregTownVill.Text = "Town/Village";
            // 
            // lblDeregEmail
            // 
            this.lblDeregEmail.AutoSize = true;
            this.lblDeregEmail.Location = new System.Drawing.Point(15, 220);
            this.lblDeregEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeregEmail.Name = "lblDeregEmail";
            this.lblDeregEmail.Size = new System.Drawing.Size(42, 17);
            this.lblDeregEmail.TabIndex = 17;
            this.lblDeregEmail.Text = "Email";
            // 
            // lblDeregPhoneNo
            // 
            this.lblDeregPhoneNo.AutoSize = true;
            this.lblDeregPhoneNo.Location = new System.Drawing.Point(7, 162);
            this.lblDeregPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeregPhoneNo.Name = "lblDeregPhoneNo";
            this.lblDeregPhoneNo.Size = new System.Drawing.Size(103, 17);
            this.lblDeregPhoneNo.TabIndex = 16;
            this.lblDeregPhoneNo.Text = "Phone Number";
            // 
            // btnExitDeregSupp
            // 
            this.btnExitDeregSupp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExitDeregSupp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitDeregSupp.Location = new System.Drawing.Point(513, 0);
            this.btnExitDeregSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExitDeregSupp.Name = "btnExitDeregSupp";
            this.btnExitDeregSupp.Size = new System.Drawing.Size(116, 30);
            this.btnExitDeregSupp.TabIndex = 20;
            this.btnExitDeregSupp.Text = "Exit";
            this.btnExitDeregSupp.UseVisualStyleBackColor = false;
            this.btnExitDeregSupp.Click += new System.EventHandler(this.btnExitDeregSupp_Click);
            // 
            // txtderegTownVillage
            // 
            this.txtderegTownVillage.Enabled = false;
            this.txtderegTownVillage.Location = new System.Drawing.Point(123, 320);
            this.txtderegTownVillage.Margin = new System.Windows.Forms.Padding(4);
            this.txtderegTownVillage.Name = "txtderegTownVillage";
            this.txtderegTownVillage.Size = new System.Drawing.Size(160, 22);
            this.txtderegTownVillage.TabIndex = 42;
            // 
            // txtderegEmail
            // 
            this.txtderegEmail.Enabled = false;
            this.txtderegEmail.Location = new System.Drawing.Point(87, 220);
            this.txtderegEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtderegEmail.Name = "txtderegEmail";
            this.txtderegEmail.Size = new System.Drawing.Size(241, 22);
            this.txtderegEmail.TabIndex = 40;
            // 
            // txtderegPhoneNo
            // 
            this.txtderegPhoneNo.Enabled = false;
            this.txtderegPhoneNo.Location = new System.Drawing.Point(123, 162);
            this.txtderegPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtderegPhoneNo.Name = "txtderegPhoneNo";
            this.txtderegPhoneNo.Size = new System.Drawing.Size(180, 22);
            this.txtderegPhoneNo.TabIndex = 38;
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(107, 28);
            this.txtSuppID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(88, 22);
            this.txtSuppID.TabIndex = 45;
            // 
            // lblDeregSuppID
            // 
            this.lblDeregSuppID.AutoSize = true;
            this.lblDeregSuppID.Location = new System.Drawing.Point(20, 33);
            this.lblDeregSuppID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeregSuppID.Name = "lblDeregSuppID";
            this.lblDeregSuppID.Size = new System.Drawing.Size(58, 17);
            this.lblDeregSuppID.TabIndex = 44;
            this.lblDeregSuppID.Text = "Supp ID";
            // 
            // btnDereg
            // 
            this.btnDereg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDereg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDereg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDereg.Location = new System.Drawing.Point(57, 517);
            this.btnDereg.Margin = new System.Windows.Forms.Padding(4);
            this.btnDereg.Name = "btnDereg";
            this.btnDereg.Size = new System.Drawing.Size(272, 52);
            this.btnDereg.TabIndex = 46;
            this.btnDereg.Text = "Deregister";
            this.btnDereg.UseVisualStyleBackColor = false;
            this.btnDereg.Click += new System.EventHandler(this.btnDereg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(629, 28);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(52, 24);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // lbldCounty
            // 
            this.lbldCounty.AutoSize = true;
            this.lbldCounty.Location = new System.Drawing.Point(20, 386);
            this.lbldCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldCounty.Name = "lbldCounty";
            this.lbldCounty.Size = new System.Drawing.Size(52, 17);
            this.lbldCounty.TabIndex = 65;
            this.lbldCounty.Text = "County";
            // 
            // grpDeselectSupp
            // 
            this.grpDeselectSupp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpDeselectSupp.Controls.Add(this.txtAccBal);
            this.grpDeselectSupp.Controls.Add(this.lblAccBal);
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
            this.grpDeselectSupp.Location = new System.Drawing.Point(36, 91);
            this.grpDeselectSupp.Margin = new System.Windows.Forms.Padding(4);
            this.grpDeselectSupp.Name = "grpDeselectSupp";
            this.grpDeselectSupp.Padding = new System.Windows.Forms.Padding(4);
            this.grpDeselectSupp.Size = new System.Drawing.Size(435, 576);
            this.grpDeselectSupp.TabIndex = 66;
            this.grpDeselectSupp.TabStop = false;
            this.grpDeselectSupp.Text = "Deselecting Supplier";
            this.grpDeselectSupp.Visible = false;
            // 
            // txtAccBal
            // 
            this.txtAccBal.Enabled = false;
            this.txtAccBal.Location = new System.Drawing.Point(133, 454);
            this.txtAccBal.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccBal.Name = "txtAccBal";
            this.txtAccBal.Size = new System.Drawing.Size(132, 22);
            this.txtAccBal.TabIndex = 72;
            this.txtAccBal.TextChanged += new System.EventHandler(this.txtAccBal_TextChanged);
            // 
            // lblAccBal
            // 
            this.lblAccBal.AutoSize = true;
            this.lblAccBal.Location = new System.Drawing.Point(7, 458);
            this.lblAccBal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccBal.Name = "lblAccBal";
            this.lblAccBal.Size = new System.Drawing.Size(114, 17);
            this.lblAccBal.TabIndex = 71;
            this.lblAccBal.Text = "Account Balance";
            // 
            // txtDeregStreet
            // 
            this.txtDeregStreet.Enabled = false;
            this.txtDeregStreet.Location = new System.Drawing.Point(79, 271);
            this.txtDeregStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeregStreet.Name = "txtDeregStreet";
            this.txtDeregStreet.Size = new System.Drawing.Size(195, 22);
            this.txtDeregStreet.TabIndex = 70;
            // 
            // lblUpdStreet
            // 
            this.lblUpdStreet.AutoSize = true;
            this.lblUpdStreet.Location = new System.Drawing.Point(15, 271);
            this.lblUpdStreet.Name = "lblUpdStreet";
            this.lblUpdStreet.Size = new System.Drawing.Size(46, 17);
            this.lblUpdStreet.TabIndex = 69;
            this.lblUpdStreet.Text = "Street";
            // 
            // txtDeregCounty
            // 
            this.txtDeregCounty.Enabled = false;
            this.txtDeregCounty.Location = new System.Drawing.Point(123, 383);
            this.txtDeregCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeregCounty.Name = "txtDeregCounty";
            this.txtDeregCounty.Size = new System.Drawing.Size(132, 22);
            this.txtDeregCounty.TabIndex = 68;
            // 
            // txtDeregName
            // 
            this.txtDeregName.Enabled = false;
            this.txtDeregName.Location = new System.Drawing.Point(127, 91);
            this.txtDeregName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeregName.Name = "txtDeregName";
            this.txtDeregName.Size = new System.Drawing.Size(180, 22);
            this.txtDeregName.TabIndex = 66;
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Location = new System.Drawing.Point(17, 95);
            this.lblSuppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(45, 17);
            this.lblSuppName.TabIndex = 67;
            this.lblSuppName.Text = "Name";
            // 
            // frmDeregSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 682);
            this.Controls.Add(this.lblDeregSuppName);
            this.Controls.Add(this.grpDeselectSupp);
            this.Controls.Add(this.cboDeregSuppliers);
            this.Controls.Add(this.btnExitDeregSupp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtAccBal;
        private System.Windows.Forms.Label lblAccBal;
    }
}