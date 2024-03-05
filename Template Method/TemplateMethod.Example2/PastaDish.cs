namespace TemplateMethod.Example2
{
    using System;

    public abstract class PastaDish
    {
        public void CookPastaDish()
        {
            this.BoilWater();
            this.AddPasta();
            this.Drain();
            this.AddSauce();
            this.AddProtein();
            this.AddCheese();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void AddPasta()
        {
            Console.WriteLine("Adding pasta");
        }

        public void Drain()
        {
            Console.WriteLine("Draining Water");
        }

        public abstract void AddSauce();
        public abstract void AddProtein();
        public abstract void AddCheese();
    }
}
