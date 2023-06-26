/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

 int[] GetArray(int size, int minel, int maxel){
    int [] result = new int [size];
    for (int i=0; i< size; i++)
    {
        result[i]=new Random().Next(minel, maxel+1);
    }
        return result;
 }
 int[] CopyArray( int[] a )
 {
    int [] result = new int[a.Length];
    for (int i= 0; i<a.Length; i++)
    {
        result[i]= a[i];
    }
    return result;
 }
int[] qwer = GetArray(7, 2 , 15);
int[] asd = CopyArray(qwer);
Console.WriteLine($" Original massive = {String.Join(" ", qwer)}");
Console.WriteLine($" Copying massive = {String.Join(" ", asd)}");
