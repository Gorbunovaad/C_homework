/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел 
и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов 
с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Аргументы, передаваемые в метод/функцию: 
18      76      11  
Сумма нечетных элементов: 76
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

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] userArray = new int[] { 18, 76, 11 };
PrintArray(userArray);
int userResult = SumOddElements(userArray);
System.Console.WriteLine($"Сумма нечетных элементов: {userResult}");