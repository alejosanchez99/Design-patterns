namespace Strategy.Example2
{
    using System;

    public class CarStrategy : ITransportModeStrategy
    {
        public void GoToWork()
        {
            Console.WriteLine("Going to work by car. it's comfortable and fast.");
        }
    }
}
