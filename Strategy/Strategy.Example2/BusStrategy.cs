namespace Strategy.Example2
{
    using System;

    public class BusStrategy : ITransportModeStrategy
    {
        public void GoToWork()
        {
            Console.WriteLine("Going to work by bus. it's economical and convenient.");
        }
    }
}
