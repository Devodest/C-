/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */

void SumAvgInColumns(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
    Console.Write("Среднее арифметическое элементов массива в каждом столбце ");
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < mass.GetLength(0); j++)
        {
            sum = sum + mass[j, i];
        }
        Console.Write($" {Math.Round(sum = sum / mass.GetLength(0), 1)} ");
    }
}
void PrintArray(double[,] mass)
{

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($" {mass[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CreateRandomMassiv(double[,] mass)
{
    Console.WriteLine();
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 1);
        }
    }
}

Console.WriteLine("Введите кол-во строк в массике");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int m = int.Parse(Console.ReadLine());
double[,] mass = new double[n, m];


CreateRandomMassiv(mass);
PrintArray(mass);
SumAvgInColumns(mass);