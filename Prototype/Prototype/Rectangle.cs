namespace Prototype.Example1
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle()
        {
            this.Name = "Rectangle";
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with id {this.Id}.");
        }
    }
}
