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
    public partial class frmUpdCD : Form
    {
        frmMainMenu parent;

        public frmUpdCD updCD;

        public frmUpdCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnUExitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUInsert_Click(object sender, EventArgs e)
        {
            float n;
            int num;

            if(cboupdCD.Text.Equals(""))
            {
                MessageBox.Show("No CD chosen! A CD must be picked!", "CD Error", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);             
                return;

            }

         if (txtUAlbum.Text.Equals(""))
            {
                MessageBox.Show("No album entered! This album must be entered!", "Album Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtUAlbum.Focus();
                return;

            }
            else if (txtUArtist.Text.Equals(""))
            {
                MessageBox.Show("No artist entered! Please type in an artist!", "Artist Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtUArtist.Focus();
                return;
            }

          
            else if (!float.TryParse(txtuCost.Text,out n))
                {
                if (n <= 0)
                    MessageBox.Show("Cost is invalid! This cost field must be re-entered!", "Cost Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtuCost.Focus();
                return;
            }

            else if (!int.TryParse(txtuQty.Text, out num ))
            {
                if (num <= 0)
                    MessageBox.Show("Quality is invalid! This quality field must be re-entered!", "Quality Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtuQty.Focus();
                return;

            }

            String availablity = "a";

            //Save Data in Supplier File
            MessageBox.Show("CD_ID: " + txtCDID.Text + "\nCD: " + cboupdCD.GetItemText(cboupdCD.SelectedItem) + "\nAlbum: " + txtUAlbum.Text + "\nArtist: " + txtUArtist.Text + "\nYear Released: " +
                chkUYr.GetItemText(chkUYr.SelectedItem) + "\nArtist Label: " + GetRadButtonText(grpUArtistLbl) + "\nCost Price: " + txtuCost.Text + "\nQuality: " + txtuQty.Text + 
                "\nAvailability: " + availablity, "Updated CD Details: ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


           /* foreach (Object item in chkUYr.CheckedItems)
            {
                MessageBox.Show(item.ToString());
            }*/


           

          

            //Display confirmation message
            MessageBox.Show("CD has now been updated!", "CD Updated", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;

#pragma warning disable CS0162 // Unreachable code detected
            txtCDID.Text = "00004";
#pragma warning restore CS0162 // Unreachable code detected
            cboupdCD.SelectedIndex = -1;
            txtUAlbum.Clear();
            txtUArtist.Clear();
            chkUYr.ClearSelected();
            txtuCost.Clear();
            txtuQty.Clear();

        }

        private void frmUpdCD_Load(object sender, EventArgs e)
        {

        }

        /*Getting a chosen radio button text from a group box
         Author: Anon
         Accessed: 07 December 2017
         Available: http://techbrij.com/get-selected-radio-button-text-windows-app-net*/
        private string GetRadButtonText(GroupBox grpUArtistLabel)
        {
            return grpUArtistLabel.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboDiscontinueCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
