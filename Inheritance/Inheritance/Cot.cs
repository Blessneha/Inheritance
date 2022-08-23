using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cot:Furniture
    {

        private string cottype;
        private string capacity;
        public string woodtype;
        public string steeltype;
        public int rate;

        public string Capacity
        {
            get { return capacity; }

            set
            {
                if (value == "Single" || value == "Double")
                    capacity = value;
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }
        public string Cottype
        {
            get { return cottype; }


            set
            {
                if (value == "Wood")
                {
                    cottype = value;
                    Console.WriteLine("Enter the woodtype whether Teak Wood/Rose Wood");
                    woodtype = Console.ReadLine();
                }
                else if (value == "Steel")
                {
                    cottype=value;
                    Console.WriteLine("Enter the steel type:Gray Steel/Green Steel/Brown Steel ");
                    steeltype = Console.ReadLine();
                }
            }
        }
        public void GetData(int orderid, DateTime orderdate, int qty, int totamt, string furnitureType, string paymentMode,int rate,string capacity,string cottype)
        {
            this.rate = rate;
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.qty = qty;
            this.totamt = totamt;
            FurnitureType = furnitureType;
            PaymentMode = paymentMode;
            Capacity = capacity;
            Cottype=cottype;
            
            

        }

       new public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Cottype: "+Cottype);
            if (Cottype == "Wood")
            {
                Console.WriteLine("WoodType: " + woodtype);
            }
            else if (Cottype == "Steel")
            {
                Console.WriteLine("Steel type: " + steeltype);
            }

        }
    }
}
