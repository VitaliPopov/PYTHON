//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//int[]
// //[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
// Console.WriteLine($"a = {a},b = {b}");

int [] GetArray(int size){
    int[] result = new int[size];
    for (int i=0; i<size; i++)
    {
        result[i] = new Random().Next(0,2);
    }
    return result;
}
int[] array = GetArray(8);
Console.WriteLine($"[{String.Join("; ", array)}]");