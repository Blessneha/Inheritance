using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Furniture
    {
        public int orderid;
        public DateTime orderdate;
        private string furnituretype;
        public int qty;
        public int totamt;
        private string paymentmode;

        public string FurnitureType { 
            get
            {
                return furnituretype;
            }

            set
            {
                if(value=="Chair"||value=="Cot")
                {
                    furnituretype=value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public string PaymentMode
        {
            get
            {
                return paymentmode;
            }
            set
            {
                if (value == "credit card" || value == "debit card")
                {
                    paymentmode = value;

                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }

        public void GetData(int orderid, DateTime orderdate,  int qty, int totamt,  string furnitureType, string paymentMode)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
        
            this.qty = qty;
            this.totamt = totamt;
            FurnitureType = furnitureType;

            PaymentMode = paymentMode;
        }
        public void ShowData()
        {
            Console.WriteLine("Orderid: " + orderid);
            Console.WriteLine("Date: " + orderdate);
            Console.WriteLine("Furniture type: " + FurnitureType);
            Console.WriteLine("qty: " + qty);
            Console.WriteLine("total amount:" + totamt);
           
            Console.WriteLine("Payment mode:  " + PaymentMode);

        }

    }
}
