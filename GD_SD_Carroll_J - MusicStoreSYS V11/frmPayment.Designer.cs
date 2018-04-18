namespace MusicStoreSYS
{
    partial class frmPayment
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
            this.lblOrderCD = new System.Windows.Forms.Label();
            this.cboPaymentCD = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPreOrderCD = new System.Windows.Forms.GroupBox();
            this.grdPayment = new System.Windows.Forms.DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.mthPaymentDate = new System.Windows.Forms.MonthCalendar();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAcceptSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblChooseOrderID = new System.Windows.Forms.Label();
            this.cboOrderID = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpPreOrderCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderCD
            // 
            this.lblOrderCD.AutoSize = true;
            this.lblOrderCD.Location = new System.Drawing.Point(7, 268);
            this.lblOrderCD.Name = "lblOrderCD";
            this.lblOrderCD.Size = new System.Drawing.Size(311, 17);
            this.lblOrderCD.TabIndex = 0;
            this.lblOrderCD.Text = "Please select the Supplier who is ordering a CD:";
            // 
            // cboPaymentCD
            // 
            this.cboPaymentCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentCD.FormattingEnabled = true;
            this.cboPaymentCD.Location = new System.Drawing.Point(11, 319);
            this.cboPaymentCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPaymentCD.Name = "cboPaymentCD";
            this.cboPaymentCD.Size = new System.Drawing.Size(199, 24);
            this.cboPaymentCD.TabIndex = 1;
            this.cboPaymentCD.SelectedIndexChanged += new System.EventHandler(this.cboOrderCD_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(773, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpPreOrderCD
            // 
            this.grpPreOrderCD.Controls.Add(this.cboOrderID);
            this.grpPreOrderCD.Controls.Add(this.lblChooseOrderID);
            this.grpPreOrderCD.Controls.Add(this.label2);
            this.grpPreOrderCD.Controls.Add(this.txtOrderID);
            this.grpPreOrderCD.Controls.Add(this.label1);
            this.grpPreOrderCD.Controls.Add(this.txtPaymentID);
            this.grpPreOrderCD.Controls.Add(this.grdPayment);
            this.grpPreOrderCD.Controls.Add(this.lblDate);
            this.grpPreOrderCD.Controls.Add(this.mthPaymentDate);
            this.grpPreOrderCD.Controls.Add(this.lblAmount);
            this.grpPreOrderCD.Controls.Add(this.txtAmount);
            this.grpPreOrderCD.Controls.Add(this.cboPaymentCD);
            this.grpPreOrderCD.Controls.Add(this.lblOrderCD);
            this.grpPreOrderCD.Location = new System.Drawing.Point(0, 52);
            this.grpPreOrderCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPreOrderCD.Name = "grpPreOrderCD";
            this.grpPreOrderCD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPreOrderCD.Size = new System.Drawing.Size(773, 886);
            this.grpPreOrderCD.TabIndex = 3;
            this.grpPreOrderCD.TabStop = false;
            this.grpPreOrderCD.Text = "PreOrder CD";
            // 
            // grdPayment
            // 
            this.grdPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.SuppID,
            this.CDID,
            this.Amount,
            this.Date});
            this.grdPayment.Location = new System.Drawing.Point(12, 730);
            this.grdPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPayment.Name = "grdPayment";
            this.grdPayment.RowTemplate.Height = 24;
            this.grdPayment.Size = new System.Drawing.Size(543, 150);
            this.grdPayment.TabIndex = 5;
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "PaymentID";
            this.PaymentID.Name = "PaymentID";
            // 
            // SuppID
            // 
            this.SuppID.HeaderText = "SuppID";
            this.SuppID.Name = "SuppID";
            // 
            // CDID
            // 
            this.CDID.HeaderText = "CDID";
            this.CDID.Name = "CDID";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 495);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Pay Date:";
            // 
            // mthPaymentDate
            // 
            this.mthPaymentDate.Location = new System.Drawing.Point(97, 495);
            this.mthPaymentDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mthPaymentDate.Name = "mthPaymentDate";
            this.mthPaymentDate.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 403);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(96, 403);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // btnAcceptSupp
            // 
            this.btnAcceptSupp.Location = new System.Drawing.Point(227, 999);
            this.btnAcceptSupp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcceptSupp.Name = "btnAcceptSupp";
            this.btnAcceptSupp.Size = new System.Drawing.Size(296, 80);
            this.btnAcceptSupp.TabIndex = 4;
            this.btnAcceptSupp.Text = "Accept";
            this.btnAcceptSupp.UseVisualStyleBackColor = true;
            this.btnAcceptSupp.Click += new System.EventHandler(this.btnAcceptSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "PaymentID:";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Enabled = false;
            this.txtPaymentID.Location = new System.Drawing.Point(102, 45);
            this.txtPaymentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(132, 22);
            this.txtPaymentID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "OrderID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(70, 202);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(132, 22);
            this.txtOrderID.TabIndex = 10;
            // 
            // lblChooseOrderID
            // 
            this.lblChooseOrderID.AutoSize = true;
            this.lblChooseOrderID.Location = new System.Drawing.Point(13, 116);
            this.lblChooseOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseOrderID.Name = "lblChooseOrderID";
            this.lblChooseOrderID.Size = new System.Drawing.Size(112, 17);
            this.lblChooseOrderID.TabIndex = 13;
            this.lblChooseOrderID.Text = "Choose OrderId:";
            // 
            // cboOrderID
            // 
            this.cboOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderID.FormattingEnabled = true;
            this.cboOrderID.Location = new System.Drawing.Point(132, 113);
            this.cboOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOrderID.Name = "cboOrderID";
            this.cboOrderID.Size = new System.Drawing.Size(121, 24);
            this.cboOrderID.TabIndex = 14;
            this.cboOrderID.SelectedIndexChanged += new System.EventHandler(this.cboOrderID_SelectedIndexChanged);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 1055);
            this.Controls.Add(this.btnAcceptSupp);
            this.Controls.Add(this.grpPreOrderCD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayment";
            this.Text = "Payment Confirmation";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPreOrderCD.ResumeLayout(false);
            this.grpPreOrderCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderCD;
        private System.Windows.Forms.ComboBox cboPaymentCD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPreOrderCD;
        private System.Windows.Forms.Button btnAcceptSupp;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView grdPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar mthPaymentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cboOrderID;
        private System.Windows.Forms.Label lblChooseOrderID;
    }
}