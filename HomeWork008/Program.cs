
using System;
Console.Clear();
/* Задача 61:Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника */

/* Console.WriteLine("Введите первые N строк треугольника");
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
    int row = 0;
    int sumRows = 0;
    int sumRows1 = 0;
    for (int i = 0; i < array.GetLength(0); i++)  // проходим по строкам
    {
        int sumRows2 = 0;                           // Обнуляем сумму.
        for (int j = 0; j < array.GetLength(1); j++) // проходим по столбцам
        {
            sumRows2 += array[i, j];                // Ищем сумму элементов строк
        }
        if (sumRows2 < sumRows1)                    // Сравниваем новую сумму элементов с предыдущей,
        {
            sumRows = sumRows2;                     // Если сумма элементов меньше предыдущей, то записываем сумм и строку её.
            row = i;
        }
        sumRows1 = sumRows2;                        // записываем наимеьшую сумму, что бы в будущем снова её сравнить и найти самую наименьшую сумму.
    }
    Console.WriteLine(" Наименьшаяя сумма = {0}", sumRows);
    Console.WriteLine(" Номер строки = {0}", row + 1);
}
void ProductOfTwoArray(int[,] array, int[,] array2)
{
    int rowMatrixArray = array.GetLength(0);
    int columsMatrixArray = array.GetLength(1);
    int rowMatrixArray2 = array2.GetLength(0);
    int columsMatrixArray2 = array2.GetLength(1);
    int temp = 0;
    int[,] array3 = new int[rowMatrixArray, columsMatrixArray2];
    if (columsMatrixArray != rowMatrixArray2){
        Console.WriteLine("Матрицы не могут быть перемножены");
    }
    else{
        for (int i = 0; i < rowMatrixArray; i++){
            for (int j = 0; j < columsMatrixArray2; j++){
                temp = 0;
                for (int k = 0; k < columsMatrixArray; k++){
                    temp += array[i,k] * array2[k,j];
                }
                array3[i,j] = temp;
                Console.Write(array3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


/* Console.WriteLine("Введите кол-во строк в массиве");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве");
int colums = int.Parse(Console.ReadLine());
int[,] array = new int[rows, colums]; */

/* CreateRandomArray(array);
Console.WriteLine("Не отсортированный массив");
PrintArray(array);
SortInDescendeingOrder(array);
Console.WriteLine("Отсортированный массив");
PrintArray(array); */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */


/* CreateRandomArray(array);
PrintArray(array);
SumAndSmallestRows(array);
 */


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */


/* Console.WriteLine("Введите кол-во строк в массиве массиве");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве массиве");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("1 матрица");
int[,] array = new int[rows, colums];
CreateRandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("2 матрица");
int[,] array2 = new int[colums, rows];
CreateRandomArray(array2);
PrintArray(array2);
int[,] array3 = new int[rows, rows];
Console.WriteLine("Результат перемножения матриц");
ProductOfTwoArray(array, array2); */



/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */





/* Задача 62: Заполните спирально массив 4 на 4. */