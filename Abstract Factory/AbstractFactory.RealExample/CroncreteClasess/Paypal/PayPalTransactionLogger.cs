namespace AbstractFactory.Example2.CroncreteClasess.PayPal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PayPalTransactionLogger : ITransactionLogger
    {
        public void LogTransaction(string message)
        {
            Console.WriteLine($"Registering transaction in PayPal: {message}");
        }
    }
}
