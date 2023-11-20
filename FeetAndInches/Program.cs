

Distanse distanse;

Console.WriteLine("Введите количество футов");

distanse.feet = double.Parse(Console.ReadLine());

Console.WriteLine("Введите количество дюймов");

distanse.inche = double.Parse(Console.ReadLine());



distanse.sum = (((int)distanse.inche / 12) + distanse.feet);

double countOfInche = distanse.sum % 12;

Console.WriteLine($"Результат: {distanse.sum}'- {countOfInche}''");


public struct Distanse
{
   public double feet;
   public double inche;
   public double sum;
  
}
