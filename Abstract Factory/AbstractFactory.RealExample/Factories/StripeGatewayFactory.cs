namespace AbstractFactory.Example2.Factories
{
    using AbstractFactory.Example2.CroncreteClasess;
    using AbstractFactory.Example2.CroncreteClasess.PayPal;

    public class StripeGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateWay()
        {
            return new StripeGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new StripeTransactionLogger();
        }
    }
}
