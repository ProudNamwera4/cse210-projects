using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("Red",4);
        //Console.WriteLine($"{square.GetColor()} {square.GetArea()}");
    
        Rectangle rectangle = new Rectangle(4,2,"Blue");
        //Console.WriteLine($"{rectangle.GetColor()} {rectangle.GetArea()}");
    
        Circle circle = new Circle(4,"Green");
        //Console.WriteLine($"{circle.GetColor()} {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);
        
        foreach(Shape shape in shapes){
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");

        }

    }
}