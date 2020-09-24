using ConsoleApp1.Model;
using ConsoleApp1.Model.Triangle;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShapeBase shape = new ShapeBase();
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.Name);
            Console.WriteLine(triangle.GetPerimeter());
            Console.WriteLine(triangle.GetSquare());
            IsoscelesTriangle triangle2 = new IsoscelesTriangle(5, 4);
            Console.WriteLine(triangle2.Name);
            Console.WriteLine(triangle2.GetPerimeter());
            Console.WriteLine(triangle2.GetSquare());
            EquilateralTriangle triangle3 = new EquilateralTriangle(3);
            Console.WriteLine(triangle3.Name);
            Console.WriteLine(triangle3.GetPerimeter());
            Console.WriteLine(triangle3.GetSquare());
            RectangularTriangle triangle4 = new RectangularTriangle(3, 4);
            Console.WriteLine(triangle4.Name);
            Console.WriteLine(triangle4.GetPerimeter());
            Console.WriteLine(triangle4.GetSquare());
            Console.ReadKey();
        }
    }
}