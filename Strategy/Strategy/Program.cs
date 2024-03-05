
using Strategy.Example1;

Navigator navigator = new Navigator(new ShortestRouteStrategy());
Console.WriteLine("Please select you preffered routing strategy (1 - Shortest, 2 - Fastest, 3 - Avoid highways):");
string userChoice = Console.ReadLine();

switch (userChoice)
{
    case "1":
        navigator.SetStrategy(new ShortestRouteStrategy());
        break;
    case "2":
        navigator.SetStrategy(new FastestRouteStrategy());
        break;
    case "3":
        navigator.SetStrategy(new AvoidHighwaysRouteStrategy());
        break;
    default:
        Console.WriteLine("Invalid choice. Defaulting to shortest route strategy.");
        navigator.SetStrategy(new ShortestRouteStrategy());
        break;
}

Console.WriteLine(navigator.ExecuteStrategy("A", "B"));