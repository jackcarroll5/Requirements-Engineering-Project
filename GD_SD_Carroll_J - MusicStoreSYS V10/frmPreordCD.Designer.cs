namespace MusicStoreSYS
{
    partial class frmPreordCD
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
            this.btnExitPreOrder = new System.Windows.Forms.Button();
            this.grpPreorderCD = new System.Windows.Forms.GroupBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.txtOrdID = new System.Windows.Forms.TextBox();
            this.lblPreorder = new System.Windows.Forms.Label();
            this.lblOrdID = new System.Windows.Forms.Label();
            this.cbopreordCD = new System.Windows.Forms.ComboBox();
            this.btnConfirmCD = new System.Windows.Forms.Button();
            this.lblSelSupp = new System.Windows.Forms.Label();
            this.cboPreSupp = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.grpPreorderCD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitPreOrder
            // 
            this.btnExitPreOrder.Location = new System.Drawing.Point(475, 24);
            this.btnExitPreOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitPreOrder.Name = "btnExitPreOrder";
            this.btnExitPreOrder.Size = new System.Drawing.Size(87, 28);
            this.btnExitPreOrder.TabIndex = 16;
            this.btnExitPreOrder.Text = "Exit";
            this.btnExitPreOrder.UseVisualStyleBackColor = true;
            this.btnExitPreOrder.Click += new System.EventHandler(this.btnExitPreOrder_Click);
            // 
            // grpPreorderCD
            // 
            this.grpPreorderCD.Controls.Add(this.lblOrderDate);
            this.grpPreorderCD.Controls.Add(this.dtpOrder);
            this.grpPreorderCD.Controls.Add(this.txtOrdID);
            this.grpPreorderCD.Controls.Add(this.lblPreorder);
            this.grpPreorderCD.Controls.Add(this.lblOrdID);
            this.grpPreorderCD.Controls.Add(this.cbopreordCD);
            this.grpPreorderCD.Location = new System.Drawing.Point(26, 192);
            this.grpPreorderCD.Name = "grpPreorderCD";
            this.grpPreorderCD.Size = new System.Drawing.Size(297, 213);
            this.grpPreorderCD.TabIndex = 17;
            this.grpPreorderCD.TabStop = false;
            this.grpPreorderCD.Text = "Order CD for Supplier";
            this.grpPreorderCD.Enter += new System.EventHandler(this.grpPreorderCD_Enter);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(6, 176);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 25;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(74, 176);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(200, 20);
            this.dtpOrder.TabIndex = 24;
            this.dtpOrder.ValueChanged += new System.EventHandler(this.dtpOrder_ValueChanged);
            // 
            // txtOrdID
            // 
            this.txtOrdID.Enabled = false;
            this.txtOrdID.Location = new System.Drawing.Point(62, 31);
            this.txtOrdID.Name = "txtOrdID";
            this.txtOrdID.Size = new System.Drawing.Size(100, 20);
            this.txtOrdID.TabIndex = 23;
            this.txtOrdID.TextChanged += new System.EventHandler(this.txtCDID_TextChanged);
            // 
            // lblPreorder
            // 
            this.lblPreorder.AutoSize = true;
            this.lblPreorder.Location = new System.Drawing.Point(6, 67);
            this.lblPreorder.Name = "lblPreorder";
            this.lblPreorder.Size = new System.Drawing.Size(187, 13);
            this.lblPreorder.TabIndex = 24;
            this.lblPreorder.Text = "Choose CDs to be ordered by Supplier";
            // 
            // lblOrdID
            // 
            this.lblOrdID.AutoSize = true;
            this.lblOrdID.Location = new System.Drawing.Point(6, 34);
            this.lblOrdID.Name = "lblOrdID";
            this.lblOrdID.Size = new System.Drawing.Size(38, 13);
            this.lblOrdID.TabIndex = 22;
            this.lblOrdID.Text = "Ord ID";
            // 
            // cbopreordCD
            // 
            this.cbopreordCD.FormattingEnabled = true;
            this.cbopreordCD.Location = new System.Drawing.Point(9, 102);
            this.cbopreordCD.Margin = new System.Windows.Forms.Padding(2);
            this.cbopreordCD.Name = "cbopreordCD";
            this.cbopreordCD.Size = new System.Drawing.Size(188, 21);
            this.cbopreordCD.TabIndex = 23;
            this.cbopreordCD.SelectedIndexChanged += new System.EventHandler(this.cbopreordCD_SelectedIndexChanged);
            // 
            // btnConfirmCD
            // 
            this.btnConfirmCD.Location = new System.Drawing.Point(138, 559);
            this.btnConfirmCD.Name = "btnConfirmCD";
            this.btnConfirmCD.Size = new System.Drawing.Size(258, 42);
            this.btnConfirmCD.TabIndex = 18;
            this.btnConfirmCD.Text = "Confirm Selection";
            this.btnConfirmCD.UseVisualStyleBackColor = true;
            this.btnConfirmCD.Click += new System.EventHandler(this.btnConfirmCD_Click);
            // 
            // lblSelSupp
            // 
            this.lblSelSupp.AutoSize = true;
            this.lblSelSupp.Location = new System.Drawing.Point(135, 97);
            this.lblSelSupp.Name = "lblSelSupp";
            this.lblSelSupp.Size = new System.Drawing.Size(263, 13);
            this.lblSelSupp.TabIndex = 19;
            this.lblSelSupp.Text = "Please select the Supplier who wants to preorder CDs:";
            // 
            // cboPreSupp
            // 
            this.cboPreSupp.FormattingEnabled = true;
            this.cboPreSupp.Location = new System.Drawing.Point(203, 131);
            this.cboPreSupp.Name = "cboPreSupp";
            this.cboPreSupp.Size = new System.Drawing.Size(121, 21);
            this.cboPreSupp.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backItem
            // 
            this.backItem.Name = "backItem";
            this.backItem.Size = new System.Drawing.Size(44, 20);
            this.backItem.Text = "Back";
            this.backItem.Click += new System.EventHandler(this.backItem_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(114, 42);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 22;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(45, 45);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 23;
            this.lblOrderID.Text = "Order ID:";
            // 
            // frmPreordCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 602);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.cboPreSupp);
            this.Controls.Add(this.lblSelSupp);
            this.Controls.Add(this.btnConfirmCD);
            this.Controls.Add(this.grpPreorderCD);
            this.Controls.Add(this.btnExitPreOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPreordCD";
            this.Text = "Preordering CDs";
            this.Load += new System.EventHandler(this.frmPreordCD_Load);
            this.grpPreorderCD.ResumeLayout(false);
            this.grpPreorderCD.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitPreOrder;
        private System.Windows.Forms.GroupBox grpPreorderCD;
        private System.Windows.Forms.Label lblPreorder;
        private System.Windows.Forms.ComboBox cbopreordCD;
        private System.Windows.Forms.Button btnConfirmCD;
        private System.Windows.Forms.Label lblSelSupp;
        private System.Windows.Forms.ComboBox cboPreSupp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backItem;
        private System.Windows.Forms.Label lblOrdID;
        private System.Windows.Forms.TextBox txtOrdID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label lblOrderDate;
    }
}