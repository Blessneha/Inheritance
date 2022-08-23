using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chair:Furniture
    {
        private string chairtype;
        private string purpose;
        public int rate;
        public string woodtype;
        public string steeltype;
        public string plasticcolor;

        public string ChairType
        {
            get { return chairtype; }

            set
            {
                if (value == "Wood")
                {
                    chairtype = value;
                    Console.WriteLine("Enter the woodtype:Teak Wood/Rose Wood ");
                    woodtype = Console.ReadLine();
                }
                else if (value == "Steel")
                {
                    chairtype = value;
                    Console.WriteLine("Enter the steel type:Gray Steel/Green Steel/Brown Steel ");
                    steeltype = Console.ReadLine();
                }
                else if (value == "Plastic")
                {   chairtype = value;
                    Console.WriteLine("Enter a plastic color:Green/Red/Blue/White ");
                    plasticcolor = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Not valid value");
                }
            }
        }
        public string Purpose
        {
            get { return purpose; }

            set { if(value == "Home"||value=="office")
                   {
                    purpose=value;

                  }
                        
                        }
        }


        public void GetData(int orderid, DateTime orderdate, int qty, int totamt, string furnitureType, string paymentMode,string chair,int rate,string purpose)
        {
            this.rate = rate;
            ChairType = chair;
            Purpose = purpose;
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.qty = qty;
            this.totamt = totamt;
            FurnitureType = furnitureType;
            PaymentMode = paymentMode;
            
            
        }

       new  public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Chairtype: " + ChairType);
            Console.WriteLine("Purpose: "+Purpose);
            Console.WriteLine("Rate: "+rate);
               if(ChairType=="Wood")
            {
                Console.WriteLine("WoodType: "+woodtype);
            }
               else if(ChairType=="Steel")
            {
                Console.WriteLine("Steel type: "+steeltype);
            }

               else if(ChairType=="Plastic")
            {
                Console.WriteLine("Plastic color: " + plasticcolor);
            }
        }
    }
}
