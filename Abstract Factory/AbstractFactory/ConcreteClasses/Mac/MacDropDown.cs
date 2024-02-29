namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class MacDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Drop Down");
        }
    }
}
