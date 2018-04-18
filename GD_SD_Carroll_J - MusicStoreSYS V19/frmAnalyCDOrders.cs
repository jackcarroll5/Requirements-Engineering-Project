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
    public partial class frmAnalyCDOrders : Form
    {
        frmMainMenu parent;

        public frmAnalyCDOrders analyCDSales;

        public frmAnalyCDOrders(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        

        private void btnExitAnalyseCDSales_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void grpSalesAnalysis_Enter(object sender, EventArgs e)
        {
           

        }

      

        private void bckMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }


        public static DataSet getOrders(DataSet ds)
        {




            return ds;
        }

        private void chartOrders_Click(object sender, EventArgs e)
        {

        }

        private void frmAnalyCDOrders_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DS = Supplier.getAllActiveSuppliers(DS);

            cboSupplier.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboSupplier.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

            loadYears();

            DS = new DataSet();

            /*
            DS = Order.getYear(DS);

            cboYear.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboYear.Items.Add(DS.Tables[0].Rows[i][0].ToString());
            */

            //define chart
            defineChart();

            //Define the chart series
            defineSeries();

           
        }


        private void defineChart()
        {
            //define chart
            chartOrders.Size = new Size(1000, 500);
            chartOrders.ChartAreas[0].Name = "mainArea";
            chartOrders.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartOrders.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chartOrders.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chartOrders.ChartAreas["mainArea"].AxisY.Interval = 100;
            chartOrders.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chartOrders.ChartAreas["mainArea"].AxisX.Interval = 1;
            chartOrders.ChartAreas["mainArea"].AxisX.Title = "Month";

            chartOrders.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            chartOrders.Titles.Add("Selected Supplier Orders Cost");
        }

        private void defineSeries()
        {
            chartOrders.Series.Clear();
            chartOrders.Series.Add("Order Payments");

            chartOrders.Series["Order Payments"].ChartType = SeriesChartType.Column;
            chartOrders.Series["Order Payments"].XValueType = ChartValueType.String;
        }

        private void fillChart()
        {
            //fill chart
            chartOrders.Series["Order Payments"].Points.Clear();

            //load values returned from query into 12 element array
            //decimal[] monthlyRev = { 0, 1200, 800, 1000, 1500, 1700, 2500, 2200, 1500, 1000, 500, 0 };

            //add values in array to chart series
            //for (int i = 0; i < 12; i++)
            //chtData.Series["Revenue"].Points.AddXY(monthName(i + 1), monthlyRev[i]);

            //get data from database
            DataSet ds = new DataSet();
            ds = Order.getOrderData(Convert.ToInt32(cboSupplier.Text.Substring(0,3)),cboYear.Text.Substring(2,2),ds);

           //chartOrders.DataSource = getOrders(ds).Tables["ss"];

            //add values in array to chart series
            int j = 0;
            int i = 1;
            while(i<=12) 
            {

                if (!(j < ds.Tables[0].Rows.Count))
                { 
                    MessageBox.Show("The selected year could not be found! Please select another year!", "Year Data Missing Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                
                if (i < Convert.ToDecimal(ds.Tables[0].Rows[j][0]))
                    chartOrders.Series["Order Payments"].Points.AddXY(monthName(i), 0);
                else
                {
                    chartOrders.Series["Order Payments"].Points.AddXY(monthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
                i++;


            }

            chartOrders.Visible = true;
            grpChart.Visible = true;

            /*
            for (int i = 1; i <= 12; i++)
            {
                if (i < Convert.ToDecimal(ds.Tables[0].Rows[j][0]))
                    chartOrders.Series["Order Payments"].Points.AddXY(monthName(i), 0);
                else
                {
                    chartOrders.Series["Order Payments"].Points.AddXY(monthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
            }
            */


        }


        /*private void fillInChart()
        {

            //set up chart 
            chartOrders.ChartAreas["Revenue"].AxisY.Minimum = 0;
            chartOrders.ChartAreas["Revenue"].AxisY.Maximum = 1000;
            chartOrders.ChartAreas["Revenue"].AxisY.Interval = 100;

            chartOrders.Series["Income"].Points.Clear();
            chartOrders.Series["Income"]["PixelPointWidth"] = "50";

            //get data from the database
            //invoke a static method getMonthlyRevenue which returns a dataset
            //preferably with 12 records (months 0 - 12) even if a month has zero income



            DataSet ds = new DataSet();
            ds = Order.getOrderData(Convert.ToInt32(cboSupplier.Text.Substring(0, 3)), cboYear.Text.Substring(2, 2), ds);
            decimal val = 0;
            int i = 1;
            int j = ds.Tables["ss"].Rows.Count - 1;

            //For each summary row in ds
            while (i <= 12 && j <= ds.Tables["ss"].Rows.Count)
            {
                MessageBox.Show("i" + " ");

                if (i < Convert.ToInt32(ds.Tables[0].Rows[j][0].ToString()))
                {
                    chartOrders.Series["Income"].Points.AddXY(monthName(i), 0);
                }
                else if (i == Convert.ToInt32(ds.Tables[0].Rows[j][0].ToString()))
                {
                    chartOrders.Series["Income"].Points.AddXY(monthName(i), ds.Tables[0].Rows[j][1].ToString());
                    j++;
                }
                i++;
            }
        }*/

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

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            //fill Chart
            fillChart();

        }

        public void loadYears()
        {
            int year = 2018;
            cboYear.Items.Add(year.ToString());
            cboYear.Items.Add((year - 1).ToString());
            cboYear.Items.Add((year - 2).ToString());
            cboYear.Items.Add((year - 3).ToString());
        }
    }
}
