﻿/*
Внутри класса Answer напишите метод ShowCube, 
который принимает на вход число (N) и выводит таблицу кубов чисел 
от 1 до N (включительно) каждое на новой строке.
N = 3 
/*
1
8
27
*/

// N = 5
/*
1
8
27
64
125
*/

Console.Clear();
System.Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int result = 0;
System.Console.WriteLine("/*");
for (int i = 1; i <= N; i++)
{
    result = i * i * i;
    System.Console.WriteLine(result);
}
System.Console.WriteLine("*/");