/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

﻿Console.Clear();
double[] array = GetArray(8, 0, 10);
Console.WriteLine(String.Join(" ", array));
//Console.WriteLine($"Максимум={max}, Минимум={min}");
Console.WriteLine($"Разница = {GetDifference(array)}");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*(maxValue - minValue) + minValue;
    }
    return result;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    double result = 0;
    for (int i=0; i<array.Length; i++)
    {
      if (max< array[i])
      max= array[i];
      if (min> array[i])
      min= array[i];
      result= max- min;
    }

    Console.WriteLine($"Максимум={max}, Минимум={min}");
    return result;

}