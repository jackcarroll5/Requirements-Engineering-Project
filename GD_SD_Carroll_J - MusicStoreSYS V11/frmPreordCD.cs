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
    public partial class frmPreordCD : Form
    {
        frmMainMenu parent;

        public frmPreordCD preordCD;

        DataSet DS;
        Supplier suppID;
        CD cdid;

        string status = "Placed";

        public frmPreordCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExitPreOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loadSuppItems()
        {
            DS = new DataSet();
            DS = Supplier.getAllActiveSuppliers(DS);

            cboPreSupp.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboPreSupp.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

           /* suppID = new Supplier();

            int theSuppID = suppID.getSuppID();

            cboPreSupp.SelectedIndex = 0;

            while (!cboPreSupp.Text.Substring(0, 3).Equals(theSuppID.ToString("000")))
            {
                cboPreSupp.SelectedIndex++;
            }*/


        }

        private void loadCDItems()
        {
            DS = new DataSet();
            //DS = CD.getAllCDsSuppliedbySupp(DS);

            cdid = new CD();

            cbopreordCD.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cbopreordCD.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

            int theCDID = cdid.getCDID();

            cbopreordCD.SelectedIndex = 0;

            while (!cbopreordCD.Text.Substring(0, 5).Equals(theCDID.ToString("00000")))
            {
                cbopreordCD.SelectedIndex++;
            }

        }


        private void backItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void grpPreorderCD_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtCDID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbopreordCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopreordCD.SelectedIndex == -1)
            {
                return;
            }

            CD preOrdCD = new CD();

            //preOrdCD.getCD(Convert.ToInt32(cbopreordCD.Text.Substring(0, 3)));

            preOrdCD.getCD(Convert.ToInt32(cbopreordCD.Text.Substring(0, 5)));

            if (preOrdCD.getCDID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbopreordCD.SelectedItem = preOrdCD.getCDID().ToString("00000");

        }

        private void frmPreordCD_Load(object sender, EventArgs e)
        {
           txtOrderID.Text = Order.nextOrder().ToString("1000");
            txtOrdID.Text = OrderItems.nextOrd().ToString("10000");
            loadSuppItems();
        }

        private void dtpOrder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboPreSupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPreSupp.SelectedIndex == -1)
            {
                return;
            }

            //display Stock details
            // txtSuppID.Text = preSupplier.getSuppID().ToString("000");
            //display Stock details
            txtSuppID.Text = cboPreSupp.Text.Substring(0, 3);

            DataSet ds = new DataSet();
            ds = CD.getSuppCDs(ds,Convert.ToInt32(txtSuppID.Text));

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cbopreordCD.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(5, '0') + " " + ds.Tables[0].Rows[i][1].ToString().PadRight(30,' ') + " " + String.Format(ds.Tables[0].Rows[i][5].ToString(),"000.00"));


            Supplier preSupplier = new Supplier();

            preSupplier.getSupp(Convert.ToInt32(cboPreSupp.Text.Substring(0, 3)));

            if (preSupplier.getSuppID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                return;
            }

          


            grpPreorderCD.Visible = true;

        }

        private void btnConfirmCD_Click(object sender, EventArgs e)
        {
            // add item to shopping cart
            lstCart.Items.Add(cbopreordCD.Text.Substring(0, 5) + " " + cbopreordCD.Text.Substring(7, 30) + " " + txtQty.Text + " " + cbopreordCD.Text.Substring(39, 6));

            //Update Orcer value
            txtOrdValue.Text = (Convert.ToDouble(txtOrdValue.Text) + (Convert.ToInt32(txtQty.Text) * (Convert.ToDecimal(cbopreordCD.Text.Substring(39, 5)))).ToString("000.00"));

            //Confirm CD Preorder
            /*Retrieve all details of selected Supplier from Supplier File and 
             Retrieve all details of selected CD from CD File */

            /*
            DialogResult dr = MessageBox.Show("Are you sure you want to preorder this CD? \nOrdID: " + txtOrdID.Text + "\nCD: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) +
              "\nSupplier: " + cboPreSupp.GetItemText(cboPreSupp.SelectedItem), "Confirm Preorder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Order order = new Order();
                //Save Order Details in Order File

                order.setOrderID(Convert.ToInt32(txtOrderID.Text));
                order.setOrdDate(dtpOrder.Text);
                order.setOrdValue(Convert.ToDecimal(txtOrdValue.Text));
                order.setStatus(status);
                order.setSuppID(Convert.ToInt32(cboPreSupp.Text.Substring(0, 3)));

                order.placeOrder();

                MessageBox.Show("OrderID : " + txtOrderID.Text + "\nSuppID: " + suppID + "\nOrder Date: " + dtpOrder.Text + "\nOrder Value: \n€" + txtOrdValue.Text + "\nStatus: " +
                 status, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);



                OrderItems orderitem = new OrderItems();

                orderitem.setOrdID(Convert.ToInt32(txtOrdID.Text));
                orderitem.setCDID(Convert.ToInt32(cbopreordCD.Text.Substring(0, 5)));
                orderitem.setQty(Convert.ToInt32(txtQty.Text));
                orderitem.setUnitCost(Convert.ToDecimal(txtUnitCost.Text));

                orderitem.placeOrderItem();

                //Save Order item Details in OrderItems File
                MessageBox.Show("OrdID : " + txtOrdID.Text + "\nCDID: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) + "\nQty" + txtQty.Text
                    + "Unit Cost: " + txtUnitCost.Text, "OrderItems Details", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MessageBox.Show("This CD has now been ordered for the Supplier \nOrder ID: " + txtOrderID.Text + "\nCD: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) +
                    "\nOrder Date: " + dtpOrder.Text, "Cd Preordered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                txtOrderID.Text = Order.nextOrder().ToString("0000");
                loadSuppItems();
                txtOrdID.Text = OrderItems.nextOrd().ToString("00000");
                txtOrdValue.Clear();
                txtQty.Clear();
                txtUnitCost.Clear();
                cboPreSupp.SelectedIndex = -1;
                cbopreordCD.SelectedIndex = -1;
                return;



            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("This CD will not be preordered and placed for the Supplier", "Cd Preordered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtOrderID.Text = Order.nextOrder().ToString("0000");
                loadSuppItems();
                txtOrdID.Text = OrderItems.nextOrd().ToString("00000");
                txtOrdValue.Clear();
                txtQty.Clear();
                txtUnitCost.Clear();
                cboPreSupp.SelectedIndex = -1;
                cbopreordCD.SelectedIndex = -1;
                return;
            }
            */
        }
        
    }
}
