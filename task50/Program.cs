/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.
Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся 
на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
 k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив
 типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате
The averages in columns are:
x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.
*/

Console.Clear();

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == 0 && j == 0)
            {
                array[i, j] = 1;
            }
            else if (j == 0)
            {
                array[i, j] = array[i - 1, m - 1] + k;
            }
            else
            {
                array[i, j] = array[i, j - 1] + k;
            }
        }
    }

    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine("");
    }
}

double[] FindAverageInColumns(int[,] matrix)
{

    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int d = matrix[i, j];
            sum = sum + d;
        }
        array[j] = Math.Round(sum / matrix.GetLength(0), 2);
    }
    return array;
}

void PrintListAvr(double[] array)
{
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
}

int[,] user2DArray = CreateIncreasingMatrix(3, 4, 2);
PrintArray(user2DArray);
PrintListAvr(FindAverageInColumns(user2DArray));