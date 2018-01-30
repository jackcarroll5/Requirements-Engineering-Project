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
            string album = "Glory Days";
            string artist = "Little Mix";
            int year = 2016;
            string artistLabel = "Sony";
            float costPrice = 10.50f;
            int cdQty = 400;
            string orderID = "2002";
            string suppID = "002";
            string ordDate = "13/12/2018";
            float ordValue = 13.45f;
            string ordID = "01340";
            string cdid = "00004";
            int qty = 100;

              /*Retrieve Supplier Details from Supplier File, Cd Details from the CD File
                 * Order details from the Order File and Orderitems File*/


            DialogResult dr = MessageBox.Show("Are you sure you want to proceed with this order for " + cboSuppliersPreOrder.GetItemText(cboSuppliersPreOrder.SelectedItem)  + " ?" + "\nCD ID: " + cdid + "\nAlbum: " + album + "\nArtist: " + artist + "\nYear: " + year + 
                "\nArtist Label: " + artistLabel + "\nCost Price: " + costPrice + "\nCD Qty: " + cdQty + "\n\n" +
                "\n\nOrder: \nOrder ID: " + orderID + "\nSupp ID: " + suppID + "\nOrdDate: " + ordDate + "\nOrdValue: " + ordValue + "\nCD ID: " + cdid + 
                "\n\nOrderItem: \nOrdID " + ordID + "\nCD ID: " + cdid + "\nQty: " + qty, "Confirm Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
            /*Confirm CDs that Supplier chose are the ones going to be delivered.*/


            if (dr == DialogResult.Yes)
            {
                

                MessageBox.Show("The chosen CDs will be delivered to the chosen Supplier in a few days", "CD Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information);


                cboSuppliersPreOrder.SelectedIndex = -1;
                return;
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("The chosen CDs will not be delivered to the chosen Supplier", "CD not Delivered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSuppliersPreOrder.SelectedIndex = -1;
                return;
            }        
        }

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboSuppliersPreOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
