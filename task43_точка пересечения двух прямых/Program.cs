/*
43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

System.Console.WriteLine("Введите значения b1, k1, b2, k2 через запятую в указанной последовательности: ");

string text = Console.ReadLine();
string[] word = text.Split(',');
int[] userArray = GetArray(word);
IntersectionPoints(userArray);


int[] GetArray(string[] str)
{
    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = Convert.ToInt32(str[i]);
    }
    return array;
}

void IntersectionPoints(int[] arr)
{
    double x1 = arr[2] - arr[0];
    double x2 = arr[1] - arr[3];
    double x = x1 / x2;
    double y1 = arr[1] * x;
    double y = y1 + arr[0];

    System.Console.WriteLine($"({x}; {y})");
}

