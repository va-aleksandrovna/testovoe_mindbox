using Тестовое_1_mindbox;

namespace TestGeometry
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.54, circle.CalculateArea(), 0.01); // Площадь круга радиусом 5 должна составлять приблизительно 78,54
        }

        [Test]
        public void TestTriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea()); // Площадь треугольника со сторонами 3, 4, 5 должна быть равна 6
        }

        [Test]
        public void TestRightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled()); // Треугольник со сторонами 3, 4, 5 - это прямоугольный треугольник
        }
    }
}