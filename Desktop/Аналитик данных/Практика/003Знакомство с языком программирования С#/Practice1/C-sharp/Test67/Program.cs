/***Задача 67:** Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9*/

using System;
using static System.Console;
Clear();
Write("Enter number: ");
int s = int.Parse(ReadLine());
WriteLine(GetSum(s));

int GetSum(int s)
{
    if (s==0)
    return s;
    return (s%10 + GetSum(s/10));
}