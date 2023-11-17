/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();

int Count(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}

System.Console.WriteLine("Введите число");
int usernumber = int.Parse(Console.ReadLine());
int result = Count(usernumber);
System.Console.WriteLine(result);