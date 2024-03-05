namespace State.Example2
{
    public class VendingMachine
    {
        private IVendingMachineState state;

        public VendingMachine()
        {
            this.state = new WaitingForProductSelectionState();
        }

        public void SetState(IVendingMachineState state)
        {
            this.state = state;
        }

        public void SelectProduct(string product)
        {
            this.state.SelectProduct(product);
        }

        public void InsertPayment(int amount)
        {
            this.state.InsertPayment(amount);
        }

        public void DispenseProduct()
        {
            this.state.DispenseProduct();
        }

    }
}
