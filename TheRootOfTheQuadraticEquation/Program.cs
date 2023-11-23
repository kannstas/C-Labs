


Console.WriteLine("Введите коэффициент a");
int coefficientA = int.Parse(Console.ReadLine());


Console.WriteLine("Введите коэффициент b");
int coefficientB = int.Parse(Console.ReadLine());


Console.WriteLine("Введите коэффициент c");
int coefficientC = int.Parse(Console.ReadLine());


int firstRoot = 0;
int secondRoot = 0;


int result = CalculateRootsOfTheQuadraticEquation(coefficientA, coefficientB, coefficientC, ref firstRoot, ref secondRoot);

if (result == -1)
{
    Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} нет ");
} else if (result == 0)
{
    Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
          $"один : x1 = x2 = {firstRoot}");

}else if (result==1)
{
    Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
           $"равны : x1 = {firstRoot} x2 = {secondRoot}");
}




static int  CalculateRootsOfTheQuadraticEquation ( int coefficientA, int coefficientB, int coefficientC,
    ref int firstRoot, ref int secondRoot) { 

int discriminant = (coefficientB * coefficientB) - 4 * coefficientA * coefficientC;

if (discriminant<0 || coefficientA<0)
    {
     
        return -1;
    }
else if (discriminant == 0)
    {
        firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
        return 0;
    }

    else

    {
        firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
        secondRoot = (int)(((-1) * coefficientB) - Math.Sqrt(discriminant)) / 2 * coefficientA;
        return 1;
    }

    
} 