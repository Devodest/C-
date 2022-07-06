/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

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





Console.WriteLine("Введите кол-во строк в массике");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int m = int.Parse(Console.ReadLine());
int[,] mass = new int[n, m];
int[,] mass2 = new int[n, m];

CreateRandomArray(mass);
PrintArray(mass);
Console.WriteLine();
ReplaceStringToRowTemp(mass);
ReplaceStringToRow(mass, mass2);