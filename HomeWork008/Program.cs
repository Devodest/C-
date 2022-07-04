
using System;
/* Задача 61:Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника */
/* 
Console.WriteLine("Введите первые N строк треугольника");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    for (int j = 0; j < n-i; j++)
    {
        Console.Write("++");
    }

    int c = 1;
    for (int m = 0; m <= i; m++)
    {
        Console.Write("   {0:D}", c);
        c = c * (i - m) / (m + 1);
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine(); */

/* Console.WriteLine("Введите первые N строк треугольника");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
     */



/* Console.WriteLine(temp);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
} */
/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void SortInDescendeingOrder(int[,] array)
{
    int temp = 0;
    for (int i = 0; i <= array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j <= array.GetLength(1) - 1; j++)
        {
            for (int k = j; k <= array.GetLength(1) - 1; k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}
void SumAndSmallestRows(int[,] array)
{
    int sumRows = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows = sumRows + array[i, j];
        }
    }
    Console.WriteLine(sumRows);
    Console.WriteLine();
}
Console.WriteLine("Введите кол-во строк в массиве");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве");
int colums = int.Parse(Console.ReadLine());
int[,] array = new int[rows, colums];

/* CreateRandomArray(array);
Console.WriteLine("Не отсортированный массив");
PrintArray(array);
SortInDescendeingOrder(array);
Console.WriteLine("Отсортированный массив");
PrintArray(array); */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */


CreateRandomArray(array);
PrintArray(array);
SumAndSmallestRows(array);



/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */





/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */





/* Задача 62: Заполните спирально массив 4 на 4. */