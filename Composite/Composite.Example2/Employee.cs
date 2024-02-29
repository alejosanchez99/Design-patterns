namespace Composite.Example2
{
    using System;

    public class Employee : IEmployee
    {
        private readonly string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + this.name);
        }
    }
}
