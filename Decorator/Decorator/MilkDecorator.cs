namespace Decorator.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return this.coffee.GetDescription() + ", milk";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 0.5;
        }
    }
}
