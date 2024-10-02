using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary
{
    /// <summary>
    /// Интерфейс для геометрических фигур.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        double GetArea();
    }
}
