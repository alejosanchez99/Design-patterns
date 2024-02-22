namespace AbstractFactory.Example2.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AbstractFactory.Example2.CroncreteClasess;
    using AbstractFactory.Example2.CroncreteClasess.PayPal;

    public class PayPalGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateWay()
        {
            return new PayPalGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new PayPalTransactionLogger();
        }
    }
}
