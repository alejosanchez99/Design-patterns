namespace Decorator.Example2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger) { }
        public override string GetDescription()
        {
            return burger.GetDescription() + ", cheese";
        }

        public override double GetCost()
        {
            return this.burger.GetCost() + 2;
        }
    }
}
