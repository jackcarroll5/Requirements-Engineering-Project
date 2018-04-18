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
            this.lblSupp = new System.Windows.Forms.Label();
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.txtUCostPrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtuQty = new System.Windows.Forms.TextBox();
            this.lbluQty = new System.Windows.Forms.Label();
            this.txtUArtistLbl = new System.Windows.Forms.TextBox();
            this.lbluArtistLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpUCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUExitA
            // 
            this.btnUExitA.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUExitA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUExitA.Location = new System.Drawing.Point(557, 0);
            this.btnUExitA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUExitA.Name = "btnUExitA";
            this.btnUExitA.Size = new System.Drawing.Size(116, 30);
            this.btnUExitA.TabIndex = 25;
            this.btnUExitA.Text = "Exit";
            this.btnUExitA.UseVisualStyleBackColor = false;
            this.btnUExitA.Click += new System.EventHandler(this.btnUExitA_Click);
            // 
            // txtUAlbum
            // 
            this.txtUAlbum.Location = new System.Drawing.Point(115, 107);
            this.txtUAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUAlbum.Name = "txtUAlbum";
            this.txtUAlbum.Size = new System.Drawing.Size(225, 22);
            this.txtUAlbum.TabIndex = 22;
            // 
            // txtUArtist
            // 
            this.txtUArtist.Location = new System.Drawing.Point(115, 177);
            this.txtUArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUArtist.Name = "txtUArtist";
            this.txtUArtist.Size = new System.Drawing.Size(225, 22);
            this.txtUArtist.TabIndex = 21;
            // 
            // btnUInsert
            // 
            this.btnUInsert.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnUInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUInsert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUInsert.Location = new System.Drawing.Point(115, 703);
            this.btnUInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUInsert.Name = "btnUInsert";
            this.btnUInsert.Size = new System.Drawing.Size(137, 34);
            this.btnUInsert.TabIndex = 19;
            this.btnUInsert.Text = "Update";
            this.btnUInsert.UseVisualStyleBackColor = false;
            this.btnUInsert.Click += new System.EventHandler(this.btnUInsert_Click);
            // 
            // lblUYr
            // 
            this.lblUYr.AutoSize = true;
            this.lblUYr.Location = new System.Drawing.Point(23, 262);
            this.lblUYr.Name = "lblUYr";
            this.lblUYr.Size = new System.Drawing.Size(106, 17);
            this.lblUYr.TabIndex = 18;
            this.lblUYr.Text = "Year Released:";
            // 
            // lblUArtist
            // 
            this.lblUArtist.AutoSize = true;
            this.lblUArtist.Location = new System.Drawing.Point(23, 177);
            this.lblUArtist.Name = "lblUArtist";
            this.lblUArtist.Size = new System.Drawing.Size(44, 17);
            this.lblUArtist.TabIndex = 17;
            this.lblUArtist.Text = "Artist:";
            // 
            // lblUAlbum
            // 
            this.lblUAlbum.AutoSize = true;
            this.lblUAlbum.Location = new System.Drawing.Point(23, 111);
            this.lblUAlbum.Name = "lblUAlbum";
            this.lblUAlbum.Size = new System.Drawing.Size(51, 17);
            this.lblUAlbum.TabIndex = 16;
            this.lblUAlbum.Text = "Album:";
            // 
            // lblOrderCDID
            // 
            this.lblOrderCDID.AutoSize = true;
            this.lblOrderCDID.Location = new System.Drawing.Point(23, 49);
            this.lblOrderCDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderCDID.Name = "lblOrderCDID";
            this.lblOrderCDID.Size = new System.Drawing.Size(44, 17);
            this.lblOrderCDID.TabIndex = 26;
            this.lblOrderCDID.Text = "CD ID";
            // 
            // txtCDID
            // 
            this.txtCDID.Enabled = false;
            this.txtCDID.Location = new System.Drawing.Point(84, 49);
            this.txtCDID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCDID.Name = "txtCDID";
            this.txtCDID.Size = new System.Drawing.Size(80, 22);
            this.txtCDID.TabIndex = 27;
            // 
            // cboupdCD
            // 
            this.cboupdCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboupdCD.FormattingEnabled = true;
            this.cboupdCD.Location = new System.Drawing.Point(220, 57);
            this.cboupdCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboupdCD.Name = "cboupdCD";
            this.cboupdCD.Size = new System.Drawing.Size(155, 24);
            this.cboupdCD.TabIndex = 28;
            this.cboupdCD.SelectedIndexChanged += new System.EventHandler(this.cboupdCD_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(671, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(52, 24);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "CD:";
            // 
            // grpUCD
            // 
            this.grpUCD.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.grpUCD.Location = new System.Drawing.Point(136, 113);
            this.grpUCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUCD.Name = "grpUCD";
            this.grpUCD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUCD.Size = new System.Drawing.Size(368, 753);
            this.grpUCD.TabIndex = 32;
            this.grpUCD.TabStop = false;
            this.grpUCD.Text = "Update CD Details";
            this.grpUCD.Visible = false;
            // 
            // lblSupp
            // 
            this.lblSupp.AutoSize = true;
            this.lblSupp.Location = new System.Drawing.Point(23, 601);
            this.lblSupp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupp.Name = "lblSupp";
            this.lblSupp.Size = new System.Drawing.Size(60, 17);
            this.lblSupp.TabIndex = 68;
            this.lblSupp.Text = "Supplier";
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Location = new System.Drawing.Point(125, 597);
            this.cboSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(160, 24);
            this.cboSuppliers.TabIndex = 67;
            // 
            // txtYr
            // 
            this.txtYr.Location = new System.Drawing.Point(135, 258);
            this.txtYr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYr.Name = "txtYr";
            this.txtYr.Size = new System.Drawing.Size(205, 22);
            this.txtYr.TabIndex = 41;
            // 
            // txtUCostPrice
            // 
            this.txtUCostPrice.Location = new System.Drawing.Point(105, 404);
            this.txtUCostPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUCostPrice.Name = "txtUCostPrice";
            this.txtUCostPrice.Size = new System.Drawing.Size(205, 22);
            this.txtUCostPrice.TabIndex = 39;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(16, 404);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(76, 17);
            this.lblCostPrice.TabIndex = 38;
            this.lblCostPrice.Text = "Cost Price:";
            // 
            // txtuQty
            // 
            this.txtuQty.Location = new System.Drawing.Point(85, 507);
            this.txtuQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuQty.Name = "txtuQty";
            this.txtuQty.Size = new System.Drawing.Size(225, 22);
            this.txtuQty.TabIndex = 37;
            // 
            // lbluQty
            // 
            this.lbluQty.AutoSize = true;
            this.lbluQty.Location = new System.Drawing.Point(23, 507);
            this.lbluQty.Name = "lbluQty";
            this.lbluQty.Size = new System.Drawing.Size(56, 17);
            this.lbluQty.TabIndex = 36;
            this.lbluQty.Text = "Quality:";
            // 
            // txtUArtistLbl
            // 
            this.txtUArtistLbl.Location = new System.Drawing.Point(115, 321);
            this.txtUArtistLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUArtistLbl.Name = "txtUArtistLbl";
            this.txtUArtistLbl.Size = new System.Drawing.Size(205, 22);
            this.txtUArtistLbl.TabIndex = 35;
            // 
            // lbluArtistLbl
            // 
            this.lbluArtistLbl.AutoSize = true;
            this.lbluArtistLbl.Location = new System.Drawing.Point(23, 321);
            this.lbluArtistLbl.Name = "lbluArtistLbl";
            this.lbluArtistLbl.Size = new System.Drawing.Size(83, 17);
            this.lbluArtistLbl.TabIndex = 34;
            this.lbluArtistLbl.Text = "Artist Label:";
            // 
            // frmUpdCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 930);
            this.Controls.Add(this.grpUCD);
            this.Controls.Add(this.btnUExitA);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cboupdCD);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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