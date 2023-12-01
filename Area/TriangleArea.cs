


WorkWithConsole();


void WorkWithConsole()
{
    Console.WriteLine("Вы хотите сравнить треугольники или посчитать их площадь?");

    string answer = Console.ReadLine();

    Triangle triangle = AddSidesInTriangle(answer);

    if (answer.Equals("посчитать"))
        triangle.PrintInformationAboutTriangle();

}



static Triangle AddSidesInTriangle(string answer)
{

    if (answer.Equals("посчитать"))
    {
        Console.WriteLine("Это равносторонний треуголник или нет?");
        string newAnswer = Console.ReadLine();

        if (newAnswer.Equals("нет"))
        {
            Console.WriteLine("Введите стороны треугольника");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            return new Triangle(sideA, sideB, sideC);
        }
        else if (newAnswer.Equals("да"))
        {

            Console.WriteLine("Введите стороны треугольника");
            double oneside = double.Parse(Console.ReadLine());

            return new Triangle(oneside);
        }
    }

    if (answer.Equals("сравнить"))
    {
        List<Triangle> triangles = new List<Triangle>();

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Введите стороны {i + 1}-го треугольника");

            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            triangles.Add(new Triangle(sideA, sideB, sideC));

        }

        CompareTriangles(triangles);

    }

    return null;


}




static void CompareTriangles(List<Triangle> triangles)
{


    IComparable comparable = triangles.First();

    Triangle triangle2 = triangles.Last();

    if (comparable.CompareTo(triangle2) == 0)

        Console.WriteLine($"Треугольники 1 и 2 равны");

    if (comparable.CompareTo(triangle2) == 1)

        Console.WriteLine($"Площадь треугольника 2 больше площади треугольника 1");

    if (comparable.CompareTo(triangle2) == -1)

        Console.WriteLine($"Площадь треугольника 1 больше площади треугольника 2");



    SortAndInputList(triangles);

}


static void SortAndInputList(List<Triangle> triangles)
{
    IEnumerable<Triangle> query = triangles.OrderBy(triangles => triangles.Area);

    foreach (Triangle triangle in query)
    {
        Console.WriteLine(triangle.Area);

    }

}





class Triangle : IComparable
{
    private double sideA;

    private double sideB;

    private double sideC;

    public double Area { get; set; } 

    public double Perimeter { get; set; }


    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;

        this.Perimeter = CalculatePerimeter();
        this.Area = CalculateArea();
    }

    public Triangle(double sideA)
    {
        this.sideA = sideA;
        this.sideB = sideA;
        this.sideC = sideA;

        this.Perimeter = CalculatePerimeter();
        this.Area = CalculateArea();

    }

    int IComparable.CompareTo(object obj)
    {
        Triangle triangle1 = (Triangle)obj;

        Triangle triangle2 = this;

        if (triangle1.Area == triangle2.Area) return 0;

        else if (triangle1.Area > triangle2.Area) return 1;
        else return -1;
    }




    public double CalculatePerimeter()
    {
        if (ItIsTriangle() == true)
        {
            double perimeter = sideA + sideB + sideC;

            return perimeter;
        }
        return 0;
    }



    public double CalculateArea()
    {
        if (ItIsTriangle() == true)
        {
            double halfPerimeter = Perimeter / 2;

            double areaOfTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB)
                  * (halfPerimeter - sideC));

            return Math.Round(areaOfTriangle, 2);

        }
        return 0;
    }


    public string PrintSides()
    {
        return $"Cтороны треугольника {sideA}, {sideB}, {sideC}";
    }



    private bool ItIsTriangle()
    {

        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            Console.WriteLine("Это не треугольник");
            return false;
        }
        else
        {
            return true;
        }
    }

    public void PrintInformationAboutTriangle() =>
        Console.WriteLine($"Периметр треугольника {Perimeter}, площадь треугольника {Area}, {PrintSides()}");

}

