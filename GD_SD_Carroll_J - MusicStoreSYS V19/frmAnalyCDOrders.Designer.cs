namespace MusicStoreSYS
{
    partial class frmAnalyCDOrders
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExitAnalyseCDSales = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bckMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chartOrders = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpChart = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrders)).BeginInit();
            this.grpChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitAnalyseCDSales
            // 
            this.btnExitAnalyseCDSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitAnalyseCDSales.Location = new System.Drawing.Point(1112, 0);
            this.btnExitAnalyseCDSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitAnalyseCDSales.Name = "btnExitAnalyseCDSales";
            this.btnExitAnalyseCDSales.Size = new System.Drawing.Size(87, 24);
            this.btnExitAnalyseCDSales.TabIndex = 16;
            this.btnExitAnalyseCDSales.Text = "Exit";
            this.btnExitAnalyseCDSales.UseVisualStyleBackColor = false;
            this.btnExitAnalyseCDSales.Click += new System.EventHandler(this.btnExitAnalyseCDSales_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bckMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bckMenu
            // 
            this.bckMenu.Name = "bckMenu";
            this.bckMenu.Size = new System.Drawing.Size(44, 20);
            this.bckMenu.Text = "Back";
            this.bckMenu.Click += new System.EventHandler(this.bckMenu_Click);
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.Location = new System.Drawing.Point(26, 53);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(62, 13);
            this.lblSuppID.TabIndex = 19;
            this.lblSuppID.Text = "Supplier ID:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 128);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Year:";
            // 
            // cboSupplier
            // 
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(106, 50);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(121, 21);
            this.cboSupplier.TabIndex = 21;
            this.cboSupplier.SelectedIndexChanged += new System.EventHandler(this.cboSupplier_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(106, 125);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 22;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // chartOrders
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOrders.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOrders.Legends.Add(legend1);
            this.chartOrders.Location = new System.Drawing.Point(0, 45);
            this.chartOrders.Name = "chartOrders";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cost";
            this.chartOrders.Series.Add(series1);
            this.chartOrders.Size = new System.Drawing.Size(384, 190);
            this.chartOrders.TabIndex = 24;
            this.chartOrders.Text = "Monthly CD Supplier Orders";
            this.chartOrders.Click += new System.EventHandler(this.chartOrders_Click);
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chartOrders);
            this.grpChart.Location = new System.Drawing.Point(29, 194);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(1139, 546);
            this.grpChart.TabIndex = 25;
            this.grpChart.TabStop = false;
            this.grpChart.Text = "Supplier Order Chart";
            this.grpChart.Visible = false;
            // 
            // frmAnalyCDOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 745);
            this.Controls.Add(this.grpChart);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSuppID);
            this.Controls.Add(this.btnExitAnalyseCDSales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyCDOrders";
            this.Text = "Analyse CD Orders";
            this.Load += new System.EventHandler(this.frmAnalyCDOrders_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrders)).EndInit();
            this.grpChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExitAnalyseCDSales;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bckMenu;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrders;
        private System.Windows.Forms.GroupBox grpChart;
    }
}