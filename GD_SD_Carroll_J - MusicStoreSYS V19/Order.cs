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
        private DateTime ordDate;
        private decimal ordValue;
        private string status;
        private int suppID;

        public Order()
        {
            orderID = 0000;
            ordDate = DateTime.MinValue;
            ordValue = 0;
            suppID = 000;
            status = "Unplaced";
        }

        public Order(int orderID, DateTime ordDate, decimal ordValue, int supp_ID, string status)
        {
            setOrderID(orderID);
            setOrdDate(ordDate);
            setOrdValue(ordValue);
            setSuppID(suppID);
            setStatus(status);
          
        }


        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }
        public void setOrdDate(DateTime ordDate)
        {
            this.ordDate = ordDate;
        }

        public void setOrdValue(decimal ordValue)
        {
            this.ordValue = ordValue;
        }

         public void setSuppID(int suppID)
        {
            this.suppID = suppID;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }
     
        public int getOrderID()
        {
            return orderID;
        }

        public DateTime getOrdDate()
        {
            return ordDate;
        }

        public decimal getOrdValue()
        {
            return ordValue;
        }

        public int getSuppID()
        {
            return suppID;
        }

        public string getStatus()
        {
            return status;
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

        public void placeOrder()
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "INSERT INTO Orders VALUES(" + this.orderID.ToString() +
            ",'" + String.Format("{0:dd-MMM-yy}",this.ordDate) +  "'," + this.ordValue + ",'" +
             this.status + "'," + this.suppID.ToString() + ")";


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();


            myConn.Close();
        }

        public void getOrd(int orderID)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query get Ordersfor the Supplier that is chosen
            String strSQL = "SELECT * FROM Orders WHERE OrderID = " + orderID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setOrderID(dr.GetInt32(0));
                setOrdDate(dr.GetDateTime(1));
                setOrdValue(dr.GetInt32(2));              
                setStatus(dr.GetString(3));
                setSuppID(dr.GetInt32(4));             
            }
            myConn.Close();
        }

        public static void receiveOrder(int orderNo)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "UPDATE Orders SET Status = 'Received' WHERE OrderID = " + orderNo;


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public static DataSet getAllOrders(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name conn.Open();
            String strSQL = "SELECT OrderID,OrdDate,OrdValue,Supp_ID FROM Orders ORDER BY OrderID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        public static DataSet getSuppOrders(DataSet DS, int Supp_ID)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM Orders WHERE Supp_Id = " + Supp_ID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


         public static DataSet getOrderData(int suppID, String year, DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT TO_CHAR(OrdDate,'MM'),SUM(OrdValue) FROM Orders WHERE Supp_Id = " + suppID + " AND " +
                "OrdDate LIKE '%" + year + "' GROUP BY TO_CHAR(OrdDate,'MM')" + " ORDER BY TO_CHAR(OrdDate,'MM')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

      

    }
    }
