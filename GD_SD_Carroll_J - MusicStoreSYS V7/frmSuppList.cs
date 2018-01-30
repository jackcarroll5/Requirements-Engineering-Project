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
    public partial class frmSuppList : Form
    {
        frmMainMenu parent;

        public frmSuppList suppList;

        public frmSuppList(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;        
        }

        private void btnSuppListExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDispSuppID_Click(object sender, EventArgs e)
        {
            //Display list of Suppliers in SuppID Order

            

            MessageBox.Show("The following list will display the suppliers in order of SuppID", "List by SuppID Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDispSuppName_Click(object sender, EventArgs e)
        {
            //Display list of Suppliers in Supp Name order

            MessageBox.Show("The following list will display the suppliers in order of Supplier name", "List by SuppName Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmSuppList_Load(object sender, EventArgs e)
        {
            grdSuppliers.Rows.Add("001", "Jack Jones", "087 2451234", "jack@gmail.com", "The Mall", "Tralee", "Co.Kerry","€0.00", "A");
            grdSuppliers.Rows.Add("002", "Billy Kelly", "087 2451234","billy@gmail.com", "Bridge Street", "Newcastle West", "Co.Limerick", "€0.00", "A");
            grdSuppliers.Rows.Add("003", "Frank Lally", "087 2451234", "Frank@gmail.com", "The Square", "Mallow", "Co.Cork", "€0.00", "A");

            DataSet ds = new DataSet();

            grdSuppliers.DataSource = getSuppliers(ds).Tables["ss"];
        }

        private void grdSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static DataSet getSuppliers(DataSet ds)
        {




            return ds;
        }
    }
}
