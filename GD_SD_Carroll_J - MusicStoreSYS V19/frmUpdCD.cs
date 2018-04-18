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
        DataSet DS;

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
            decimal n;
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

            else if (!decimal.TryParse(txtUCostPrice.Text, out n))
            {
                if (n <= 0)
                    MessageBox.Show("Cost is invalid! This cost field must be re-entered!", "Cost Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtUCostPrice.Focus();
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

            char availablity = 'a';

            CD cd = new CD();
            cd.setCDID(Convert.ToInt32(txtCDID.Text));
            cd.setAlbumName(txtUAlbum.Text);
            cd.setArtist(txtUArtist.Text);
            cd.setYr(Convert.ToInt32(txtYr.Text));
            cd.setArtLabel(txtUArtistLbl.Text);
            cd.setCostPrice(Convert.ToDecimal(txtUCostPrice.Text));
            cd.setQty(Convert.ToInt32(txtuQty.Text));
            cd.setSuppId(Convert.ToInt32(cboSuppliers.Text.Substring(0, 3)));
            //cd.setAvailability('a');
            cd.setAvailability(availablity);

            cd.updCD();

            //Save Data in Supplier File
            MessageBox.Show("CD: " + cboupdCD.GetItemText(cboupdCD.SelectedItem) + "\n\nCD_ID: " + txtCDID.Text + "\nAlbum: " + txtUAlbum.Text + "\nArtist: " + txtUArtist.Text + "\nYear Released: " +
                txtYr.Text + "\nArtist Label: " + txtUArtistLbl.Text + "\nCost Price: €" + txtUCostPrice.Text + "\nQuality: " + txtuQty.Text +
             "\nSuppliers: " + cboSuppliers.GetItemText(cboSuppliers.SelectedItem) + "\nAvailability: " + availablity, "Updated CD Details: ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
      

            //Display confirmation message
            MessageBox.Show("CD has now been updated!", "CD Updated", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            loadCDItems();
           // cboupdCD.SelectedIndex = -1;
            grpUCD.Visible = false;
            txtCDID.Clear();        
            txtUAlbum.Clear();
            txtUArtist.Clear();
            txtYr.Clear();
            txtUArtistLbl.Clear();
            txtUCostPrice.Clear();
            txtuQty.Clear();
            cboSuppliers.SelectedIndex = -1;
           

        }

        private void frmUpdCD_Load(object sender, EventArgs e)
        {
            loadCDItems();
        }

        private void loadCDItems()
        {
            DS = new DataSet();
            DS = CD.getAvailableCDS1(DS);

            cboupdCD.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboupdCD.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());      

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

        private void cboupdCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboupdCD.SelectedIndex == -1)
            {
                return;
            }

            CD updCD = new CD();

            //updCD.getCD(Convert.ToInt32(cboupdCD.Text.Substring(0, 3)));

            updCD.getCD(Convert.ToInt32(cboupdCD.Text.Substring(0, 4)));

            if (updCD.getCDID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCDID.Focus();
                return;
            }

            //display Stock details
            txtCDID.Text = updCD.getCDID().ToString("00000");
            txtUAlbum.Text = updCD.getAlbumName();
            txtUArtist.Text = updCD.getArtist().ToString();
            txtYr.Text = updCD.getYr().ToString();
             txtUArtistLbl.Text = updCD.getArtLabel();
            txtUCostPrice.Text = updCD.getCostPrice().ToString();
            txtuQty.Text = updCD.getQty().ToString();
            cboSuppliers.SelectedItem = updCD.getSuppID().ToString("000");



            DataSet ds = new DataSet();
            ds = Supplier.getAllActiveSuppliers(ds);
            //load suppliers
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboSuppliers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());


            int theSuppID = updCD.getSuppID();

            cboSuppliers.SelectedIndex = 0;

            while(!cboSuppliers.Text.Substring(0,3).Equals(theSuppID.ToString("000")))
            {
                cboSuppliers.SelectedIndex++;
            }

            grpUCD.Visible = true;

        }
    }
}
