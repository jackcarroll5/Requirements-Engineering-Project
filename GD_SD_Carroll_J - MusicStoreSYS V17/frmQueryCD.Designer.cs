namespace MusicStoreSYS
{
    partial class frmQueryCD
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
            this.grpOrderCD = new System.Windows.Forms.GroupBox();
            this.radArtLbl = new System.Windows.Forms.RadioButton();
            this.radCDID = new System.Windows.Forms.RadioButton();
            this.btnQueryCDExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.grdCD = new System.Windows.Forms.DataGridView();
            this.grpOrderCD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCD)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrderCD
            // 
            this.grpOrderCD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOrderCD.Controls.Add(this.radArtLbl);
            this.grpOrderCD.Controls.Add(this.radCDID);
            this.grpOrderCD.Location = new System.Drawing.Point(15, 65);
            this.grpOrderCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderCD.Name = "grpOrderCD";
            this.grpOrderCD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderCD.Size = new System.Drawing.Size(444, 96);
            this.grpOrderCD.TabIndex = 5;
            this.grpOrderCD.TabStop = false;
            this.grpOrderCD.Text = "Choose Order";
            // 
            // radArtLbl
            // 
            this.radArtLbl.AutoSize = true;
            this.radArtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArtLbl.Location = new System.Drawing.Point(228, 47);
            this.radArtLbl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radArtLbl.Name = "radArtLbl";
            this.radArtLbl.Size = new System.Drawing.Size(112, 21);
            this.radArtLbl.TabIndex = 1;
            this.radArtLbl.Text = "Artist Label";
            this.radArtLbl.UseVisualStyleBackColor = true;
            this.radArtLbl.CheckedChanged += new System.EventHandler(this.radArtLbl_CheckedChanged);
            // 
            // radCDID
            // 
            this.radCDID.AutoSize = true;
            this.radCDID.Checked = true;
            this.radCDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCDID.Location = new System.Drawing.Point(36, 47);
            this.radCDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCDID.Name = "radCDID";
            this.radCDID.Size = new System.Drawing.Size(70, 21);
            this.radCDID.TabIndex = 0;
            this.radCDID.TabStop = true;
            this.radCDID.Text = "CD ID";
            this.radCDID.UseVisualStyleBackColor = true;
            this.radCDID.CheckedChanged += new System.EventHandler(this.radCDID_CheckedChanged);
            // 
            // btnQueryCDExit
            // 
            this.btnQueryCDExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQueryCDExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQueryCDExit.Location = new System.Drawing.Point(851, 0);
            this.btnQueryCDExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQueryCDExit.Name = "btnQueryCDExit";
            this.btnQueryCDExit.Size = new System.Drawing.Size(176, 30);
            this.btnQueryCDExit.TabIndex = 6;
            this.btnQueryCDExit.Text = "Quit";
            this.btnQueryCDExit.UseVisualStyleBackColor = false;
            this.btnQueryCDExit.Click += new System.EventHandler(this.btnQueryCDExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1027, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenuStrip
            // 
            this.backMenuStrip.Name = "backMenuStrip";
            this.backMenuStrip.Size = new System.Drawing.Size(52, 24);
            this.backMenuStrip.Text = "Back";
            this.backMenuStrip.Click += new System.EventHandler(this.backMenuStrip_Click);
            // 
            // grdCD
            // 
            this.grdCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCD.Location = new System.Drawing.Point(29, 212);
            this.grdCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdCD.Name = "grdCD";
            this.grdCD.Size = new System.Drawing.Size(844, 340);
            this.grdCD.TabIndex = 8;
            this.grdCD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCD_CellContentClick);
            // 
            // frmQueryCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 612);
            this.Controls.Add(this.grdCD);
            this.Controls.Add(this.btnQueryCDExit);
            this.Controls.Add(this.grpOrderCD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQueryCD";
            this.Text = "Querying CDs";
            this.Load += new System.EventHandler(this.frmQueryCD_Load);
            this.grpOrderCD.ResumeLayout(false);
            this.grpOrderCD.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderCD;
        private System.Windows.Forms.Button btnQueryCDExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenuStrip;
        private System.Windows.Forms.RadioButton radCDID;
        private System.Windows.Forms.RadioButton radArtLbl;
        private System.Windows.Forms.DataGridView grdCD;
    }
}