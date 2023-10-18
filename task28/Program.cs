/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();

int Multiplication(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    return result;
}

System.Console.WriteLine("Введите число");
int userN = int.Parse(Console.ReadLine());
int userResult = Multiplication(userN);
System.Console.WriteLine(userResult);