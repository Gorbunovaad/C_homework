/*
Внутри класса Answer напишите метод FindMax, 
который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) { max = b; }
if (c > max) { max = c; }
System.Console.WriteLine(max);