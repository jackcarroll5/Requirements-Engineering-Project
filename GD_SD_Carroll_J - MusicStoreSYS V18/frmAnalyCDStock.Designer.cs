﻿namespace MusicStoreSYS
{
    partial class frmAnalyCDStock
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
            this.btnExitAnalyseCDStock = new System.Windows.Forms.Button();
            this.backMenu = new System.Windows.Forms.MenuStrip();
            this.backM = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOrderItems = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboAnalyseOrderItems = new System.Windows.Forms.ComboBox();
            this.lblAnalyseOrderItems = new System.Windows.Forms.Label();
            this.backMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitAnalyseCDStock
            // 
            this.btnExitAnalyseCDStock.Location = new System.Drawing.Point(726, 0);
            this.btnExitAnalyseCDStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitAnalyseCDStock.Name = "btnExitAnalyseCDStock";
            this.btnExitAnalyseCDStock.Size = new System.Drawing.Size(87, 24);
            this.btnExitAnalyseCDStock.TabIndex = 16;
            this.btnExitAnalyseCDStock.Text = "Exit";
            this.btnExitAnalyseCDStock.UseVisualStyleBackColor = true;
            this.btnExitAnalyseCDStock.Click += new System.EventHandler(this.btnExitAnalyseCDStock_Click);
            // 
            // backMenu
            // 
            this.backMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.backMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backM});
            this.backMenu.Location = new System.Drawing.Point(0, 0);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(813, 24);
            this.backMenu.TabIndex = 19;
            this.backMenu.Text = "menuStrip1";
            // 
            // backM
            // 
            this.backM.Name = "backM";
            this.backM.Size = new System.Drawing.Size(44, 20);
            this.backM.Text = "Back";
            this.backM.Click += new System.EventHandler(this.backM_Click);
            // 
            // chartOrderItems
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOrderItems.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOrderItems.Legends.Add(legend1);
            this.chartOrderItems.Location = new System.Drawing.Point(107, 234);
            this.chartOrderItems.Name = "chartOrderItems";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Qty";
            this.chartOrderItems.Series.Add(series1);
            this.chartOrderItems.Size = new System.Drawing.Size(502, 300);
            this.chartOrderItems.TabIndex = 20;
            this.chartOrderItems.Text = "OrderItems Chart";
            this.chartOrderItems.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cboAnalyseOrderItems
            // 
            this.cboAnalyseOrderItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnalyseOrderItems.FormattingEnabled = true;
            this.cboAnalyseOrderItems.Location = new System.Drawing.Point(180, 56);
            this.cboAnalyseOrderItems.Name = "cboAnalyseOrderItems";
            this.cboAnalyseOrderItems.Size = new System.Drawing.Size(121, 21);
            this.cboAnalyseOrderItems.TabIndex = 21;
            this.cboAnalyseOrderItems.SelectedIndexChanged += new System.EventHandler(this.cboAnalyseOrderItems_SelectedIndexChanged);
            // 
            // lblAnalyseOrderItems
            // 
            this.lblAnalyseOrderItems.AutoSize = true;
            this.lblAnalyseOrderItems.Location = new System.Drawing.Point(81, 59);
            this.lblAnalyseOrderItems.Name = "lblAnalyseOrderItems";
            this.lblAnalyseOrderItems.Size = new System.Drawing.Size(72, 13);
            this.lblAnalyseOrderItems.TabIndex = 22;
            this.lblAnalyseOrderItems.Text = "Select CD_ID";
            // 
            // frmAnalyCDStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 654);
            this.Controls.Add(this.lblAnalyseOrderItems);
            this.Controls.Add(this.cboAnalyseOrderItems);
            this.Controls.Add(this.chartOrderItems);
            this.Controls.Add(this.btnExitAnalyseCDStock);
            this.Controls.Add(this.backMenu);
            this.MainMenuStrip = this.backMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyCDStock";
            this.Text = "Analyse CD Stock";
            this.Load += new System.EventHandler(this.frmAnalyCDStock_Load);
            this.backMenu.ResumeLayout(false);
            this.backMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitAnalyseCDStock;
        private System.Windows.Forms.MenuStrip backMenu;
        private System.Windows.Forms.ToolStripMenuItem backM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderItems;
        private System.Windows.Forms.ComboBox cboAnalyseOrderItems;
        private System.Windows.Forms.Label lblAnalyseOrderItems;
    }
}