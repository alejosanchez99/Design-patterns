namespace Strategy.Example2
{
    using System;

    public class WalkingStrategy : ITransportModeStrategy
    {
        public void GoToWork()
        {
            Console.WriteLine("Walking to work. it's a good exercise and eco-friendly.");
        }
    }
}
