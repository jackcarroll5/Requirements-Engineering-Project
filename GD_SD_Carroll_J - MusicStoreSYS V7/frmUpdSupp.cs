using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStoreSYS
{
    public partial class frmUpdSupp : Form
    {
        frmMainMenu parent;

        public frmUpdSupp updSuppReg;

        public frmUpdSupp()
        {
            InitializeComponent();

        }
        public frmUpdSupp(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnUReg_Click(object sender, EventArgs e)
        {
            char status = 'A';
            float accBal = 0;
          
            
            if (cboUpdSuppliers.Text.Equals(""))
            {
                MessageBox.Show("No Supplier selected! Please select a Supplier!", "No Supplier selected", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);             
                return;
            }

            else if (txtUpdPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("No phone number detected! This phone number must be entered!", "Supplier Confirmation", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                txtUpdPhoneNo.Focus();
                return;

            }

            else if (!valEmail(txtUpdEmail.Text))
            {
                MessageBox.Show("No email detected! This email must be entered!", "Email Error", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                txtUpdEmail.Focus();
                return;
            }

            else if (txtUpdStreet.Text.Equals(""))
            {
                MessageBox.Show("No street entered! This street must be entered!", "Missing Street", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtUpdStreet.Focus();
                return;

            }

            else if (txtUpdTownVillage.Text.Equals(""))
            {
                MessageBox.Show("No town/village detected! This town/village must be entered!", "Missing Town/Village", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtUpdTownVillage.Focus();
                return;

            }           


            //Save Data in Supplier File
            MessageBox.Show("Supplier ID: " + txtSuppID.Text + "\nSupplier: " + cboUpdSuppliers.GetItemText(cboUpdSuppliers.SelectedItem) + "\nPhone No: " +
                txtUpdPhoneNo.Text + "\nEmail: " + txtUpdEmail.Text + "\nStreet: " + txtUpdStreet.Text + "\nTown/Village: " + txtUpdTownVillage.Text +
                "\nCounty: " + cboupdCounties.GetItemText(cboupdCounties.SelectedItem) + "\nAccount Balance: " + accBal + "\nStatus: " + status,"Supplier Details",MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Display confirmation message

            MessageBox.Show("Supplier has been updated!", "Supplier Updated", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            //Clear UI
            txtSuppID.Text = "002";
           cboUpdSuppliers.SelectedIndex = -1;
            txtUpdPhoneNo.Clear();
            txtUpdEmail.Clear();
            txtUpdStreet.Clear();
            txtUpdTownVillage.Clear();
            cboupdCounties.SelectedIndex = -1;
            return;
        }

        private void btnUExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmUpdSupp_Load(object sender, EventArgs e)
        {
                
        }

        private void txtSuppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        public bool valEmail(String txtUEmail)
        {
            if (Regex.IsMatch(txtUEmail, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void cboUpdSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboupdCounties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
