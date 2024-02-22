
using Prototype.Example1;

Circle circle = new Circle { Id = 1 };
Rectangle rectangle = new Rectangle { Id = 2 };
Square square = new Square { Id = 3 };


circle.Draw();
rectangle.Draw();
square.Draw();

Circle clonedCircle = (Circle)circle.Clone();
Rectangle clonedRectangle = (Rectangle)rectangle.Clone();
Square clonedSquare = (Square)square.Clone();

clonedCircle.Draw();
clonedCircle.Id = 4;
clonedCircle.Draw();