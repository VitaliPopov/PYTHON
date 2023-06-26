/* **Задача 32:**Напишите программу замена ѝлементов маѝѝива: 
положительные ѝлементы замените на ѝоответѝтвующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]  String.Join(", ", array)*/

Console.Clear();
int[] startArray = GetArray(6, -10, 10);
int[] startArray2 = GetArray(12, -100, 150);
Console.WriteLine($"startArray -> {String.Join(" ", startArray)}");
Console.WriteLine($"startArray -> {String.Join(" ", InversArray(startArray))}");
Console.WriteLine($"startArray -> {String.Join(" ", startArray2)}");
Console.WriteLine($"startArray -> {String.Join(" ", InversArray(startArray2))}");


int[] GetArray(int size, int minel, int maxel){
    int [] result = new int [size];
    for (int i=0; i< size; i++)
    {
        result[i]=new Random().Next(minel, maxel+1);
    }
        return result;
}
int[] InversArray(int [] array){
    for (int i=0; i< array.Length; i++)
    {
        array[i] *=-1;
    }
    return array;
}
//Console.WriteLine(GetArray);