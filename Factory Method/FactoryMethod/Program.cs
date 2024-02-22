using FactoryMethod.Factories;
using FactoryMethod.Products;

Console.WriteLine("Welcome to the coder cave factory metho example!");

VehicleFactory vehicleFactory = null;


while (true)
{
    Console.WriteLine("Please choose a vehicule type: 1.Car, 2.Motorcycle, 3.Bike, 4. Quit");
    int vehiculeChoice = Convert.ToInt32(Console.ReadLine());

    switch (vehiculeChoice)
    {
        case 1:
            vehicleFactory = new CarFactory();
            break;
        case 2:
            vehicleFactory = new MotorcycleFactory();
            break;
        case 3:
            vehicleFactory = new BikeFactory();
            break;
        default:
            break;
    }

    IVehicle vehicle = vehicleFactory.OrderVehicule();
    Console.WriteLine($"you have used a {vehicle.GetType().Name}\n");
}

Console.WriteLine("Thank you for using the System");