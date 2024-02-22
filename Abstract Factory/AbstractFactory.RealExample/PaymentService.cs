namespace AbstractFactory.Example2
{
    using AbstractFactory.Example2.CroncreteClasess;
    using AbstractFactory.Example2.Factories;

    public class PaymentService
    {
        private readonly IPaymentGateway paymentGateway;
        private readonly ITransactionLogger transactionLogger;

        public PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
        {
            this.paymentGateway = paymentGatewayFactory.CreatePaymentGateWay();
            this.transactionLogger = paymentGatewayFactory.CreateTransactionLogger();
        }

        public void ProcessPayment(decimal amount)
        {
            string messageProcessPayment = paymentGateway.ProcessPayment(amount) ? "successful" : "failed";

            this.transactionLogger.LogTransaction($"Payment of {amount}, was {messageProcessPayment}");
        }
    }
}
