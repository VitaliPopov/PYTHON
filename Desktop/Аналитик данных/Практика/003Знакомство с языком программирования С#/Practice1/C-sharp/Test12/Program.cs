/*12 Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
*/

Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine());
if (a % b ==0){
    Console.Write("Кратно");
    } else Console.WriteLine($"-> no {a % b}");
