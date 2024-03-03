namespace Mediator
{
    public class EcommercePlataform : IMediator
    {
        private ShoppingCart shoppingCart;
        private InventorySystem inventorySystem;

        public EcommercePlataform(ShoppingCart shoppingCart, InventorySystem inventorySystem)
        {
            this.shoppingCart = shoppingCart;
            this.inventorySystem = inventorySystem;
        }
        public void Notify(object sender, string eventCode)
        {
            if (sender is ShoppingCart)
            {
                this.inventorySystem.CheckItemAvailability(eventCode);
            }
        }
    }
}
