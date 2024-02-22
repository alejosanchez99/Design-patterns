namespace FactoryMethod.Factories
{
    using FactoryMethod.Products;

    public class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicule()
        {
            return new Motorcycle();
        }
    }
}
