
/* Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

void NumberSeries(int numberStart, int numberFinish)
{
    if (numberStart > numberFinish)
    {
        return;
    }
    Console.Write(numberStart + " ");
    NumberSeries(numberStart + 1, numberFinish);
}
(int numberStart, int numberFinish) MinMax(int numberStart, int numberFinish)
{
    int temp;
    if (numberStart > numberFinish)
    {
        temp = numberStart;
        numberStart = numberFinish;
        numberFinish = temp;
    }
    return (numberStart, numberFinish);
}

Console.WriteLine("Введите numberStart");
int numberFinish = int.Parse(Console.ReadLine());
Console.WriteLine("Введите numberFinish");
int numberStart = int.Parse(Console.ReadLine());
Console.WriteLine();


(numberStart, numberFinish) = MinMax(numberStart, numberFinish);
NumberSeries(numberStart, numberFinish);