namespace Command.Example1
{
    public class CancelOrderCommand : ICommand
    {
        private readonly Order order;

        public CancelOrderCommand(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            this.order.Cancel();
        }
    }
}
