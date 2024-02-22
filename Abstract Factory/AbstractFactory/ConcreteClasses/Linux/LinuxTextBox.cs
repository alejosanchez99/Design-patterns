namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class LinuxTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux TextBox");
        }
    }
}
