
/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
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
int[,] FindMinAndCreateNewArray(int[,] array)
{
    int minvalue = array[0, 0];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minvalue > array[i, j])
            {
                minvalue = array[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
    Console.Write("Минимальное значение = " + minvalue + ";");
    Console.WriteLine(" Индекс строки = " + iMin + ";" + " Индекс столбца = " + jMin + ".");
    Console.WriteLine();



    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i < iMin && j < jMin)
            {
                newArray[i, j] = array[i, j];
            }
            else if (i == iMin && j == jMin && i == j)
            {
                newArray[i, j] = array[i + 1, j + 1];
            }
            else if (j >= jMin && i < iMin)
            {
                newArray[i, j] = array[i, j + 1];
            }
            else if (i >= iMin && j < jMin)
            {
                newArray[i, j] = array[i + 1, j];
            }
            else if (i != iMin && j != jMin && i == j)
            {
                newArray[i, j] = array[i + 1, j + 1];
            }
            else
            {
                newArray[i, j] = array[i + 1, j + 1];
            }
        }
    }
    return newArray;
}
/*(int, int) FindIdx(int[,] array, int minvalue) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == minvalue)
            {
                Console.WriteLine($"Минимальное число значения i={i} и j={j}");
                return (i, j);
            }
        }
    }
}*/

Console.WriteLine("Введите кол-во строк в массике");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int m = int.Parse(Console.ReadLine());
int[,] mass = new int[n, m];

CreateRandomArray(mass);
PrintArray(mass);
Console.WriteLine("Исходный массив");
Console.WriteLine();

PrintArray(FindMinAndCreateNewArray(mass)); 

