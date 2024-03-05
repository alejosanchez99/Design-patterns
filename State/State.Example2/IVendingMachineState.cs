namespace State.Example2
{
    public interface IVendingMachineState
    {
        void SelectProduct(string product);
        void InsertPayment(int amount);
        void DispenseProduct();
    }
}
