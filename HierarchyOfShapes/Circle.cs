using System;
namespace HierarchyOfShapes
{
	public class Circle : Shape
	{
		private int radius;

        private double perimeter;

        private double area;

        public Circle(int radius)
        {
            this.radius = radius;
            perimeter = CalculatePerimeter();
            area = CalculateArea();
        }

        public override void Show()
        {
            Console.WriteLine($"Радиус окружности {radius}, периметр {perimeter}, площадь {area}");
        }

        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * radius;
        }

        public override double CalculateArea()
        {
            return (radius * radius) * 3.14;
        }
    }
}

