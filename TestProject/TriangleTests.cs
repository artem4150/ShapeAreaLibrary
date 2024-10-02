using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaLibrary;
using System;

namespace ShapeAreaLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-10);
        }

        [TestMethod]
        public void TestIsRightAngled()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [TestMethod]
        public void TestIsNotRightAngled()
        {
            // Arrange
            Triangle triangle = new Triangle(2, 3, 4);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleInvalidSides()
        {
            // Arrange & Act
            Triangle triangle = new Triangle(1, 1, 3);

            // Assert обработан атрибутом ExpectedException
        }
    }
}
