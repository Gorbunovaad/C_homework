/*
41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

System.Console.WriteLine("Введите числе через запятую: ");

string text = Console.ReadLine();
string[] word = text.Split(',');
int[] userArray = GetArray(word);
int result = CountPositive(userArray);
System.Console.WriteLine($"Количество чисел больше 0 в ряду составляет: {result}");



int[] GetArray(string[] str)
{
    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = Convert.ToInt32(str[i]);
    }
    return array;
}


int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count = count + 1;
    }
    return count;
}