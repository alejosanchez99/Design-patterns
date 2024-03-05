
using Visitor.Example1;

List<IAnimal> animals = new List<IAnimal>
{
    new Lion(),
    new Monkey()
};

List<IAnimalOperation> animalOperations = new List<IAnimalOperation>
{
    new Feed(),
    new MedicalCheck()
};

foreach (IAnimal animal in animals)
{
    foreach (IAnimalOperation operation in animalOperations)
    {
        animal.Accept(operation);
    }
}