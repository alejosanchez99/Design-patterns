namespace FactoryMethod.Products
{
    using System;

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the car.");
        }

        public void Start()
        {
            Console.WriteLine("Starting the car.");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping the car.");
        }
    }
}
