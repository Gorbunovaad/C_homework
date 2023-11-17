/*
Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных 
трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает массив целых положительных 
трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}. 

Массив:
124     378     593     821     456 
Количество четных элементов: 3
*/
Console.Clear();

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            System.Console.Write(arr[i] + "\t");
        }
        else
        {
            System.Console.WriteLine(arr[i]);
        }
    }
}

int CountOfElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] userArray = new int[] { 124, 378, 593, 821, 456 };
PrintArray(userArray);
int userCount = CountOfElements(userArray);
System.Console.WriteLine($"Количество четных элементов: {userCount}");