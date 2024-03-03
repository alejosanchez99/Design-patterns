
using Mediator;

InventorySystem inventorySystem = new InventorySystem(null);
ShoppingCart shoppingCart = new ShoppingCart(null);

EcommercePlataform ecommercePlataform = new EcommercePlataform(shoppingCart, inventorySystem);

inventorySystem.SetMediator(ecommercePlataform);
shoppingCart.SetMediator(ecommercePlataform);

shoppingCart.AddItem("Apple");
shoppingCart.AddItem("Orange");
