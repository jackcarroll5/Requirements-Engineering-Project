namespace MusicStoreSYS
{
    partial class frmInsNewCD
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
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblYr = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.chkYr = new System.Windows.Forms.CheckedListBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.radSony = new System.Windows.Forms.RadioButton();
            this.radUniversal = new System.Windows.Forms.RadioButton();
            this.radWBros = new System.Windows.Forms.RadioButton();
            this.radPolydor = new System.Windows.Forms.RadioButton();
            this.grpArtistLbl = new System.Windows.Forms.GroupBox();
            this.btnExitA = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCDID = new System.Windows.Forms.TextBox();
            this.lblOrderCDID = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.grpInsCD = new System.Windows.Forms.GroupBox();
            this.grpArtistLbl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpInsCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(6, 106);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Album:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(9, 164);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist:";
            // 
            // lblYr
            // 
            this.lblYr.AutoSize = true;
            this.lblYr.Location = new System.Drawing.Point(-3, 203);
            this.lblYr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYr.Name = "lblYr";
            this.lblYr.Size = new System.Drawing.Size(80, 13);
            this.lblYr.TabIndex = 2;
            this.lblYr.Text = "Year Released:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(247, 657);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 40);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // chkYr
            // 
            this.chkYr.CheckOnClick = true;
            this.chkYr.FormattingEnabled = true;
            this.chkYr.Items.AddRange(new object[] {
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
            this.chkYr.Location = new System.Drawing.Point(81, 203);
            this.chkYr.Margin = new System.Windows.Forms.Padding(2);
            this.chkYr.Name = "chkYr";
            this.chkYr.Size = new System.Drawing.Size(215, 64);
            this.chkYr.TabIndex = 5;
            this.chkYr.SelectedIndexChanged += new System.EventHandler(this.chkYr_SelectedIndexChanged);
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(56, 164);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(170, 20);
            this.txtArtist.TabIndex = 6;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(56, 103);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(170, 20);
            this.txtAlbum.TabIndex = 7;
            // 
            // radSony
            // 
            this.radSony.AutoSize = true;
            this.radSony.Location = new System.Drawing.Point(4, 17);
            this.radSony.Margin = new System.Windows.Forms.Padding(2);
            this.radSony.Name = "radSony";
            this.radSony.Size = new System.Drawing.Size(49, 17);
            this.radSony.TabIndex = 8;
            this.radSony.TabStop = true;
            this.radSony.Text = "Sony";
            this.radSony.UseVisualStyleBackColor = true;
            // 
            // radUniversal
            // 
            this.radUniversal.AutoSize = true;
            this.radUniversal.Checked = true;
            this.radUniversal.Location = new System.Drawing.Point(0, 76);
            this.radUniversal.Margin = new System.Windows.Forms.Padding(2);
            this.radUniversal.Name = "radUniversal";
            this.radUniversal.Size = new System.Drawing.Size(69, 17);
            this.radUniversal.TabIndex = 9;
            this.radUniversal.TabStop = true;
            this.radUniversal.Text = "Universal";
            this.radUniversal.UseVisualStyleBackColor = true;
            // 
            // radWBros
            // 
            this.radWBros.AutoSize = true;
            this.radWBros.Location = new System.Drawing.Point(66, 17);
            this.radWBros.Margin = new System.Windows.Forms.Padding(2);
            this.radWBros.Name = "radWBros";
            this.radWBros.Size = new System.Drawing.Size(84, 17);
            this.radWBros.TabIndex = 10;
            this.radWBros.TabStop = true;
            this.radWBros.Text = "Warner Bros";
            this.radWBros.UseVisualStyleBackColor = true;
            // 
            // radPolydor
            // 
            this.radPolydor.AutoSize = true;
            this.radPolydor.Location = new System.Drawing.Point(73, 76);
            this.radPolydor.Margin = new System.Windows.Forms.Padding(2);
            this.radPolydor.Name = "radPolydor";
            this.radPolydor.Size = new System.Drawing.Size(60, 17);
            this.radPolydor.TabIndex = 11;
            this.radPolydor.TabStop = true;
            this.radPolydor.Text = "Polydor";
            this.radPolydor.UseVisualStyleBackColor = true;
            // 
            // grpArtistLbl
            // 
            this.grpArtistLbl.Controls.Add(this.radSony);
            this.grpArtistLbl.Controls.Add(this.radWBros);
            this.grpArtistLbl.Controls.Add(this.radPolydor);
            this.grpArtistLbl.Controls.Add(this.radUniversal);
            this.grpArtistLbl.Location = new System.Drawing.Point(5, 303);
            this.grpArtistLbl.Margin = new System.Windows.Forms.Padding(2);
            this.grpArtistLbl.Name = "grpArtistLbl";
            this.grpArtistLbl.Padding = new System.Windows.Forms.Padding(2);
            this.grpArtistLbl.Size = new System.Drawing.Size(150, 108);
            this.grpArtistLbl.TabIndex = 13;
            this.grpArtistLbl.TabStop = false;
            this.grpArtistLbl.Text = "Artist Label:";
            this.grpArtistLbl.Enter += new System.EventHandler(this.grpArtistLbl_Enter);
            // 
            // btnExitA
            // 
            this.btnExitA.Location = new System.Drawing.Point(535, 0);
            this.btnExitA.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(87, 24);
            this.btnExitA.TabIndex = 15;
            this.btnExitA.Text = "Exit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backItem
            // 
            this.backItem.Name = "backItem";
            this.backItem.Size = new System.Drawing.Size(44, 20);
            this.backItem.Text = "Back";
            this.backItem.Click += new System.EventHandler(this.backItem_Click);
            // 
            // txtCDID
            // 
            this.txtCDID.Enabled = false;
            this.txtCDID.Location = new System.Drawing.Point(62, 43);
            this.txtCDID.Name = "txtCDID";
            this.txtCDID.Size = new System.Drawing.Size(61, 20);
            this.txtCDID.TabIndex = 29;
            this.txtCDID.Text = "00001";
            // 
            // lblOrderCDID
            // 
            this.lblOrderCDID.AutoSize = true;
            this.lblOrderCDID.Location = new System.Drawing.Point(6, 46);
            this.lblOrderCDID.Name = "lblOrderCDID";
            this.lblOrderCDID.Size = new System.Drawing.Size(36, 13);
            this.lblOrderCDID.TabIndex = 28;
            this.lblOrderCDID.Text = "CD ID";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(64, 448);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(170, 20);
            this.txtCost.TabIndex = 31;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(2, 448);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(58, 13);
            this.lblCost.TabIndex = 30;
            this.lblCost.Text = "Cost Price:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(50, 516);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(170, 20);
            this.txtQty.TabIndex = 33;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(3, 516);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(42, 13);
            this.lblQty.TabIndex = 32;
            this.lblQty.Text = "Quality:";
            // 
            // grpInsCD
            // 
            this.grpInsCD.Controls.Add(this.lblOrderCDID);
            this.grpInsCD.Controls.Add(this.txtQty);
            this.grpInsCD.Controls.Add(this.lblAlbum);
            this.grpInsCD.Controls.Add(this.lblQty);
            this.grpInsCD.Controls.Add(this.txtAlbum);
            this.grpInsCD.Controls.Add(this.txtCost);
            this.grpInsCD.Controls.Add(this.txtCDID);
            this.grpInsCD.Controls.Add(this.lblCost);
            this.grpInsCD.Controls.Add(this.lblArtist);
            this.grpInsCD.Controls.Add(this.txtArtist);
            this.grpInsCD.Controls.Add(this.grpArtistLbl);
            this.grpInsCD.Controls.Add(this.lblYr);
            this.grpInsCD.Controls.Add(this.chkYr);
            this.grpInsCD.Location = new System.Drawing.Point(69, 37);
            this.grpInsCD.Name = "grpInsCD";
            this.grpInsCD.Size = new System.Drawing.Size(407, 558);
            this.grpInsCD.TabIndex = 34;
            this.grpInsCD.TabStop = false;
            this.grpInsCD.Text = "Please insert the CD you want to put into the system:";
            // 
            // frmInsNewCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 704);
            this.Controls.Add(this.grpInsCD);
            this.Controls.Add(this.btnExitA);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInsNewCD";
            this.Text = "Insert CDs";
            this.Load += new System.EventHandler(this.frmInsNewCD_Load);
            this.grpArtistLbl.ResumeLayout(false);
            this.grpArtistLbl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpInsCD.ResumeLayout(false);
            this.grpInsCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblYr;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckedListBox chkYr;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.RadioButton radSony;
        private System.Windows.Forms.RadioButton radUniversal;
        private System.Windows.Forms.RadioButton radWBros;
        private System.Windows.Forms.RadioButton radPolydor;
        private System.Windows.Forms.GroupBox grpArtistLbl;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backItem;
        private System.Windows.Forms.TextBox txtCDID;
        private System.Windows.Forms.Label lblOrderCDID;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox grpInsCD;
    }
}