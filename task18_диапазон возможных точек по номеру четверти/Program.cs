/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();
System.Console.Write("Введите номер четверти");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
    System.Console.WriteLine("x>0 и y>0");
}
if (quarter == 2)
{
    System.Console.WriteLine("x<0 и y>0");
}
if (quarter == 3)
{
    System.Console.WriteLine("x<0 и y<0");
}
if (quarter == 4)
{
    System.Console.WriteLine("x>0 и y<0");
}

