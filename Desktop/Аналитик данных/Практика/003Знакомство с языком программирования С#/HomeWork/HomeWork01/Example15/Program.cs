/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.Write("Enter day number: ");
int day = int.Parse(Console.ReadLine());
if (day <=7){
    if (day == 7 || day == 6){
        Console.Write($"{day}-> Weekend");
        } 
        else Console.Write($"{day}-> Weekday");
} 
else Console.Write($"{day}-> Error");