namespace State.Example2
{
    using System;

    public class EmptyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("The vending machine is empty. Please restock");
        }

        public void InsertPayment(int amount)
        {
            Console.WriteLine("The vending machine is empty. No payment can be processed");
        }

        public void SelectProduct(string product)
        {
            Console.WriteLine("The vending machine is empty. Please restock");
        }
    }
}
