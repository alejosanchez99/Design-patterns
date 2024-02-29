namespace Decorator.Example1
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return this.coffee.GetDescription() + ", milk";
        }

        public override double GetCost()
        {
            return this.coffee.GetCost() + 0.5;
        }
    }
}
