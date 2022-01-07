using System;

namespace DesignPatterns.Proxies
{
    class Program
    {
        static void Main(string[] args)
        {
            InteriorOffice interiorOffice = new InteriorOffice();

            IShowInfo interriorMachine = new InteriorOfficeProxy(interiorOffice);

            ShowId(interriorMachine);
        }

        static void ShowId(IShowInfo info)
        {
            info.ShowID();
        }
    }
}
