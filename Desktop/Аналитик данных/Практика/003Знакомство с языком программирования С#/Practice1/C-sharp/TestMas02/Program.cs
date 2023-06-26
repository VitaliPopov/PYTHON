/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/

int [] GetArray(int size){
    int[] result= new int[size];
    for (int i=0; i< size; i++)
    {
        int N = int.Parse(Console.ReadLine());
        result[i]=N;

    }
    return result;
}
int [] GetNewArray(int newsize){
    
}