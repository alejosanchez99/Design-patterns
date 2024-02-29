namespace Decorator.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
