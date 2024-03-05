namespace Visitor.Example1
{
    public class Lion : IAnimal
    {
        public void Accept(IAnimalOperation animalOperation)
        {
            animalOperation.VisitLion(this);
        }
    }
}
