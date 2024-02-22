namespace Builder.FastFoodChain
{
    public class VeggieBurgerBuilder : IBurgerBuilder
    {
        private readonly Burger veggieBurger = new Burger();

        public void AddBread()
        {
            this.veggieBurger.Bread = "Whole Wheat";
        }

        public void AddCheese()
        {
            this.veggieBurger.Cheese = "Vegan cheese";
        }

        public void AddDressing()
        {
            this.veggieBurger.Dressing = "Vegan mayo";
        }

        public void AddLettuce()
        {
            this.veggieBurger.Lettuce = true;
        }

        public void AddMeat()
        {
            this.veggieBurger.Meat = "Lentil patty";
        }

        public void AddTomato()
        {
            this.veggieBurger.Tomato = true;
        }

        public Burger GetBurger()
        {
            return this.veggieBurger;
        }
    }
}
