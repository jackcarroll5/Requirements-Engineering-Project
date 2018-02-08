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

            Supplier supp = new Supplier();
        

            DialogResult dr = MessageBox.Show("Are you sure you want to deregister this supplier? \nSupplier: " + cboDeregSuppliers.GetItemText(cboDeregSuppliers.SelectedItem) + "\n\nSupplier ID:" + txtSuppID.Text + 
               "\nName: " + txtDeregName.Text + "\nPhone Number: " + txtderegPhoneNo.Text + "\nEmail: " + txtderegEmail.Text + "\nStreet: " + txtDeregStreet.Text + "\nTown/Village; " + txtderegTownVillage.Text + "\nCounty: " + txtDeregCounty.Text, "Confirm Deregistration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                //Set status = inactive
                iStatus = 'I';


                supp.setStatus('U');

                
                supp.deregSupp();

                MessageBox.Show("This supplier has now been deregistered \nStatus: " + iStatus, "Supplier deregistered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                cboDeregSuppliers.SelectedIndex = -1;
                grpDeselectSupp.Visible = false;
                txtSuppID.Clear();
                txtDeregName.Clear();
                txtderegPhoneNo.Clear();
                txtderegEmail.Clear();
                txtderegTownVillage.Clear();
                txtDeregCounty.Clear();
                return;
            }

            else if (dr == DialogResult.No)
            {
                /*Keep status at Active*/
                iStatus = 'A';

                MessageBox.Show("This supplier will remain registered \nStatus: " + iStatus, "Keep Supplier Registered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                cboDeregSuppliers.SelectedIndex = -1;
                grpDeselectSupp.Visible = false;
                txtSuppID.Clear();
                txtDeregName.Clear();
                txtderegPhoneNo.Clear();
                txtderegEmail.Clear();
                txtderegTownVillage.Clear();
                txtDeregCounty.Clear();
                return;
            }       

        }

        private void cboDeregSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeregSuppliers.SelectedIndex == -1)
            {
                return;
            }

            Supplier deregSupplier = new Supplier();

            deregSupplier.getSupp(Convert.ToInt32(cboDeregSuppliers.Text.Substring(0, 3)));

            if (deregSupplier.getSuppID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuppID.Focus();
                return;
            }

           
            txtSuppID.Text = deregSupplier.getSuppID().ToString("000");
            txtDeregName.Text = deregSupplier.getSuppName();
            txtderegPhoneNo.Text = deregSupplier.getPhoneNo().ToString();
            txtderegEmail.Text = deregSupplier.getEmail();
           txtDeregStreet.Text = deregSupplier.getStreet();
            txtderegTownVillage.Text = deregSupplier.getTownVillage();
            txtDeregCounty.Text = deregSupplier.getCounty();

           grpDeselectSupp.Visible = true;

        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmDeregSupp_Load(object sender, EventArgs e)
        {
            loadSuppItems();
        }

        public void loadSuppItems()
        {
          DataSet DS = new DataSet();
            DS = Supplier.getAllSuppliers1(DS);

            cboDeregSuppliers.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboDeregSuppliers.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

        }
    }
}
