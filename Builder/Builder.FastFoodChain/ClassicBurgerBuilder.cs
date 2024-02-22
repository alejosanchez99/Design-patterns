namespace Builder.FastFoodChain
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private readonly Burger classicBurger = new Burger();

        public void AddBread()
        {
            this.classicBurger.Bread = "Sesame bread";
        }

        public void AddCheese()
        {
            this.classicBurger.Cheese = "Cheddar";
        }

        public void AddDressing()
        {
            this.classicBurger.Dressing = "Ketchup";
        }

        public void AddLettuce()
        {
            this.classicBurger.Lettuce = true;
        }

        public void AddMeat()
        {
            this.classicBurger.Meat = "Chicken";
        }

        public void AddTomato()
        {
            this.classicBurger.Tomato = true;
        }

        public Burger GetBurger()
        {
            return this.classicBurger;
        }
    }
}
