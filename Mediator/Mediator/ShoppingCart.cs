namespace Mediator
{
    public class ShoppingCart
    {
        private IMediator mediator;

        public ShoppingCart(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void AddItem(string item)
        {
            this.mediator.Notify(this, item);
        }
    }
}
