namespace FactoryMethod.Notification.Factories
{
    using FactoryMethod.Notification.Products;

    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
