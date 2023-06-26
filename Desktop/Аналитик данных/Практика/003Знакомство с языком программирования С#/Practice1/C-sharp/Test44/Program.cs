// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8  

// <aside>
// ❗️ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.

int[] Fib(int a)
{
    int[] result = new int[a]; 
    result[0]=0;
    if (a>=2)
    {
        result[1]=1;
    }
    else return result;
    for (int i =2; i<a; i++)
    {
    
        result[i] =  result[i-1]+ result[i-2];
    }
return result;
}
Console.WriteLine($"Fibonacci of {8}= {String.Join(" ", Fib(8))}");