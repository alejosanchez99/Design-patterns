namespace Visitor.Example1
{
    using System;

    public class MedicalCheck : IAnimalOperation
    {
        public void VisitLion(Lion lion)
        {
            Console.WriteLine("The lion has been checked.");
        }

        public void VisitMonkey(Monkey monkey)
        {
            Console.WriteLine("The monkey has been checked.");
        }
    }
}
