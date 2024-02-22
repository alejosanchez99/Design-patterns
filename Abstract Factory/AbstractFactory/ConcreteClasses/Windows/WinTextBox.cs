namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class WinTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Win TextBox");
        }
    }
}
