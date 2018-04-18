using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MusicStoreSYS
{
    class OrderItems
    {
        private int ordID;
        private int cdID;   
        private int qty;
        private decimal unitCost;
        //private int orderID;
      

        public OrderItems()
        {
            ordID = 00000;
            cdID = 00000;
            qty = 0;
            unitCost = 0;        
        }

        public OrderItems(int ordID,int cdID, int qty, decimal unitCost)
        {
            setOrdID(ordID);
            setCDID(cdID); 
             setQty(qty);
            setUnitCost(unitCost);
                     
        }


        public void setOrdID(int ordID)
        {
            this.ordID = ordID;
        }

        public void setCDID(int cdID)
        {
            this.cdID = cdID;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public void setUnitCost(decimal unitCost)
        {
            this.unitCost = unitCost;
        }


       /* public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }*/



        public int getOrdID()
        {
            return ordID;
        }
        
        public int getCDID()
        {
            return cdID;
        }

        public int getQty()
        {
            return qty;
        }

        public decimal getUnitCost()
        {
            return unitCost;
        }

        /*public int getorderID()
        {
            return orderID;
        }*/


        public static int nextOrd()
        {
            // variable to hold value to be returned
            int nextOrd;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "SELECT MAX(OrdID) FROM OrderItems";

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
                nextOrd = 1;
            else
                nextOrd = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return nextOrd;
        }

        public void placeOrderItem()
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "INSERT INTO OrderItems VALUES(" + this.ordID.ToString() +
            "," + this.cdID.ToString()  + ",'" +  this.qty.ToString() + "','" +
              this.unitCost + "')";


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();


            myConn.Close();
        }

        public void getOrd(int ordNo)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query get OrderItems for the Supplier that is chosen
            String strSQL = "SELECT * FROM OrderItems WHERE OrdID = " + ordNo;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setOrdID(dr.GetInt32(0));
                setCDID(dr.GetInt32(1));
                setQty(dr.GetInt32(2));
                setUnitCost(dr.GetDecimal(3));
            }
            myConn.Close();
        }

        public static DataSet getSuppOrdItems(DataSet DS, int Supp_ID)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM OrderItems WHERE Supp_Id = " + Supp_ID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
    }
}
