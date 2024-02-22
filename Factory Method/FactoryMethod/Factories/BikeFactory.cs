namespace FactoryMethod.Factories
{
    using FactoryMethod.Products;

    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicule()
        {
            return new Bike();
        }
    }
}
