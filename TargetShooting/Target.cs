


Coordinates coordinates;
int userScores = 0;


while (true) {
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Введите координаты x");
        coordinates.x = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты y");
        coordinates.y = int.Parse(Console.ReadLine());

        if ((coordinates.x <= 5 || coordinates.x <= -5) && (coordinates.y <= 5 || coordinates.y <= -5))
        {
            userScores += 10;
        }
        else if ((coordinates.x <= 10 || coordinates.x <= -10) && (coordinates.y <= 10 || coordinates.y <= -10))
        {
            userScores += 5;
        }

        else if ((coordinates.x <= 20 || coordinates.x <= -20) && (coordinates.y <= 20 || coordinates.y <= -20))
        {
            userScores += 1;
        }
        else
        {
            userScores += 0;
        }



    Console.WriteLine("BOOM! \n");

    }
    Console.WriteLine($"Счёт: {userScores} \n");

    Console.WriteLine("Еще раз? \n" +
        "1. да \n" +
        "2. нет ");

    int userAnswer = int.Parse(Console.ReadLine());

    switch (userAnswer)
    {
        case 1: continue;

        case 2:
            Console.WriteLine("До свидания!");
            return;

           
    }

} 



struct Coordinates
{
    public int x;
    public int y;
}