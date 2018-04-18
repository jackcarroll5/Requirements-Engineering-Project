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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegSupp_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSuppReg frmNextForm = new frmSuppReg(this);
            frmNextForm.Show();
        }

        private void mnuUpdSupp_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUpdSupp frmNextForm = new frmUpdSupp(this);
            frmNextForm.Show();
        }

        private void deRegisterSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDeregSupp frmNextForm = new frmDeregSupp(this);
            frmNextForm.Show();

        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSuppList frmNextForm = new frmSuppList(this);
            frmNextForm.Show();
        }

        private void insertNewCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmInsNewCD frmNextForm = new frmInsNewCD(this);
            frmNextForm.Show();
        }

        private void updateCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

           frmUpdCD frmNextForm = new frmUpdCD(this);
            frmNextForm.Show();
        }

        private void discontinueCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDisCD frmNextForm = new frmDisCD(this);
            frmNextForm.Show();

        }

        private void queryCDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmQueryCD frmNextForm = new frmQueryCD(this);
            frmNextForm.Show();

        }

        private void receiveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRecCD frmNextForm = new frmRecCD(this);
            frmNextForm.Show();

        }

        private void placePreorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPreordCD frmNextForm = new frmPreordCD(this);
            frmNextForm.Show();

        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPayment frmNextForm = new frmPayment(this);
            frmNextForm.Show();

        }

        private void analyseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAnalyCDOrders frmNextForm = new frmAnalyCDOrders(this);
            frmNextForm.Show();

        }

        private void analyseCDStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAnalyCDStock frmNextForm = new frmAnalyCDStock(this);
            frmNextForm.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
