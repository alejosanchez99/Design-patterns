namespace Visitor.Example2
{
    public class TV : IProduct
    {
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}