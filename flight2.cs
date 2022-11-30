using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcore
{
    internal class flight2

    {

        public int  BookingTime { get; set; }
        public int Fare { get; set; }

        public int FareRise { get; set; }
       
        
        public void ShowRise()
        {
            if (6 <= BookingTime && BookingTime < 9)
            {
                FareRise = 10;
                Fare = Fare + (Fare * 10) / 100;
                return;

            }
            else if (9 <= BookingTime && BookingTime < 17)
            {
                FareRise = 20;
                Fare = Fare + (Fare * 20) / 100;
                return;
            }
            else if (17 <= BookingTime && BookingTime < 23)
            {
                FareRise = 7;
                Fare = Fare + (Fare * 7) / 100;
                return;

            }
            else if (23 <= BookingTime && BookingTime < 24)
            {

                FareRise = 5;
                Fare = Fare + (Fare * 5) / 100;
                return;

            }
            else if  (0 <= BookingTime && BookingTime < 6){
                FareRise = 5;
                Fare = Fare + (Fare * 5) / 100;
                return;

            }
            
            
        }
        public void ShowData()
        {
            Console.WriteLine(BookingTime);
            Console.WriteLine(Fare);
            Console.WriteLine(FareRise);

        }
    
    
    
    }
}




