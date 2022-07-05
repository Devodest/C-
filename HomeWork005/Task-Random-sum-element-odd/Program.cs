/* Задача Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void CreateRandomArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(1,10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}


int[ ] array = new int [5];
CreateRandomArray(array);
PrintArray(array);
int sumIndex = 0;
for (int i = 0; i < array.Length; i+=2)
{
    sumIndex += array[i];
}
Console.WriteLine(sumIndex);
