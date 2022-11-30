using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class student
    {
        public string FullName { get; set; }
        private int _age;
       // public int Mark2;
       // public int Total()=>Mark1 + Mark2;

        //public void GetData()
        //{
        //    Console.Write("enter the name");
        //    Name = Console.ReadLine();
        //    Console.Write("enter Mark 1");
        //    Mark1 = int.Parse(Console.ReadLine());
        //    Console.Write("enter mark2 ");
        //    Mark2 = int.Parse(Console.ReadLine());
        //}
        public int Age
        {
            get { return _age; }
            set { 
                
                if(value < 18|| value> 50)
                {
                    Console.WriteLine("invalid age");
                    return;
                }
                _age = value;
            }
        }




    } 
}
