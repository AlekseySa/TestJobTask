using Calculation;
using Calculation.Objects;
using NUnit.Framework;
using System;

namespace TestProject
{
    public class CalculationAreaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStaticCircle()
        {
            const double radius = 5;

            double areaTest = Math.PI * Math.Pow(radius, 2);

            double area = CalculationArea.Calculation(radius);

            Assert.AreEqual(areaTest, area);
        }

        [Test]
        public void TestStaticTriangle()
        {
            const double a = 5;
            const double b = 6;
            const double c = 7;

            double areaTest;
            {
                double perimeter = (a + b + c) / 2;
                areaTest = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            }

            double area = CalculationArea.Calculation(a, b, c);

            Assert.AreEqual(areaTest, area);
        }

        [Test]
        public void TestStaticRightTriangle()
        {
            const double a = 3;
            const double b = 4;
            const double c = 5;

            bool right = CalculationOtherProperties.CheckRightTriangle(a, b, c);

            Assert.IsTrue(right);
        }

        [Test]
        public void TestCircle()
        {
            const double radius = 5;
            double areaTest = Math.PI * Math.Pow(radius, 2);

            Circle circle = new Circle(radius);

            Assert.AreEqual(areaTest, circle.AreaOfFigure);
        }

        [Test]
        public void TestTriangle()
        {
            const double a = 5;
            const double b = 6;
            const double c = 7;
            double areaTest;
            {
                double perimeter = (a + b + c) / 2;
                areaTest = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            }

            Triangle triangle = new Triangle(a, b, c);

            Assert.AreEqual(areaTest, triangle.AreaOfFigure);
        }

        [Test]
        public void TestRightTriangle()
        {
            const double a = 3;
            const double b = 4;
            const double c = 5;

            Triangle triangle = new Triangle(a, b, c);

            Assert.IsTrue(triangle.RightTriangle);
        }

        [Test]
        public void TestUnknowmFigureIsTriangle()
        {
            const double a = 5;
            const double b = 6;
            const double c = 7;
            double areaTest;
            {
                double perimeter = (a + b + c) / 2;
                areaTest = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            }

            UnknownFigure unknownFigure = new UnknownFigure(new Triangle(a, b, c));

            Assert.AreEqual(areaTest, unknownFigure.AreaOfFigure);
        }

        [Test]
        public void TestUnknowmFigureIsCircle()
        {
            const double radius = 5;
            double areaTest = Math.PI * Math.Pow(radius, 2);

            UnknownFigure unknownFigure = new UnknownFigure(new Circle(radius));

            Assert.AreEqual(areaTest, unknownFigure.AreaOfFigure);
        }
    }
}