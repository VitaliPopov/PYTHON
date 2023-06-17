// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.



Console.Clear();
Console.Write("Enter X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Enter Y: ");
int Y = int.Parse(Console.ReadLine());
 if (X>0 && Y>0){
    Console.WriteLine("First quarter");
 }
 else if (X>0 && Y<0){
    Console.WriteLine("Second quarter");
 }
 else if (X<0 && Y<0){
    Console.WriteLine("Third quarter");
 }
 else Console.WriteLine("Fourth quarter");