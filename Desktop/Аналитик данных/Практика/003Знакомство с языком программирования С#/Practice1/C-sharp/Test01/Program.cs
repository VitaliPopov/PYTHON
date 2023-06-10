Console.Clear();
Console.Write("Enter number a:");
int a = int.Parse(Console.ReadLine());
//первый способ
int result1 = a * a;
Console.WriteLine($"Способ 1 -> Квадрат числа {a} равен {result1}");
//второй способ
int result2 = Convert.ToInt32(Math.Pow(a, 2));
Console.WriteLine($"Способ 2 -> Квадрат числа {a} равен {result2}");