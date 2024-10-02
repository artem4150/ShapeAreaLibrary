using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary
{
    /// <summary>
    /// Представляет треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Длина стороны A.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Длина стороны B.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Длина стороны C.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Triangle с заданными сторонами.
        /// </summary>
        public Triangle(double sideA, double sideB, double sideC)
        {
            // Проверка корректности сторон
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Все стороны должны быть положительными.");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Нарушено неравенство треугольника.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона.
        /// </summary>
        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2; // Полупериметр
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Определяет, является ли треугольник прямоугольным.
        /// </summary>
        public bool IsRightAngled()
        {
            double[] sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            double a = sides[0], b = sides[1], c = sides[2];

            // Проверка по теореме Пифагора: c^2 ≈ a^2 + b^2
            return Math.Abs(c * c - (a * a + b * b)) < 1e-10;
        }
    }
}
