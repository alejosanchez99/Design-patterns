namespace Decorator.Example1
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return this.coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return this.coffee.GetDescription();
        }
    }
}
