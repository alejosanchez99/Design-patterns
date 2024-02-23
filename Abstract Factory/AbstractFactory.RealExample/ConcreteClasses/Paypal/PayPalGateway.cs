namespace AbstractFactory.Example2.CroncreteClasess.PayPal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PayPalGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with PayPal");

            return true;
        }
    }
}
