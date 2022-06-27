using System;
/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */

/* int[] CreateRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
        Console.WriteLine();
}
Console.WriteLine("Введите колличество элементов в массиве: ");
int[] myArr = CreateRandomArray(int.Parse(Console.ReadLine()));
PrintArray(myArr);
 */
/* int count = 0;
for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] % 2 == 0)
    {
    count++;
    }
}
 */

/* Задача Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* 
int sumIndex = 0;
for (int i = 0; i < myArr.Length; i+=2)
{
    sumIndex += myArr[i];
}
Console.WriteLine(sumIndex);
 */


/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

Console.Clear();
double[] CreateRandomArray(int length)
{
    double[] arr = new double[length];
    for (int i = 0; i < arr.Length; i++)
    {
        //arr[i] = new Random().Next(1, 100) + new Random().NextDouble();
        arr[i] = (double) new Random().Next(1, 100000000) / 10000000;
    }
    return arr;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите колличество элементов в массиве: ");
double[] myArr = CreateRandomArray(int.Parse(Console.ReadLine()));
PrintArray(myArr);
double max = 0;
double? min = null;

for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] > max)
    {
        max = myArr[i];
    }
    if (min == null || myArr[i] < min)
    {
        min = myArr[i];
    }
}
if (min != null)
{
    decimal diff = ((decimal)max) - ((decimal)min);
    Console.WriteLine($"{max} - {min} = {Math.Round(diff, 2)}");
} else Console.WriteLine("Не удалось определить минимальное значение");