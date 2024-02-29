namespace AbstractFactory.Example2.CroncreteClasess.PayPal
{
    using System;

    public class PayPalTransactionLogger : ITransactionLogger
    {
        public void LogTransaction(string message)
        {
            Console.WriteLine($"Registering transaction in PayPal: {message}");
        }
    }
}
