using ��������_1_mindbox;

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
            Assert.AreEqual(78.54, circle.CalculateArea(), 0.01); // ������� ����� �������� 5 ������ ���������� �������������� 78,54
        }

        [Test]
        public void TestTriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea()); // ������� ������������ �� ��������� 3, 4, 5 ������ ���� ����� 6
        }

        [Test]
        public void TestRightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled()); // ����������� �� ��������� 3, 4, 5 - ��� ������������� �����������
        }
    }
}