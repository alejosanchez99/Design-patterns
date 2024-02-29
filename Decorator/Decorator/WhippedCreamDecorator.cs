namespace Decorator.Example1
{
    public class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return this.coffee.GetDescription() + ", whipped cream";
        }
        public override double GetCost()
        {
            return this.coffee.GetCost() + 0.7;
        }
    }
}
