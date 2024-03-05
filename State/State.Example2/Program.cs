using State.Example2;

VendingMachine vendingMachine = new VendingMachine();
vendingMachine.SelectProduct("Candy");
vendingMachine.SetState(new WaitingForPaymentState());

vendingMachine.InsertPayment(50);
vendingMachine.SetState(new DispenseProductState());

vendingMachine.DispenseProduct();
vendingMachine.SetState(new EmptyState());

vendingMachine.SelectProduct("Soda");