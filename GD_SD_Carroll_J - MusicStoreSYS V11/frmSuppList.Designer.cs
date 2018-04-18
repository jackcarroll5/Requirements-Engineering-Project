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
            this.menuStrip1.SuspendLayout();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppListExit
            // 
            this.btnSuppListExit.Location = new System.Drawing.Point(721, 0);
            this.btnSuppListExit.Name = "btnSuppListExit";
            this.btnSuppListExit.Size = new System.Drawing.Size(132, 23);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(44, 20);
            this.backMenu.Text = "Back";
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radName);
            this.grpOrder.Controls.Add(this.radID);
            this.grpOrder.Location = new System.Drawing.Point(34, 42);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(381, 56);
            this.grpOrder.TabIndex = 6;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Select Order";
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(152, 20);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(94, 17);
            this.radName.TabIndex = 1;
            this.radName.Text = "Supplier Name";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // radID
            // 
            this.radID.AutoSize = true;
            this.radID.Checked = true;
            this.radID.Location = new System.Drawing.Point(16, 19);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(77, 17);
            this.radID.TabIndex = 0;
            this.radID.TabStop = true;
            this.radID.Text = "Supplier ID";
            this.radID.UseVisualStyleBackColor = true;
            this.radID.CheckedChanged += new System.EventHandler(this.radID_CheckedChanged);
            // 
            // grdSuppliers
            // 
            this.grdSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSuppliers.Location = new System.Drawing.Point(0, 145);
            this.grdSuppliers.Name = "grdSuppliers";
            this.grdSuppliers.Size = new System.Drawing.Size(709, 138);
            this.grdSuppliers.TabIndex = 7;
            this.grdSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSuppliers_CellContentClick);
            // 
            // frmSuppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.grdSuppliers);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnSuppListExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}