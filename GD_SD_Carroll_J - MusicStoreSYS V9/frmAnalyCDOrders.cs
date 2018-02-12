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

        private void frmAnalyCDSales_Load(object sender, EventArgs e)
        {
            grdanalyseCDOrders.Rows.Add("00001", "+", "Ed Sheeran", "2011", "Warner Bros", "€6.00", "40", "a","8000","019320");
            grdanalyseCDOrders.Rows.Add("00002", "Made in the AM", "One Direction", "2015", "Sony", "€5.80", "20", "a", "8002", "019330");
            grdanalyseCDOrders.Rows.Add("00003", "1989", "Taylor Swift", "2014", "Universal", "€7.90", "60", "a", "8003", "019340");

            grdOrders.Rows.Add("01932","200","€12.50","2910","00001");
            grdOrders.Rows.Add("01933", "500", "€12.00", "2400", "00002");
            grdOrders.Rows.Add("01934", "750", "€11.40", "2872", "00003");

            grdOrd.Rows.Add("2910", "19/12/2017", "€32.50", "A", "001");
            grdOrd.Rows.Add("2400", "10/1/2018", "€45.00", "A", "003");
            grdOrd.Rows.Add("2872", "07/11/2017", "€64.40", "U", "002");

            DataSet ds = new DataSet();

            grdanalyseCDOrders.DataSource = getOrders(ds).Tables["ss"];


        }

        private void btnAnalyseOrders_Click(object sender, EventArgs e)
        {
            /*CD Details retrieved from CD File with orders made from CD in order
                        selected
                        Analyse Cd orders in order chosen*/


            MessageBox.Show("The following list will display the orders of CDs in the order of " + chkStockAnalysis.GetItemText(chkStockAnalysis.SelectedItem), "Analysing CD Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int i = 0; i < chkStockAnalysis.Items.Count; i++)
                chkStockAnalysis.SetItemChecked(i, false);
            return;

        }

        public static DataSet getOrders(DataSet ds)
        {




            return ds;
        }
    }
}
