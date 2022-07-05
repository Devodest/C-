/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


void PrintArr(double[] arr)
{
    for (double i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
double[] CreateRandomArray(double length)
{
    double[] arr = new double[length];
    for (double i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 300);
    }
    return arr;
}
double[] InputNumbersN(double length)
{
    double[] arr = new double[length];

    for (double i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = double.Parse(Console.ReadLine());
    }
    return arr;
}


Console.WriteLine("Введите размер массива");
double[] arr = InputNumbersN(double.Parse(Console.ReadLine()));
PrintArr(arr);
double count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);