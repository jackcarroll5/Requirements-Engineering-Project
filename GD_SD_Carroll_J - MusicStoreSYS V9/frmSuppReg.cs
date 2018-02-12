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
    public partial class frmSuppReg : Form
    {
        frmMainMenu parent;

        public frmSuppReg suppReg;

        public frmSuppReg()
        {
            InitializeComponent();
        }

        public frmSuppReg(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public void loadCounties()
        { 
        //load combo with stockNo and Description for all stock
             DataSet ds = new DataSet();
              ds = Supplier.getAllCounties(ds);

               for (int i = 0; i<ds.Tables["ss"].Rows.Count; i++)
              cboCounties.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3,'0') + " " + ds.Tables[0].Rows[i][1].ToString());
          }

        private void frmSuppReg_Load(object sender, EventArgs e)
        {
            txtSuppId.Text = Supplier.nextSupplier().ToString("000");
            loadCounties();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboCounties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool ValEmail(String txtEmail)
        {
            if(Regex.IsMatch(txtEmail,@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPhoneNo(String txtphoneNo)
            {
                if (Regex.IsMatch(txtphoneNo,@"|^\s *\(?\s *\d{ 1,4}\s *\)?\s *[\d\s]{ 5,10}\s *$?|", RegexOptions.IgnoreCase))           
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("No Supplier name written! Please enter a Supplier!", "Supplier Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            else if(!IsPhoneNo(txtPhoneNo.Text))
            //else if (txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("No phone number detected! This phone number must be entered!", "Missing Phone Number", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;

            }


            else if (!ValEmail(txtEmail.Text))
            {
                MessageBox.Show("No email detected! This email must be entered!", "Email Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }


            else if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("No street entered! This street must be entered!", "Missing Street", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtStreet.Focus();
                return;

            }

            else if (txtTownVillage.Text.Equals(""))
            {
                MessageBox.Show("No town/village detected! This town/village must be entered!", "Missing Town/Village", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtTownVillage.Focus();
                return;

            }



            //Set Default Values
            decimal accBal = 0;
            char status = 'A';

            //instantiate Supplier Object
            Supplier supp = new Supplier();
            supp.setSuppID(Convert.ToInt32(txtSuppId.Text));
            supp.setSuppName(txtName.Text);
            supp.setPhoneNo(Convert.ToInt32(txtPhoneNo.Text));
            supp.setEmail(txtEmail.Text);
            supp.setStreet(txtStreet.Text);
            supp.setTownVillage(txtTownVillage.Text);
            supp.setCounty((cboCounties.Text.Substring(0,2)));
            supp.setAccBal(Convert.ToDecimal(accBal));
            supp.setStatus(status);

            //Insert Supplier record into Supplier Table
            supp.regSupplier();


            //Save Data in Supplier File
            MessageBox.Show("SuppID: " + txtSuppId.Text + "\nSupplier: " + txtName.Text + "\nPhone No: " +
                txtPhoneNo.Text + "\nEmail: " + txtEmail.Text + "\nStreet: " + txtStreet.Text + "\nTown/Village: " + txtTownVillage.Text +
                "\nCounty: " + cboCounties.GetItemText(cboCounties.SelectedItem) + "\nAccount Balance: €" + accBal + "\nStatus: " + status, "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //Display confirmation message
            MessageBox.Show("Supplier is now added!", "Supplier Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            //Reset UI
            txtSuppId.Text = Supplier.nextSupplier().ToString("000");
            //txtSuppId.Text = "012";
            txtName.Focus();
            txtName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTownVillage.Clear();
            cboCounties.SelectedIndex = -1;
            return;
        }
    }
}
