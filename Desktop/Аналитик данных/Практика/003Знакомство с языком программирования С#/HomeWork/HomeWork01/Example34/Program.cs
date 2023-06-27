/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
int [] array = GetArray(9, 100, 999);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine($"Количество четных чисел массива = {GetCount(array)}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result= new int[size];
    for (int i=0; i<size; i++)
    {
        result[i]= new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int GetCount(int [] result){
    int count= 0;
    for (int i=0; i<result.Length; i++)
    {
        if (result[i] % 2 == 0)
        {
            count=count+1;
        }
    }
    return count;
}