


Console.WriteLine("Это равностороний треугольник или нет?");
String answer = Console.ReadLine();

 if (answer.Equals("да"))
{
    Console.WriteLine("Введите сторону");
    double sideOfEquilateralTriangle = double.Parse(Console.ReadLine());

    Operation.Calculate(sideOfEquilateralTriangle);

} else if (answer.Equals("нет"))

{
    Console.WriteLine("Введите сторону A");
    double sideA= double.Parse(Console.ReadLine());

    Console.WriteLine("Введите сторону B");
    double sideB = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите сторону C");
    double sideC = double.Parse(Console.ReadLine());

    Operation.Calculate(sideA, sideB, sideC);

}




 class Operation
{


    public static void Calculate(double side)

    {

        if (side == 0 || side < 0)
        {
            ItIsTriangle(false);
            Console.WriteLine("Это не треугольник");
        }
        else
        {
            double trianglePerimeter = side * 3;

            double areaOfTriangle = Math.Sqrt((trianglePerimeter / 2) * Math.Pow((trianglePerimeter / 2) - side, 3));

            Console.WriteLine($"площадь: {Math.Round(areaOfTriangle, 2)}");

        }
    }




    public static void Calculate(double sideA, double sideB, double sideC)
    {

        if ((sideA == 0) || (sideA < 0)
                || (sideB == 0) || (sideB < 0)
                || (sideC == 0) || (sideC < 0))
        {
            ItIsTriangle(false);
            Console.WriteLine("Это не треугольник");
        }
        else
        {
            double halfTrianglePerimeter = (sideA + sideB + sideC) / 2;

            double areaOfTriangle = Math.Sqrt(halfTrianglePerimeter * (halfTrianglePerimeter - sideA) * (halfTrianglePerimeter - sideB)
                * (halfTrianglePerimeter - sideC));

            Console.WriteLine($"площадь: {Math.Round(areaOfTriangle, 2)}");

        }
    }


    private static void ItIsTriangle(bool ok)
    {

    }


}
