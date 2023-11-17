/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Clear();

int Sum(int A)
{
    int result = 0;
    for (int i = 1; i <= A; i++)
    {
        result = result + i;
    }
    return result;
}

System.Console.WriteLine("Введите число");
int userA = int.Parse(Console.ReadLine());
int userSum = Sum(userA);
System.Console.WriteLine(userSum);