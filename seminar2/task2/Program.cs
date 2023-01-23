/*
1. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю 
цифру этого числа.

Например:
        456 -> 6
        782 -> 2
        918 -> 8
*/

Console.Write("Enter number ");
int n = int.Parse(Console.ReadLine()!);

int lastDigit = 0;

if(n > 0) lastDigit = n % 10;

else lastDigit = n*(-1)%10;

Console.Write($"Last digit of this number is {lastDigit}");