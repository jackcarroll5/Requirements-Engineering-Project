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
            this.grpUArtistLbl = new System.Windows.Forms.GroupBox();
            this.radUPolydor = new System.Windows.Forms.RadioButton();
            this.radUSony = new System.Windows.Forms.RadioButton();
            this.radUWBros = new System.Windows.Forms.RadioButton();
            this.radUUniversal = new System.Windows.Forms.RadioButton();
            this.txtUAlbum = new System.Windows.Forms.TextBox();
            this.txtUArtist = new System.Windows.Forms.TextBox();
            this.chkUYr = new System.Windows.Forms.CheckedListBox();
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
            this.txtuQty = new System.Windows.Forms.TextBox();
            this.lbluQty = new System.Windows.Forms.Label();
            this.txtuCost = new System.Windows.Forms.TextBox();
            this.lbluCost = new System.Windows.Forms.Label();
            this.grpUArtistLbl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpUCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUExitA
            // 
            this.btnUExitA.Location = new System.Drawing.Point(589, 24);
            this.btnUExitA.Margin = new System.Windows.Forms.Padding(2);
            this.btnUExitA.Name = "btnUExitA";
            this.btnUExitA.Size = new System.Drawing.Size(87, 35);
            this.btnUExitA.TabIndex = 25;
            this.btnUExitA.Text = "Exit";
            this.btnUExitA.UseVisualStyleBackColor = true;
            this.btnUExitA.Click += new System.EventHandler(this.btnUExitA_Click);
            // 
            // grpUArtistLbl
            // 
            this.grpUArtistLbl.Controls.Add(this.radUPolydor);
            this.grpUArtistLbl.Controls.Add(this.radUSony);
            this.grpUArtistLbl.Controls.Add(this.radUWBros);
            this.grpUArtistLbl.Controls.Add(this.radUUniversal);
            this.grpUArtistLbl.Location = new System.Drawing.Point(11, 349);
            this.grpUArtistLbl.Margin = new System.Windows.Forms.Padding(2);
            this.grpUArtistLbl.Name = "grpUArtistLbl";
            this.grpUArtistLbl.Padding = new System.Windows.Forms.Padding(2);
            this.grpUArtistLbl.Size = new System.Drawing.Size(150, 99);
            this.grpUArtistLbl.TabIndex = 23;
            this.grpUArtistLbl.TabStop = false;
            this.grpUArtistLbl.Text = "Artist Label:";
            // 
            // radUPolydor
            // 
            this.radUPolydor.AutoSize = true;
            this.radUPolydor.Location = new System.Drawing.Point(79, 76);
            this.radUPolydor.Margin = new System.Windows.Forms.Padding(2);
            this.radUPolydor.Name = "radUPolydor";
            this.radUPolydor.Size = new System.Drawing.Size(60, 17);
            this.radUPolydor.TabIndex = 12;
            this.radUPolydor.TabStop = true;
            this.radUPolydor.Text = "Polydor";
            this.radUPolydor.UseVisualStyleBackColor = true;
            // 
            // radUSony
            // 
            this.radUSony.AutoSize = true;
            this.radUSony.Location = new System.Drawing.Point(4, 17);
            this.radUSony.Margin = new System.Windows.Forms.Padding(2);
            this.radUSony.Name = "radUSony";
            this.radUSony.Size = new System.Drawing.Size(49, 17);
            this.radUSony.TabIndex = 8;
            this.radUSony.Text = "Sony";
            this.radUSony.UseVisualStyleBackColor = true;
            // 
            // radUWBros
            // 
            this.radUWBros.AutoSize = true;
            this.radUWBros.Location = new System.Drawing.Point(68, 17);
            this.radUWBros.Margin = new System.Windows.Forms.Padding(2);
            this.radUWBros.Name = "radUWBros";
            this.radUWBros.Size = new System.Drawing.Size(84, 17);
            this.radUWBros.TabIndex = 10;
            this.radUWBros.Text = "Warner Bros";
            this.radUWBros.UseVisualStyleBackColor = true;
            // 
            // radUUniversal
            // 
            this.radUUniversal.AutoSize = true;
            this.radUUniversal.Checked = true;
            this.radUUniversal.Location = new System.Drawing.Point(0, 76);
            this.radUUniversal.Margin = new System.Windows.Forms.Padding(2);
            this.radUUniversal.Name = "radUUniversal";
            this.radUUniversal.Size = new System.Drawing.Size(69, 17);
            this.radUUniversal.TabIndex = 9;
            this.radUUniversal.TabStop = true;
            this.radUUniversal.Text = "Universal";
            this.radUUniversal.UseVisualStyleBackColor = true;
            // 
            // txtUAlbum
            // 
            this.txtUAlbum.Location = new System.Drawing.Point(86, 143);
            this.txtUAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.txtUAlbum.Name = "txtUAlbum";
            this.txtUAlbum.Size = new System.Drawing.Size(170, 20);
            this.txtUAlbum.TabIndex = 22;
            // 
            // txtUArtist
            // 
            this.txtUArtist.Location = new System.Drawing.Point(86, 200);
            this.txtUArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtUArtist.Name = "txtUArtist";
            this.txtUArtist.Size = new System.Drawing.Size(170, 20);
            this.txtUArtist.TabIndex = 21;
            // 
            // chkUYr
            // 
            this.chkUYr.CheckOnClick = true;
            this.chkUYr.FormattingEnabled = true;
            this.chkUYr.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.chkUYr.Location = new System.Drawing.Point(110, 251);
            this.chkUYr.Margin = new System.Windows.Forms.Padding(2);
            this.chkUYr.Name = "chkUYr";
            this.chkUYr.Size = new System.Drawing.Size(215, 64);
            this.chkUYr.TabIndex = 20;
            // 
            // btnUInsert
            // 
            this.btnUInsert.Location = new System.Drawing.Point(287, 700);
            this.btnUInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnUInsert.Name = "btnUInsert";
            this.btnUInsert.Size = new System.Drawing.Size(103, 56);
            this.btnUInsert.TabIndex = 19;
            this.btnUInsert.Text = "Update";
            this.btnUInsert.UseVisualStyleBackColor = true;
            this.btnUInsert.Click += new System.EventHandler(this.btnUInsert_Click);
            // 
            // lblUYr
            // 
            this.lblUYr.AutoSize = true;
            this.lblUYr.Location = new System.Drawing.Point(17, 269);
            this.lblUYr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUYr.Name = "lblUYr";
            this.lblUYr.Size = new System.Drawing.Size(80, 13);
            this.lblUYr.TabIndex = 18;
            this.lblUYr.Text = "Year Released:";
            // 
            // lblUArtist
            // 
            this.lblUArtist.AutoSize = true;
            this.lblUArtist.Location = new System.Drawing.Point(17, 200);
            this.lblUArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUArtist.Name = "lblUArtist";
            this.lblUArtist.Size = new System.Drawing.Size(33, 13);
            this.lblUArtist.TabIndex = 17;
            this.lblUArtist.Text = "Artist:";
            // 
            // lblUAlbum
            // 
            this.lblUAlbum.AutoSize = true;
            this.lblUAlbum.Location = new System.Drawing.Point(17, 146);
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
            this.txtCDID.Text = "00003";
            // 
            // cboupdCD
            // 
            this.cboupdCD.FormattingEnabled = true;
            this.cboupdCD.Items.AddRange(new object[] {
            "002 Parachutes - Coldplay",
            "008 X - Ed Sheeran",
            "012 1989 - Taylor Swift",
            "018 Glory Days - Little Mix",
            "Reputation - Taylor Swift",
            "1989 - Taylor Swift",
            "+ - Ed Sheeran",
            "Harry Styles - Harry Styles"});
            this.cboupdCD.Location = new System.Drawing.Point(71, 92);
            this.cboupdCD.Margin = new System.Windows.Forms.Padding(2);
            this.cboupdCD.Name = "cboupdCD";
            this.cboupdCD.Size = new System.Drawing.Size(117, 21);
            this.cboupdCD.TabIndex = 28;
            this.cboupdCD.SelectedIndexChanged += new System.EventHandler(this.cboDiscontinueCD_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
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
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "CD";
            // 
            // grpUCD
            // 
            this.grpUCD.Controls.Add(this.txtuQty);
            this.grpUCD.Controls.Add(this.lbluQty);
            this.grpUCD.Controls.Add(this.txtuCost);
            this.grpUCD.Controls.Add(this.lbluCost);
            this.grpUCD.Controls.Add(this.lblOrderCDID);
            this.grpUCD.Controls.Add(this.label1);
            this.grpUCD.Controls.Add(this.grpUArtistLbl);
            this.grpUCD.Controls.Add(this.cboupdCD);
            this.grpUCD.Controls.Add(this.chkUYr);
            this.grpUCD.Controls.Add(this.txtUArtist);
            this.grpUCD.Controls.Add(this.txtUAlbum);
            this.grpUCD.Controls.Add(this.lblUYr);
            this.grpUCD.Controls.Add(this.txtCDID);
            this.grpUCD.Controls.Add(this.lblUAlbum);
            this.grpUCD.Controls.Add(this.lblUArtist);
            this.grpUCD.Location = new System.Drawing.Point(100, 36);
            this.grpUCD.Margin = new System.Windows.Forms.Padding(2);
            this.grpUCD.Name = "grpUCD";
            this.grpUCD.Padding = new System.Windows.Forms.Padding(2);
            this.grpUCD.Size = new System.Drawing.Size(431, 647);
            this.grpUCD.TabIndex = 32;
            this.grpUCD.TabStop = false;
            this.grpUCD.Text = "Update CD Details";
            // 
            // txtuQty
            // 
            this.txtuQty.Location = new System.Drawing.Point(55, 563);
            this.txtuQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtuQty.Name = "txtuQty";
            this.txtuQty.Size = new System.Drawing.Size(170, 20);
            this.txtuQty.TabIndex = 37;
            // 
            // lbluQty
            // 
            this.lbluQty.AutoSize = true;
            this.lbluQty.Location = new System.Drawing.Point(8, 563);
            this.lbluQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluQty.Name = "lbluQty";
            this.lbluQty.Size = new System.Drawing.Size(42, 13);
            this.lbluQty.TabIndex = 36;
            this.lbluQty.Text = "Quality:";
            // 
            // txtuCost
            // 
            this.txtuCost.Location = new System.Drawing.Point(70, 494);
            this.txtuCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtuCost.Name = "txtuCost";
            this.txtuCost.Size = new System.Drawing.Size(170, 20);
            this.txtuCost.TabIndex = 35;
            // 
            // lbluCost
            // 
            this.lbluCost.AutoSize = true;
            this.lbluCost.Location = new System.Drawing.Point(8, 494);
            this.lbluCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluCost.Name = "lbluCost";
            this.lbluCost.Size = new System.Drawing.Size(58, 13);
            this.lbluCost.TabIndex = 34;
            this.lbluCost.Text = "Cost Price:";
            // 
            // frmUpdCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 756);
            this.Controls.Add(this.grpUCD);
            this.Controls.Add(this.btnUExitA);
            this.Controls.Add(this.btnUInsert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdCD";
            this.Text = "Update CD";
            this.Load += new System.EventHandler(this.frmUpdCD_Load);
            this.grpUArtistLbl.ResumeLayout(false);
            this.grpUArtistLbl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUCD.ResumeLayout(false);
            this.grpUCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUExitA;
        private System.Windows.Forms.GroupBox grpUArtistLbl;
        private System.Windows.Forms.RadioButton radUSony;
        private System.Windows.Forms.RadioButton radUWBros;
        private System.Windows.Forms.RadioButton radUUniversal;
        private System.Windows.Forms.TextBox txtUAlbum;
        private System.Windows.Forms.TextBox txtUArtist;
        private System.Windows.Forms.CheckedListBox chkUYr;
        private System.Windows.Forms.Button btnUInsert;
        private System.Windows.Forms.Label lblUYr;
        private System.Windows.Forms.Label lblUArtist;
        private System.Windows.Forms.Label lblUAlbum;
        private System.Windows.Forms.Label lblOrderCDID;
        private System.Windows.Forms.TextBox txtCDID;
        private System.Windows.Forms.ComboBox cboupdCD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenu;
        private System.Windows.Forms.RadioButton radUPolydor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUCD;
        private System.Windows.Forms.TextBox txtuQty;
        private System.Windows.Forms.Label lbluQty;
        private System.Windows.Forms.TextBox txtuCost;
        private System.Windows.Forms.Label lbluCost;
    }
}