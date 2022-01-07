using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Strategy
{
    class TrafficLightManager
    {
        private ITrafficLight _trafficTime;

        public void Operator(DateTime time)
        {
            if (time.Hour >= 22 || time.Hour < 5)
            {
                _trafficTime = new NightTrafficLight();
            }
            else
            {
                if ((time.Hour <= 8 && time.Hour < 10) || (time.Hour <= 16 && time.Hour < 19))
                {
                    _trafficTime = new RushHourTrafficLight();
                }
                else
                {
                    _trafficTime = new DayTrafficLight();
                }
            }

            _trafficTime.Operator();
        }


    }
}
