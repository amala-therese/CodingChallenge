using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class Employee
    {
        public string Name;
        public string Department;

        private string _designation { get; set; }


        public int Salary;
        public string Designation
        {
            get
            {
                return _designation;
            }

            set
            {
                if (value == "trainee")
                {
                    Salary = 5000;
                }
                else if (value == "senior employee")
                {
                    Salary = 15000;

                }
                else if (value== "manager")
                {
                    Salary = 25000;
                }

                _designation = value;

            }

        }
       
    }
}

