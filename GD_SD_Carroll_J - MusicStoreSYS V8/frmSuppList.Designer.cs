namespace MusicStoreSYS
{
    partial class frmSuppList
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
            this.btnSuppListExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.radName = new System.Windows.Forms.RadioButton();
            this.radID = new System.Windows.Forms.RadioButton();
            this.grdSuppliers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppListExit
            // 
            this.btnSuppListExit.Location = new System.Drawing.Point(1076, 0);
            this.btnSuppListExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuppListExit.Name = "btnSuppListExit";
            this.btnSuppListExit.Size = new System.Drawing.Size(176, 37);
            this.btnSuppListExit.TabIndex = 4;
            this.btnSuppListExit.Text = "Quit";
            this.btnSuppListExit.UseVisualStyleBackColor = true;
            this.btnSuppListExit.Click += new System.EventHandler(this.btnSuppListExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1252, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(52, 24);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radName);
            this.grpOrder.Controls.Add(this.radID);
            this.grpOrder.Location = new System.Drawing.Point(45, 52);
            this.grpOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrder.Size = new System.Drawing.Size(508, 69);
            this.grpOrder.TabIndex = 6;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Select Order";
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(203, 25);
            this.radName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(122, 21);
            this.radName.TabIndex = 1;
            this.radName.Text = "Supplier Name";
            this.radName.UseVisualStyleBackColor = true;
            // 
            // radID
            // 
            this.radID.AutoSize = true;
            this.radID.Checked = true;
            this.radID.Location = new System.Drawing.Point(21, 23);
            this.radID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(98, 21);
            this.radID.TabIndex = 0;
            this.radID.TabStop = true;
            this.radID.Text = "Supplier ID";
            this.radID.UseVisualStyleBackColor = true;
            // 
            // grdSuppliers
            // 
            this.grdSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SuppName,
            this.Phone,
            this.Email,
            this.Street,
            this.Town,
            this.County,
            this.AccountBal,
            this.Status});
            this.grdSuppliers.Location = new System.Drawing.Point(0, 178);
            this.grdSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdSuppliers.Name = "grdSuppliers";
            this.grdSuppliers.Size = new System.Drawing.Size(1252, 170);
            this.grdSuppliers.TabIndex = 7;
            this.grdSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSuppliers_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "SuppID";
            this.ID.Name = "ID";
            // 
            // SuppName
            // 
            this.SuppName.HeaderText = "Name";
            this.SuppName.Name = "SuppName";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            // 
            // Town
            // 
            this.Town.HeaderText = "Town";
            this.Town.Name = "Town";
            // 
            // County
            // 
            this.County.HeaderText = "County";
            this.County.Name = "County";
            // 
            // AccountBal
            // 
            this.AccountBal.HeaderText = "Account Bal";
            this.AccountBal.Name = "AccountBal";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // frmSuppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 591);
            this.Controls.Add(this.grdSuppliers);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnSuppListExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSuppList";
            this.Text = "List of Suppliers";
            this.Load += new System.EventHandler(this.frmSuppList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSuppListExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenu;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radID;
        private System.Windows.Forms.DataGridView grdSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}