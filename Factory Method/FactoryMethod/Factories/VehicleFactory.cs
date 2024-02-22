using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicule();

        public IVehicle OrderVehicule()
        {
            IVehicle vehicle = CreateVehicule();

            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

            return vehicle;
        }
    }
}
