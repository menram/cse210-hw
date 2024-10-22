using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning06 World!");
        List<Shape> shapeList = [];
        Square square = new("red", 4);
        shapeList.Add(square);
        Rectangle rectangle = new("blue", 2, 6);
        shapeList.Add(rectangle);
        Circle circle = new("yellow", 2);
        shapeList.Add(circle);

        foreach (Shape s in shapeList)
        {
            Console.WriteLine($"Shape Color: {s.GetColor()} Shape Area: {s.GetArea()}");
        }
    }
}