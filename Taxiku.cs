using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi2
{
    class Taxiku
    {
        public string DriverName {get; set;}
        public bool Onduty {get; set;}
        public int NumPassanger {get; set;}

        public void TaxiInfo()
    {
            string duty;

            if (Onduty)
            {
                duty = "Yes";
            }
            else
            {
                duty = "No";
            }
        Console.WriteLine("DriverName   : {0}", DriverName);
        Console.WriteLine("OnDuty       : {0}", Onduty);
        Console.WriteLine("NumPassanger : {0}", NumPassanger);
    }
    public void PickUpPassanger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName );
        }
    public void DropoffPassanger()
    {
        Console.WriteLine("{0} Selesai Mengantar Penumpang\n", DriverName);
    }
    }
}
