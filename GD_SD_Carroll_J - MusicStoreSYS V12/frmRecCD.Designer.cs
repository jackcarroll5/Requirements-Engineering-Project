namespace MusicStoreSYS
{
    partial class frmRecCD
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
            this.cboSuppliersPreOrder = new System.Windows.Forms.ComboBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnSelSupplier = new System.Windows.Forms.Button();
            this.grpDeliverCD = new System.Windows.Forms.GroupBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblCDChoice = new System.Windows.Forms.Label();
            this.cboCDChoice = new System.Windows.Forms.ComboBox();
            this.btnExitRecOrder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDeliverCD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSuppliersPreOrder
            // 
            this.cboSuppliersPreOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppliersPreOrder.FormattingEnabled = true;
            this.cboSuppliersPreOrder.Location = new System.Drawing.Point(166, 33);
            this.cboSuppliersPreOrder.Name = "cboSuppliersPreOrder";
            this.cboSuppliersPreOrder.Size = new System.Drawing.Size(121, 21);
            this.cboSuppliersPreOrder.TabIndex = 1;
            this.cboSuppliersPreOrder.SelectedIndexChanged += new System.EventHandler(this.cboSuppliersPreOrder_SelectedIndexChanged);
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(6, 36);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(155, 13);
            this.lblDelivery.TabIndex = 2;
            this.lblDelivery.Text = "Select Supplier for CD Delivery:";
            this.lblDelivery.Click += new System.EventHandler(this.lblDelivery_Click);
            // 
            // btnSelSupplier
            // 
            this.btnSelSupplier.Location = new System.Drawing.Point(208, 536);
            this.btnSelSupplier.Name = "btnSelSupplier";
            this.btnSelSupplier.Size = new System.Drawing.Size(187, 31);
            this.btnSelSupplier.TabIndex = 3;
            this.btnSelSupplier.Text = "Prepare for Delivery";
            this.btnSelSupplier.UseVisualStyleBackColor = true;
            this.btnSelSupplier.Click += new System.EventHandler(this.btnSelSupplier_Click);
            // 
            // grpDeliverCD
            // 
            this.grpDeliverCD.Controls.Add(this.lstOrder);
            this.grpDeliverCD.Controls.Add(this.lblCDChoice);
            this.grpDeliverCD.Controls.Add(this.cboCDChoice);
            this.grpDeliverCD.Controls.Add(this.lblDelivery);
            this.grpDeliverCD.Controls.Add(this.cboSuppliersPreOrder);
            this.grpDeliverCD.Location = new System.Drawing.Point(25, 51);
            this.grpDeliverCD.Name = "grpDeliverCD";
            this.grpDeliverCD.Size = new System.Drawing.Size(535, 439);
            this.grpDeliverCD.TabIndex = 4;
            this.grpDeliverCD.TabStop = false;
            this.grpDeliverCD.Text = "Delivering CD for receiving pre-order";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(109, 313);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(315, 121);
            this.lstOrder.TabIndex = 5;
            // 
            // lblCDChoice
            // 
            this.lblCDChoice.AutoSize = true;
            this.lblCDChoice.Location = new System.Drawing.Point(6, 139);
            this.lblCDChoice.Name = "lblCDChoice";
            this.lblCDChoice.Size = new System.Drawing.Size(202, 13);
            this.lblCDChoice.TabIndex = 4;
            this.lblCDChoice.Text = "Select the order that you want to receive:";
            // 
            // cboCDChoice
            // 
            this.cboCDChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCDChoice.FormattingEnabled = true;
            this.cboCDChoice.Location = new System.Drawing.Point(222, 139);
            this.cboCDChoice.Name = "cboCDChoice";
            this.cboCDChoice.Size = new System.Drawing.Size(121, 21);
            this.cboCDChoice.TabIndex = 3;
            this.cboCDChoice.SelectedIndexChanged += new System.EventHandler(this.cboCDChoice_SelectedIndexChanged);
            // 
            // btnExitRecOrder
            // 
            this.btnExitRecOrder.Location = new System.Drawing.Point(525, 0);
            this.btnExitRecOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitRecOrder.Name = "btnExitRecOrder";
            this.btnExitRecOrder.Size = new System.Drawing.Size(87, 28);
            this.btnExitRecOrder.TabIndex = 21;
            this.btnExitRecOrder.Text = "Exit";
            this.btnExitRecOrder.UseVisualStyleBackColor = true;
            this.btnExitRecOrder.Click += new System.EventHandler(this.btnExitRecOrder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenuItem
            // 
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backMenuItem.Text = "Back";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // frmRecCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 567);
            this.Controls.Add(this.btnExitRecOrder);
            this.Controls.Add(this.grpDeliverCD);
            this.Controls.Add(this.btnSelSupplier);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRecCD";
            this.Text = "Receiving CD Order";
            this.Load += new System.EventHandler(this.frmRecCD_Load);
            this.grpDeliverCD.ResumeLayout(false);
            this.grpDeliverCD.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSuppliersPreOrder;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Button btnSelSupplier;
        private System.Windows.Forms.GroupBox grpDeliverCD;
        private System.Windows.Forms.Button btnExitRecOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.Label lblCDChoice;
        private System.Windows.Forms.ComboBox cboCDChoice;
        private System.Windows.Forms.ListBox lstOrder;
    }
}