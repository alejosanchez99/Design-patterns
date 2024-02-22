namespace AbstractFactory.Example2.Factories
{
    using AbstractFactory.Example2.CroncreteClasess;

    public interface IPaymentGatewayFactory
    {
        IPaymentGateway CreatePaymentGateWay();
        ITransactionLogger CreateTransactionLogger();
    }
}
