namespace Builder.FastFoodChain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BurgerDirector
    {
        public void MakeBurger(IBurgerBuilder burgerBuilder)
        {
            burgerBuilder.AddBread();
            burgerBuilder.AddMeat();
            burgerBuilder.AddCheese();
            burgerBuilder.AddDressing();
            burgerBuilder.AddLettuce();
            burgerBuilder.AddTomato();
        }
    }
}
