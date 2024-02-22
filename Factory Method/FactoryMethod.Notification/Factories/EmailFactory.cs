using FactoryMethod.Notification.Products;

namespace FactoryMethod.Notification.Factories
{
    public class EmailFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
