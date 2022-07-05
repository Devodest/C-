/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


void fillArrayToRand(int[] array)
{
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 100);
        }
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[ ");
            Console.Write($"{array[i]}, ");

    }
    Console.Write("]");
    Console.WriteLine();
}

int[] array = new int[10];



fillArrayToRand(array);
printArray(array);