﻿int x = 1234;
int a1 = x % 10; // 4
int a2 = x / 10 % 10; // 3
int a3 = x / 100 % 10; // 2
int a4 = x / 1000; // 1
x = a1 * 1000 + a2 * 100 + a3 * 10 + a4; // 4000 + 300 + 20 + 1 = 4321
Console.Write(x == 1);