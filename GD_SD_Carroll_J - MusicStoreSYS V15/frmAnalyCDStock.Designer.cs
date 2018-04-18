namespace MusicStoreSYS
{
    partial class frmAnalyCDStock
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
            this.btnExitAnalyseCDStock = new System.Windows.Forms.Button();
            this.grpStockAnalysis = new System.Windows.Forms.GroupBox();
            this.chkOrderAnalysis = new System.Windows.Forms.CheckedListBox();
            this.lblDisplayCDAnalysis = new System.Windows.Forms.Label();
            this.backMenu = new System.Windows.Forms.MenuStrip();
            this.backM = new System.Windows.Forms.ToolStripMenuItem();
            this.grdanalyStock = new System.Windows.Forms.DataGridView();
            this.StockCDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockArtistLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdOrderItemsStock = new System.Windows.Forms.DataGridView();
            this.btnAnalyseStock = new System.Windows.Forms.Button();
            this.OrderItemsOrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsCD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsUnit_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStockAnalysis.SuspendLayout();
            this.backMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdanalyStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderItemsStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitAnalyseCDStock
            // 
            this.btnExitAnalyseCDStock.Location = new System.Drawing.Point(726, 0);
            this.btnExitAnalyseCDStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitAnalyseCDStock.Name = "btnExitAnalyseCDStock";
            this.btnExitAnalyseCDStock.Size = new System.Drawing.Size(87, 24);
            this.btnExitAnalyseCDStock.TabIndex = 16;
            this.btnExitAnalyseCDStock.Text = "Exit";
            this.btnExitAnalyseCDStock.UseVisualStyleBackColor = true;
            this.btnExitAnalyseCDStock.Click += new System.EventHandler(this.btnExitAnalyseCDStock_Click);
            // 
            // grpStockAnalysis
            // 
            this.grpStockAnalysis.Controls.Add(this.chkOrderAnalysis);
            this.grpStockAnalysis.Controls.Add(this.lblDisplayCDAnalysis);
            this.grpStockAnalysis.Location = new System.Drawing.Point(12, 42);
            this.grpStockAnalysis.Name = "grpStockAnalysis";
            this.grpStockAnalysis.Size = new System.Drawing.Size(247, 163);
            this.grpStockAnalysis.TabIndex = 17;
            this.grpStockAnalysis.TabStop = false;
            this.grpStockAnalysis.Text = "Order CDs for Stock Analysis";
            // 
            // chkOrderAnalysis
            // 
            this.chkOrderAnalysis.CheckOnClick = true;
            this.chkOrderAnalysis.FormattingEnabled = true;
            this.chkOrderAnalysis.Items.AddRange(new object[] {
            "CD_ID",
            "Artist",
            "No_Sold (Qty)"});
            this.chkOrderAnalysis.Location = new System.Drawing.Point(9, 94);
            this.chkOrderAnalysis.Name = "chkOrderAnalysis";
            this.chkOrderAnalysis.Size = new System.Drawing.Size(222, 34);
            this.chkOrderAnalysis.TabIndex = 1;
            this.chkOrderAnalysis.SelectedIndexChanged += new System.EventHandler(this.chkOrderAnalysis_SelectedIndexChanged);
            // 
            // lblDisplayCDAnalysis
            // 
            this.lblDisplayCDAnalysis.AutoSize = true;
            this.lblDisplayCDAnalysis.Location = new System.Drawing.Point(6, 47);
            this.lblDisplayCDAnalysis.Name = "lblDisplayCDAnalysis";
            this.lblDisplayCDAnalysis.Size = new System.Drawing.Size(228, 13);
            this.lblDisplayCDAnalysis.TabIndex = 0;
            this.lblDisplayCDAnalysis.Text = "Select the order to display the CDs for analysis:";
            this.lblDisplayCDAnalysis.Click += new System.EventHandler(this.lblDisplayCDAnalysis_Click);
            // 
            // backMenu
            // 
            this.backMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.backMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backM});
            this.backMenu.Location = new System.Drawing.Point(0, 0);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(813, 24);
            this.backMenu.TabIndex = 19;
            this.backMenu.Text = "menuStrip1";
            // 
            // backM
            // 
            this.backM.Name = "backM";
            this.backM.Size = new System.Drawing.Size(44, 20);
            this.backM.Text = "Back";
            this.backM.Click += new System.EventHandler(this.backM_Click);
            // 
            // grdanalyStock
            // 
            this.grdanalyStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdanalyStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCDID,
            this.StockAlbum,
            this.StockArtist,
            this.StockYear,
            this.StockArtistLabel,
            this.StockCostPrice,
            this.StockQty,
            this.StockAvailability,
            this.StockPaymentID,
            this.StockOrdID});
            this.grdanalyStock.Location = new System.Drawing.Point(-2, 222);
            this.grdanalyStock.Name = "grdanalyStock";
            this.grdanalyStock.Size = new System.Drawing.Size(815, 150);
            this.grdanalyStock.TabIndex = 21;
            this.grdanalyStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdanalyStock_CellContentClick);
            // 
            // StockCDID
            // 
            this.StockCDID.HeaderText = "CDID";
            this.StockCDID.Name = "StockCDID";
            // 
            // StockAlbum
            // 
            this.StockAlbum.HeaderText = "Album";
            this.StockAlbum.Name = "StockAlbum";
            // 
            // StockArtist
            // 
            this.StockArtist.HeaderText = "Artist";
            this.StockArtist.Name = "StockArtist";
            // 
            // StockYear
            // 
            this.StockYear.HeaderText = "Year";
            this.StockYear.Name = "StockYear";
            // 
            // StockArtistLabel
            // 
            this.StockArtistLabel.HeaderText = "Artist Label";
            this.StockArtistLabel.Name = "StockArtistLabel";
            // 
            // StockCostPrice
            // 
            this.StockCostPrice.HeaderText = "Cost Price";
            this.StockCostPrice.Name = "StockCostPrice";
            // 
            // StockQty
            // 
            this.StockQty.HeaderText = "Qty";
            this.StockQty.Name = "StockQty";
            // 
            // StockAvailability
            // 
            this.StockAvailability.HeaderText = "Availability";
            this.StockAvailability.Name = "StockAvailability";
            // 
            // StockPaymentID
            // 
            this.StockPaymentID.HeaderText = "PaymentID";
            this.StockPaymentID.Name = "StockPaymentID";
            // 
            // StockOrdID
            // 
            this.StockOrdID.HeaderText = "OrdID";
            this.StockOrdID.Name = "StockOrdID";
            // 
            // grdOrderItemsStock
            // 
            this.grdOrderItemsStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderItemsStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItemsOrdID,
            this.OrderItemsCD_ID,
            this.OrderItemsQty,
            this.OrderItemsUnit_Cost});
            this.grdOrderItemsStock.Location = new System.Drawing.Point(0, 397);
            this.grdOrderItemsStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdOrderItemsStock.Name = "grdOrderItemsStock";
            this.grdOrderItemsStock.RowTemplate.Height = 24;
            this.grdOrderItemsStock.Size = new System.Drawing.Size(446, 122);
            this.grdOrderItemsStock.TabIndex = 22;
            // 
            // btnAnalyseStock
            // 
            this.btnAnalyseStock.Location = new System.Drawing.Point(343, 619);
            this.btnAnalyseStock.Name = "btnAnalyseStock";
            this.btnAnalyseStock.Size = new System.Drawing.Size(129, 35);
            this.btnAnalyseStock.TabIndex = 23;
            this.btnAnalyseStock.Text = "Analyse";
            this.btnAnalyseStock.UseVisualStyleBackColor = true;
            this.btnAnalyseStock.Click += new System.EventHandler(this.btnAnalyseStock_Click_1);
            // 
            // OrderItemsOrdID
            // 
            this.OrderItemsOrdID.HeaderText = "OrdID";
            this.OrderItemsOrdID.Name = "OrderItemsOrdID";
            // 
            // OrderItemsCD_ID
            // 
            this.OrderItemsCD_ID.HeaderText = "CD ID";
            this.OrderItemsCD_ID.Name = "OrderItemsCD_ID";
            // 
            // OrderItemsQty
            // 
            this.OrderItemsQty.HeaderText = "Qty";
            this.OrderItemsQty.Name = "OrderItemsQty";
            // 
            // OrderItemsUnit_Cost
            // 
            this.OrderItemsUnit_Cost.HeaderText = "Unit Cost";
            this.OrderItemsUnit_Cost.Name = "OrderItemsUnit_Cost";
            // 
            // frmAnalyCDStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 654);
            this.Controls.Add(this.btnAnalyseStock);
            this.Controls.Add(this.grdOrderItemsStock);
            this.Controls.Add(this.grdanalyStock);
            this.Controls.Add(this.grpStockAnalysis);
            this.Controls.Add(this.btnExitAnalyseCDStock);
            this.Controls.Add(this.backMenu);
            this.MainMenuStrip = this.backMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAnalyCDStock";
            this.Text = "Analyse CD Stock";
            this.Load += new System.EventHandler(this.frmAnalyCDStock_Load);
            this.grpStockAnalysis.ResumeLayout(false);
            this.grpStockAnalysis.PerformLayout();
            this.backMenu.ResumeLayout(false);
            this.backMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdanalyStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderItemsStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitAnalyseCDStock;
        private System.Windows.Forms.GroupBox grpStockAnalysis;
        private System.Windows.Forms.CheckedListBox chkOrderAnalysis;
        private System.Windows.Forms.Label lblDisplayCDAnalysis;
        private System.Windows.Forms.MenuStrip backMenu;
        private System.Windows.Forms.ToolStripMenuItem backM;
        private System.Windows.Forms.DataGridView grdanalyStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockArtistLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOrdID;
        private System.Windows.Forms.DataGridView grdOrderItemsStock;
        private System.Windows.Forms.Button btnAnalyseStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsOrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsCD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsUnit_Cost;
    }
}