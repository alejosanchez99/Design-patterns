namespace AbstractFactory.Example2.CroncreteClasess
{
    public interface IPaymentGateway
    {
        bool ProcessPayment(decimal amount);
    }
}
