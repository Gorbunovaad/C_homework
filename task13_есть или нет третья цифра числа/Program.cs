/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = new Random().Next();
System.Console.WriteLine(number);
if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int result = number % 10;
    System.Console.WriteLine(result);
}

