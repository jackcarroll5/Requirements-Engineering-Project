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
    public partial class frmQueryCD : Form
    {
        frmMainMenu parent;

        public frmSuppList suppList;

        DataSet ds;

        public frmQueryCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblQuerySupp_Click(object sender, EventArgs e)
        {

        }

        private void btnQueryCDExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCDID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following list will display the CDs in order of CDID", "Query CDs by CDID", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Show album list on screen in order of CDID



        }
      
        private void btnArtist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following list will display the CDs in order of Artist name", "Query CDs by Artist", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Show album list on screen in order of Artist Label




        }

        private void backMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmQueryCD_Load(object sender, EventArgs e)
        {        
            DataSet ds = new DataSet();
            ds = CD.getAllCDS1(ds);

            grdCD.DataSource = getCDS(ds).Tables["ss"];
        }

        private void radCDID_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CD.getAllCDsIDOrder(ds);

            grdCD.DataSource = getCDS(ds).Tables["ss"];

        }

        private void radArtLbl_CheckedChanged(object sender, EventArgs e)
        {
            /*CD Details retrieved from CD File with orders made from CD in order
                        selected
                        Analyse Cd orders in order chosen*/

            DataSet ds = new DataSet();
            ds = CD.getAllCDsOrderArtLabel(ds);

            grdCD.DataSource = getCDS(ds).Tables["ss"];

        }

        private string GetRadioButtonText(GroupBox grpOrderCD)
        {
            return grpOrderCD.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void grdCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string cdID = grdCD.Rows[grdCD.CurrentCell.RowIndex].Cells[0].Value.ToString();
            getCDS(Convert.ToInt32(cdID));*/
        }

        public static DataSet getCDS(DataSet ds)
        {




            return ds;
        }
    }
}
