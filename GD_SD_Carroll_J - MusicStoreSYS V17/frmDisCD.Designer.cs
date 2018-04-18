namespace MusicStoreSYS
{
    partial class frmDisCD
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
            this.lblDeregYr = new System.Windows.Forms.Label();
            this.lblDeregArtist = new System.Windows.Forms.Label();
            this.lblDeregAlbum = new System.Windows.Forms.Label();
            this.lblSelCD = new System.Windows.Forms.Label();
            this.lblDeregArtistLabel = new System.Windows.Forms.Label();
            this.btnExitDiscontinueCD = new System.Windows.Forms.Button();
            this.txtDeregAlbum = new System.Windows.Forms.TextBox();
            this.txtDeregArtist = new System.Windows.Forms.TextBox();
            this.txtDisYr = new System.Windows.Forms.TextBox();
            this.txtDisArtLabel = new System.Windows.Forms.TextBox();
            this.txtDisCDID = new System.Windows.Forms.TextBox();
            this.lblDisCDID = new System.Windows.Forms.Label();
            this.btnDisCD = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.chkDisCD = new System.Windows.Forms.CheckedListBox();
            this.txtDisCostPrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtDisQty = new System.Windows.Forms.TextBox();
            this.lbluQty = new System.Windows.Forms.Label();
            this.grpDisCD = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpDisCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeregYr
            // 
            this.lblDeregYr.AutoSize = true;
            this.lblDeregYr.Location = new System.Drawing.Point(21, 236);
            this.lblDeregYr.Name = "lblDeregYr";
            this.lblDeregYr.Size = new System.Drawing.Size(106, 17);
            this.lblDeregYr.TabIndex = 21;
            this.lblDeregYr.Text = "Year Released:";
            // 
            // lblDeregArtist
            // 
            this.lblDeregArtist.AutoSize = true;
            this.lblDeregArtist.Location = new System.Drawing.Point(21, 172);
            this.lblDeregArtist.Name = "lblDeregArtist";
            this.lblDeregArtist.Size = new System.Drawing.Size(44, 17);
            this.lblDeregArtist.TabIndex = 20;
            this.lblDeregArtist.Text = "Artist:";
            // 
            // lblDeregAlbum
            // 
            this.lblDeregAlbum.AutoSize = true;
            this.lblDeregAlbum.Location = new System.Drawing.Point(21, 108);
            this.lblDeregAlbum.Name = "lblDeregAlbum";
            this.lblDeregAlbum.Size = new System.Drawing.Size(51, 17);
            this.lblDeregAlbum.TabIndex = 19;
            this.lblDeregAlbum.Text = "Album:";
            // 
            // lblSelCD
            // 
            this.lblSelCD.AutoSize = true;
            this.lblSelCD.Location = new System.Drawing.Point(48, 86);
            this.lblSelCD.Name = "lblSelCD";
            this.lblSelCD.Size = new System.Drawing.Size(169, 17);
            this.lblSelCD.TabIndex = 23;
            this.lblSelCD.Text = "Select CDs to discontinue";
            // 
            // lblDeregArtistLabel
            // 
            this.lblDeregArtistLabel.AutoSize = true;
            this.lblDeregArtistLabel.Location = new System.Drawing.Point(20, 305);
            this.lblDeregArtistLabel.Name = "lblDeregArtistLabel";
            this.lblDeregArtistLabel.Size = new System.Drawing.Size(79, 17);
            this.lblDeregArtistLabel.TabIndex = 24;
            this.lblDeregArtistLabel.Text = "Artist Label";
            // 
            // btnExitDiscontinueCD
            // 
            this.btnExitDiscontinueCD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitDiscontinueCD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExitDiscontinueCD.Location = new System.Drawing.Point(651, 0);
            this.btnExitDiscontinueCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExitDiscontinueCD.Name = "btnExitDiscontinueCD";
            this.btnExitDiscontinueCD.Size = new System.Drawing.Size(149, 28);
            this.btnExitDiscontinueCD.TabIndex = 25;
            this.btnExitDiscontinueCD.Text = "Exit";
            this.btnExitDiscontinueCD.UseVisualStyleBackColor = false;
            this.btnExitDiscontinueCD.Click += new System.EventHandler(this.btnExitDiscontinueCD_Click);
            // 
            // txtDeregAlbum
            // 
            this.txtDeregAlbum.Enabled = false;
            this.txtDeregAlbum.Location = new System.Drawing.Point(111, 103);
            this.txtDeregAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeregAlbum.Name = "txtDeregAlbum";
            this.txtDeregAlbum.Size = new System.Drawing.Size(225, 22);
            this.txtDeregAlbum.TabIndex = 27;
            // 
            // txtDeregArtist
            // 
            this.txtDeregArtist.Enabled = false;
            this.txtDeregArtist.Location = new System.Drawing.Point(111, 172);
            this.txtDeregArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeregArtist.Name = "txtDeregArtist";
            this.txtDeregArtist.Size = new System.Drawing.Size(225, 22);
            this.txtDeregArtist.TabIndex = 26;
            // 
            // txtDisYr
            // 
            this.txtDisYr.Enabled = false;
            this.txtDisYr.Location = new System.Drawing.Point(133, 233);
            this.txtDisYr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisYr.Name = "txtDisYr";
            this.txtDisYr.Size = new System.Drawing.Size(65, 22);
            this.txtDisYr.TabIndex = 29;
            // 
            // txtDisArtLabel
            // 
            this.txtDisArtLabel.Enabled = false;
            this.txtDisArtLabel.Location = new System.Drawing.Point(111, 300);
            this.txtDisArtLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisArtLabel.Name = "txtDisArtLabel";
            this.txtDisArtLabel.Size = new System.Drawing.Size(181, 22);
            this.txtDisArtLabel.TabIndex = 28;
            // 
            // txtDisCDID
            // 
            this.txtDisCDID.Enabled = false;
            this.txtDisCDID.Location = new System.Drawing.Point(97, 23);
            this.txtDisCDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDisCDID.Name = "txtDisCDID";
            this.txtDisCDID.Size = new System.Drawing.Size(119, 22);
            this.txtDisCDID.TabIndex = 31;
            // 
            // lblDisCDID
            // 
            this.lblDisCDID.AutoSize = true;
            this.lblDisCDID.Location = new System.Drawing.Point(17, 27);
            this.lblDisCDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisCDID.Name = "lblDisCDID";
            this.lblDisCDID.Size = new System.Drawing.Size(44, 17);
            this.lblDisCDID.TabIndex = 30;
            this.lblDisCDID.Text = "CD ID";
            // 
            // btnDisCD
            // 
            this.btnDisCD.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDisCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisCD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDisCD.Location = new System.Drawing.Point(124, 562);
            this.btnDisCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisCD.Name = "btnDisCD";
            this.btnDisCD.Size = new System.Drawing.Size(272, 86);
            this.btnDisCD.TabIndex = 47;
            this.btnDisCD.Text = "Discontinue";
            this.btnDisCD.UseVisualStyleBackColor = false;
            this.btnDisCD.Click += new System.EventHandler(this.btnDisCD_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMnu
            // 
            this.backMnu.Name = "backMnu";
            this.backMnu.Size = new System.Drawing.Size(52, 24);
            this.backMnu.Text = "Back";
            this.backMnu.Click += new System.EventHandler(this.backMnu_Click);
            // 
            // chkDisCD
            // 
            this.chkDisCD.BackColor = System.Drawing.SystemColors.Window;
            this.chkDisCD.CheckOnClick = true;
            this.chkDisCD.FormattingEnabled = true;
            this.chkDisCD.Location = new System.Drawing.Point(248, 63);
            this.chkDisCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDisCD.Name = "chkDisCD";
            this.chkDisCD.Size = new System.Drawing.Size(251, 89);
            this.chkDisCD.TabIndex = 49;
            this.chkDisCD.SelectedIndexChanged += new System.EventHandler(this.chkDisCD_SelectedIndexChanged);
            // 
            // txtDisCostPrice
            // 
            this.txtDisCostPrice.Enabled = false;
            this.txtDisCostPrice.Location = new System.Drawing.Point(111, 386);
            this.txtDisCostPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisCostPrice.Name = "txtDisCostPrice";
            this.txtDisCostPrice.Size = new System.Drawing.Size(205, 22);
            this.txtDisCostPrice.TabIndex = 53;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(21, 386);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(76, 17);
            this.lblCostPrice.TabIndex = 52;
            this.lblCostPrice.Text = "Cost Price:";
            // 
            // txtDisQty
            // 
            this.txtDisQty.Enabled = false;
            this.txtDisQty.Location = new System.Drawing.Point(91, 490);
            this.txtDisQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisQty.Name = "txtDisQty";
            this.txtDisQty.Size = new System.Drawing.Size(225, 22);
            this.txtDisQty.TabIndex = 51;
            // 
            // lbluQty
            // 
            this.lbluQty.AutoSize = true;
            this.lbluQty.Location = new System.Drawing.Point(28, 490);
            this.lbluQty.Name = "lbluQty";
            this.lbluQty.Size = new System.Drawing.Size(56, 17);
            this.lbluQty.TabIndex = 50;
            this.lbluQty.Text = "Quality:";
            // 
            // grpDisCD
            // 
            this.grpDisCD.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpDisCD.Controls.Add(this.txtDisCDID);
            this.grpDisCD.Controls.Add(this.txtDisCostPrice);
            this.grpDisCD.Controls.Add(this.lblDeregAlbum);
            this.grpDisCD.Controls.Add(this.lblCostPrice);
            this.grpDisCD.Controls.Add(this.lblDeregArtist);
            this.grpDisCD.Controls.Add(this.txtDisQty);
            this.grpDisCD.Controls.Add(this.lblDeregYr);
            this.grpDisCD.Controls.Add(this.lbluQty);
            this.grpDisCD.Controls.Add(this.lblDeregArtistLabel);
            this.grpDisCD.Controls.Add(this.txtDeregArtist);
            this.grpDisCD.Controls.Add(this.btnDisCD);
            this.grpDisCD.Controls.Add(this.txtDeregAlbum);
            this.grpDisCD.Controls.Add(this.txtDisArtLabel);
            this.grpDisCD.Controls.Add(this.lblDisCDID);
            this.grpDisCD.Controls.Add(this.txtDisYr);
            this.grpDisCD.Location = new System.Drawing.Point(80, 208);
            this.grpDisCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDisCD.Name = "grpDisCD";
            this.grpDisCD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDisCD.Size = new System.Drawing.Size(535, 656);
            this.grpDisCD.TabIndex = 54;
            this.grpDisCD.TabStop = false;
            this.grpDisCD.Text = "CD Details";
            this.grpDisCD.Visible = false;
            // 
            // frmDisCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 940);
            this.Controls.Add(this.grpDisCD);
            this.Controls.Add(this.chkDisCD);
            this.Controls.Add(this.btnExitDiscontinueCD);
            this.Controls.Add(this.lblSelCD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDisCD";
            this.Text = "Discontinue CDs";
            this.Load += new System.EventHandler(this.frmDisCD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDisCD.ResumeLayout(false);
            this.grpDisCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeregYr;
        private System.Windows.Forms.Label lblDeregArtist;
        private System.Windows.Forms.Label lblDeregAlbum;
        private System.Windows.Forms.Label lblSelCD;
        private System.Windows.Forms.Label lblDeregArtistLabel;
        private System.Windows.Forms.Button btnExitDiscontinueCD;
        private System.Windows.Forms.TextBox txtDeregAlbum;
        private System.Windows.Forms.TextBox txtDeregArtist;
        private System.Windows.Forms.TextBox txtDisYr;
        private System.Windows.Forms.TextBox txtDisArtLabel;
        private System.Windows.Forms.TextBox txtDisCDID;
        private System.Windows.Forms.Label lblDisCDID;
        private System.Windows.Forms.Button btnDisCD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMnu;
        private System.Windows.Forms.CheckedListBox chkDisCD;
        private System.Windows.Forms.TextBox txtDisCostPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.TextBox txtDisQty;
        private System.Windows.Forms.Label lbluQty;
        private System.Windows.Forms.GroupBox grpDisCD;
    }
}