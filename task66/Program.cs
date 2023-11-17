/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int NumberSumm(int min, int max)
{
    if (min > max)
    {
        return 0;
    }
    else
    {
        return min + NumberSumm(min + 1, max);
    }
}

int result = NumberSumm(4, 8);
System.Console.WriteLine(result);