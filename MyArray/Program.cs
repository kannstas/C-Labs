


Console.WriteLine("Введите сколько цифр вы хотите ввести");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

int sumPositive = 0;
int sumNegative = 0;

var tupleSumPositiveAndNegativeElements = (SumPositive: sumPositive, SumNegative: sumNegative);

//tupleSumPositiveAndNegativeElements = SumPositiveAndNegativeElementInArray(InputInArray(array)); 


int sumEvenNumbers = 0;
int sumOddNumbers = 0;

var tupleSumEvenAndOddElementInArray = (SumEvenNumbers: sumEvenNumbers, SumOddNumbers: sumOddNumbers);

//tupleSumEvenAndOddElementInArray = SumEvenAndOddElementInArray(InputInArray(array));

//ArrayAverageValue(InputInArray(array));


int maxElementInArray = 0;
int minElementInArray = 0;


var tupleMaxandMinElementInArray = (MaxElementInArray: maxElementInArray, MinElementInArray: minElementInArray);

tupleMaxandMinElementInArray = SearchMinAndMaxElementInArray(InputInArray(array));







static int [] InputInArray (int[] array) // заполнение массива элементами с клавиатуры
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = int.Parse(Console.ReadLine());
    }

    foreach (int number in array)
    {
        Console.Write( number + " ");
        
    }
    Console.WriteLine("\n");

    return array;
}


static int CountAllElementInArray (int[] array) // определение суммы всех элементов массива.
{
    int sum = 0;

    for (int i = 0; i <array.Length; i++)
    {
        sum += array[i];

    }

    Console.WriteLine(sum);

    return sum;
}


static int ArrayAverageValue (int[] array) // среднего значения массива
{
    int result = CountAllElementInArray(array) / 2;
    Console.WriteLine($"Среднее арифметическое от {CountAllElementInArray(array)} = {result}");
    return result;
        
}



(int sumPositive, int sumNegative) SumPositiveAndNegativeElementInArray (int[] array) //расчет суммы отрицательных и положительных элементов.
{
    
   for (int i = 0; i< array.Length; i++)
    {
        if (array[i]>=0)
        {
            sumPositive += array[i];
        } else if (array[i]<=0)
        {
            sumNegative += array[i];
        }
    }

    Console.WriteLine($"Cумма положительных чисел в массиве: {sumPositive}");
    Console.WriteLine($"Cумма отрицательных чисел в массиве: {sumNegative}");

    return (sumPositive, sumNegative);
  

}


(int sumEvenNumbers, int sumOddNumbers) SumEvenAndOddElementInArray(int[] array) //расчет суммы элементов с нечетными и четными номерами
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumEvenNumbers += array[i];
        }
        else if (!(array[i] %2 == 0))
        {
            sumOddNumbers += array[i];
        }

      

    }
    Console.WriteLine($"Cумма четных чисел в массиве: {sumEvenNumbers}");
    Console.WriteLine($"Cумма нечетных чисел в массиве: {sumOddNumbers}");

    return (sumEvenNumbers, sumOddNumbers);
}


(int maxElementInArray, int minElementInArray) SearchMinAndMaxElementInArray (int[] array) //найти максимальный или минимальный элементы массива и
//вывести их индексы,
{

    maxElementInArray = array.Max();
    int indexMax = Array.IndexOf(array, array.Max());

    minElementInArray = array.Min();
    int indexMin= Array.IndexOf(array, array.Min());


    Console.WriteLine($"Максимальный элемент в массиве {maxElementInArray}, его индекс {indexMax}");

    Console.WriteLine($"Минимальный элемент в массиве {minElementInArray}, его индекс {indexMin}");

    return (maxElementInArray, minElementInArray);
}










