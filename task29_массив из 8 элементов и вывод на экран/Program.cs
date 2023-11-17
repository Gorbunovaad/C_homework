/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

System.Console.WriteLine("Введите размер массива");
int userSize = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите минимальное число массива");
int userMin = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите максимальное число массива");
int userMax = int.Parse(Console.ReadLine());

int[] userArray = GetArray(userSize, userMin, userMax);
PrintArray(userArray);