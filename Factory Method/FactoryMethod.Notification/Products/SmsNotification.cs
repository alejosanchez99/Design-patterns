namespace FactoryMethod.Notification.Products
{
    using System;

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }
}
