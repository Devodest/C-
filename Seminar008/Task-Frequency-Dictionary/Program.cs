/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */


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
void FrequencyCount(int[,] array, int element)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element) { counter++; }
        }

    }
    Console.WriteLine($"{element} встречается {counter} раз");
}
bool CheckArray(int[,] array, int idx, int elem)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (counter == idx) return true;
            if (array[i, j] == elem) return false;
            counter++;
        }
    }
    return true;
}



Console.WriteLine("Введите кол-во строк в массике");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int m = int.Parse(Console.ReadLine());
int[,] mass = new int[n, m];

CreateRandomArray(mass);
PrintArray(mass);
Console.WriteLine();
int counter = 0;
foreach (int elem in mass)
{
    if (CheckArray(mass, counter, elem))
        FrequencyCount(mass, elem);
    counter++;
}
// Создать отдельынй массив с уникальными элементами.