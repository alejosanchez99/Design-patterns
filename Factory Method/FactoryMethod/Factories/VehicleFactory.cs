namespace FactoryMethod.Factories
{
    using FactoryMethod.Products;

    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicule();

        public IVehicle OrderVehicule()
        {
            IVehicle vehicle = this.CreateVehicule();

            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

            return vehicle;
        }
    }
}
