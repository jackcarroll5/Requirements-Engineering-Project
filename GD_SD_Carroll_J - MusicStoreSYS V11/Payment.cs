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
        private decimal amount;
        private string payDate;
        private int suppID;
        private int orderID;

        public Payment()
        {
           paymentID = 000000;
            amount = 0;
            payDate = "Unknown";
            suppID = 000;
            orderID = 0000;
        }

        public Payment(int ordID, decimal amount, string payDate, int suppID, int orderID)
        {
           setPaymentID(paymentID);
            setAmount(amount);
           setPayDate(payDate);
            setSuppID(suppID);
            setOrderID(orderID);
        }


        public void setPaymentID(int paymentID)
        {
            this.paymentID = paymentID;
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

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }



        public int getPaymentID()
        {
            return paymentID;
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
        public int getOrderID()
        {
            return orderID;
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


            String strSQL = "INSERT INTO Payment VALUES(" + this.paymentID.ToString() +
            ",'" + this.orderID.ToString() + "','" + this.amount + "','" +
             this.payDate + "','" + this.suppID.ToString() + "')";


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();


            myConn.Close();
        }

        


    }
}
