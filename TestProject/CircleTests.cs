using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaLibrary;
using System;

namespace ShapeAreaLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleNegativeRadius()
        {
            // Arrange & Act
            Circle circle = new Circle(-5);

            // Assert обработан атрибутом ExpectedException
        }
    }
}
