using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MusicStoreSYS
{
    class Supplier
    {
        private int supp_ID;
        private string supp_Name;
        private int phone_No;
        private string email;
        private string street;
        private string townVillage;
        private string county;
        private decimal accBal;
        private char status;

     public Supplier()
        {
            supp_ID = 000;
            supp_Name = "No name";
            phone_No = 0000000000;
            email = "My email";
            street = "Unknown";
            townVillage = "Unknown";
            county = "Unknown";
            accBal = 0;
            status = 'U';//Unknown
          
        }

        public Supplier(int supp_ID, string supp_Name, int phone_No, string email, string street, string townVillage, string county,
            decimal accBal, char status)
        {
            setSuppID(supp_ID);
            setSuppName(supp_Name);
            setPhoneNo(phone_No);
            setEmail(email);
            setStreet(street);
            setTownVillage(townVillage);
            setCounty(county);
            setAccBal(accBal);
            setStatus(status);
        }

        //Mutators
        public void setSuppID(int supp_ID)
        {
            this.supp_ID = supp_ID;
        }
        public void setSuppName(String supp_Name)
        {
            this.supp_Name = supp_Name;
        }

        public void setPhoneNo(int phone_No)
        {
            this.phone_No = phone_No;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setStreet(string street)
        {
            this.street = street;
        }

        public void setTownVillage(string townVillage)
        {
            this.townVillage = townVillage;
        }

        public void setCounty(string county)
        {
            this.county = county;
        }

        public void setAccBal(decimal accBal)
        {
            this.accBal = accBal;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }

        

        //Accessors
        public int getSuppID()
        {
            return supp_ID;
        }

        public string getSuppName()
        {
            return supp_Name;
        }
        public int getPhoneNo()
        {
            return phone_No;
        }
        public string getEmail()
        {
            return email;
        }
        public string getStreet()
        {
            return street;
        }
        public string getTownVillage()
        {
            return townVillage;
        }

        public string getCounty()
        {
            return county;
        }

        public decimal getAccBal()
        {
            return accBal;
        }
        public char getStatus()
        {
            return status;
        }
       


        //define a static method to get data
        /*public static DataSet getAllSuppliers(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();


            String strSQL = "SELECT * FROM Suppliers ORDER BY Supp_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
             



            }


            conn.Close();

            return DS;
        }*/

        public void updSupp()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Suppliers SET Supp_Name = '" + this.supp_Name.ToUpper() + "', PhoneNo = '" + this.phone_No +
                "', Email = '" + this.email + "', Street = '" + this.street + "', TownVillage = '" + this.townVillage + "', County_Code = '" + this.county +
                "', Acc_Bal = '" + this.accBal + "' WHERE Supp_Id = " + this.supp_ID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static DataSet getAllCounties(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Counties ORDER BY County_Code";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static void deregSupp(int SuppID)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            String strSQL = "UPDATE Suppliers SET Status = 'I' WHERE Supp_Id = " + SuppID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            
            myConn.Close();
        }

        public void getSupp(int suppID)
        {
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM Suppliers WHERE Supp_Id = " + suppID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setSuppID(dr.GetInt32(0));
                setSuppName(dr.GetString(1));
                setPhoneNo(dr.GetInt32(2));
                setEmail(dr.GetString(3));
                setStreet(dr.GetString(4));
                setTownVillage(dr.GetString(5));
                setCounty(dr.GetString(6));  
                setAccBal(dr.GetDecimal(7));
            }
            myConn.Close();
        }

        public static DataSet getAllSuppliers1(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM Suppliers ORDER BY Supp_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getAllSuppliersIDOrder(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM Suppliers ORDER BY Supp_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getAllSuppliersOrderNames(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM Suppliers ORDER BY Supp_Name";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet getAllActiveSuppliers(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DataConnect.orac);

            //connection name 
            conn.Open();

            String strSQL = "SELECT * FROM Suppliers WHERE Status = 'A' ORDER BY Supp_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static int nextSupplier()
        {
            // variable to hold value to be returned
            int nextSupplier;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT MAX(Supp_Id) FROM Suppliers";

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
                nextSupplier = 1;
            else
                nextSupplier = Convert.ToInt16(dr.GetValue(0)) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return nextSupplier;
        }

        public void regSupplier()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DataConnect.orac);
            myConn.Open();

            //Define SQL query to INSERT Supplier record
            String strSQL = "INSERT INTO Suppliers VALUES(" + this.supp_ID.ToString() +
                ",'" + this.supp_Name + "'," + this.phone_No + ",'" +
                this.email + "','" + this.street + "','" + this.townVillage + "','" + this.county 
                + "'," + this.accBal + ",'" + this.status + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }





    }
}
