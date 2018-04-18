namespace MusicStoreSYS
{
    partial class frmUpdCD
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
            this.btnUExitA = new System.Windows.Forms.Button();
            this.txtUAlbum = new System.Windows.Forms.TextBox();
            this.txtUArtist = new System.Windows.Forms.TextBox();
            this.btnUInsert = new System.Windows.Forms.Button();
            this.lblUYr = new System.Windows.Forms.Label();
            this.lblUArtist = new System.Windows.Forms.Label();
            this.lblUAlbum = new System.Windows.Forms.Label();
            this.lblOrderCDID = new System.Windows.Forms.Label();
            this.txtCDID = new System.Windows.Forms.TextBox();
            this.cboupdCD = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUCD = new System.Windows.Forms.GroupBox();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.txtUCostPrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtuQty = new System.Windows.Forms.TextBox();
            this.lbluQty = new System.Windows.Forms.Label();
            this.txtUArtistLbl = new System.Windows.Forms.TextBox();
            this.lbluArtistLbl = new System.Windows.Forms.Label();
            this.lblSupp = new System.Windows.Forms.Label();
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpUCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUExitA
            // 
            this.btnUExitA.Location = new System.Drawing.Point(418, 0);
            this.btnUExitA.Margin = new System.Windows.Forms.Padding(2);
            this.btnUExitA.Name = "btnUExitA";
            this.btnUExitA.Size = new System.Drawing.Size(87, 24);
            this.btnUExitA.TabIndex = 25;
            this.btnUExitA.Text = "Exit";
            this.btnUExitA.UseVisualStyleBackColor = true;
            this.btnUExitA.Click += new System.EventHandler(this.btnUExitA_Click);
            // 
            // txtUAlbum
            // 
            this.txtUAlbum.Location = new System.Drawing.Point(86, 87);
            this.txtUAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.txtUAlbum.Name = "txtUAlbum";
            this.txtUAlbum.Size = new System.Drawing.Size(170, 20);
            this.txtUAlbum.TabIndex = 22;
            // 
            // txtUArtist
            // 
            this.txtUArtist.Location = new System.Drawing.Point(86, 144);
            this.txtUArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtUArtist.Name = "txtUArtist";
            this.txtUArtist.Size = new System.Drawing.Size(170, 20);
            this.txtUArtist.TabIndex = 21;
            // 
            // btnUInsert
            // 
            this.btnUInsert.Location = new System.Drawing.Point(86, 571);
            this.btnUInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnUInsert.Name = "btnUInsert";
            this.btnUInsert.Size = new System.Drawing.Size(103, 28);
            this.btnUInsert.TabIndex = 19;
            this.btnUInsert.Text = "Update";
            this.btnUInsert.UseVisualStyleBackColor = true;
            this.btnUInsert.Click += new System.EventHandler(this.btnUInsert_Click);
            // 
            // lblUYr
            // 
            this.lblUYr.AutoSize = true;
            this.lblUYr.Location = new System.Drawing.Point(17, 213);
            this.lblUYr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUYr.Name = "lblUYr";
            this.lblUYr.Size = new System.Drawing.Size(80, 13);
            this.lblUYr.TabIndex = 18;
            this.lblUYr.Text = "Year Released:";
            // 
            // lblUArtist
            // 
            this.lblUArtist.AutoSize = true;
            this.lblUArtist.Location = new System.Drawing.Point(17, 144);
            this.lblUArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUArtist.Name = "lblUArtist";
            this.lblUArtist.Size = new System.Drawing.Size(33, 13);
            this.lblUArtist.TabIndex = 17;
            this.lblUArtist.Text = "Artist:";
            // 
            // lblUAlbum
            // 
            this.lblUAlbum.AutoSize = true;
            this.lblUAlbum.Location = new System.Drawing.Point(17, 90);
            this.lblUAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUAlbum.Name = "lblUAlbum";
            this.lblUAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblUAlbum.TabIndex = 16;
            this.lblUAlbum.Text = "Album:";
            // 
            // lblOrderCDID
            // 
            this.lblOrderCDID.AutoSize = true;
            this.lblOrderCDID.Location = new System.Drawing.Point(17, 40);
            this.lblOrderCDID.Name = "lblOrderCDID";
            this.lblOrderCDID.Size = new System.Drawing.Size(36, 13);
            this.lblOrderCDID.TabIndex = 26;
            this.lblOrderCDID.Text = "CD ID";
            // 
            // txtCDID
            // 
            this.txtCDID.Enabled = false;
            this.txtCDID.Location = new System.Drawing.Point(63, 40);
            this.txtCDID.Name = "txtCDID";
            this.txtCDID.Size = new System.Drawing.Size(61, 20);
            this.txtCDID.TabIndex = 27;
            // 
            // cboupdCD
            // 
            this.cboupdCD.FormattingEnabled = true;
            this.cboupdCD.Location = new System.Drawing.Point(165, 46);
            this.cboupdCD.Margin = new System.Windows.Forms.Padding(2);
            this.cboupdCD.Name = "cboupdCD";
            this.cboupdCD.Size = new System.Drawing.Size(117, 21);
            this.cboupdCD.TabIndex = 28;
            this.cboupdCD.SelectedIndexChanged += new System.EventHandler(this.cboupdCD_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(44, 20);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "CD";
            // 
            // grpUCD
            // 
            this.grpUCD.Controls.Add(this.lblSupp);
            this.grpUCD.Controls.Add(this.cboSuppliers);
            this.grpUCD.Controls.Add(this.txtYr);
            this.grpUCD.Controls.Add(this.txtUCostPrice);
            this.grpUCD.Controls.Add(this.lblCostPrice);
            this.grpUCD.Controls.Add(this.txtuQty);
            this.grpUCD.Controls.Add(this.lbluQty);
            this.grpUCD.Controls.Add(this.btnUInsert);
            this.grpUCD.Controls.Add(this.txtUArtistLbl);
            this.grpUCD.Controls.Add(this.lbluArtistLbl);
            this.grpUCD.Controls.Add(this.lblOrderCDID);
            this.grpUCD.Controls.Add(this.txtUArtist);
            this.grpUCD.Controls.Add(this.txtUAlbum);
            this.grpUCD.Controls.Add(this.lblUYr);
            this.grpUCD.Controls.Add(this.txtCDID);
            this.grpUCD.Controls.Add(this.lblUAlbum);
            this.grpUCD.Controls.Add(this.lblUArtist);
            this.grpUCD.Location = new System.Drawing.Point(102, 92);
            this.grpUCD.Margin = new System.Windows.Forms.Padding(2);
            this.grpUCD.Name = "grpUCD";
            this.grpUCD.Padding = new System.Windows.Forms.Padding(2);
            this.grpUCD.Size = new System.Drawing.Size(276, 612);
            this.grpUCD.TabIndex = 32;
            this.grpUCD.TabStop = false;
            this.grpUCD.Text = "Update CD Details";
            this.grpUCD.Visible = false;
            // 
            // txtYr
            // 
            this.txtYr.Location = new System.Drawing.Point(101, 210);
            this.txtYr.Margin = new System.Windows.Forms.Padding(2);
            this.txtYr.Name = "txtYr";
            this.txtYr.Size = new System.Drawing.Size(155, 20);
            this.txtYr.TabIndex = 41;
            // 
            // txtUCostPrice
            // 
            this.txtUCostPrice.Location = new System.Drawing.Point(79, 328);
            this.txtUCostPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUCostPrice.Name = "txtUCostPrice";
            this.txtUCostPrice.Size = new System.Drawing.Size(155, 20);
            this.txtUCostPrice.TabIndex = 39;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(12, 328);
            this.lblCostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(58, 13);
            this.lblCostPrice.TabIndex = 38;
            this.lblCostPrice.Text = "Cost Price:";
            // 
            // txtuQty
            // 
            this.txtuQty.Location = new System.Drawing.Point(64, 412);
            this.txtuQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtuQty.Name = "txtuQty";
            this.txtuQty.Size = new System.Drawing.Size(170, 20);
            this.txtuQty.TabIndex = 37;
            // 
            // lbluQty
            // 
            this.lbluQty.AutoSize = true;
            this.lbluQty.Location = new System.Drawing.Point(17, 412);
            this.lbluQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluQty.Name = "lbluQty";
            this.lbluQty.Size = new System.Drawing.Size(42, 13);
            this.lbluQty.TabIndex = 36;
            this.lbluQty.Text = "Quality:";
            // 
            // txtUArtistLbl
            // 
            this.txtUArtistLbl.Location = new System.Drawing.Point(86, 261);
            this.txtUArtistLbl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUArtistLbl.Name = "txtUArtistLbl";
            this.txtUArtistLbl.Size = new System.Drawing.Size(155, 20);
            this.txtUArtistLbl.TabIndex = 35;
            // 
            // lbluArtistLbl
            // 
            this.lbluArtistLbl.AutoSize = true;
            this.lbluArtistLbl.Location = new System.Drawing.Point(17, 261);
            this.lbluArtistLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluArtistLbl.Name = "lbluArtistLbl";
            this.lbluArtistLbl.Size = new System.Drawing.Size(62, 13);
            this.lbluArtistLbl.TabIndex = 34;
            this.lbluArtistLbl.Text = "Artist Label:";
            // 
            // lblSupp
            // 
            this.lblSupp.AutoSize = true;
            this.lblSupp.Location = new System.Drawing.Point(17, 488);
            this.lblSupp.Name = "lblSupp";
            this.lblSupp.Size = new System.Drawing.Size(45, 13);
            this.lblSupp.TabIndex = 68;
            this.lblSupp.Text = "Supplier";
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Location = new System.Drawing.Point(94, 485);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cboSuppliers.TabIndex = 67;
            // 
            // frmUpdCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 756);
            this.Controls.Add(this.grpUCD);
            this.Controls.Add(this.btnUExitA);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cboupdCD);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdCD";
            this.Text = "Update CD";
            this.Load += new System.EventHandler(this.frmUpdCD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUCD.ResumeLayout(false);
            this.grpUCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUExitA;
        private System.Windows.Forms.TextBox txtUAlbum;
        private System.Windows.Forms.TextBox txtUArtist;
        private System.Windows.Forms.Button btnUInsert;
        private System.Windows.Forms.Label lblUYr;
        private System.Windows.Forms.Label lblUArtist;
        private System.Windows.Forms.Label lblUAlbum;
        private System.Windows.Forms.Label lblOrderCDID;
        private System.Windows.Forms.TextBox txtCDID;
        private System.Windows.Forms.ComboBox cboupdCD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUCD;
        private System.Windows.Forms.TextBox txtuQty;
        private System.Windows.Forms.Label lbluQty;
        private System.Windows.Forms.TextBox txtUArtistLbl;
        private System.Windows.Forms.Label lbluArtistLbl;
        private System.Windows.Forms.TextBox txtYr;
        private System.Windows.Forms.TextBox txtUCostPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblSupp;
        private System.Windows.Forms.ComboBox cboSuppliers;
    }
}