namespace FactoryMethod.Notification.Factories
{
    using FactoryMethod.Notification.Products;

    public class PushFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
