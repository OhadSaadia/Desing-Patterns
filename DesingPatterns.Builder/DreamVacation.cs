namespace DesingPatterns.Builder
{
    class DreamVacation : VacationBuilder
    {
        public override void BuildFlight()
        {
            vacation.SetFlight("First Class Direct Flight");
        }

        public override void BuildSleepingArrangement()
        {
            vacation.SetSleepingArrangement("5 Stars Hotel");
        }

        public override void BuildTransportations()
        {
            vacation.SetTransportations("Special Cab From AirPort");
        }
    }
}
