using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicStoreSYS
{
    public partial class frmAnalyCDStock : Form
    {
        frmMainMenu parent;

        public frmAnalyCDStock analyCDStock;

        public frmAnalyCDStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExitAnalyseCDStock_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDisplayCDAnalysis_Click(object sender, EventArgs e)
        {

        }


        private void backM_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmAnalyCDStock_Load(object sender, EventArgs e)
        {


            //define chart
            defineChart();

            //Define the chart series
            defineSeries();

           

        }

      
        private void defineChart()
        {
            //define chart
            chartOrderItems.Size = new Size(1000, 500);
            chartOrderItems.ChartAreas[0].Name = "mainArea";
            chartOrderItems.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartOrderItems.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chartOrderItems.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chartOrderItems.ChartAreas["mainArea"].AxisY.Interval = 500;
            chartOrderItems.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chartOrderItems.ChartAreas["mainArea"].AxisX.Interval = 1;
            chartOrderItems.ChartAreas["mainArea"].AxisX.Title = "Month";

            chartOrderItems.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            chartOrderItems.Titles.Add("CD OrderItems");
        }

        private void defineSeries()
        {
            chartOrderItems.Series.Clear();
            chartOrderItems.Series.Add("Revenue");

            chartOrderItems.Series["Revenue"].ChartType = SeriesChartType.Column;
            chartOrderItems.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void fillChart()
        {
            //fill chart
            chartOrderItems.Series["Revenue"].Points.Clear();

            //load values returned from query into 12 element array
            //decimal[] monthlyRev = { 0, 1200, 800, 1000, 1500, 1700, 2500, 2200, 1500, 1000, 500, 0 };

            //add values in array to chart series
            //for (int i = 0; i < 12; i++)
            //chtData.Series["Revenue"].Points.AddXY(monthName(i + 1), monthlyRev[i]);

            //get data from database
            DataSet ds = new DataSet();
            //ds = Order.getOrderData(Convert.ToInt32(cboSupplier.Text.Substring(0,3)),cboYear.Text.Substring(2,2),ds);

           //chartOrders.DataSource = getOrders(ds).Tables["ss"];

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (i < Convert.ToDecimal(ds.Tables[0].Rows[j][1]))
                    chartOrderItems.Series["Revenue"].Points.AddXY(monthName(i), 0);
                else
                {
                    chartOrderItems.Series["Revenue"].Points.AddXY(monthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
            }

        }
        private string monthName(int MonthNo)
        {
            String strMonth = "";

            switch (MonthNo)
            {
                case 1:
                    strMonth = "JAN";
                    break;
                case 2:
                    strMonth = "FEB";
                    break;
                case 3:
                    strMonth = "MAR";
                    break;
                case 4:
                    strMonth = "APR";
                    break;
                case 5:
                    strMonth = "MAY";
                    break;
                case 6:
                    strMonth = "JUN";
                    break;
                case 7:
                    strMonth = "JUL";
                    break;
                case 8:
                    strMonth = "AUG";
                    break;
                case 9:
                    strMonth = "SEP";
                    break;
                case 10:
                    strMonth = "OCT";
                    break;
                case 11:
                    strMonth = "NOV";
                    break;
                case 12:
                    strMonth = "DEC";
                    break;
            }

            return strMonth;
        }

        public static DataSet getStock(DataSet ds)
        {




            return ds;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cboAnalyseOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill Chart
            fillChart();
        }
    }
}
