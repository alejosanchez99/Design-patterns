
using Singleton2;

MySingleton instance = MySingleton.GetInstance();

Console.WriteLine($"Instance 1 ID: {instance.Id}");

MySingleton instance2 = MySingleton.GetInstance();

Console.WriteLine($"Instance 2 ID: {instance2.Id}");

MySingleton instance3 = MySingleton.GetInstance();

Console.WriteLine($"Instance 3 ID: {instance3.Id}");
