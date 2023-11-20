


Calculate(WorkWithConsole());




static double WorkWithConsole()
{
    Console.WriteLine("Введите периметр равностороннего треугольника");

    double trianglePerimeter = double.Parse(Console.ReadLine());

    return trianglePerimeter;


}

void Calculate (double trianglePerimeter)

{
    double side = trianglePerimeter / 3;

    double areaOfTriangle = Math.Sqrt((trianglePerimeter/2) * Math.Pow((trianglePerimeter/2)- side, 3));


    Console.WriteLine("{0,10} |{1,10}", "Сторона", "Площадь");

    Console.WriteLine("{0,10} |{1,10}", side, Math.Round(areaOfTriangle, 2));

}




    