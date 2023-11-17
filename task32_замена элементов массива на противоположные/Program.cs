/*
32. Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

void ReverseElementsValue(int[] array)
{
    for (uint i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

void Print(int[] arr)
{
    foreach (int i in arr) System.Console.Write(i + " ");
}

int[] userArray = { 1, -1, 10, 15, -20 };
ReverseElementsValue(userArray);
Print(userArray);