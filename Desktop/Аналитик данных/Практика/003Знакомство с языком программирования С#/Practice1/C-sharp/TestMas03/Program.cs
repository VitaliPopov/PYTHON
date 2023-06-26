/***Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5*/

Console.Clear();
int[] startArray = GetArray(123, 0, 150);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество элементов в отрезке [10,99] = {GetCount(startArray, 10, 99)}");
int[] GetArray(int size, int minValue, int maxValue){
    int[] result= new int[size];
    for (int i=0; i< size; i++)
    {
        result[i]= new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int GetCount(int [] result, int left, int right){
    int el =0;
    for (int i=0; i < result.Length; i++)
    {
        if (result[i] > left && result[i] <right)
        {
           el = el + 1;
        }
            }
            return el;
}
/*Console.WriteLine($"array={GetArray()}");
Console.WriteLine($"result= {GetCount(GetArray())}");*/
