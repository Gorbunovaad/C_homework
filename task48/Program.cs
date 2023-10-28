/*
48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Аmn=m+n

*/



Console.Clear();

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

int[,] userArray = Get2DArray(4, 5);
Print2DArray(userArray);