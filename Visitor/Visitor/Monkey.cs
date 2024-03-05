namespace Visitor.Example1
{
    public class Monkey : IAnimal
    {
        public void Accept(IAnimalOperation animalOperation)
        {
            animalOperation.VisitMonkey(this);
        }
    }
}
