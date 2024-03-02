namespace Command.Example1
{
    public class PlaceOrderCommand : ICommand
    {
        private Order order;

        public PlaceOrderCommand(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            this.order.Place();
        }
    }
}
