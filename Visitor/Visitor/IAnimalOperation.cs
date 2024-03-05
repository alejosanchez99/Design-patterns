namespace Visitor.Example1
{
    public interface IAnimalOperation
    {
        void VisitLion(Lion lion);
        void VisitMonkey(Monkey monkey);
    }
}
