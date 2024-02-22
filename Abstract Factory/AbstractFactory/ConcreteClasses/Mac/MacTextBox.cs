namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac TextBox");
        }
    }
}
