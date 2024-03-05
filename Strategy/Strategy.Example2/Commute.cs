namespace Strategy.Example2
{
    public class Commute
    {
        private ITransportModeStrategy transportModeStrategy;

        public Commute(ITransportModeStrategy transportModeStrategy)
        {
            this.transportModeStrategy = transportModeStrategy;
        }

        public void SetTransportModeStrategy(ITransportModeStrategy transportModeStrategy)
        {
            this.transportModeStrategy = transportModeStrategy;
        }

        public void GoToWork()
        {
            this.transportModeStrategy.GoToWork();
        }
    }
}
