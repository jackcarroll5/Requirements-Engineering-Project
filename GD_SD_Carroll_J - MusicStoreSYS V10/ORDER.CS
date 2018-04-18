using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MusicStoreSYS
{
    class Order
    {
        private int orderID;
        private string ordDate;
        private decimal ordValue;
        private string status;
        private int suppID;

        public Order()
        {
            orderID = 0000;
            ordDate = "Unknown";
            ordValue = 0;
            status = "Not placed";
            suppID = 000;



        }

        public Order(int orderID, string ordDate, decimal ordValue, string status, int supp_ID)
        {
            setOrderID(orderID);
            setOrdDate(ordDate);
            setOrdValue(ordValue);
            setStatus(status);
            setSuppID(suppID);
        }


        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }
        public void setOrdDate(String ordDate)
        {
            this.ordDate = ordDate;
        }

        public void setOrdValue(decimal ordValue)
        {
            this.ordValue = ordValue;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public void setSuppID(int suppID)
        {
            this.suppID = suppID;
        }



        public int getOrderID()
        {
            return orderID;
        }

        public string getOrdDate()
        {
            return ordDate;
        }
        public decimal getOrdValue()
        {
            return ordValue;
        }
        public string getStatus()
        {
            return status;
        }
        public int getSuppID()
        {
            return suppID;
        }

        public static int nextOrder()
        {
            // variable to hold value to be returned
            int nextOrder;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

           
            String strSQL = "SELECT MAX(OrderID) FROM Orders";

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
                nextOrder = 1;
            else
                nextOrder = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return nextOrder;
        }











    }
    }
