/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Clear();

int[] GetArray()
{
    int[] array = new int[123];
    for (int i = 0; i < 123; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < 123; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

void CountOfNumber(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < 123; i++)
    {
        if (arr1[i] >= 10 && arr1[i] < 100)
        {
            count = count + 1;
        }
    }
    System.Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {count}");

}

int[] userArray = GetArray();
PrintArray(userArray);
System.Console.WriteLine();
CountOfNumber(userArray);


