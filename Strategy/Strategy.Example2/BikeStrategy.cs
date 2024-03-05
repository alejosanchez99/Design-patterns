namespace Strategy.Example2
{
    using System;

    public class BikeStrategy : ITransportModeStrategy
    {
        public void GoToWork()
        {
            Console.WriteLine("Going to work by bike. it's eco friendly and healthy");
        }
    }
}
