namespace FactoryMethod.Notification.Factories
{
    using FactoryMethod.Notification.Products;

    public class EmailFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
