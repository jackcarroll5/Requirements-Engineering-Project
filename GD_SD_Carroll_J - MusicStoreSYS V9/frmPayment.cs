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

        public frmPayment payment;

        public frmPayment(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void cboOrderCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceptSupp_Click(object sender, EventArgs e)
        {


            /*Payment made by Supplier saved in Payment file*/





           
            /*Getting text for selected date on calendar as help for displaying date for payment in store system.
             Title: How to get the selected date of a MonthCalendar control in C#
              Author: Anon
              Available at https://stackoverflow.com/questions/3429128/how-to-get-the-selected-date-of-a-monthcalendar-control-in-c-sharp
               Site: stackoverflow.com
               Year: 2010
               Accessed: 12 December 2017*/

            MessageBox.Show("The supplier  " + cboPaymentCD.GetItemText(cboPaymentCD.SelectedItem) + " has paid for the CDs on \nDate: " + 
                mthPaymentDate.SelectionRange.Start + "\nPayment ID " + txtPaymentID.Text + "\nSuppID: 002    \nCD ID: 00004" + "\nAmount: €12.80", "Payment made", MessageBoxButtons.OK, MessageBoxIcon.Information);



            txtPaymentID.Text = "019321";
            cboPaymentCD.SelectedIndex = -1;
            return;

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
           grdPayment.Rows.Add("019320","001","00003","€12.80","12/2/2018");
            grdPayment.Rows.Add("019321", "006", "00001", "€10.50", "07/1/2018");

        }
    }
}
