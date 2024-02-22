namespace FactoryMethod.Notification.Products
{
    using System;

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Push notification: {message}");
        }
    }
}
