using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Company
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
    }

      class Emp: Company
        {
            public string EmpName { get; set; }

            public string Designation { get; set; }

          public void ReadData()
        {
            Console.WriteLine("company name:");
              CompanyName =Console.ReadLine();
            Console.WriteLine("company type:");
            CompanyType = Console.ReadLine();

            Console.WriteLine("employee name:");
            EmpName = Console.ReadLine();

            Console.WriteLine("designation:");
            Designation = Console.ReadLine();






        }


        public void ShowData()
            {
                Console.WriteLine(CompanyName);
                Console.WriteLine(CompanyType);
                Console.WriteLine(EmpName);
                Console.WriteLine(Designation);
            }
      

    }
}
