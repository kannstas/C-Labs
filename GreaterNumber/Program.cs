
using System.Buffers;

public class Test
{
    public static void Main()

    {
      

         //задание 5 из лабы 7 на создание собственного интерфейса
        int number = 0;
        ulong longNumber = 32313121;
        string s = "Text";

        Coordinate coordinate = new Coordinate(21.0, 68.0);

        Utils.Display(number);
        Utils.Display(s);
        Utils.Display(coordinate);

        // задание 4 из лабы 7 на интерфейсы

        Console.WriteLine(Utils.IsItFormattable(number));

        Console.WriteLine(Utils.IsItFormattable(longNumber));
        Console.WriteLine(Utils.IsItFormattable(s));





        Console.WriteLine("Введите первое число");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int secondNumber = int.Parse(Console.ReadLine());

        int greater = Utils.Greater(firstNumber, secondNumber);
        Console.WriteLine($"большее значение {greater}");


        Console.WriteLine($"до преобразования {firstNumber}, {secondNumber}");
        Utils.Swap(ref firstNumber, ref secondNumber);
        Console.WriteLine($"после преобразования {firstNumber}, {secondNumber}");


        int factorialResult;
        bool ok;

        Console.WriteLine("Число для которого рассчитать факториал");
        int numberForFactorial = int.Parse(Console.ReadLine());

        ok = Utils.Factorial(numberForFactorial, out factorialResult);

        if (ok)

            Console.WriteLine($"Factorial({numberForFactorial}) = {factorialResult}");

        else

            Console.WriteLine("Cannot compute this factorial");



        string wordForReverse = Console.ReadLine();
        Utils.Reserve(ref wordForReverse);

        Console.WriteLine(wordForReverse);

    }
}


interface IPrintable
{
    void Print();
}

class Utils
{

    public static void Swap(ref int firstNumber, ref int secondNumber)
    {
        
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

    }

    public static int Greater(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
            return firstNumber;
        else
            return secondNumber;

     
    
    }

    public static bool Factorial(int number, out int result)
    {
        int counter; 
        int f; 
        bool ok = true; 
                        
        if (number < 0)
            ok = false;

        try
        {
            checked
            {
                f = 1;
                for (counter = 2; counter <= number; ++counter)
                {
                    f = f * counter;
                }
            }
        }
        catch (Exception)
        {
            f = 0;
            ok = false;
        }
        result = f;
        return ok;

    }


    public static void Reserve(ref string s)
    {

        string reverseResult = "";

        for (int i = s.Length-1; i>=0; i--)
        {
            reverseResult = reverseResult + s[i];
        }

        s=  reverseResult;

    }

    public static bool IsItFormattable (Object x)
    {
        if (x is IFormattable)
            return true;

        else
            return false;
        
    }

    public static void Display (Object item)
    {
        IPrintable ip;

        ip = item as IPrintable;

        if (ip!=null)
        {
            ip.Print();
        }
        else
        {
            Console.WriteLine($"Этот объект не поддерживает интерфейс  IPrintable {item}");
            
           
        }


    }
}

class Coordinate : IPrintable
{
    private double x;
    private double y;

    public Coordinate()
    {
        x = 0.0;
        y = 0.0;
    }

    public Coordinate(double px, double py)
    {
        x = px;
        y = py;
    }

    public void Print()
    {
        Console.WriteLine($"({x},{y})");
    }
}








