

Console.WriteLine("Напишите число");
try
{
double firstNumber = double.Parse(Console.ReadLine()); // вместо int использовала double для точности вычисления

Console.WriteLine("Напишите второе число");

double secondNumber = double.Parse(Console.ReadLine()); 


double divisionResult = firstNumber / secondNumber;
Console.WriteLine($"результат деления: {firstNumber} / {secondNumber} = {divisionResult}");
} catch (FormatException e){
   Console.WriteLine($"An exception was thrown: {e.Message}");
} //операция на 0 выдает исключние только в int,
  // в C# double реализуются согласно стандарту IEEE-754, в котором деление на 0 определено как бесконечность.

