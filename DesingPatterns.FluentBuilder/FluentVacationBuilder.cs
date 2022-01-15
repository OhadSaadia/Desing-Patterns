using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FluentBuilder
{
    class FluentVacationBuilder
    {
        private Vacation _vacation = new Vacation();

        public Vacation Builde() => _vacation;

        public FluentVacationBuilder LowCostFlight()
        {
            _vacation.SetFlight("Tourists Class Connection Flight");
            return this;
        }

        public FluentVacationBuilder LowCostTransportations()
        {
            _vacation.SetTransportations("Bus From AirPort");
            return this;
        }

        public FluentVacationBuilder LowCostSleepingArrangements()
        {
            _vacation.SetSleepingArrangement("3 Stars Hotel");
            return this;
        }



        public FluentVacationBuilder DreamFlight()
        {
            _vacation.SetFlight("First Class Direct Flight");
            return this;
        }

        public FluentVacationBuilder DreamTransportations()
        {
            _vacation.SetTransportations("Special Cab From AirPort");
            return this;
        }

        public FluentVacationBuilder DreamSleepingArrangements()
        {
            _vacation.SetSleepingArrangement("5 Stars Hotel");
            return this;
        }
    }
}
