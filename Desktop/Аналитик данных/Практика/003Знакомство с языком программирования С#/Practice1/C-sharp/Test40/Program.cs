// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
Console.WriteLine("Enter a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter c: ");
int c = int.Parse(Console.ReadLine());

if (Triangle(a, b, c))
{
    Console.WriteLine("Верно");
}
else Console.WriteLine("Неверно");

bool Triangle (int a, int b, int c)
{
    return (a+b>c) && (a+c>b) && (c+b>a);
}