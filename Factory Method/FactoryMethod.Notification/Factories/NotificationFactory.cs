using FactoryMethod.Notification.Products;

namespace FactoryMethod.Notification.Factories
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
