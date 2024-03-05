namespace Visitor.Example2
{
    public interface IProductVisitor
    {
        void Visit(TV tv);
        void Visit(Phone phone);
        void Visit(Computer computer);
    }
}
