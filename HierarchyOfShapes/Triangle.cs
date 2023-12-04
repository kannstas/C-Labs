using System;
namespace HierarchyOfShapes
{
	public class Triangle : Shape, Rotation

	{
        private double sideA;

        private double sideB;

        private double sideC;

        private double perimeter;

        private double area;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            perimeter = CalculatePerimeter();
            area = CalculateArea();
        }

        public override void Show()
        {
            Console.WriteLine($"Стороны треугольника {sideA}, {sideB}, {sideC}, периметр {perimeter}, площадь {area}");
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double CalculateArea()
        {
            double halfPerimeter = perimeter / 2;

            double areaOfTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB)
                  * (halfPerimeter - sideC));

            return Math.Round(areaOfTriangle, 2);
        }

        public void Turn()
        {
            Console.WriteLine($"Треугольник повернулся");
        }
    }
}

