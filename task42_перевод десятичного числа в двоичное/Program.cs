/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 ->101101
3 -> 11
2 -> 10
*/

Console.Clear();

/*
int DecToBinary(int num)
{
    int result = 0;
    int temp = 1;

    while(num > 0)
    {
        result = result + num%2 * temp;
        num = num / 2;
        temp= temp*10;
    }
    result = result + "1";



    return result;
}
*/

void DecToBinary(int num)
{
    string result = "";
    int binary = 0;
    for (int i = num; i > 0; i /= 2)
    {
        binary = i % 2;
        result = binary + result;
    }
    System.Console.WriteLine(result);
}

DecToBinary(10);
