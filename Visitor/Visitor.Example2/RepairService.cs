namespace Visitor.Example2
{
    using System;

    public class RepairService : IProductVisitor
    {
        public void Visit(TV tv)
        {
            Console.WriteLine("Repairing a TV.");
        }

        public void Visit(Phone phone)
        {
            Console.WriteLine("Repairing a Phone.");
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("Repairing a Computer.");
        }
    }
}
