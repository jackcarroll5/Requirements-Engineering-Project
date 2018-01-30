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
    public partial class frmDeregSupp : Form
    {

        frmMainMenu parent;

        char iStatus;

        public frmDeregSupp deregSupp;

        public frmDeregSupp(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExitDeregSupp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Retrieve active Suppliers from Supplier File



        private void btnDereg_Click(object sender, EventArgs e)
        {
            /*Retrieve details of selected supplier.For now, type in details of selected Supplier
             Regardless of method, display the details on choice screen*/

            DialogResult dr = MessageBox.Show("Are you sure you want to deregister this supplier? \nSupplier: " + cboDeregSuppliers.GetItemText(cboDeregSuppliers.SelectedItem) + "\nSupplier ID:" + txtSuppID.Text + 
                "\nPhone Number: " + txtderegPhoneNo.Text + "\nEmail: " + txtderegEmail.Text + "\nTown/Village; " + txtderegTownVillage.Text + "\nCounty: " + cboderegCounties.GetItemText(cboderegCounties.SelectedItem), "Confirm Deregistration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                //Set status = inactive
                iStatus = 'I';
                
             
                MessageBox.Show("This supplier has now been deregistered \nStatus: " + iStatus, "Supplier deregistered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                cboDeregSuppliers.SelectedIndex = -1;
                txtSuppID.Text = "105";
                txtderegPhoneNo.Clear();
                txtderegEmail.Clear();
                txtderegTownVillage.Clear();
                cboderegCounties.SelectedIndex = -1;
                return;
            }

            else if (dr == DialogResult.No)
            {
                /*Keep status at Active*/
                iStatus = 'A';

                MessageBox.Show("This supplier will remain registered \nStatus: " + iStatus, "Keep Supplier Registered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                cboDeregSuppliers.SelectedIndex = -1;
                txtSuppID.Text = "105";
                txtderegPhoneNo.Clear();
                txtderegEmail.Clear();
                txtderegTownVillage.Clear();
                cboderegCounties.SelectedIndex = -1;
                return;
            }       
            


            cboDeregSuppliers.SelectedIndex = -1;
            txtSuppID.Text = "105";
            txtderegPhoneNo.Clear();
           txtderegEmail.Clear();
            txtderegTownVillage.Clear();
            cboderegCounties.SelectedIndex = -1;

        }

        private void cboDeregSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
