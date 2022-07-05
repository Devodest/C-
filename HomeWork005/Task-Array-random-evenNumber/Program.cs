/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */

int[] CreateRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
        Console.WriteLine();
}
Console.WriteLine("Введите колличество элементов в массиве: ");
int[] myArr = CreateRandomArray(int.Parse(Console.ReadLine()));
PrintArray(myArr);

 int count = 0;
for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] % 2 == 0)
    {
    count++;
    }
}
