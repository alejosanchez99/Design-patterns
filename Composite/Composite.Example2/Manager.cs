namespace Composite.Example2
{
    using System;
    using System.Collections.Generic;

    public class Manager : IEmployee
    {
        private readonly string name;
        private readonly List<IEmployee> employees;

        public Manager(string name)
        {
            this.name = name;
            this.employees = new List<IEmployee>(0);
        }

        public void Add(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + this.name);
            foreach (IEmployee employee in this.employees)
            {
                employee.Display(indent + 2);
            }
        }
    }
}
