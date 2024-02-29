namespace Decorator.Example2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BaconDecorator : BurgerDecorator
    {
        public BaconDecorator(IBurger burger) : base(burger) { }
        public override string GetDescription()
        {
            return this.burger.GetDescription() + ", bacon";
        }

        public override double GetCost()
        {
            return this.burger.GetCost() + 1;
        }

    }
}
