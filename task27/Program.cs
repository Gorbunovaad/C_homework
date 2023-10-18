/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int SumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int remainder = number % 10;
        sum = sum + remainder;
        number = number / 10;
    }
    return sum;
}

System.Console.WriteLine("Введите число");
int userNumber = int.Parse(Console.ReadLine());
int userResult = SumNumber(userNumber);
System.Console.WriteLine(userResult);