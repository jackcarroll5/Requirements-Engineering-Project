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













    }
}
