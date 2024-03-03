namespace Mediator
{
    public class InventorySystem
    {
        private IMediator mediator;

        public InventorySystem(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void CheckItemAvailability(string item)
        {
            Console.WriteLine($"Checking how many {item} are available...");
        }
    }
}
