namespace Bridge.Example2
{
    using System;

    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the electric engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping the electric engine");
        }
    }
}
