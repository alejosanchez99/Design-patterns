using Command.Example1;

Order order = new Order();
ICommand placeOrder = new PlaceOrderCommand(order);
ICommand cancelOrder = new CancelOrderCommand(order);

Waiter waiter = new Waiter();
waiter.TakeCommand(placeOrder);
waiter.TakeCommand(cancelOrder);