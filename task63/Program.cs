/*
63. Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от 1 до N.
*/

Console.Clear();

void DigitDiapason(int max, int start = 1)
{
    if (start > max)
    {
        return;
    }
    else
    {
        System.Console.Write(start + " ");
        DigitDiapason(max, start + 1);
    }
}

DigitDiapason(5);