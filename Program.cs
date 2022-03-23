using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi2 
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxiku driver = new Taxiku();

            driver.DriverName   = "Fatah";
            driver.Onduty       = true;
            driver.NumPassanger = 21114327;

            driver.TaxiInfo();
            Console.WriteLine();
            driver.PickUpPassanger();
            driver.DropoffPassanger();

            Console.ReadKey();
        }
    }
}
