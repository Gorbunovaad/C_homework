/*
Напишите программу для работы с массивом вещественных чисел.
Реализуйте класс ArrayOperations, который содержит следующие статические методы:
FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и 
возвращает максимальное число из массива.
FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и 
возвращает минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных 
чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив 
array и выводит его элементы с двумя знаками после запятой через табуляцию.
    Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:
Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/

Console.Clear();

/*double[] GetDoubleRnd(int size)
{
    double[] array= new double [size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(-99,99)+ new Random().NextDouble();
    }
    return array;
}
*/

void PrintArray(double[] arr)
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

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double userMax = FindMax(array);
    double userMin = FindMin(array);
    double result = userMax - userMin;
    return result;
}

double[] userArray = new double[] { 3.17, 8.94, 2.36, 5.72, 0.85 };
PrintArray(userArray);
double userResult = CalcDifferenceBetweenMaxMin(userArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов: {userResult}");
