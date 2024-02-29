namespace AbstractFactory.Example2.CroncreteClasess.PayPal
{
    using System;

    public class PayPalGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with PayPal");

            return true;
        }
    }
}
