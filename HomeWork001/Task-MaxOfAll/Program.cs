﻿/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите 3 числа: " );
int a = int.Parse(Console.ReadLine()),
    b = int.Parse(Console.ReadLine()),
    c = int.Parse(Console.ReadLine()),
    max = 0;

if ( a >= b && a >= c ){
    max = a;
} else if (b >= a && b >= c){
    max = b;
} else max = c;
Console.WriteLine(max);