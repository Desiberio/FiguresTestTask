using FiguresLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FiguresLibrary.Tests
{
    public class FiguresTests
    {
        [Fact]
        public void CreateCircle_ThrowsException_WhenValuesAreNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [Theory]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        [InlineData(double.PositiveInfinity, double.PositiveInfinity)]
        [InlineData(double.NaN, double.NaN)]
        public void CreateCircle_Create_WhenEdgeCase(double radius, double expected)
        {
            Circle circle = new Circle(radius);
            Assert.Equal(expected, circle.Area);
        }

        [Fact]
        public void CircleArea_IsCorrect()
        {
            // Arrange
            double expected = 113.0973355292325565;

            // Act
            double actual = new Circle(6).Area;

            //Assert
            Assert.Equal(expected, actual, 0.0000001);
        }

        [Theory]
        [InlineData(-10, 10, 10)]
        [InlineData(10, -10, 10)]
        [InlineData(10, 10, -10)]
        [InlineData(0, 10, 10)]
        [InlineData(10, 0, 10)]
        [InlineData(10, 10, 0)]
        public void CreateTriangle_ThrowsException_WhenOneOfValuesAreZeroOrNegative(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Theory]
        [InlineData(4, 1, 5)]
        [InlineData(1000, 23, 5)]
        [InlineData(1, 10, 4)]
        public void CreateTriangle_ThrowsException_WhenValuesAreNotMakingValidTriangle(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue, double.PositiveInfinity)]
        public void CreateTriangle_Create_WhenEdgeCase(double firstSide, double secondSide, double thirdSide, double expected)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.Equal(expected, triangle.Area);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(2, 4, 4, false)]
        public void Triangle_IsRightAngled(double firstSide, double secondSide, double thirdSide, bool expected)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.Equal(expected, triangle.IsRightAngled);
        }

        [Fact]
        public void TriangleArea_IsCorrect()
        {
            // Arrange
            double expected = 6;

            // Act
            double actual = new Triangle(3, 4, 5).Area;

            //Assert
            Assert.Equal(expected, actual, 0.0000001);
        }
    }
}
