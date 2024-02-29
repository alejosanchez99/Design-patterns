namespace Decorator.Example2
{
    public class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger) { }
        public override string GetDescription()
        {
            return this.burger.GetDescription() + ", cheese";
        }

        public override double GetCost()
        {
            return this.burger.GetCost() + 2;
        }
    }
}
