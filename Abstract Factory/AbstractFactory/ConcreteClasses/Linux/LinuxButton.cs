namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;

    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux Button");
        }
    }
}
