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

        public frmPreordCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExitPreOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmCD_Click(object sender, EventArgs e)
        {
           string suppID = "002";
                float ordValue = 13.45f;
                string cdid = "00004";
                int qty = 100;


            //Confirm CD Preorder
            /*Retrieve all details of selected Supplier from Supplier File and 
             Retrieve all details of selected CD from CD File */

            DialogResult dr =  MessageBox.Show("Are you sure you want to preorder this CD? \nOrdID: " + txtOrdID.Text +  "\nCD: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) + 
              "\nSupplier: " + cboPreSupp.GetItemText(cboPreSupp.SelectedItem), "Confirm Preorder", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {

                //Save Order Details in Order File
                

                MessageBox.Show("OrderID : " + txtOrderID.Text + "\nSuppID: " + suppID + "\nOrder Date: " + dtpOrder.Text + "\nOrder Value: \n€" + ordValue + "\nCD_ID: " + 
                 cdid,"Order Details",MessageBoxButtons.OK,MessageBoxIcon.Information);



                //Save Order item Details in OrderItems File
                MessageBox.Show("OrdID : " + txtOrdID.Text + "\nCDID: " + cdid + "\nQty" + qty,"OrderItems Details", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MessageBox.Show("This CD has now been ordered for the Supplier \nOrder ID: " + txtOrderID.Text + "\nCD: " + cbopreordCD.GetItemText(cbopreordCD.SelectedItem) + 
                    "\nOrder Date: " + dtpOrder.Text, "Cd Preordered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                txtOrderID.Text = "2004";
                txtOrdID.Text = "01350";
                cboPreSupp.SelectedIndex = -1;
                cbopreordCD.SelectedIndex = -1;
                return;



            }
           else if(dr == DialogResult.No)
            {
                MessageBox.Show("This CD will not be preordered and placed for the Supplier", "Cd Preordered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtOrderID.Text = "2004";
            
                txtOrdID.Text = "01350";
                cboPreSupp.SelectedIndex = -1;
                cbopreordCD.SelectedIndex = -1;
                return;
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
            //Display all Suppliers on UI









        }
    }
}
