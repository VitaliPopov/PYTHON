﻿/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.Clear();
Console.WriteLine("Enter number a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number c: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write($"{a}, {b}, {c} -> max=");
Console.Write(max);