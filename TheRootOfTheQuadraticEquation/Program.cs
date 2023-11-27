


Console.WriteLine("Введите коэффициент a");
int coefficientA = int.Parse(Console.ReadLine());


Console.WriteLine("Введите коэффициент b");
int coefficientB = int.Parse(Console.ReadLine());


Console.WriteLine("Введите коэффициент c");
int coefficientC = int.Parse(Console.ReadLine());
int firstRoot = 0;
int secondRoot = 0;
int flag = 0;



var result = (Flag: flag, FirstRoot: firstRoot, SecondRoot: secondRoot);

result = CalculateRootsOfTheQuadraticEquation(coefficientA, coefficientB, coefficientC);

if (result.Flag == -1)
{
    Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} нет ");
} else if (result.Flag == 0)
{
    Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
          $"один : x1 = x2 = {firstRoot}");

}else if (result.Flag==1)
{
    Console.WriteLine($"Корней уравнения с коэффициентами a = {coefficientA}, b = {coefficientB}, c = {coefficientC} " +
           $"равны : x1 = {firstRoot} x2 = {secondRoot}");
}



(int flag, int firstRoot, int secondRoot) CalculateRootsOfTheQuadraticEquation
    ( int coefficientA, int coefficientB, int coefficientC) {

  
    int discriminant = (coefficientB * coefficientB) - 4 * coefficientA * coefficientC;
   

if (discriminant<0 || coefficientA<0)
    {
     
       return(-1, 0, 0) ;
    }
else if (discriminant == 0)
    {
        firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
        return (0, firstRoot, firstRoot);
    }

    else

    {
        firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
        secondRoot = (int)(((-1) * coefficientB) - Math.Sqrt(discriminant)) / 2 * coefficientA;

        return (1, firstRoot, secondRoot);
        
    }

    
} 