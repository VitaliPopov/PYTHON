/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();
Console.WriteLine("Enter X:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y:");
int Y = int.Parse(Console.ReadLine());
Console.WriteLine($"{X}^{Y} = {result}");
int result(int s)
{
    int newresult = X;
    {
        for (int s=1; s<=Y; s++);
        newresult = newresult*X;
    }
    return newresult;
}