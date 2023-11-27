

using System;

Triangle triangle = new Triangle();


Input();

   static void Input()
{
    Triangle triangle = new Triangle();


    Console.WriteLine("Это равностороний треугольник или нет?");
    String answer = Console.ReadLine();

    if (answer.Equals("да"))

    {
        Console.WriteLine("Введите сторону");
        double oneSide = double.Parse(Console.ReadLine());

        OutputEquilateralTriangle(triangle, oneSide);

    }
    else if (answer.Equals("нет"))

    {
        Console.WriteLine("Введите сторону A");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите сторону B");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите сторону C");
        double sideC = double.Parse(Console.ReadLine());


        var tuple = (SideA: sideA, SideB: sideB, SideC: sideC);
        tuple = triangle.InitializationSides(sideA, sideB, sideC);
        Output(triangle, tuple);

    }

    static void Output(Triangle triangle, (double SideA, double SideB, double SideC) tuple)
    {
        Console.WriteLine($"периметр {triangle.CalculateTrianglePerimeter(tuple)}");
        triangle.CalculateArea(tuple);
        triangle.PrintSides(tuple);
    }

    static void OutputEquilateralTriangle(Triangle triangle, double oneSide)
    {
        Console.WriteLine($"периметр {triangle.CalculateTrianglePerimeter(triangle.InitializationSides(oneSide))}");
     
        triangle.CalculateArea(triangle.InitializationSides(oneSide));

        triangle.PrintSides(oneSide);
    }
}
  





class Triangle
{
    private double sideA;

    private double sideB;

    private double sideC;



    public (double sideA, double sideB, double sideC) InitializationSides(double sideA, double sideB, double sideC)
    {
        sideA = sideA;
        sideB = sideB;
        sideC = sideC;

        return (sideA, sideB, sideC);
    }

    public double InitializationSides(double oneSide)
    {
        return sideA = oneSide;
    }

    public double CalculateTrianglePerimeter(double oneSide)
    {
        if (ItIsTriangle(oneSide).Equals(true))
        {
            double perimeter = oneSide * 3;
            return perimeter;
        }
        return 0;
    }

    public double CalculateTrianglePerimeter((double sideA, double sideB, double sideC) tuple)
    {
        if (ItIsTriangle(tuple).Equals(true))
        {
            double perimeter = tuple.sideA + tuple.sideB + tuple.sideC;
    
            return perimeter;
        }
        return 0; 
    }


    public void CalculateArea(double oneSide)

    {
        if (ItIsTriangle(oneSide).Equals(true))
        {
            double areaOfTriangle = Math.Sqrt(CalculateTrianglePerimeter(oneSide) / 2 * Math.Pow(CalculateTrianglePerimeter(oneSide) / 2 - sideA, 3));

            Console.WriteLine($"площадь: {Math.Round(areaOfTriangle, 2)}");

        }
    }


    public void CalculateArea((double sideA, double sideB, double sideC) tuple)
    {
        if (ItIsTriangle(tuple).Equals(true))
        {
            double halfPerimeter = CalculateTrianglePerimeter(tuple) / 2;

            double areaOfTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - tuple.sideA) * (halfPerimeter - tuple.sideB)
                  * (halfPerimeter - tuple.sideC));

            Console.WriteLine($"площадь: {Math.Round(areaOfTriangle, 2)}");

        }
    }

    public void PrintSides((double sideA, double sideB, double sideC) tuple)
    {
        if (ItIsTriangle(tuple).Equals(true))
        {
            Console.WriteLine($"Cтороны треугольника {tuple.sideA}, {tuple.sideB}, {tuple.sideC}");
        }
    }


    public void PrintSides(double oneSide)
    {
        if (ItIsTriangle(oneSide).Equals(true))
        {
            Console.WriteLine($"Cтороны треугольника равны {oneSide}");
        }
    }



    private bool ItIsTriangle((double sideA, double sideB, double sideC) tuple)
    {


        if ((tuple.sideA == 0) || (tuple.sideA < 0)
               || (tuple.sideB == 0) || (tuple.sideB < 0)
               || (tuple.sideC == 0) || (tuple.sideC < 0))
        {

            Console.WriteLine("Это не треугольник");
            return false;
        }
        else
        {
            return true;
        }
    }


    private bool ItIsTriangle(double oneSide)
    {
        if ( oneSide <= 0)
        {
            Console.WriteLine("Это не треугольник");
            return false;
        }
        else
        {
            return true;
        }
    }
}

