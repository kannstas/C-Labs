



    System.Collections.ICollection DaysInMonths
             = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    System.Collections.ICollection DaysInLeapMonths
          = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

try
{

    Console.WriteLine("Введите год");

    int yearNum = int.Parse(Console.ReadLine());

    bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);

    int maxDayNum = isLeapYear ? 366 : 365;





//if (isLeapYear)
//{
//    Console.WriteLine("Это високосный год");
//} else
//{
//    Console.WriteLine("Это не високосный год");
//}


    Console.WriteLine($"Введите день года от 1 до {maxDayNum}");


    int dayNum = int.Parse(Console.ReadLine());


    if (dayNum < 1 || dayNum > maxDayNum)
    {
        throw new ArgumentOutOfRangeException("Day out of range");
    }


    int monthNum = 0;


    if (isLeapYear)
    {
        foreach (int daysInMonths in DaysInLeapMonths)
        {
            if (dayNum <= daysInMonths)
            {
                break;
            }
            else
            {
                dayNum -= daysInMonths;
                monthNum++;
            }
        }
    }
    else
    {
        foreach (int daysInMonths in DaysInMonths)
        {
            if (dayNum <= daysInMonths)
            {
                break;
            }
            else
            {
                dayNum -= daysInMonths;
                monthNum++;
            }
        }


    }


    MonthName temp = (MonthName)monthNum;
    string monthName = temp.ToString();

    Console.WriteLine($"Месяц {monthName}, день {dayNum}");

}

catch (Exception caught)
{
    Console.WriteLine(caught);
}
       
        

enum MonthName
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

