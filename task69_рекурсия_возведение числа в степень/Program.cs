/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

Console.Clear();

int Degree(int digit, int degree)
{
    if (degree == 1)
    {
        return digit;
    }
    else
    {
        return digit * Degree(digit, degree - 1);
    }
}

int result = Degree(3, 2);
System.Console.WriteLine(result);
