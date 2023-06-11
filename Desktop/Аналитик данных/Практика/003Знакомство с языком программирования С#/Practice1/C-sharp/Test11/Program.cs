Console.Clear();
int num = new Random().Next(100, 1000);
int num1 = (num / 100) * 10;
int num2 = num % 10;
int num3 = num1 + num2;
Console.WriteLine($"Двузначное от трехзначного {num} -> {num3}");