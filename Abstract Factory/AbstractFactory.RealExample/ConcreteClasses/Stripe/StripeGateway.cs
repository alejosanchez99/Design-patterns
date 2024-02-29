namespace AbstractFactory.Example2.CroncreteClasess.PayPal
{
    using System;

    public class StripeGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with Stripe");

            return true;
        }
    }
}
