
/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
        }
    Console.WriteLine();
    }
}
void CreateRandomArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(1, 100);
            }
        }
    }
}
void FrequencyCount(int[,,] array, int element)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) { counter++; }
            }
        }

    }
    Console.WriteLine($"{element} встречается {counter} раз");
}
bool CheckArray(int[,,] array, int idx, int elem)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (counter == idx) return true;
                if (array[i, j, k] == elem) return false;
                counter++;
            }
        }
    }
    return true;
}
Console.WriteLine("Введите кол-во строк в массике");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во вложености в массике");
int nested = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,,] mass = new int[rows, colums, nested];

CreateRandomArray(mass);
PrintArray(mass);

int counter = 0;
foreach (int elem in mass)
{
    if (CheckArray(mass, counter, elem))
        FrequencyCount(mass, elem);
    counter++;
}
