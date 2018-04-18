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
                        "\nYear Released: " + txtDisYr.Text + "\nArtist Label: " + txtDisArtLabel.Text + "\nCost Price: €" +  txtDisCostPrice.Text + "\nQty: " + txtDisQty.Text);
                }
               
            }


            /*Asks Manager to either discontinue the chosen CDs or to keep them available*/
            DialogResult dr = MessageBox.Show("Are you sure you want to discontinue these CDs? \nCD: " + chkDisCD.GetItemText(chkDisCD.SelectedItems), "Confirm CD Discontinuation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                availability = 'u';


                CD.disCD(Convert.ToInt32(txtDisCDID.Text));

                MessageBox.Show("These CDs are now discontinued. \nThey are now " + availability, "CD Discontinued", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                
            }
            loadCDs();
            grpDisCD.Visible = false;
            txtDisCDID.Clear();
            txtDeregAlbum.Clear();
            txtDeregArtist.Clear();
            txtDisYr.Clear();
            txtDisArtLabel.Clear();
            txtDisCostPrice.Clear();
            txtDisQty.Clear();
           
        }

        private void backMnu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmDisCD_Load(object sender, EventArgs e)
        {
            loadCDs();
        }

        private void loadCDs()
        {
          DataSet DS = new DataSet();
            DS = CD.getAvailableCDS1(DS);

            chkDisCD.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                chkDisCD.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

        }

        private void chkDisCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkDisCD.SelectedIndex == -1)
            {
                return;
            }

            CD deregCD = new CD();

            deregCD.getCD(Convert.ToInt32(chkDisCD.Text.Substring(0, 3)));

            if (deregCD.getCDID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisCDID.Focus();
                return;
            }

            txtDisCDID.Text = deregCD.getCDID().ToString("000");
            txtDeregAlbum.Text = deregCD.getAlbumName();
            txtDeregArtist.Text = deregCD.getArtist().ToString();
            txtDisYr.Text = deregCD.getYr().ToString();
            txtDisArtLabel.Text = deregCD.getArtLabel();
            txtDisCostPrice.Text = deregCD.getCostPrice().ToString();
            txtDisQty.Text = deregCD.getQty().ToString();


            grpDisCD.Visible = true;
        }
    }
}
