namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }
}
