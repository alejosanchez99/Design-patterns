namespace FactoryMethod.Products
{
    using System;

    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the Motorcycle.");
        }

        public void Start()
        {
            Console.WriteLine("Starting the Motorcycle.");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping the Motorcycle.");
        }
    }
}
