using ShapeAreaLibrary;
using System;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape = GetShapeFromUserInput();

            double area = shape.GetArea();
            Console.WriteLine($"Площадь фигуры: {area}");

            if (shape is Triangle triangle)
            {
                if (triangle.IsRightAngled())
                    Console.WriteLine("Треугольник является прямоугольным.");
                else
                    Console.WriteLine("Треугольник не является прямоугольным.");
            }
        }

        static IShape GetShapeFromUserInput()
        {
            // Для примера возвращаем треугольник
            return new Triangle(3, 4, 5);
        }
    }
}
