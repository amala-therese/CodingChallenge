using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Miles7
    {
        public string Name { get; set; }

        public int TotalMiles { get; set; }

        public int FlyerPoint { get; set; }

        public void Point()
        {
            if(TotalMiles>= 10000 && TotalMiles< 20000)
            {
                FlyerPoint = 10;
                return;
            }
            else if (TotalMiles>=20000 && TotalMiles< 50000)
            {
                FlyerPoint = 20;
                return;
            }
            else if(TotalMiles>=50000 && TotalMiles < 100000)
            {
                FlyerPoint = 30;
                return;
            }
            else if (TotalMiles>= 100000)
            {
                FlyerPoint = 50;
                return;
            }
        }

       public void ShowData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(TotalMiles);
            Console.WriteLine(FlyerPoint);
        }

    }
}
