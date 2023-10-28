/* 
40. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины.
*/
/*
bool Triangle(int a, int b, int c)
{
    if (a + b > c & b + c > a & a + c > b)
    {
        return true;
    }
    return false;

}

System.Console.WriteLine(Triangle(1, 2, 3));
*/
string Triangle1(int a, int b, int c)
{
    string result = $"Нет, треугольник со сторонами {a}, {b}, {c} не может существовать";
    if (a + b > c & b + c > a & a + c > b)
    {
        result = $"Да, треугольник со сторонами {a}, {b}, {c} существует";
    }
    return result;

}

System.Console.WriteLine(Triangle1(1, 2, 3));

/*
bool IsTriangle(int a, int b, int c)
{
    if (a<=0 || b<=0|| c<=0)
        return false;
    
    return a+b>c & b+c>a & c+a>b;
}

