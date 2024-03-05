namespace Visitor.Example1
{
    using System;

    public class Feed : IAnimalOperation
    {
        public void VisitLion(Lion lion)
        {
            Console.WriteLine("The lion has been feed.");
        }

        public void VisitMonkey(Monkey monkey)
        {
            Console.WriteLine("The monkey has been fed.");
        }
    }
}
