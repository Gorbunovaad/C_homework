/*
37. Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


Console.Clear();

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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


int[] NewArray(int[] array)
{
    int[] newArray = new int[array.Length % 2 == 0 ? array.Length / 2 : (array.Length / 2) + 1];

    for (int i = 0, j = array.Length - 1; i < newArray.Length; i++, j--)
    {
        if (i == j)
        {
            newArray[i] = array[i];
            break;
        }
        newArray[i] = array[i] * array[j];
    }

    return newArray;
}

int[] userArray = GetArray(5);
PrintArray(userArray);
System.Console.WriteLine();
int[] userNewArray = NewArray(userArray);
PrintArray(userNewArray);