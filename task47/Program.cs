/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся
 на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
 k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. Элементы матрицы должны 
быть выведены через символ табуляции для более читаемого вывода.

Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 
Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной 
позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода 
FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран 
"The number in [{x}, {y}] is {значение}".
*/

Console.Clear();

int[,] CreateIncreasingMatrix(int n, int ml, int k)
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

int[] FindNumberByPosition(int[,] arr1, int row, int col)
{
    int[] arr2 = new int[2];
    if (arr1.GetLength(0) <= row & arr1.GetLength(1) <= col)
    {
        for (int i = 0; i < 2; i++)
        {
            arr2[i] = 0;
        }
    }
    else
    {
        for (int k = 0; k < arr1.GetLength(0); k++)
        {
            if (k == row)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (j == col)
                    {
                        arr2[0] = arr1[k, j];
                        arr2[1] = 0;
                    }
                }
            }
        }
    }
    return arr2;
}

void PrintCheckIfError(int[] array, int row, int col)
{
    if (array[0] == 0)
    {
        System.Console.WriteLine("There is no such index");
    }
    else
    {
        System.Console.WriteLine($"The number in [{row}, {col}] is {array[0]}");
    }
}

int[,] userArray = CreateIncreasingMatrix(4, 5, 3);
PrintArray(userArray);
PrintCheckIfError(FindNumberByPosition(userArray, 2, 2), 2, 2);