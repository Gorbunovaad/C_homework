/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();
System.Console.WriteLine("Введите значение оси Х для точки а:");
double aX = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите значение оси Y для точки а:");
double aY = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите значение оси Х для точки b:");
double bX = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите значение оси Y для точки b:");
double bY = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2));
//Math.Sqrt ищет квадратный корень из числа (обязательно использовать тип double)
// Math.Pow(arg, n) возведение в степень n аргумента arg

System.Console.WriteLine(Math.Round(result, 3));
// Math.Round(arg, n) округление числа arg до n знаков после запятой