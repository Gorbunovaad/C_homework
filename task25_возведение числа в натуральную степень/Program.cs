/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

/*double Exp(int basis, int degree)
{
    double result = Math.Pow(basis, degree);
    return result;
}*/

System.Console.WriteLine("Введите число");
int userBasis = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите степень числа");
int userDegree = int.Parse(Console.ReadLine());

double userResult = Exp(userBasis, userDegree);
System.Console.WriteLine(userResult);


int Exp(int basis, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * basis;
    }
    return result;
}

