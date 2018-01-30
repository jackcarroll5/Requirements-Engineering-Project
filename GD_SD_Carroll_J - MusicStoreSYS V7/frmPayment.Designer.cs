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
            this.lblDate = new System.Windows.Forms.Label();
            this.mthPaymentDate = new System.Windows.Forms.MonthCalendar();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.btnAcceptSupp = new System.Windows.Forms.Button();
            this.grdPayment = new System.Windows.Forms.DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpPreOrderCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderCD
            // 
            this.lblOrderCD.AutoSize = true;
            this.lblOrderCD.Location = new System.Drawing.Point(2, 123);
            this.lblOrderCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderCD.Name = "lblOrderCD";
            this.lblOrderCD.Size = new System.Drawing.Size(233, 13);
            this.lblOrderCD.TabIndex = 0;
            this.lblOrderCD.Text = "Please select the Supplier who is ordering a CD:";
            // 
            // cboPaymentCD
            // 
            this.cboPaymentCD.FormattingEnabled = true;
            this.cboPaymentCD.Items.AddRange(new object[] {
            "Jack Jones",
            "Billy Kelly",
            "Frank Lally",
            "John Adams",
            "Francis Flowers",
            "Sarah Kelly",
            "Niamh Walsh"});
            this.cboPaymentCD.Location = new System.Drawing.Point(5, 164);
            this.cboPaymentCD.Margin = new System.Windows.Forms.Padding(2);
            this.cboPaymentCD.Name = "cboPaymentCD";
            this.cboPaymentCD.Size = new System.Drawing.Size(150, 21);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
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
            this.grpPreOrderCD.Controls.Add(this.grdPayment);
            this.grpPreOrderCD.Controls.Add(this.lblDate);
            this.grpPreOrderCD.Controls.Add(this.mthPaymentDate);
            this.grpPreOrderCD.Controls.Add(this.lblPaymentID);
            this.grpPreOrderCD.Controls.Add(this.txtPaymentID);
            this.grpPreOrderCD.Controls.Add(this.cboPaymentCD);
            this.grpPreOrderCD.Controls.Add(this.lblOrderCD);
            this.grpPreOrderCD.Location = new System.Drawing.Point(0, 42);
            this.grpPreOrderCD.Name = "grpPreOrderCD";
            this.grpPreOrderCD.Size = new System.Drawing.Size(580, 720);
            this.grpPreOrderCD.TabIndex = 3;
            this.grpPreOrderCD.TabStop = false;
            this.grpPreOrderCD.Text = "PreOrder CD";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 272);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // mthPaymentDate
            // 
            this.mthPaymentDate.Location = new System.Drawing.Point(51, 272);
            this.mthPaymentDate.Name = "mthPaymentDate";
            this.mthPaymentDate.TabIndex = 6;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Location = new System.Drawing.Point(6, 33);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(62, 13);
            this.lblPaymentID.TabIndex = 3;
            this.lblPaymentID.Text = "PaymentID:";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Enabled = false;
            this.txtPaymentID.Location = new System.Drawing.Point(74, 30);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentID.TabIndex = 2;
            this.txtPaymentID.Text = "019320";
            // 
            // btnAcceptSupp
            // 
            this.btnAcceptSupp.Location = new System.Drawing.Point(170, 812);
            this.btnAcceptSupp.Name = "btnAcceptSupp";
            this.btnAcceptSupp.Size = new System.Drawing.Size(222, 65);
            this.btnAcceptSupp.TabIndex = 4;
            this.btnAcceptSupp.Text = "Accept";
            this.btnAcceptSupp.UseVisualStyleBackColor = true;
            this.btnAcceptSupp.Click += new System.EventHandler(this.btnAcceptSupp_Click);
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
            this.grdPayment.Location = new System.Drawing.Point(11, 478);
            this.grdPayment.Margin = new System.Windows.Forms.Padding(2);
            this.grdPayment.Name = "grdPayment";
            this.grdPayment.RowTemplate.Height = 24;
            this.grdPayment.Size = new System.Drawing.Size(407, 122);
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
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 879);
            this.Controls.Add(this.btnAcceptSupp);
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
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.DataGridView grdPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar mthPaymentDate;
    }
}