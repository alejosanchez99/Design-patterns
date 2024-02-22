namespace Prototype.Example1
{
    using System;

    public class Square : Shape
    {
        public Square()
        {
            this.Name = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Square with id {this.Id}.");
        }
    }
}
