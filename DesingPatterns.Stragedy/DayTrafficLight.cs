using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Strategy
{
    class DayTrafficLight : ITrafficLight
    {
        public void Operator()
        {
            Console.WriteLine("Traffic Light: Day\nChanged Every One Minute");
        }   
    }

}
