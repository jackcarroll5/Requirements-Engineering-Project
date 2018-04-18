namespace MusicStoreSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegSupp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdSupp = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinueCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placePreorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseCDStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picCD = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCD)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.preorderToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.mnuExit});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(597, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegSupp,
            this.mnuUpdSupp,
            this.deRegisterSupplierToolStripMenuItem,
            this.supplierListToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // mnuRegSupp
            // 
            this.mnuRegSupp.Name = "mnuRegSupp";
            this.mnuRegSupp.Size = new System.Drawing.Size(181, 22);
            this.mnuRegSupp.Text = "Register Supplier";
            this.mnuRegSupp.Click += new System.EventHandler(this.mnuRegSupp_Click);
            // 
            // mnuUpdSupp
            // 
            this.mnuUpdSupp.Name = "mnuUpdSupp";
            this.mnuUpdSupp.Size = new System.Drawing.Size(181, 22);
            this.mnuUpdSupp.Text = "Update Supplier";
            this.mnuUpdSupp.Click += new System.EventHandler(this.mnuUpdSupp_Click);
            // 
            // deRegisterSupplierToolStripMenuItem
            // 
            this.deRegisterSupplierToolStripMenuItem.Name = "deRegisterSupplierToolStripMenuItem";
            this.deRegisterSupplierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deRegisterSupplierToolStripMenuItem.Text = "De-Register Supplier";
            this.deRegisterSupplierToolStripMenuItem.Click += new System.EventHandler(this.deRegisterSupplierToolStripMenuItem_Click);
            // 
            // supplierListToolStripMenuItem
            // 
            this.supplierListToolStripMenuItem.Name = "supplierListToolStripMenuItem";
            this.supplierListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.supplierListToolStripMenuItem.Text = "Supplier List";
            this.supplierListToolStripMenuItem.Click += new System.EventHandler(this.supplierListToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewCDToolStripMenuItem,
            this.updateCDToolStripMenuItem,
            this.discontinueCDToolStripMenuItem,
            this.queryCDsToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // insertNewCDToolStripMenuItem
            // 
            this.insertNewCDToolStripMenuItem.Name = "insertNewCDToolStripMenuItem";
            this.insertNewCDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.insertNewCDToolStripMenuItem.Text = "Insert New CD";
            this.insertNewCDToolStripMenuItem.Click += new System.EventHandler(this.insertNewCDToolStripMenuItem_Click);
            // 
            // updateCDToolStripMenuItem
            // 
            this.updateCDToolStripMenuItem.Name = "updateCDToolStripMenuItem";
            this.updateCDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updateCDToolStripMenuItem.Text = "Update CD";
            this.updateCDToolStripMenuItem.Click += new System.EventHandler(this.updateCDToolStripMenuItem_Click);
            // 
            // discontinueCDToolStripMenuItem
            // 
            this.discontinueCDToolStripMenuItem.Name = "discontinueCDToolStripMenuItem";
            this.discontinueCDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.discontinueCDToolStripMenuItem.Text = "Discontinue CD";
            this.discontinueCDToolStripMenuItem.Click += new System.EventHandler(this.discontinueCDToolStripMenuItem_Click);
            // 
            // queryCDsToolStripMenuItem
            // 
            this.queryCDsToolStripMenuItem.Name = "queryCDsToolStripMenuItem";
            this.queryCDsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.queryCDsToolStripMenuItem.Text = "Query CDs";
            this.queryCDsToolStripMenuItem.Click += new System.EventHandler(this.queryCDsToolStripMenuItem_Click);
            // 
            // preorderToolStripMenuItem
            // 
            this.preorderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placePreorderToolStripMenuItem,
            this.receiveOrderToolStripMenuItem,
            this.recordPaymentToolStripMenuItem});
            this.preorderToolStripMenuItem.Name = "preorderToolStripMenuItem";
            this.preorderToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.preorderToolStripMenuItem.Text = "Preorder";
            // 
            // placePreorderToolStripMenuItem
            // 
            this.placePreorderToolStripMenuItem.Name = "placePreorderToolStripMenuItem";
            this.placePreorderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.placePreorderToolStripMenuItem.Text = "Place Preorder";
            this.placePreorderToolStripMenuItem.Click += new System.EventHandler(this.placePreorderToolStripMenuItem_Click);
            // 
            // receiveOrderToolStripMenuItem
            // 
            this.receiveOrderToolStripMenuItem.Name = "receiveOrderToolStripMenuItem";
            this.receiveOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.receiveOrderToolStripMenuItem.Text = "Receive Order";
            this.receiveOrderToolStripMenuItem.Click += new System.EventHandler(this.receiveOrderToolStripMenuItem_Click);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyseToolStripMenuItem,
            this.analyseCDStockToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // analyseToolStripMenuItem
            // 
            this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
            this.analyseToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.analyseToolStripMenuItem.Text = "Analyse CD Orders";
            this.analyseToolStripMenuItem.Click += new System.EventHandler(this.analyseToolStripMenuItem_Click);
            // 
            // analyseCDStockToolStripMenuItem
            // 
            this.analyseCDStockToolStripMenuItem.Name = "analyseCDStockToolStripMenuItem";
            this.analyseCDStockToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.analyseCDStockToolStripMenuItem.Text = "Analyse CD Stock";
            this.analyseCDStockToolStripMenuItem.Click += new System.EventHandler(this.analyseCDStockToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // picCD
            // 
            this.picCD.Image = ((System.Drawing.Image)(resources.GetObject("picCD.Image")));
            this.picCD.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCD.InitialImage")));
            this.picCD.Location = new System.Drawing.Point(37, 62);
            this.picCD.Name = "picCD";
            this.picCD.Size = new System.Drawing.Size(503, 367);
            this.picCD.TabIndex = 1;
            this.picCD.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(-1, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(598, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to the Throwback CD Music Store! Please choose from the following options" +
    " above to navigate through the system.";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 429);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picCD);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegSupp;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdSupp;
        private System.Windows.Forms.ToolStripMenuItem deRegisterSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem insertNewCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinueCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placePreorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseCDStockToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCD;
        private System.Windows.Forms.Label lblWelcome;
    }
}