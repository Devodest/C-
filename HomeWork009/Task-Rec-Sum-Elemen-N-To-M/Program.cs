/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



void NumberSeries(int numberStart, int numberFinish)
{
    if (Math.Abs(numberStart - numberFinish) == 0)
    {
        return 0;
    }
        NumberSeries(numberStart - 1, numberFinish);
}


Console.WriteLine("Введите numberStart");
int numberFinish = int.Parse(Console.ReadLine());
Console.WriteLine("Введите numberFinish");
int numberStart = int.Parse(Console.ReadLine());
Console.WriteLine();


NumberSeries(numberStart, numberFinish);