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
           txtOrderID.Text = Order.nextOrder().ToString("0000");
            txtOrdID.Text = OrderItems.nextOrd().ToString("00000");
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
            {
                Font font1 = new Font(FontFamily.GenericMonospace.Name, 9);
                cbopreordCD.Font = font1;

                //testData = ds.Tables[0].Rows[i][0].ToString().PadLeft(5, '0')+" "+ ds.Tables[0].Rows[i][1].ToString().Trim().PadRight(30)+"X";
                //MessageBox.Show(testData);
                //cbopreordCD.Items.Add(testData);
                cbopreordCD.Items.Add(String.Format("{0:00000} {1,-30} {2,5}",ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][5].ToString()));

                //cbopreordCD.Items.Add(String.Format(ds.Tables[0].Rows[i][0].ToString().PadLeft(5, '0') + " " + ds.Tables[0].Rows[i][1].ToString().PadRight(30, ' ') + " " + String.Format(ds.Tables[0].Rows[i][5].ToString(), "000.00")));
            }

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
            String a, b, c;
            decimal sum = 0;
            // add item to shopping cart
            

            Font font1 = new Font(FontFamily.GenericMonospace.Name, 9);
            lstCart.Font = font1;

            //for(int i = 0; i < lstCart.Items.Count; i++){
            //foreach(var item in lstCart.SelectedIndices) { 
            //foreach(var item in lstCart.Items){

            txtOrdID.Text = OrderItems.nextOrd().ToString("00000");


            lstCart.Items.Add(cbopreordCD.Text.Substring(0, 5) + " " + cbopreordCD.Text.Substring(6, 30) + " " + txtQty.Text.PadLeft(2,'0') + "        €" + cbopreordCD.Text.Substring(37, 5));

            

            //Update Order value
            txtOrdValue.Text = (Convert.ToDecimal(txtOrdValue.Text) + (Convert.ToInt32(txtQty.Text) * Convert.ToDecimal(cbopreordCD.Text.Substring(37, 5)))).ToString();

            //txtOrdValue.Text = (Convert.ToDecimal(txtOrdValue.Text) + (Convert.ToInt32(txtQty.Text) * Convert.ToDecimal(cbopreordCD.Text.Substring(35, 5))).ToString("000.00"));

            

            //sum += Convert.ToDecimal(txtOrdValue.Text);
            //}

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Confirm CD Preorder
            /*Retrieve all details of selected Supplier from Supplier File and 
             Retrieve all details of selected CD from CD File */


            DialogResult dr = MessageBox.Show("Are you sure you want to preorder the CDs selected in the cart? \nOrder ID: " + txtOrderID.Text + 
              "\nSupplier: " + cboPreSupp.GetItemText(cboPreSupp.SelectedItem), "Confirm Preorder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if (dr == DialogResult.Yes)
                {
                    Order order = new Order();
                    //Save Order Details in Order File

                    order.setOrderID(Convert.ToInt32(txtOrderID.Text));
                    order.setOrdDate(dtpOrder.Value);
                    order.setOrdValue(Convert.ToDecimal(txtOrdValue.Text));
                    order.setStatus(status);
                    order.setSuppID(Convert.ToInt32(txtSuppID.Text.Substring(0, 3)));

                    order.placeOrder();

                    MessageBox.Show("OrderID : " + txtOrderID.Text + "\nSuppID: " + txtSuppID.Text + "\nOrder Date: " + dtpOrder.Text + "\nOrder Value: €" + txtOrdValue.Text + "\nStatus: " +
                     status, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);


                foreach(var item in lstCart.Items)
                //Placing orderitems in cart
                //Confirming orderitems
                {
                
                OrderItems orderitem = new OrderItems();

                orderitem.setOrdID(Convert.ToInt32(txtOrdID.Text));
                orderitem.setCDID(Convert.ToInt32(cbopreordCD.Text.Substring(0, 5)));
                orderitem.setQty(Convert.ToInt32(txtQty.Text));               
                orderitem.setUnitCost(Convert.ToDecimal(cbopreordCD.Text.Substring(37, 5)));

                orderitem.placeOrderItem();

                //Save Order item Details in OrderItems File
                MessageBox.Show("OrdID : " + txtOrdID.Text + "\nCDID: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) + "\nQty: " + txtQty.Text
                    + "\nUnit Cost: €" + cbopreordCD.Text.Substring(37, 5), "OrderItems Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtOrdID.Text = OrderItems.nextOrd().ToString("00000");
                }


                MessageBox.Show("This CD has now been ordered for the Supplier \nOrder ID: " + txtOrderID.Text + "\nCD: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) +
                        "\nOrder Date: " + dtpOrder.Text, "Cd Preordered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    txtOrderID.Text = Order.nextOrder().ToString("0000");
                    txtSuppID.Clear();
                    loadSuppItems();                 
                    txtOrdValue.Clear();
                    txtQty.Clear();
                    cboPreSupp.SelectedIndex = -1;
                    cbopreordCD.SelectedIndex = -1;
                   lstCart.Items.Clear();
                 
                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("This CD will not be preordered and placed for the Supplier", "Cd Preordered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSuppID.Clear();
                loadSuppItems();              
                    txtOrdValue.Clear();
                    txtQty.Clear();                
                    cboPreSupp.SelectedIndex = -1;
                    cbopreordCD.SelectedIndex = -1;
                }
                
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
