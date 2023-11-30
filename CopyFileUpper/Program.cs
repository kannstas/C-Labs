using System;


    string sFrom;
    string sTo;


    try
    {

       StreamReader srFrom;
       StreamWriter swTo;

       Console.WriteLine("Введите имя входного файла");

        sFrom = Console.ReadLine();

        Console.WriteLine("Введите имя выходного файла");

        sTo = Console.ReadLine();


       srFrom= new StreamReader(sFrom);

       swTo = new StreamWriter(sTo);


       while(srFrom.Peek() != -1)
    {
       string sBuffer = srFrom.ReadLine();
       sBuffer = sBuffer.ToUpper();

       swTo.WriteLine(sBuffer);
    }

    srFrom.Close();
    swTo.Close();


}
catch (FileNotFoundException e)
    {
        Console.WriteLine("Файл не был найден");

    } catch (Exception e)
    {
        Console.WriteLine($"Возникла ошибка. Подробности: {e.ToString()}");
    }



