/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет
*/

void PrintArray(double[,] mass)
{

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($" {mass[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CreateRandomMassiv(double[,] mass)
{
    Console.WriteLine();
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 1);
        }
    }
}
void FindsPosElement(double[,] mass)
{
    Console.WriteLine("введите позицию элемента, которого хотите увидеть:");
    string posElement = Console.ReadLine();
    Console.WriteLine();
    int posElement1 = 0;
    int idx1 = 0;
    int idx2 = 0;
    if (int.TryParse(posElement, out posElement1))   // Преобразуем temp из стринга в биты, Что такое out temp1?
    {
        if (posElement1 != 0)
        {
            if (posElement1 > (mass.GetLength(0) * mass.GetLength(1)))
            {
                Console.WriteLine("Вы задали большее значение, чем кол-во элементов в массиве: " + (mass.GetLength(0) * mass.GetLength(1)));
                return;
            }
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                if (posElement1 <= 0) { break; }
                idx1 = i;
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    posElement1--;
                    idx2 = j;
                    if (posElement1 <= 0) break;
                }

            }
        }
    }
    else
    {
        string[] poz = posElement.Split(',');
        idx1 = int.Parse(poz[0]) - 1; if (idx1 >= mass.GetLength(0)) { Console.WriteLine("Такого элмента нет"); return; }
        idx2 = int.Parse(poz[1]) - 1; if (idx2 >= mass.GetLength(1)) { Console.WriteLine("Такого элмента нет"); return; }
    }
    Console.WriteLine("Ваш элемент " + mass[idx1, idx2]);
}
void FindElemntsInMassiv(double[,] mass)
{
    Console.WriteLine("Напишите число, которое хотите найти в массиве");
    double number = double.Parse(Console.ReadLine());
    Console.WriteLine();
    int idx1 = 0;
    int idx2 = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        idx1 = i;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            idx2 = j;
            if (mass[i, j] == number)
            {

                Console.WriteLine("Ваше число есть: " + mass[i, j]); break;
            }
        }
    }
    if (mass[idx1, idx2] != number) Console.WriteLine("Вашего числа нет в массиве");
    Console.WriteLine();
}


Console.WriteLine("Введите кол-во строк в массике");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массике");
int m = int.Parse(Console.ReadLine());
double[,] mass = new double[n, m];


CreateRandomMassiv(mass);
PrintArray(mass);
FindElemntsInMassiv(mass);
FindsPosElement(mass);
