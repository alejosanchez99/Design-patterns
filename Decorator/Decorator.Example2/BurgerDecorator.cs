namespace Decorator.Example2
{
    public abstract class BurgerDecorator : IBurger
    {
        protected readonly IBurger burger;

        protected BurgerDecorator(IBurger burger)
        {
            this.burger = burger;
        }

        public virtual string GetDescription()
        {
            return this.burger.GetDescription();
        }

        public virtual double GetCost()
        {
            return this.burger.GetCost();
        }
    }
}
