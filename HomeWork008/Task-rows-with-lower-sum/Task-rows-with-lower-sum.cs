/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

Console.Clear();
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




Console.WriteLine("Введите кол-во строк в массиве");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве");
int colums = int.Parse(Console.ReadLine());
int[,] array = new int[rows, colums];

CreateRandomArray(array);
PrintArray(array);
SumAndSmallestRows(array);
 