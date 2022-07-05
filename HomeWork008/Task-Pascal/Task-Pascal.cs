Console.Clear();
/* Задача 61:Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника */

Console.WriteLine("Введите первые N строк треугольника");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    for (int j = 0; j < n-i; j++)
    {
        Console.Write("  ");
    }

    int c = 1;
    for (int m = 0; m <= i; m++)
    {
        Console.Write("   {0:D}", c);
        c = c * (i - m) / (m + 1);
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();