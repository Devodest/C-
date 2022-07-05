/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("enter the day of the week is from 1 to 7 ");
int a = int.Parse(Console.ReadLine());

if (a >= 1 && a <= 5)
{
    Console.WriteLine($"No, this day is not day off ");
}
else if (a > 5 && a < 8)
{
    Console.WriteLine($"Yes, this day is day off ");
}