
/* Задача 61:Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника */
/* void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите первые N строк треугольника");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
/* int b = int.Parse(Console.ReadLine());
int[,] array = new int[a, b];  PrintArray(array); */
/* Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = 1 + j + i;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("{0}{1}", array[i,j], "\t");
        Console.WriteLine();
    }
} */

/* Console.WriteLine("Введите первые N строк треугольника");
int n = int.Parse(Console.ReadLine());

for (int y = 0; y < n; y++)
{
    int c = 1;
    for (int q = 0; q < n - y; q++)
    {
        System.Console.Write("   ");
    }

    for (int x = 0; x <= y; x++)
    {
        System.Console.Write("   {0:D} ", c);
        c = c * (y - x) / (x + 1);
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}
System.Console.WriteLine(); */

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
        Console.Write("    {0:D}", c);
        c = c * (i - m) / (m + 1);
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();

/* Console.WriteLine(temp);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
} */
/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */




/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */




/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */





/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */





/* Задача 62: Заполните спирально массив 4 на 4. */