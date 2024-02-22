namespace FactoryMethod.Notification.Factories
{
    using FactoryMethod.Notification.Products;

    public class SmsFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
