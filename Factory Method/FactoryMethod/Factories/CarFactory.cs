namespace FactoryMethod.Factories
{
    using FactoryMethod.Products;

    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicule()
        {
            return new Car();
        }
    }
}
