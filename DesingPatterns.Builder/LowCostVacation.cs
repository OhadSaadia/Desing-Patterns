namespace DesingPatterns.Builder
{
    class LowCostVacation : VacationBuilder
    {
        public override void BuildFlight()
        {
            vacation.SetFlight("Tourists Class Connection Flight");
        }

        public override void BuildSleepingArrangement()
        {
            vacation.SetSleepingArrangement("3 Stars Hotel");
        }

        public override void BuildTransportations()
        {
            vacation.SetTransportations("Bus From AirPort");
        }
    }
}
