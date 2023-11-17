/*
Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает 
на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

System.Console.Write("Введите координату х первой точки ");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y первой точки ");
int y1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату z первой точки ");
int z1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите координату х второй точки ");
int x2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y второй точки ");
int y2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату z второй точки ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

System.Console.WriteLine(Math.Round(result, 2));