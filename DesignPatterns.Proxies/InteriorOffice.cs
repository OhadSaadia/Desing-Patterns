using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxies
{
    class InteriorOffice : IReports, IShowInfo
    {
        public void SendChangeNameReport()
        {
            Console.WriteLine("Sending Change Name Report...");
        }

        public void SendQuarterReport()
        {
            Console.WriteLine("Sending Quarter Report...");

        }

        public void ShowChildren()
        {
            Console.WriteLine("The Children");

        }

        public void ShowID()
        {
            Console.WriteLine("The Id");

        }

        public void ShowPassport()
        {
            Console.WriteLine("The Passport");

        }
    }
}
