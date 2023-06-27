/*Задача 37:*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6]-> 36 21*/

Console.Clear();
int[] startArray = GetArray(9, 0, 10);
Console.WriteLine(String.Join(" ", startArray));

Console.WriteLine(String.Join(" ", Result(startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result= new int[size];
    for (int i=0; i< size; i++)
    {
        result[i]= new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int[] Result(int[] Number)
{
    int size = (Number.Length + 1)/ 2;
    int[] newresult = new int[size];
    for (int i = 0; i < Number.Length / 2; i++)
    {
        
        newresult[i] = Number[i] * Number[Number.Length - 1 - i];
    }
    if (Number.Length % 2 == 1)
    newresult[size-1] = Number[Number.Length / 2];
    return newresult;
}
