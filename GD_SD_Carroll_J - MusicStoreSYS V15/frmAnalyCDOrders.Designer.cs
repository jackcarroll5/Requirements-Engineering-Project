namespace MusicStoreSYS
{
    partial class frmAnalyCDOrders
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
            this.grpSalesAnalysis = new System.Windows.Forms.GroupBox();
            this.chkStockAnalysis = new System.Windows.Forms.CheckedListBox();
            this.lblDisplayCDAnalysis = new System.Windows.Forms.Label();
            this.btnExitAnalyseCDSales = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bckMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grdanalyseCDOrders = new System.Windows.Forms.DataGridView();
            this.CDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.grdOrd = new System.Windows.Forms.DataGridView();
            this.OrdersOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalyseOrders = new System.Windows.Forms.Button();
            this.OrderItemsOrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSalesAnalysis.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdanalyseCDOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrd)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSalesAnalysis
            // 
            this.grpSalesAnalysis.Controls.Add(this.chkStockAnalysis);
            this.grpSalesAnalysis.Controls.Add(this.lblDisplayCDAnalysis);
            this.grpSalesAnalysis.Location = new System.Drawing.Point(46, 51);
            this.grpSalesAnalysis.Name = "grpSalesAnalysis";
            this.grpSalesAnalysis.Size = new System.Drawing.Size(418, 173);
            this.grpSalesAnalysis.TabIndex = 0;
            this.grpSalesAnalysis.TabStop = false;
            this.grpSalesAnalysis.Text = "Order CDs for Orders Analysis";
            this.grpSalesAnalysis.Enter += new System.EventHandler(this.grpSalesAnalysis_Enter);
            // 
            // chkStockAnalysis
            // 
            this.chkStockAnalysis.CheckOnClick = true;
            this.chkStockAnalysis.FormattingEnabled = true;
            this.chkStockAnalysis.Items.AddRange(new object[] {
            "CD_ID",
            "Album Name",
            "Highest Sale",
            "Cost Price"});
            this.chkStockAnalysis.Location = new System.Drawing.Point(9, 81);
            this.chkStockAnalysis.Name = "chkStockAnalysis";
            this.chkStockAnalysis.Size = new System.Drawing.Size(222, 64);
            this.chkStockAnalysis.TabIndex = 5;
            // 
            // lblDisplayCDAnalysis
            // 
            this.lblDisplayCDAnalysis.AutoSize = true;
            this.lblDisplayCDAnalysis.Location = new System.Drawing.Point(6, 47);
            this.lblDisplayCDAnalysis.Name = "lblDisplayCDAnalysis";
            this.lblDisplayCDAnalysis.Size = new System.Drawing.Size(225, 13);
            this.lblDisplayCDAnalysis.TabIndex = 0;
            this.lblDisplayCDAnalysis.Text = "Select the order to display the CDs for analysis";
            // 
            // btnExitAnalyseCDSales
            // 
            this.btnExitAnalyseCDSales.Location = new System.Drawing.Point(769, 0);
            this.btnExitAnalyseCDSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitAnalyseCDSales.Name = "btnExitAnalyseCDSales";
            this.btnExitAnalyseCDSales.Size = new System.Drawing.Size(87, 24);
            this.btnExitAnalyseCDSales.TabIndex = 16;
            this.btnExitAnalyseCDSales.Text = "Exit";
            this.btnExitAnalyseCDSales.UseVisualStyleBackColor = true;
            this.btnExitAnalyseCDSales.Click += new System.EventHandler(this.btnExitAnalyseCDSales_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bckMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bckMenu
            // 
            this.bckMenu.Name = "bckMenu";
            this.bckMenu.Size = new System.Drawing.Size(44, 20);
            this.bckMenu.Text = "Back";
            this.bckMenu.Click += new System.EventHandler(this.bckMenu_Click);
            // 
            // grdanalyseCDOrders
            // 
            this.grdanalyseCDOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdanalyseCDOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDID,
            this.Album,
            this.Artist,
            this.Year,
            this.ArtistLabel,
            this.CostPrice,
            this.Qty,
            this.Availability,
            this.PaymentID,
            this.OrdID});
            this.grdanalyseCDOrders.Location = new System.Drawing.Point(2, 231);
            this.grdanalyseCDOrders.Name = "grdanalyseCDOrders";
            this.grdanalyseCDOrders.Size = new System.Drawing.Size(783, 150);
            this.grdanalyseCDOrders.TabIndex = 19;
            // 
            // CDID
            // 
            this.CDID.HeaderText = "CDID";
            this.CDID.Name = "CDID";
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.HeaderText = "Artist Label";
            this.ArtistLabel.Name = "ArtistLabel";
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost Price";
            this.CostPrice.Name = "CostPrice";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "PaymentID";
            this.PaymentID.Name = "PaymentID";
            // 
            // OrdID
            // 
            this.OrdID.HeaderText = "OrdID";
            this.OrdID.Name = "OrdID";
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItemsOrdID,
            this.CD_ID,
            this.OrderItemsQty,
            this.Unit_Cost});
            this.grdOrders.Location = new System.Drawing.Point(0, 419);
            this.grdOrders.Margin = new System.Windows.Forms.Padding(2);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowTemplate.Height = 24;
            this.grdOrders.Size = new System.Drawing.Size(447, 122);
            this.grdOrders.TabIndex = 20;
            // 
            // grdOrd
            // 
            this.grdOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersOrderID,
            this.OrdDate,
            this.OrdValue,
            this.Status,
            this.SuppID});
            this.grdOrd.Location = new System.Drawing.Point(4, 561);
            this.grdOrd.Margin = new System.Windows.Forms.Padding(2);
            this.grdOrd.Name = "grdOrd";
            this.grdOrd.RowTemplate.Height = 24;
            this.grdOrd.Size = new System.Drawing.Size(542, 112);
            this.grdOrd.TabIndex = 21;
            // 
            // OrdersOrderID
            // 
            this.OrdersOrderID.HeaderText = "OrderID";
            this.OrdersOrderID.Name = "OrdersOrderID";
            // 
            // OrdDate
            // 
            this.OrdDate.HeaderText = "OrdDate";
            this.OrdDate.Name = "OrdDate";
            // 
            // OrdValue
            // 
            this.OrdValue.HeaderText = "OrdValue";
            this.OrdValue.Name = "OrdValue";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // SuppID
            // 
            this.SuppID.HeaderText = "SuppID";
            this.SuppID.Name = "SuppID";
            // 
            // btnAnalyseOrders
            // 
            this.btnAnalyseOrders.Location = new System.Drawing.Point(295, 831);
            this.btnAnalyseOrders.Name = "btnAnalyseOrders";
            this.btnAnalyseOrders.Size = new System.Drawing.Size(130, 35);
            this.btnAnalyseOrders.TabIndex = 22;
            this.btnAnalyseOrders.Text = "Analyse";
            this.btnAnalyseOrders.UseVisualStyleBackColor = true;
            this.btnAnalyseOrders.Click += new System.EventHandler(this.btnAnalyseOrders_Click);
            // 
            // OrderItemsOrdID
            // 
            this.OrderItemsOrdID.HeaderText = "OrdID";
            this.OrderItemsOrdID.Name = "OrderItemsOrdID";
            // 
            // CD_ID
            // 
            this.CD_ID.HeaderText = "CD ID";
            this.CD_ID.Name = "CD_ID";
            // 
            // OrderItemsQty
            // 
            this.OrderItemsQty.HeaderText = "Qty";
            this.OrderItemsQty.Name = "OrderItemsQty";
            // 
            // Unit_Cost
            // 
            this.Unit_Cost.HeaderText = "Unit Cost";
            this.Unit_Cost.Name = "Unit_Cost";
            // 
            // frmAnalyCDOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 866);
            this.Controls.Add(this.btnAnalyseOrders);
            this.Controls.Add(this.grdOrd);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.grdanalyseCDOrders);
            this.Controls.Add(this.btnExitAnalyseCDSales);
            this.Controls.Add(this.grpSalesAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyCDOrders";
            this.Text = "Analyse CD Sales";
            this.Load += new System.EventHandler(this.frmAnalyCDSales_Load);
            this.grpSalesAnalysis.ResumeLayout(false);
            this.grpSalesAnalysis.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdanalyseCDOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalesAnalysis;
        private System.Windows.Forms.Label lblDisplayCDAnalysis;
        private System.Windows.Forms.Button btnExitAnalyseCDSales;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bckMenu;
        private System.Windows.Forms.DataGridView grdanalyseCDOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdID;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.DataGridView grdOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppID;
        private System.Windows.Forms.CheckedListBox chkStockAnalysis;
        private System.Windows.Forms.Button btnAnalyseOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsOrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Cost;
    }
}