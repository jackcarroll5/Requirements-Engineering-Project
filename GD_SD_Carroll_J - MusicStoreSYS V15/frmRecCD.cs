using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStoreSYS
{
    public partial class frmRecCD : Form
    {
        frmMainMenu parent;

        public frmRecCD recCD;

        DataSet DS;
        String status;

        public frmRecCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblDelivery_Click(object sender, EventArgs e)
        {

        }

        private void btnExitRecOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*Retrieve CD Details from CD File*/


            /*Retrieve Order details from Order File and OrderItems File*/


        private void btnSelSupplier_Click(object sender, EventArgs e)
        {
            CD cdQty = new CD();
          

              /*Retrieve Supplier Details from Supplier File, Cd Details from the CD File
                 * Order details from the Order File and Orderitems File*/


            DialogResult dr = MessageBox.Show("Are you sure you want to proceed with this order for \n" + cboSuppliersPreOrder.GetItemText(cboSuppliersPreOrder.SelectedItem)  + "?", 
                "Confirm Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
            /*Confirm CDs that Supplier chose are the ones going to be delivered.*/


            if (dr == DialogResult.Yes)
            {

                status = "Received";

                Order order = new Order();

                order.setStatus(status);

                Order.receiveOrder(Convert.ToInt32(cboCDChoice.Text.Substring(0,4)));



                cdQty.increaseQty();


                MessageBox.Show("The chosen CDs will be delivered to the chosen Supplier in a few days \nThe CDs are going to be Received", "CD Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSuppliersPreOrder.SelectedIndex = -1;
                cboCDChoice.SelectedIndex = -1;
                txtSuppID.Clear();
                loadSuppItems();

                this.grdSuppOrderItems.DataSource = null;
                this.grdSuppOrderItems.Rows.Clear();
                this.grdSuppOrderItems.Refresh();

                return;
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("The chosen CDs will not be delivered to the chosen Supplier \nThe Cd will not be received", "CD not Delivered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSuppliersPreOrder.SelectedIndex = -1;
                cboCDChoice.SelectedIndex = -1;
                txtSuppID.Clear();
                loadSuppItems();

                this.grdSuppOrderItems.DataSource = null;
                this.grdSuppOrderItems.Rows.Clear();
                this.grdSuppOrderItems.Refresh();

                return;
            }        
        }

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        public void loadSuppItems()
        {
            DS = new DataSet();
            DS = Supplier.getAllActiveSuppliers(DS);

            cboSuppliersPreOrder.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboSuppliersPreOrder.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

        }

       
        private void cboSuppliersPreOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSuppliersPreOrder.SelectedIndex == -1)
            {
                return;
            }

            Supplier suppOrd = new Supplier();

            //preOrdCD.getCD(Convert.ToInt32(cbopreordCD.Text.Substring(0, 3)));

            suppOrd.getSupp(Convert.ToInt32(cboSuppliersPreOrder.Text.Substring(0, 3)));

            if (suppOrd.getSuppID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cboSuppliersPreOrder.SelectedItem = suppOrd.getSuppID().ToString("000");

            txtSuppID.Text = cboSuppliersPreOrder.Text.Substring(0, 3);



            Order suppOrder = new Order();
      
            DS = new DataSet();
            DS = Order.getSuppOrders(DS,Convert.ToInt32(txtSuppID.Text));

            cboCDChoice.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)

                cboCDChoice.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " + String.Format("{0:dd-MMM-yy}",DS.Tables[0].Rows[i][1]) + " " + DS.Tables[0].Rows[i][2].ToString() + " " + DS.Tables[0].Rows[i][3].ToString());

        }

        private void frmRecCD_Load(object sender, EventArgs e)
        {
            loadSuppItems();
           
        }

        private void cboCDChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCDChoice.SelectedIndex == -1)
            {
                return;
            }

            Order ord = new Order();

            //preOrdCD.getCD(Convert.ToInt32(cbopreordCD.Text.Substring(0, 3)));

            ord.getOrd(Convert.ToInt32(cboCDChoice.Text.Substring(0, 4)));


            if (ord.getOrderID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txtOrderID.Text = cboCDChoice.Text.Substring(0, 4);

            cboCDChoice.SelectedItem = ord.getOrderID().ToString("0000");

            
            DS = new DataSet();
            DS = OrderItems.getSuppOrdItems(DS, Convert.ToInt32(txtOrderID.Text));
               
            grdSuppOrderItems.DataSource = getSuppCDOrderItems(DS).Tables["ss"];

            /*  cboCDChoice.Items.Clear();
              for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
            cboCDChoice.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString() + " " + 
            DS.Tables[0].Rows[i][2].ToString() + " " + DS.Tables[0].Rows[i][3].ToString());*/

        }

        public static DataSet getSuppCDOrderItems(DataSet ds)
        {
            return ds;
        }

        private void grdSuppOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
