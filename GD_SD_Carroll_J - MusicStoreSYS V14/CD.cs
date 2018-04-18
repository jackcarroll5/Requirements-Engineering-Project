using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MusicStoreSYS
{
    class CD
    {
        private int CD_ID;
        private string album_Name;
        private string artist;
        private int yrReleased;
        private string art_Label;
        private decimal cost_Price;
        private int qty;
        private int suppID;
        private char availability;


        public CD()
        {
          CD_ID = 00000;
          album_Name = "Unknown";
          artist = "Unknown";
          yrReleased = 0000;
          art_Label = "Unknown";
          cost_Price = 0;
          qty = 0;
          suppID = 000;
          availability = 'I';//Stands for unknown
    }

        public CD(int CD_ID,string album_Name, string artist, int yrReleased, string art_Label, decimal cost_Price,
            int qty, char availability)
        {
            setCDID(CD_ID);
            setAlbumName(album_Name);
            setArtist(artist);
            setYr(yrReleased);
            setArtLabel(art_Label);
            setCostPrice(cost_Price);
            setQty(qty);
            setSuppId(suppID);
            setAvailability(availability);
        }


        public void setCDID(int CD_ID)
        {
            this.CD_ID = CD_ID;
        }
        public void setAlbumName(String album_Name)
        {
            this.album_Name = album_Name;
        }

        public void setArtist(string artist)
        {
            this.artist = artist;
        }

        public void setYr(int yrReleased)
        {
            this.yrReleased = yrReleased;
        }

        public void setArtLabel(string art_Label)
        {
            this.art_Label = art_Label;
        }

        public void setCostPrice(decimal cost_Price)
        {
            this.cost_Price = cost_Price;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public void setSuppId(int suppID)
        {
            this.suppID = suppID;
        }

        public void setAvailability(char availability)
        {
            this.availability = availability;
        }


        //Accessors
        public int getCDID()
        {
            return CD_ID;
        }

        public string getAlbumName()
        {
            return album_Name;
        }
        public string getArtist()
        {
            return artist;
        }
        public int getYr()
        {
            return yrReleased;
        }
        public string getArtLabel()
        {
            return art_Label;
        }
        public decimal getCostPrice()
        {
            return cost_Price;
        }
        public int getQty()
        {
            return qty;
        }
        public int getSuppID()
        {
            return suppID;
        }

        public char getAvailability()
        {
            return availability;
        }




        /*public static DataSet getAllCDS(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            conn.Open();

            String strSQL = "SELECT * FROM CDs ORDER BY CD_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            conn.Close();

            return DS;
        }*/

        public void getCD(int CDNo)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM CDs WHERE CD_ID = " + CDNo;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setCDID(dr.GetInt32(0));
               setAlbumName(dr.GetString(1));
                setArtist(dr.GetString(2));
                setYr(dr.GetInt32(3));
               setArtLabel(dr.GetString(4));
                setCostPrice(dr.GetDecimal(5));
                setQty(dr.GetInt32(6));
                setSuppId(dr.GetInt32(7));
            }
            myConn.Close();
        }

        public void updCD()
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "UPDATE CDs SET CD_ID = '" + this.CD_ID.ToString() + "', Album_Name = '" + this.album_Name +
                "', Artist = '" + this.artist + "', Year_Released = " + this.yrReleased.ToString() + ", Artist_Label = '" + this.art_Label +
               "', Cost_Price = " + this.cost_Price.ToString() + ", Qty = " + this.qty.ToString() + " , Supp_Id = " + this.suppID.ToString() + " WHERE CD_ID = '" + this.CD_ID + "'";


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();


            myConn.Close();
        }

        public static void disCD(int CDID)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();


            String strSQL = "UPDATE CDs SET Availability = 'u' WHERE CD_ID = " + CDID;


            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();


        }

        public static DataSet getAllCDS1(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM CDs ORDER BY CD_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getAvailableCDS1(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM CDs WHERE Availability = 'a' ORDER BY CD_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getAllCDsIDOrder(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM CDs ORDER BY CD_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getAllCDsOrderArtLabel(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM CDs ORDER BY Artist_Label";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getSuppCDs(DataSet DS,int Supp_ID)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM CDs WHERE SuppId = " + Supp_ID;
              
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        public static int nextCD()
        {
            // variable to hold value to be returned
            int nextCD;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

           
            String strSQL = "SELECT MAX(CD_ID) FROM CDs";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            
            OracleDataReader dr = cmd.ExecuteReader();         
            dr.Read();

           

            if (dr.IsDBNull(0))
                nextCD = 1;
            else
                nextCD = Convert.ToInt16(dr.GetValue(0)) + 1;

           
            myConn.Close();
   
            return nextCD;
        }


        public void increaseQty()
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "UPDATE CDs SET Qty = Qty " + this.qty;


            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void regCD()
        {       
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

          
            String strSQL = "INSERT INTO CDs VALUES(" + this.CD_ID.ToString() +
                ",'" + this.album_Name.ToUpper() + "','" + this.artist + "','" +
                this.yrReleased.ToString() + "','" + this.art_Label + "'," + this.cost_Price + "," + this.qty + 
                "," + this.suppID.ToString() + ",'" + this.availability + "')";

           
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            
            myConn.Close();
        }


       


    }
}
