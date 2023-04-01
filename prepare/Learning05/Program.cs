using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle(12, 3, "green");
        Circle circle = new Circle(4, "yellow");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}