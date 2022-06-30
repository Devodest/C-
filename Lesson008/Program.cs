﻿
/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

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
void ReplaceFirstToLast(int[,] array)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}
void ReplaceStringToRow(int[,] array, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i, j] = array[j, i];
        }
    }
}
void ReplaceStringToRowTemp(int[,] array)
{
    int temp;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Матрица не квадратная");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
}
int FrequencyDictionary(int[,] array)
{
    int count = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            bool flag = false;
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0;  ((i != k) && j < array.GetLength(1)) || ((i == k) && (j < l)); j++)
                {
                    if (array[i, j] == array[k, l])
                    {
                        flag = true;
                    }
                }
            }
            if (!flag)
            {
                count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == array[k, l])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Элемент {array[k, l]} встречается {count} раз");
            }
        }
    }
    return count;
}
Console.WriteLine("Введите кол-во строк в массике");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int m = int.Parse(Console.ReadLine());
int[,] mass = new int[n, m];
int[,] mass2 = new int[n, m];

CreateRandomArray(mass);
PrintArray(mass);
Console.WriteLine();
/* ReplaceFirstToLast(mass);
PrintArray(mass);
 */

/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */
/* ReplaceStringToRowTemp(mass); */
/* ReplaceStringToRow(mass, mass2); */

/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

Console.WriteLine($"Элемент {mass[0, 0]} встречается {FrequencyDictionary(mass)} раз");


/* void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void CountFrequency(int[,] arr, int element)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[i, j] == element) counter++;
        }

    }
    Console.WriteLine($"{element} встречается {counter} раз");
}
bool CheckArray(int[,] arr, int idx, int elem)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (counter==idx) return true;
            if (arr[i, j] == elem) return false;
            counter++;
        }
    }
    return true;
}
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
int counter=0;
foreach (int elem in array)
{
    if (CheckArray(array, counter, elem)) CountFrequency(array, elem);
    counter++;
} */
