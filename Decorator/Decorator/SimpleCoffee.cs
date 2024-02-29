namespace Decorator.Example1
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1.0;
        }

        public string GetDescription()
        {
            return "Simple coffee";
        }
    }
}
