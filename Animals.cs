using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Animals
    {


        public string Name { get; set; }
        public int MaxLife { get; set; }
        public string Food { get; set; }
       
        public void showData()
        {
            Console.WriteLine($" Animal is a {Name}");
            Console.WriteLine($" it lives for {MaxLife} years");
            Console.WriteLine($" it eats {Food}");
        }
    }
}
