/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

void Fibonacchi(int num)
{
    int[] fib = new int[num + 1];
    if (num == 0) System.Console.WriteLine("1");
    else
    {
        for (int i = 0; i < 2; i++)
        {
            fib[i] = i;
            System.Console.Write(fib[i] + " ");
        }
        for (int i = 2; i < num; i++)
        {
            fib[i] = fib[i - 2] + fib[i - 1];
            System.Console.Write(fib[i] + " ");
        }
    }
}

Fibonacchi(10);