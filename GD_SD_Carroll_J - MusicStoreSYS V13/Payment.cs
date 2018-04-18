using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MusicStoreSYS
{
    class Payment
    {
        private int paymentID;
        private int orderID;
        private decimal amount;
        private string payDate;
        private int suppID;
      

        public Payment()
        {
           paymentID = 000000;
            amount = 0;
            orderID = 0000;
            payDate = "Unknown";
            suppID = 000;
            
        }

        public Payment(int paymentID, int orderID, decimal amount, string payDate, int suppID)
        {
           setPaymentID(paymentID);
            setOrderID(orderID);
            setAmount(amount);
           setPayDate(payDate);
            setSuppID(suppID);
            
        }


        public void setPaymentID(int paymentID)
        {
            this.paymentID = paymentID;
        }

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public void setAmount(decimal amount)
        {
            this.amount = amount;
        }

        public void setPayDate(string payDate)
        {
            this.payDate = payDate;
        }

        public void setSuppID(int suppID)
        {
            this.suppID = suppID;
        }

      

      public int getPaymentID()
        {
            return paymentID;
        }

       public int getOrderID()
        {
            return orderID;
        }

        public decimal getAmount()
        {
            return amount;
        }

        public string getPayDate()
        {
            return payDate;
        }

        public int getSuppID()
        {
            return suppID;
        }
       


        public static int nextPayment()
        {
            // variable to hold value to be returned
            int nextPayment;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "SELECT MAX(PaymentID) FROM Payments";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first suppID, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no Suppliers in the Supplier File - start at 1
            //Otherwise add 1 to the value read

            if (dr.IsDBNull(0))
               nextPayment = 1;
            else
                nextPayment = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return nextPayment;
        }

        public void placeOrder()
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "INSERT INTO Payments VALUES(" + this.paymentID.ToString() +
            "," + this.orderID.ToString() + "," + this.amount + ",TO_DATE('" +
             this.payDate + "','DD-MMM-YY')" + "," + this.suppID.ToString() + ")";


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();


            myConn.Close();
        }

        


    }
}
