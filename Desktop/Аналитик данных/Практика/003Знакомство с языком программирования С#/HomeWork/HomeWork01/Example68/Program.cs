/*3адача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;
Clear();
Write("Введите первое число N: ");
int n=int.Parse(ReadLine());

Write("Введите второе число M: ");
int m=int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {Akkerman(n, m)}");
int Akkerman(int n, int m)
{
    if(n==0)
    return m+1;
    if(m==0)
    return Akkerman(n-1,1);
    return Akkerman(n-1, Akkerman(n,m-1));
}
