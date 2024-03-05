namespace State.Example2
{
    using System;

    public class WaitingForPaymentState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Please insert payment first.");
        }

        public void InsertPayment(int amount)
        {
            Console.WriteLine($"Inserted payment of {amount}");
        }

        public void SelectProduct(string product)
        {
            Console.WriteLine($"Product {product} has been selected, waiting for payment.");
        }
    }
}
