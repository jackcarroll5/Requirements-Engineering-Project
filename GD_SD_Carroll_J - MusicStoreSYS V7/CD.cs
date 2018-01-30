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
        public char getAvailability()
        {
            return availability;
        }




        public static DataSet getAllCDS(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name conn.Open();
            String strSQL = "SELECT CD_ID, Album_Name,Artist FROM CD ORDER BY CD_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

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

        public void regCD()
        {       
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

          
            String strSQL = "INSERT INTO CDs VALUES(" + this.CD_ID.ToString() +
                ",'" + this.album_Name + "','" + this.artist + "','" +
                this.yrReleased.ToString() + "','" + this.art_Label + "'," + this.cost_Price + "," + this.qty
                + ",'" + this.availability + "')";

           
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            
            myConn.Close();
        }


    }
}
