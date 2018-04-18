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
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnConfirmCD = new System.Windows.Forms.Button();
            this.lblPreorder = new System.Windows.Forms.Label();
            this.cbopreordCD = new System.Windows.Forms.ComboBox();
            this.lblSelSupp = new System.Windows.Forms.Label();
            this.cboPreSupp = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.txtOrdID = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblOrdID = new System.Windows.Forms.Label();
            this.lblOrdValue = new System.Windows.Forms.Label();
            this.txtOrdValue = new System.Windows.Forms.TextBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.grpPreorderCD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitPreOrder
            // 
            this.btnExitPreOrder.Location = new System.Drawing.Point(841, 0);
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
            this.grpPreorderCD.Controls.Add(this.label2);
            this.grpPreorderCD.Controls.Add(this.txtQty);
            this.grpPreorderCD.Controls.Add(this.btnConfirmCD);
            this.grpPreorderCD.Controls.Add(this.lblPreorder);
            this.grpPreorderCD.Controls.Add(this.cbopreordCD);
            this.grpPreorderCD.Location = new System.Drawing.Point(26, 282);
            this.grpPreorderCD.Name = "grpPreorderCD";
            this.grpPreorderCD.Size = new System.Drawing.Size(359, 213);
            this.grpPreorderCD.TabIndex = 17;
            this.grpPreorderCD.TabStop = false;
            this.grpPreorderCD.Text = "Order CD for Supplier";
            this.grpPreorderCD.Visible = false;
            this.grpPreorderCD.Enter += new System.EventHandler(this.grpPreorderCD_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Qty:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(62, 148);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 29;
            // 
            // btnConfirmCD
            // 
            this.btnConfirmCD.Location = new System.Drawing.Point(88, 184);
            this.btnConfirmCD.Name = "btnConfirmCD";
            this.btnConfirmCD.Size = new System.Drawing.Size(154, 29);
            this.btnConfirmCD.TabIndex = 18;
            this.btnConfirmCD.Text = "Add to cart";
            this.btnConfirmCD.UseVisualStyleBackColor = true;
            this.btnConfirmCD.Click += new System.EventHandler(this.btnConfirmCD_Click);
            // 
            // lblPreorder
            // 
            this.lblPreorder.AutoSize = true;
            this.lblPreorder.Location = new System.Drawing.Point(22, 25);
            this.lblPreorder.Name = "lblPreorder";
            this.lblPreorder.Size = new System.Drawing.Size(187, 13);
            this.lblPreorder.TabIndex = 24;
            this.lblPreorder.Text = "Choose CDs to be ordered by Supplier";
            // 
            // cbopreordCD
            // 
            this.cbopreordCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopreordCD.FormattingEnabled = true;
            this.cbopreordCD.Location = new System.Drawing.Point(5, 52);
            this.cbopreordCD.Margin = new System.Windows.Forms.Padding(2);
            this.cbopreordCD.Name = "cbopreordCD";
            this.cbopreordCD.Size = new System.Drawing.Size(329, 21);
            this.cbopreordCD.TabIndex = 23;
            this.cbopreordCD.SelectedIndexChanged += new System.EventHandler(this.cbopreordCD_SelectedIndexChanged);
            // 
            // lblSelSupp
            // 
            this.lblSelSupp.AutoSize = true;
            this.lblSelSupp.Location = new System.Drawing.Point(41, 89);
            this.lblSelSupp.Name = "lblSelSupp";
            this.lblSelSupp.Size = new System.Drawing.Size(263, 13);
            this.lblSelSupp.TabIndex = 19;
            this.lblSelSupp.Text = "Please select the Supplier who wants to preorder CDs:";
            // 
            // cboPreSupp
            // 
            this.cboPreSupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreSupp.FormattingEnabled = true;
            this.cboPreSupp.Location = new System.Drawing.Point(42, 116);
            this.cboPreSupp.Name = "cboPreSupp";
            this.cboPreSupp.Size = new System.Drawing.Size(196, 21);
            this.cboPreSupp.TabIndex = 20;
            this.cboPreSupp.SelectedIndexChanged += new System.EventHandler(this.cboPreSupp_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
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
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.Location = new System.Drawing.Point(98, 216);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(62, 13);
            this.lblSuppID.TabIndex = 25;
            this.lblSuppID.Text = "Supplier ID:";
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(167, 213);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(100, 20);
            this.txtSuppID.TabIndex = 24;
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.txtOrdID);
            this.grpCart.Controls.Add(this.btnCheckOut);
            this.grpCart.Controls.Add(this.lblOrdID);
            this.grpCart.Controls.Add(this.lblOrdValue);
            this.grpCart.Controls.Add(this.txtOrdValue);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Location = new System.Drawing.Point(407, 282);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(424, 286);
            this.grpCart.TabIndex = 26;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Order Details";
            // 
            // txtOrdID
            // 
            this.txtOrdID.Enabled = false;
            this.txtOrdID.Location = new System.Drawing.Point(72, 23);
            this.txtOrdID.Name = "txtOrdID";
            this.txtOrdID.Size = new System.Drawing.Size(100, 20);
            this.txtOrdID.TabIndex = 30;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(123, 257);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(216, 29);
            this.btnCheckOut.TabIndex = 30;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblOrdID
            // 
            this.lblOrdID.AutoSize = true;
            this.lblOrdID.Location = new System.Drawing.Point(16, 25);
            this.lblOrdID.Name = "lblOrdID";
            this.lblOrdID.Size = new System.Drawing.Size(38, 13);
            this.lblOrdID.TabIndex = 29;
            this.lblOrdID.Text = "Ord ID";
            // 
            // lblOrdValue
            // 
            this.lblOrdValue.AutoSize = true;
            this.lblOrdValue.Enabled = false;
            this.lblOrdValue.Location = new System.Drawing.Point(16, 215);
            this.lblOrdValue.Name = "lblOrdValue";
            this.lblOrdValue.Size = new System.Drawing.Size(66, 13);
            this.lblOrdValue.TabIndex = 29;
            this.lblOrdValue.Text = "Order Value:";
            // 
            // txtOrdValue
            // 
            this.txtOrdValue.Enabled = false;
            this.txtOrdValue.Location = new System.Drawing.Point(88, 212);
            this.txtOrdValue.Name = "txtOrdValue";
            this.txtOrdValue.Size = new System.Drawing.Size(76, 20);
            this.txtOrdValue.TabIndex = 28;
            this.txtOrdValue.Text = "0.00";
            this.txtOrdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(0, 73);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(418, 108);
            this.lstCart.TabIndex = 0;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(380, 49);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 28;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrder
            // 
            this.dtpOrder.Enabled = false;
            this.dtpOrder.Location = new System.Drawing.Point(459, 42);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(200, 20);
            this.dtpOrder.TabIndex = 27;
            // 
            // frmPreordCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.lblSuppID);
            this.Controls.Add(this.txtSuppID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.cboPreSupp);
            this.Controls.Add(this.lblSelSupp);
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
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
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
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblOrdValue;
        private System.Windows.Forms.TextBox txtOrdValue;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.TextBox txtOrdID;
        private System.Windows.Forms.Label lblOrdID;
    }
}