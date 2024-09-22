using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_1_mindbox
{
    public class Geometry
    {
        public Geometry() { }
        public virtual double CalculateArea() => 0;
    }

    public class Circle : Geometry // круг
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea() // площадь круга по радиусу
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Triangle : Geometry // треуголик
    {
        private double _side1, _side2, _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override double CalculateArea() // площадь треугольника по трем сторонам
        {
            double semiPerimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
        }

        public bool IsRightAngled() // является ли треугольник прямоугольным?
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);
            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}
