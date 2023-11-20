

Distanse distanse1, distanse2, distance3;

Console.WriteLine("Введите 1 значение футов");
distanse1.feet = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 значение футов");
distanse2.feet = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 1 значение дюймов");

distanse1.inche = double.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 значение дюймов");
distanse2.inche = double.Parse(Console.ReadLine());


distance3.sumFeet = (int)((distanse1.feet + distanse2.feet) + ((distanse1.inche + distanse2.inche)/12));
distance3.sumInche = (distanse1.inche + distanse2.inche)%12;


Console.WriteLine($"Результат: {distance3.sumFeet}'- {distance3.sumInche}''");


public struct Distanse
{
   public double feet;
   public double inche;
   public double sumFeet;
   public double sumInche;
  
}
