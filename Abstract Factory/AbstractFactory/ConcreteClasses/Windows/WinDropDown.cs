namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class WinDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Win Drop Down");
        }
    }
}
