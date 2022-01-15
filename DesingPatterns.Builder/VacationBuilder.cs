namespace DesingPatterns.Builder
{
    abstract class VacationBuilder
    {
        protected Vacation vacation = new Vacation();

        public abstract void BuildFlight();
        public abstract void BuildTransportations();
        public abstract void BuildSleepingArrangement();

        public void ConstructVacation()
        {
            BuildFlight();
            BuildTransportations();
            BuildSleepingArrangement();
        }

        public Vacation GetVacation()
        {
            return vacation;
        }


    }
}
