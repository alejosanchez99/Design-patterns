namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class WinButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Win Button");
        }
    }
}
