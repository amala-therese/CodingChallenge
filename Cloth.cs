using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Cloth
    {

        public string Stock { get; set; }


        public int Price { get; set; }

        public string Category { get; set; }

        public string  Sale { get; set; }

        public void StockValue()
        {
            if(Stock == "old")
            {
                Sale = "Discount";
                Price = Price - (Price * 20) / 100;
                return;
            }
            else if (Stock == "new")
            {
                Sale = "Normal";
                Price = Price;
                return;
            }
        }

        public void ShowData()
        {
            Console.WriteLine(Stock);
            Console.WriteLine(Price);
            Console.WriteLine(Sale);
        }







    }




}
