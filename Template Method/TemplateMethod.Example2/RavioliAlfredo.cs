namespace TemplateMethod.Example2
{
    using System;

    public class RavioliAlfredo : PastaDish
    {
        public override void AddCheese()
        {
            Console.WriteLine("Adding parmesan cheese");
        }

        public override void AddProtein()
        {
            Console.WriteLine("Adding chicken");
        }

        public override void AddSauce()
        {
            Console.WriteLine("Adding alfredo sauce");
        }
    }
}
