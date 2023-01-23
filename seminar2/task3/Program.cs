/*
2. Напишите программу, которая выводит случайное число из 
отрезка [10, 99] и показывает наибольшую цифру числа.
Например:
        78 -> 8
        12 -> 2
        85 -> 8
*/

void GetBiggestDigit(int N)
{
    int d = 0;
    int max = 0;
    if(N > 1)
    {
        while(N >= 10)
        {
            d = N % 10;
            if(d > max)max = d;
            N = N/10;
        }
        if(N > max) max = N;
    }
    else
    {
        N = N*(-1);
        while(N >= 10)
        {
            d = N % 10;
            if(d > max)max = d;
            N = N/10;
        }
        if(N > max) max = N;
    }
    Console.WriteLine($"The biggest digit is {max}");
}

Console.Write("Enter number ");
int n = int.Parse(Console.ReadLine()!);
GetBiggestDigit(n);
