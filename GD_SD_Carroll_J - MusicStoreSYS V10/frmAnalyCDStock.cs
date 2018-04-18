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


        private void chkOrderAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void backM_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmAnalyCDStock_Load(object sender, EventArgs e)
        {
            grdanalyStock.Rows.Add("00004", "X", "Ed Sheeran", "2014", "Warner Bros", "€8.60", "195", "a", "8008", "01933");
            grdanalyStock.Rows.Add("00006", "Harry Styles", "Harry Styles", "2017", "Sony", "€11.50", "130", "a", "8012", "01932");
            grdanalyStock.Rows.Add("00009", "Reputation", "Taylor Swift", "2017", "Universal", "€10.40", "205", "u", "8020", "01934");

            grdOrderItemsStock.Rows.Add("01932", "400", "€12.00", "1000", "00009");
            grdOrderItemsStock.Rows.Add("01933", "690", "€12.40", "1005", "00006");
            grdOrderItemsStock.Rows.Add("01934", "870", "€11.50", "1020", "00004");

            DataSet ds = new DataSet();

           grdanalyStock.DataSource = getStock(ds).Tables["ss"];
        }

        private void btnAnalyseStock_Click_1(object sender, EventArgs e)
        {
            /*CD Details retrieved from CD File in order
            selected
            Analyse Cd Stock in order chosen*/



            MessageBox.Show("The following list will display the CDs in the order of " + chkOrderAnalysis.SelectedItem, "Analysing CD Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //https://stackoverflow.com/questions/19010069/check-uncheck-all-items-in-checkboxlist-in-asp-net
            /*Unchecking item selected for the analysis of CDs*/

            for (int i = 0; i < chkOrderAnalysis.Items.Count; i++)
                chkOrderAnalysis.SetItemChecked(i, false);
            return;


        }

        private void grdanalyStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static DataSet getStock(DataSet ds)
        {




            return ds;
        }

    }
}
