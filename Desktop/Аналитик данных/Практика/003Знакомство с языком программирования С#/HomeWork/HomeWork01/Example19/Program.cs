Console.Clear();
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
if ((N/10000) == N%10 && (N/1000)%10 == (N/10)%10){
    Console.WriteLine($"{N} - это палиндром!");
}
else Console.WriteLine($"{N} - это НЕ палиндром!");