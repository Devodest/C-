/*Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; 5,5) */


Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());

double x = 0;
double y = 0;
if (k2 - k1 == 0 || k1 - k2 == 0)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    x = (b1 - b2) / (k2 - k1);
    y = (k1 * b2 - k2 * b1) / (k1 - k2);
    Console.WriteLine($" x = ({x}) y = ({y})");
}
