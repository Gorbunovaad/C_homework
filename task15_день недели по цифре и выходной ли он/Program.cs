/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


System.Console.WriteLine("Введите номер дня недели");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday < 8 && weekday > 0)
{
    if (weekday < 6)
    {
        System.Console.WriteLine("нет");
    }
    else
    {
        System.Console.WriteLine("да");
    }
}
else
{
    System.Console.WriteLine("такого дня недели нет");
}