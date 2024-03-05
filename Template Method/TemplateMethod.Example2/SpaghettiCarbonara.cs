namespace TemplateMethod.Example2
{
    using System;

    internal class SpaghettiCarbonara : PastaDish
    {
        public override void AddCheese()
        {
            Console.WriteLine("Adding pecorino cheese");
        }

        public override void AddProtein()
        {
            Console.WriteLine("Adding pancetta");
        }

        public override void AddSauce()
        {
            Console.WriteLine("Adding carbonara sauce");
        }
    }
}
