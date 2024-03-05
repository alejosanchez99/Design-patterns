namespace Visitor.Example2
{
    public class Phone : IProduct
    {
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}