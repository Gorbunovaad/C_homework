/* 
Напишите код, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Он должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное 
и False в следующей строке.

Для остальных чисел вернуть True или False.
*/

Console.Clear();

System.Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
int a = 0;
double reverse = 0;
if (number < 10000 || number > 99999)
{
    System.Console.WriteLine("Данное число не пятизначное");
    System.Console.WriteLine("False");
}
else
{
    int number1 = number;
    for (double i = 0; i < 5; i++)
    {
        a = number % 10;
        number = number / 10;
        reverse = reverse + a * (Math.Pow(10, 5 - i));
    }
    reverse = reverse / 10;
    if (number1 == reverse)
    {
        System.Console.WriteLine("True");
    }
    else
    {
        System.Console.WriteLine("False");
    }

}
