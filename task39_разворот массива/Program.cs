/* 
39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а
первый - на последнем и т.д)
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}


void PrintArray(int[] arr)

{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
void Rev(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;

    }
}

int[] userArray = GetRnd(8);
PrintArray(userArray);
Rev(userArray);
PrintArray(userArray);