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
        private int qty;
        private decimal unitCost;
       private int cdID;
        private int orderID;

        public OrderItems()
        {
            ordID = 00000;
            qty = 0;
            unitCost = 0;
            cdID = 00000;
            orderID = 0000;
        }

        public OrderItems(int ordID, int qty, decimal unitCost, int cdID, int orderID)
        {
            setOrdID(ordID);
             setQty(qty);
            setUnitCost(unitCost);
            setCDID(cdID);
            setOrderID(orderID);
        }


        public void setOrdID(int ordID)
        {
            this.ordID = ordID;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public void setUnitCost(decimal unitCost)
        {
            this.unitCost = unitCost;
        }

        public void setCDID(int cdID)
        {
            this.cdID = cdID;
        }

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }



        public int getOrdID()
        {
            return ordID;
        }

        public int getQty()
        {
            return qty;
        }
        public decimal getUnitCost()
        {
            return unitCost;
        }
        public int getCDID()
        {
            return cdID;
        }
        public int getOrderID()
        {
            return orderID;
        }

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



    }
}
