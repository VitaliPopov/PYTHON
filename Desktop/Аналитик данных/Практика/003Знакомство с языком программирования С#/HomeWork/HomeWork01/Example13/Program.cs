/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"{N} -> ");

int num1 = 0;
if (N / 100 > 0){
     while (N > 99){
          num1 = (N % 10);
          N = N / 10;
          }
     Console.Write($"{num1}");
    }
else Console.WriteLine("there is no third number");