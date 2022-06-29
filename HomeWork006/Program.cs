/*  Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */
/* void PrintArr(double[] arr)
{
    for (double i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
double[] CreateRandomArray(double length)
{
    double[] arr = new double[length];
    for (double i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 300);
    }
    return arr;
}
double[] InputNumbersN(double length)
{
    double[] arr = new double[length];

    for (double i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = double.Parse(Console.ReadLine());
    }
    return arr;
}


Console.WriteLine("Введите размер массива");
double[] arr = InputNumbersN(double.Parse(Console.ReadLine()));
PrintArr(arr);
double count = 0;
for (double i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);
/*  */




/*  Задача 43. Напишите программу, которая найдёт точку
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
