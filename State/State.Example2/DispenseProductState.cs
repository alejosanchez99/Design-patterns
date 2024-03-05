namespace State.Example2
{
    using System;

    public class DispenseProductState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Dispensing product now...");
        }

        public void InsertPayment(int amount)
        {
            Console.WriteLine($"Please wait! Dispensing in progress.");
        }

        public void SelectProduct(string product)
        {
            Console.WriteLine($"Please wait! Dispensing in progress.");
        }
    }
}
