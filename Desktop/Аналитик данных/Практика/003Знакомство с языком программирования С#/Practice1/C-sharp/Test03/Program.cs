/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница*/

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
  Console.WriteLine("Monday");
}
if (day == 2)
{
  Console.WriteLine("Tuesday");
}
if (day == 3)
{
  Console.WriteLine("Wednesday");
}
if (day == 4)
{
  Console.WriteLine("Thursday");
}
if (day == 5)
{
  Console.WriteLine("Friday");
}
if (day == 6)
{
  Console.WriteLine("Saturday");
}
if (day == 7)
{
  Console.WriteLine("Sunday");
}