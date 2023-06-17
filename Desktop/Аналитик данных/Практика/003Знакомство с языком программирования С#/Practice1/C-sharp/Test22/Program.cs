// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4
Console.Clear();
Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine());
int[] result = new int[N];

for (int i=1; i<=N; i++)
    result[i-1] = i*i;

for (int i=0; i<N; i++)
    Console.WriteLine($"{result[i]} ");
Console.WriteLine();  

for (int i=1; i<=N; i++)
    Console.WriteLine($"{i} в квадрате = {Math.Pow(i, 2)}");


int a = 1;
while (a <N)
{
int s = Convert.ToInt32(Math.Pow(a,2));
Console.Write($"{s}, ");
a++;
}
Console.Write($"{N*N}. ");