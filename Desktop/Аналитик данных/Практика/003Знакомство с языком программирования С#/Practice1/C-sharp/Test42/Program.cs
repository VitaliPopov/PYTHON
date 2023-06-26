// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10
Console.Clear();
int Number(int a){
string result = " ";


while (a > 0)
{
    result= Convert.ToString(a % 2) + result;
    a= a/2;
}
return int.Parse(result);
}
int a= Number(45);
Console.WriteLine(a);