using System;
namespace HierarchyOfShapes
{
    public class Square : Shape, Rotation
    {
        private int side;
        private double perimeter;
        private double area;

        public Square(int side)
        {
            this.side = side;
            perimeter = CalculatePerimeter();
            area = CalculateArea();
        }


        public override void Show()
        {
            Console.WriteLine($"Сторона квадрата {side}, периметр {perimeter}, площадь {area}");
        }

        public override double CalculatePerimeter()
        {
            return side * 4;
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public void Turn()
        {
            Console.WriteLine($"Квадрат повернулся");
        }


    }
}
