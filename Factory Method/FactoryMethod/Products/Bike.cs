namespace FactoryMethod.Products
{
    using System;

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the bike.");
        }

        public void Start()
        {
            Console.WriteLine("Starting the bike.");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping the bike.");
        }
    }
}
