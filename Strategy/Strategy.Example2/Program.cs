
using Strategy.Example2;

Commute morningCommute = new Commute(new CarStrategy());
Commute middayCommute = new Commute(new BusStrategy());
Commute eveningCommute = new Commute(new BikeStrategy());

Console.WriteLine("Enter the time (in hours from 0 to 23):");
int hour = int.Parse(Console.ReadLine());

if (hour >= 7 && hour <= 9)
{
    Console.WriteLine("Morning commute with Car:");
    morningCommute.GoToWork();
}
else if (hour >= 10 && hour <= 16)
{
    Console.WriteLine("midday commute with Bus:");
    middayCommute.GoToWork();
}
else if (hour >= 17 && hour <= 19)
{
    Console.WriteLine("Evening commute with Bicyle:");
    eveningCommute.GoToWork();
}
else
{
    Console.WriteLine("Morning commute with Car by default:");
    morningCommute.GoToWork();
}