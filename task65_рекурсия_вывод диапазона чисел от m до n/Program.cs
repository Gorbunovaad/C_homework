/*
65. Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
*/

Console.Clear();

void DigitDiapason(int max, int start)
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

DigitDiapason(10, 5);