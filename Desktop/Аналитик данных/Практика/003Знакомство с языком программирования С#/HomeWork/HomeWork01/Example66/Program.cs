/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
using static System.Console;
Clear();
Write("Введите первое число N: ");
int n=int.Parse(ReadLine());

Write("Введите второе число M: ");
int m=int.Parse(ReadLine());

WriteLine(PrintNumbers(n,m));

WriteLine(GetSum(n,m));

string PrintNumbers(int n, int m)
{
    if (m==n)
    {
        return n.ToString();
    }
    string s = PrintNumbers(n, m-1) + ", "+ m.ToString();
    return s;
}

int GetSum(int n, int m)
{
    int sum=n;
    if (sum==m)
    return sum;
    return (sum+GetSum(sum+1,m));
}