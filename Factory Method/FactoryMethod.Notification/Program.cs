
using FactoryMethod.Notification.Factories;
using FactoryMethod.Notification.Products;

Console.WriteLine("Welcome to the Notification module!");

NotificationFactory? notificationFactory;

while (true)
{
    Console.WriteLine("Please choose a vehicule type: 1.Email, 2.SMS, 3.Push, 4. Quit");
    int notificationChoise = Convert.ToInt32(Console.ReadLine());

    switch (notificationChoise)
    {
        case 1:
            notificationFactory = new EmailFactory();
            break;
        case 2:
            notificationFactory = new SmsFactory();
            break;
        case 3:
            notificationFactory = new PushFactory();
            break;
        default:
            return;
    }

    INotification notification = notificationFactory.CreateNotification();

    Console.WriteLine($"Please enter the message to send:");
    string message = Console.ReadLine();

    notification.Send(message);
}