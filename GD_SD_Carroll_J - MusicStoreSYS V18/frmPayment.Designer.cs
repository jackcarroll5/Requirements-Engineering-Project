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
            this.btnAcceptSupp = new System.Windows.Forms.Button();
            this.cboOrderID = new System.Windows.Forms.ComboBox();
            this.lblChooseOrderID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.mthPaymentDate = new System.Windows.Forms.MonthCalendar();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpPreOrderCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderCD
            // 
            this.lblOrderCD.AutoSize = true;
            this.lblOrderCD.Location = new System.Drawing.Point(5, 218);
            this.lblOrderCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderCD.Name = "lblOrderCD";
            this.lblOrderCD.Size = new System.Drawing.Size(233, 13);
            this.lblOrderCD.TabIndex = 0;
            this.lblOrderCD.Text = "Please select the Supplier who is ordering a CD:";
            // 
            // cboPaymentCD
            // 
            this.cboPaymentCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentCD.FormattingEnabled = true;
            this.cboPaymentCD.Location = new System.Drawing.Point(8, 259);
            this.cboPaymentCD.Margin = new System.Windows.Forms.Padding(2);
            this.cboPaymentCD.Name = "cboPaymentCD";
            this.cboPaymentCD.Size = new System.Drawing.Size(150, 21);
            this.cboPaymentCD.TabIndex = 1;
            this.cboPaymentCD.SelectedIndexChanged += new System.EventHandler(this.cboOrderCD_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpPreOrderCD
            // 
            this.grpPreOrderCD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpPreOrderCD.Controls.Add(this.btnAcceptSupp);
            this.grpPreOrderCD.Controls.Add(this.cboOrderID);
            this.grpPreOrderCD.Controls.Add(this.lblChooseOrderID);
            this.grpPreOrderCD.Controls.Add(this.label2);
            this.grpPreOrderCD.Controls.Add(this.txtOrderID);
            this.grpPreOrderCD.Controls.Add(this.label1);
            this.grpPreOrderCD.Controls.Add(this.txtPaymentID);
            this.grpPreOrderCD.Controls.Add(this.lblDate);
            this.grpPreOrderCD.Controls.Add(this.mthPaymentDate);
            this.grpPreOrderCD.Controls.Add(this.lblAmount);
            this.grpPreOrderCD.Controls.Add(this.txtAmount);
            this.grpPreOrderCD.Controls.Add(this.cboPaymentCD);
            this.grpPreOrderCD.Controls.Add(this.lblOrderCD);
            this.grpPreOrderCD.Location = new System.Drawing.Point(0, 42);
            this.grpPreOrderCD.Name = "grpPreOrderCD";
            this.grpPreOrderCD.Size = new System.Drawing.Size(406, 722);
            this.grpPreOrderCD.TabIndex = 3;
            this.grpPreOrderCD.TabStop = false;
            this.grpPreOrderCD.Text = "PreOrder CD";
            // 
            // btnAcceptSupp
            // 
            this.btnAcceptSupp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAcceptSupp.Location = new System.Drawing.Point(134, 660);
            this.btnAcceptSupp.Name = "btnAcceptSupp";
            this.btnAcceptSupp.Size = new System.Drawing.Size(135, 38);
            this.btnAcceptSupp.TabIndex = 4;
            this.btnAcceptSupp.Text = "Accept Payment";
            this.btnAcceptSupp.UseVisualStyleBackColor = true;
            this.btnAcceptSupp.Click += new System.EventHandler(this.btnAcceptSupp_Click);
            // 
            // cboOrderID
            // 
            this.cboOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderID.FormattingEnabled = true;
            this.cboOrderID.Location = new System.Drawing.Point(99, 92);
            this.cboOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.cboOrderID.Name = "cboOrderID";
            this.cboOrderID.Size = new System.Drawing.Size(302, 21);
            this.cboOrderID.TabIndex = 14;
            this.cboOrderID.SelectedIndexChanged += new System.EventHandler(this.cboOrderID_SelectedIndexChanged);
            // 
            // lblChooseOrderID
            // 
            this.lblChooseOrderID.AutoSize = true;
            this.lblChooseOrderID.Location = new System.Drawing.Point(10, 94);
            this.lblChooseOrderID.Name = "lblChooseOrderID";
            this.lblChooseOrderID.Size = new System.Drawing.Size(84, 13);
            this.lblChooseOrderID.TabIndex = 13;
            this.lblChooseOrderID.Text = "Choose OrderId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "OrderID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(52, 164);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PaymentID:";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Enabled = false;
            this.txtPaymentID.Location = new System.Drawing.Point(76, 37);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentID.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 402);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Pay Date:";
            // 
            // mthPaymentDate
            // 
            this.mthPaymentDate.Location = new System.Drawing.Point(73, 402);
            this.mthPaymentDate.Name = "mthPaymentDate";
            this.mthPaymentDate.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(5, 327);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(72, 327);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(310, 0);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(102, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 741);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grpPreOrderCD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayment";
            this.Text = "Payment Confirmation";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPreOrderCD.ResumeLayout(false);
            this.grpPreOrderCD.PerformLayout();
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar mthPaymentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cboOrderID;
        private System.Windows.Forms.Label lblChooseOrderID;
        private System.Windows.Forms.Button btnQuit;
    }
}