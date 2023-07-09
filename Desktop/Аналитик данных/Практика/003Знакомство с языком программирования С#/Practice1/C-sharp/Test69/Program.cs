/**Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)

A = 2; B = 3 -> 8*/

using System;
using static System.Console;
Clear();
Write("Введите первое число N: ");
int n=int.Parse(ReadLine());

Write("Введите второе число M: ");
int m=int.Parse(ReadLine());

WriteLine($"{n}^{m} = {Power(n,m)}");
int Power(int n, int m)
{
    if(m==1)
    
        return n;
        //return (n * Power(n,m-1));
    
    return (n * Power(n,m-1));
}
