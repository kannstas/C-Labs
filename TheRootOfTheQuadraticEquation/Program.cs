


Console.WriteLine("Введите коэффициент a");
int coefficientA = int.Parse(Console.ReadLine());


Console.WriteLine("Введите коэффициент b");
int coefficientB = int.Parse(Console.ReadLine());


Console.WriteLine("Введите коэффициент c");
int coefficientC = int.Parse(Console.ReadLine());

CalculateRootsOfTheQuadraticEquation(ref coefficientA, ref coefficientB, ref coefficientC);



static int  CalculateRootsOfTheQuadraticEquation (ref int coefficientA, ref int coefficientB, ref int coefficientC) { 

int discriminant = (coefficientB * coefficientB) - 4 * coefficientA * coefficientC;

if (discriminant<0 || coefficientA<0)
    {
        Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} нет ");
        return -1;
    }
else if (discriminant == 0)
    {
        int firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
        Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
          $"один : x1 = x2 = {firstRoot}");
        return 0;
    }

    else

    {
        int firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
        int secondRoot = (int)(((-1) * coefficientB) - Math.Sqrt(discriminant)) / 2 * coefficientA;

        Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
            $"равны : x1 = {firstRoot} x2 = {secondRoot}");
        return 1;
    }

    
} 