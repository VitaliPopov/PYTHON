



Console.Clear();
Console.WriteLine("Enter number: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number: ");
int Y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
double s = Math.Sqrt((Math.Pow(X-M,2))+(Math.Pow(Y-N,2)));
Console.WriteLine($"расстояние между точками равно {s}");
