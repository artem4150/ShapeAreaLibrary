using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary
{
    /// <summary>
    /// Представляет круг.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Circle с заданным радиусом.
        /// </summary>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным.", nameof(radius));

            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}