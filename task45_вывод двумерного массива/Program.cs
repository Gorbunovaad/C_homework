/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n 
(размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают 
на минимальную и максимальную границы случайных чисел.
Также, задайте метод PrintArray, который выводил бы массив на экран.
Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] 
с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. 
Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.
*/

Console.Clear();

double[,] Get2Darray(int row, int col, int min, int max)
{
    double[,] array2D = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array2D[i, j] = new Random().Next(min, max) + new Random().NextDouble();
            array2D[i, j] = Math.Round(array2D[i, j], 1);
        }
    }
    return array2D;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine("");
    }
}

double[,] userArray2D = Get2Darray(3, 4, -10, 10);
Print2DArray(userArray2D);
