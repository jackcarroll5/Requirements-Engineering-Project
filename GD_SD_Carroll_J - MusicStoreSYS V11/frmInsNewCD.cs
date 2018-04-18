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
    public partial class frmInsNewCD : Form
    {

        frmMainMenu parent;

        public frmInsNewCD insNewCD;
        //private Func<RadioButton, bool> rad;

        public frmInsNewCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void grpArtistLbl_Enter(object sender, EventArgs e)
        {

        }

        private string GetRadioButtonText(GroupBox grpArtistLabel)
        {
            return grpArtistLabel.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInsNewCD_Load(object sender, EventArgs e)
        {
            txtCDID.Text = CD.nextCD().ToString("00000");

            DataSet ds = new DataSet();
            ds = Supplier.getAllActiveSuppliers(ds);
            //load suppliers
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboSuppliers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void chkYr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpInsCD_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertCD_Click(object sender, EventArgs e)
        {
            decimal number;
            int num;


            if (txtAlbum.Text.Equals(""))
            {
                MessageBox.Show("No album entered! This album must be entered!", "Album Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtAlbum.Focus();
                return;

            }

            else if (txtArtist.Text.Equals(""))
            {
                MessageBox.Show("No artist entered! Please type in an artist!", "Artist Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtArtist.Focus();
                return;
            }




            else if (!decimal.TryParse(txtCost.Text, out number))
            {
                if (number <= 0)
                    MessageBox.Show("Cost is invalid! This cost field must be re-entered!", "Cost Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtCost.Focus();
                return;
            }

            else if (!int.TryParse(txtQty.Text, out num))
            {
                if (num <= 0)
                    MessageBox.Show("Quality is invalid! This quality field must be re-entered!", "Quality Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtQty.Focus();
                return;

            }

            //Set Default Values        
            String availability = "a";

            CD cd = new CD();
            cd.setCDID(Convert.ToInt32(txtCDID.Text));
            cd.setAlbumName(txtAlbum.Text);
            cd.setArtist(txtArtist.Text);
            cd.setYr(Convert.ToInt32(chkYr.GetItemText(chkYr.SelectedItem)));
            cd.setArtLabel(GetRadioButtonText(grpArtistLbl));
            cd.setCostPrice(Convert.ToDecimal(txtCost.Text));
            cd.setQty(Convert.ToInt32(txtQty.Text));
            cd.setSuppId(Convert.ToInt32(cboSuppliers.Text.Substring(0, 3)));
            cd.setAvailability('a');

            cd.regCD();


            //Save Data in CD File
            MessageBox.Show("CD ID; " + txtCDID.Text + "\nAlbum: " + txtAlbum.Text + "\nArtist: " + txtArtist.Text + "\nYear Released: " + chkYr.GetItemText(chkYr.SelectedItem) +
                "\nArtist Label: " + GetRadioButtonText(grpArtistLbl) + "\nCost Price: €" + txtCost.Text + "\nQuality: " + txtQty.Text + "\nSupplier: " + cboSuppliers.GetItemText(cboSuppliers.SelectedItem) + 
                "\nAvailabilty: " + availability, "CD Details: ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);



            //Display confirmation message

            MessageBox.Show("CD has now been added!", "CD Confirmation", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);


            //Reset UI
            txtCDID.Text = CD.nextCD().ToString("00000");
            //txtCDID.Text = "00002";
            txtAlbum.Focus();
            txtAlbum.Clear();
            txtArtist.Clear();
            chkYr.ClearSelected();
            txtCost.Clear();
            txtQty.Clear();
            cboSuppliers.SelectedIndex = -1;
            

            foreach (int i in chkYr.CheckedIndices)
            {
                chkYr.SetItemCheckState(i, CheckState.Unchecked);
            }
            return;

        }
    }
    }
