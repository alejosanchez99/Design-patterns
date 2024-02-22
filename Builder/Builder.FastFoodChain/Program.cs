using Builder.FastFoodChain;

IBurgerBuilder classicBurgerBuilder = new ClassicBurgerBuilder();
IBurgerBuilder VeggieBurgerBuilder = new VeggieBurgerBuilder();

BurgerDirector chef = new BurgerDirector();

chef.MakeBurger(classicBurgerBuilder);
chef.MakeBurger(VeggieBurgerBuilder);

Burger classicBurger = classicBurgerBuilder.GetBurger();
Burger veggieBurger = VeggieBurgerBuilder.GetBurger();

Console.WriteLine("Classic Burger:");
classicBurger.DisplayInformation();

Console.WriteLine("Veggie Burger:");
veggieBurger.DisplayInformation();