namespace Visitor.Example2
{
    public interface IProduct
    {
        void Accept(IProductVisitor visitor);
    }
}
