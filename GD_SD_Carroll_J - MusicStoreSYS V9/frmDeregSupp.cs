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
        char iStatus;
        frmMainMenu parent;

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

        private void btnDereg_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to deregister this supplier? \nSupplier: " + cboDeregSuppliers.GetItemText(cboDeregSuppliers.SelectedItem) + "\n\nSupplier ID:" + txtSuppID.Text + 
               "\nName: " + txtDeregName.Text + "\nPhone Number: " + txtderegPhoneNo.Text + "\nEmail: " + txtderegEmail.Text + "\nStreet: " + txtDeregStreet.Text + "\nTown/Village; " + txtderegTownVillage.Text + "\nCounty: " + txtDeregCounty.Text + 
               "\nAccount Balance: €0.00"," Confirm Deregistration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                             
                Supplier.deregSupp(Convert.ToInt32(txtSuppID.Text));

                MessageBox.Show("This supplier has now been deregistered \nStatus: I " + iStatus, "Supplier deregistered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
               
            }

            loadSuppItems();
            grpDeselectSupp.Visible = false;
            txtSuppID.Clear();
            txtDeregName.Clear();
            txtderegPhoneNo.Clear();
            txtderegEmail.Clear();
            txtDeregStreet.Clear();
            txtderegTownVillage.Clear();
            txtDeregCounty.Clear();
           
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
            //Retrieve active Suppliers from Supplier File
            loadSuppItems();
        }

        public void loadSuppItems()
        {
          DataSet DS = new DataSet();
            DS = Supplier.getAllActiveSuppliers1(DS);

            cboDeregSuppliers.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboDeregSuppliers.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

        }
    }
}
