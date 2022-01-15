using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FluentBuilder
{
    class Vacation
    {
        string _flight;
        string _transportations;
        string _sleepingArrangement;

        public void SetFlight(string flight)
        {
            _flight = flight;
        }
        public void SetTransportations(string transportations)
        {
            _transportations = transportations;
        }
        public void SetSleepingArrangement(string sleepingArrangement)
        {
            _sleepingArrangement = sleepingArrangement;
        }

        public override string ToString()
        {
            return $"Flight: {_flight}, \nTransportations: {_transportations}, \nsleeping arrangements: {_sleepingArrangement}";
        }
    }
}
