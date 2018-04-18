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
    public partial class frmPayment : Form
    {
        frmMainMenu parent;

        DataSet DS;

        public frmPayment payment;

        public frmPayment(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void cboOrderCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaymentCD.SelectedIndex == -1)
            {
                return;
            }

            Supplier paySupplier = new Supplier();

            paySupplier.getSupp(Convert.ToInt32(cboPaymentCD.Text.Substring(0, 3)));

            if (paySupplier.getSuppID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                return;
            }
        }

        private void btnAcceptSupp_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.setPaymentID(Convert.ToInt32(txtPaymentID.Text));
            payment.setOrderID(Convert.ToInt32(txtOrderID.Text));
            payment.setAmount(Convert.ToDecimal(txtAmount.Text));
            payment.setPayDate(mthPaymentDate.SelectionStart);
            payment.setSuppID(Convert.ToInt32(cboPaymentCD.Text.Substring(0, 3)));

            /*Payment made by Supplier saved in Payment file*/
            payment.placeOrder();

            /*Getting text for selected date on calendar as help for displaying date for payment in store system.
             Title: How to get the selected date of a MonthCalendar control in C#
              Author: Anon
              Available at https://stackoverflow.com/questions/3429128/how-to-get-the-selected-date-of-a-monthcalendar-control-in-c-sharp
               Site: stackoverflow.com
               Year: 2010
               Accessed: 12 December 2017*/

           // +"Payment Date: " + mthPaymentDate.SelectionRange.Start.ToShortDateString()

            MessageBox.Show("The Supplier:  " + cboPaymentCD.GetItemText(cboPaymentCD.SelectedItem) + "\nPayment ID: " + txtPaymentID.Text + 
                "\nOrder ID: " + txtOrderID.Text + " \nhas paid for the CDs on \nPayment Date: " + 
                mthPaymentDate.SelectionRange.Start + "\nThe Amount paid is: €" + txtAmount.Text, 
                "Payment made", MessageBoxButtons.OK, MessageBoxIcon.Information);



           txtAmount.Text = Payment.nextPayment().ToString("000000");
            loadOrderItems();
             txtOrderID.Clear();
            loadSuppItems();        
            txtAmount.Clear();
            cboPaymentCD.SelectedIndex = -1;
            cboOrderID.SelectedIndex = -1;         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            txtPaymentID.Text = Payment.nextPayment().ToString("000000");

            loadOrderItems();
            loadSuppItems();
        }

        private void cboOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboOrderID.SelectedIndex == -1)
            {
                return;
            }

            Order payOrder = new Order();

            //updCD.getCD(Convert.ToInt32(cboupdCD.Text.Substring(0, 3)));

            payOrder.getOrd(Convert.ToInt32(cboOrderID.Text.Substring(0, 4)));

            //payOrder.getOrd(Convert.ToInt32(cboOrderID.Text.Substring(5, 23)));

            if (payOrder.getOrderID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderID.Focus();
                return;
            }

            //display Stock details
           txtOrderID.Text = payOrder.getOrderID().ToString("0000");
            txtOrderID.Text = cboOrderID.Text.Substring(0, 4);
        }

        public void loadSuppItems()
        {
            DS = new DataSet();
            DS = Supplier.getAllActiveSuppliers(DS);

            cboPaymentCD.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboPaymentCD.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + DS.Tables[0].Rows[i][1].ToString());

        }


        public void loadOrderItems()
        {
            DS = new DataSet();
            DS = Order.getAllOrders(DS);

            cboOrderID.Items.Clear();
            for (int i = 0; i < DS.Tables["ss"].Rows.Count; i++)
                cboOrderID.Items.Add(DS.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " + DS.Tables[0].Rows[i][1].ToString() + " " + DS.Tables[0].Rows[i][2].ToString() + " " + DS.Tables[0].Rows[i][3].ToString().PadLeft(3,'0'));

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
