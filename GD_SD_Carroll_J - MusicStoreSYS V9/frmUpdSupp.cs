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
        DataSet DS;

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


        private void btnUExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmUpdSupp_Load(object sender, EventArgs e)
        {
            loadSuppItems();             
        }

        public void loadSuppItems()
        {
            DS = new DataSet();
            DS = Supplier.getAllSuppliers1(DS);

            cboUpdSuppliers.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboUpdSuppliers.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

        }

        private void txtSuppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        public bool ValEmail(String txtUEmail)
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

        public bool IsPhoneNo(String txtuPhoneNo)
        {  // https://stackoverflow.com/questions/2957412/need-a-regular-expression-for-an-irish-phone-number /*Expression of phone number validation based on user-created Irish phone number regex.Formed by mr.b Allows spaces in any section
           // of phone no*/
            if (Regex.IsMatch(txtuPhoneNo, @"|^\s *\(?\s *\d{ 1,4}\s *\)?\s *[\d\s]{ 5,10}\s *$?|", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    
        private void cboUpdSuppliers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            //if resetting combo, ignore
            if (cboUpdSuppliers.SelectedIndex == -1)
            {
                return;
            }

            Supplier updSupplier = new Supplier();

            updSupplier.getSupp(Convert.ToInt32(cboUpdSuppliers.Text.Substring(0, 3)));

            if (updSupplier.getSuppID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuppID.Focus();
                return;
            }

            //display Stock details
            txtSuppID.Text = updSupplier.getSuppID().ToString("000");
            txtName.Text = updSupplier.getSuppName();
            txtUpdPhoneNo.Text = updSupplier.getPhoneNo().ToString();
            txtUpdEmail.Text = updSupplier.getEmail().Trim();
            txtUpdStreet.Text = updSupplier.getStreet();
            txtUpdTownVillage.Text = updSupplier.getTownVillage();
            txtUpdCounties.Text = updSupplier.getCounty();
            txtAccBal.Text = updSupplier.getAccBal().ToString();

            grpSupp.Visible = true;


        }

        private void btnUReg_Click_1(object sender, EventArgs e)
        {
            if (cboUpdSuppliers.Text.Equals(""))
            {
                MessageBox.Show("No Supplier selected! Please select a Supplier!", "No Supplier selected", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                return;
            }


            else if (!IsPhoneNo(txtUpdPhoneNo.Text))
            //else if (txtUpdPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("No phone number detected! This phone number must be entered!", "Supplier Confirmation", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                txtUpdPhoneNo.Focus();
                return;

            }

            else if (!ValEmail(txtUpdEmail.Text))
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
            char status = 'A';

            Supplier supp = new Supplier();
            supp.setSuppID(Convert.ToInt32(txtSuppID.Text));
            supp.setSuppName(txtName.Text);
            supp.setPhoneNo(Convert.ToInt32(txtUpdPhoneNo.Text));
            supp.setEmail(txtUpdEmail.Text);
            supp.setStreet(txtUpdStreet.Text);
            supp.setTownVillage(txtUpdTownVillage.Text);
            supp.setCounty(txtUpdCounties.Text);
            supp.setAccBal(Convert.ToDecimal(txtAccBal.Text));
            supp.setStatus(status);

            supp.updSupp();


            //Save Data in Supplier File
            MessageBox.Show("Supplier ID: " + txtSuppID.Text + "\nSupplier: " + cboUpdSuppliers.GetItemText(cboUpdSuppliers.SelectedItem) + "\nPhone No: " +
                txtUpdPhoneNo.Text + "\nEmail: " + txtUpdEmail.Text + "\nStreet: " + txtUpdStreet.Text + "\nTown/Village: " + txtUpdTownVillage.Text +
                "\nCounty: " + txtUpdCounties.Text + "\nAccount Balance: " + txtAccBal.Text + "\nStatus: " + status, "Supplier Details", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Display confirmation message

            MessageBox.Show("Supplier has been updated!", "Supplier Updated", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            //Clear UI 
            cboUpdSuppliers.SelectedIndex = -1;
            grpSupp.Visible = false;
            txtSuppID.Clear();
            txtName.Clear();
            txtUpdPhoneNo.Clear();
            txtUpdEmail.Clear();
            txtUpdStreet.Clear();
            txtUpdTownVillage.Clear();
            txtUpdCounties.Clear();
            txtAccBal.Clear();
            return;

        }

        private void txtUpdEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
