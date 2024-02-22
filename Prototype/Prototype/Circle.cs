namespace Prototype.Example1
{
    using System;

    public class Circle : Shape
    {
        public Circle()
        {
            this.Name = "Circule";
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with id {this.Id}.");
        }
    }
}
