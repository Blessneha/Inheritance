using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
         /*   Furniture f=new Furniture();
            f.GetData(2, DateTime.Now, 2, 33, "Chair", "credit card");
            f.ShowData();*/
       /*  Chair c=new Chair();
            c.GetData(2, DateTime.Now, 2, 33, "Chair", "credit card", "Wood", 23, "Home");
            c.ShowData(); */

             Cot ob=new Cot();
            ob.GetData(2, DateTime.Now, 5, 33, "Cot", "credit card", 3, "Single", "Steel");
            ob.ShowData();
        }
    }
}
