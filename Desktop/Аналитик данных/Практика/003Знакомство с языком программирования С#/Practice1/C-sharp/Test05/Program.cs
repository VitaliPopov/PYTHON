/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    
    456 -> 6
    
    782 -> 2
    
    918 -> 8*/

Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра числа равна");
Console.Write(N % 100);
Console.WriteLine(" результат деления ");
Console.WriteLine(N / 10);