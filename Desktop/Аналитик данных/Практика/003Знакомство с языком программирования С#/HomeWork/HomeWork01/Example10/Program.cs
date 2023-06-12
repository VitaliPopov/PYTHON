/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"{N} -> ");
int num1 = (N / 10);
int num2 = (num1 % 10);
Console.WriteLine($"{num2}");
