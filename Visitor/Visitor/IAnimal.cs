namespace Visitor.Example1
{
    public interface IAnimal
    {
        void Accept(IAnimalOperation animalOperation);
    }
}
