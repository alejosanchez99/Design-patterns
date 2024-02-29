namespace AbstractFactory.Example2.CroncreteClasess.PayPal
{
    using System;

    public class StripeTransactionLogger : ITransactionLogger
    {
        public void LogTransaction(string message)
        {
            Console.WriteLine($"Registering transaction in Stripe: {message}");
        }
    }
}
