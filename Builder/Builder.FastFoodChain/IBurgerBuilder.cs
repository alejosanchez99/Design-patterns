namespace Builder.FastFoodChain
{
    public interface IBurgerBuilder
    {
        void AddBread();
        void AddMeat();
        void AddCheese();
        void AddDressing();
        void AddLettuce();
        void AddTomato();
        Burger GetBurger();
    }
}
