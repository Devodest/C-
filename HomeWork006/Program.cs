/*  Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int[] CreateRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 300);
    }
    return arr;
}
int[] InputNumbersN(int length)
{
    int[] arr = new int[length];

    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}


Console.WriteLine("Введите размер массива");
int[] arr = InputNumbersN(int.Parse(Console.ReadLine()));
PrintArr(arr);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    } 
    if else (count == 0)
}
 Console.WriteLine(count);