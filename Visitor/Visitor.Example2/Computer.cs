namespace Visitor.Example2
{
    public class Computer : IProduct
    {
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}