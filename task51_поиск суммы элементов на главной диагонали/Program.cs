/*
51. Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

Console.Clear();

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 11);
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

int SumElement(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + arr[i, j];
            }
        }
    }
    return sum;
}

/* int SumOfDiagonal(int [,] array)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i,i];        
    }

    return result;
}
*/
int[,] userArray = Get2DArray(4, 5);
Print2DArray(userArray);
int userSum = SumElement(userArray);
System.Console.WriteLine($"Сумма элементов по главной диагонали равна: {userSum}");