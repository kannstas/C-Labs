

Distanse distanse1, distanse2, distance3;

Console.WriteLine("Введите 1 значение футов");
int feet1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 1 значение дюймов");
double inche1 = double.Parse(Console.ReadLine());

Distanse firstDistance = new Distanse(feet1, inche1);



Console.WriteLine("Введите 2 значение футов");

int feet2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 значение дюймов");
double inche2 = double.Parse(Console.ReadLine());

Distanse secondDistance = new Distanse((int)feet2, inche2);


Distanse sum = firstDistance+secondDistance;

Distanse subtraction = firstDistance - secondDistance;

Console.WriteLine(sum);


Console.WriteLine(firstDistance == secondDistance);

Console.WriteLine(firstDistance.Equals(secondDistance));



public class Distanse
{
    private int feet;
    private double inche;

    private static int sumFeet;
    private static int sumInche;


    private static int subtractionFeet;
    private static int subtractionInche;


    public Distanse(int feet, double inche)
    {
        this.feet = feet;
        this.inche = inche;

    }


    public Distanse()
    {

    }

    public static Distanse operator +(Distanse firstDistance, Distanse secondDistanse)
    {

        sumFeet = (int)((firstDistance.feet + secondDistanse.feet) + ((firstDistance.inche + secondDistanse.inche) / 12));
        sumInche = (int)(firstDistance.inche + secondDistanse.inche) % 12;
        return new Distanse(sumFeet, sumInche);


    }


    public static Distanse operator -(Distanse firstDistance, Distanse secondDistanse)
    {

        subtractionFeet = (int)((firstDistance.feet + secondDistanse.feet) - ((firstDistance.inche + secondDistanse.inche) / 12));
        subtractionInche= (int)(firstDistance.inche - secondDistanse.inche) % 12;

        return new Distanse(subtractionFeet, subtractionInche);
    }

    public override string ToString()
    {
        return $"Результат сложения: {sumFeet}'- {sumInche}''" +
            $"Результат вычитания: {subtractionFeet}'- {subtractionInche}''";

    }


    public static bool operator == (Distanse firstDistanse, Distanse secondDistanse)
    {
        if (firstDistanse.feet == secondDistanse.feet && firstDistanse.inche == secondDistanse.inche)
            return true;
        else return false;
    }

    public static bool operator != (Distanse firstDistanse, Distanse secondDistanse)
    {
        return !(firstDistanse == secondDistanse);
    }

    public override bool Equals(Object distanse)
    {
        return this == (Distanse)distanse;
    }


}
