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
    public partial class frmDisCD : Form
    {

        frmMainMenu parent;

        public frmDisCD disCD;

        char availability;

        public frmDisCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExitDiscontinueCD_Click(object sender, EventArgs e)
        {
            Application.Exit();
          }

        private void btnDisCD_Click(object sender, EventArgs e)
        {
            /*Retrieve details of selected CDs.For now, type in details of selected CDs
             Regardless of method, display the details on choice screen*/

             /*foreach (Object item in chkDisCD.CheckedItems)
          {
              MessageBox.Show(item.ToString());
          }*/



               //Outputs the selected CDs according to the checked CDs
            for(int i = 0; i <= chkDisCD.Items.Count - 1; i++)
            {
                     

                if(chkDisCD.GetItemChecked(i))
                {
                    MessageBox.Show(chkDisCD.Items[i].ToString() + "\nCD ID: " + txtDisCDID.Text + "\nAlbum: " + txtDeregAlbum.Text + "\nArtist: " + txtDeregArtist.Text + 
                        "\nYear Released: " + txtYr.Text + "\nArtist Label: " + txtArtLabel.Text);
                }
               
            }


            /*Asks Manager to either discontinue the chosen CDs or to keep them available*/
            DialogResult dr = MessageBox.Show("Are you sure you want to discontinue these CDs? \nCD: " + chkDisCD.GetItemText(chkDisCD.SelectedItems), "Confirm CD Discontinuation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                availability = 'u';

                MessageBox.Show("These CDs are now discontinued. \nThey are now " + availability, "CD Discontinued", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                txtDisCDID.Clear();
                txtDeregAlbum.Clear();
                txtDeregArtist.Clear();
                txtYr.Clear();
                txtArtLabel.Clear();
            }
            else if (dr == DialogResult.No)
            {

                availability = 'a';

                MessageBox.Show("These CDs will remain in stock. \nThey are " + availability, "CD In Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtDisCDID.Clear();
                txtDeregAlbum.Clear();
                txtDeregArtist.Clear();
                txtYr.Clear();
                txtArtLabel.Clear();


            }
           return;
          
        }

        private void backMnu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
