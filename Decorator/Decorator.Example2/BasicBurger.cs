namespace Decorator.Example2
{
    public class BasicBurger : IBurger
    {
        public double GetCost()
        {
            return 3.0;
        }

        public string GetDescription()
        {
            return "Basic burger";
        }
    }
}
