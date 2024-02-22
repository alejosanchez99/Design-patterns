namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class LinuxDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux Drop Down");
        }
    }
}
