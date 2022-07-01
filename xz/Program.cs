/* Console.WriteLine("Введите сколько строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбцов");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
double[,] mass = new double[m, n];
void PrintDoubleMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {

        for (int j = 0; j < massive.GetLength(1); j++)
        {

            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillDoubleMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 1);
            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
} */
/* void ChooseTheElementMassive(double[,] massive)
{
    int pozstr = 0;
    int pozstnd = 0;
    Console.WriteLine("Задайте номер элемента Порядковый или Позиционный");
    string temp = Console.ReadLine(); 
    int temp1 = 0;
    if (int.TryParse(temp, out temp1)) 
    {
        if (!(temp1 == 0))
        {
            if (temp1 > (massive.GetLength(0) * massive.GetLength(1))) { Console.WriteLine("Такого элмента нет"); return; } // вовзращаем число, если оно не входит в рамки массива
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                if (temp1 <= 0) { break; }
                pozstr = i;
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    temp1--;
                    pozstnd = j;
                    if (temp1 <= 0) { break; }
                }

            }
        }
    }
    else
    {
        string[] poz = temp.Split(',');
        pozstr = int.Parse(poz[0]) - 1; if (pozstr >= massive.GetLength(0)) { Console.WriteLine("Такого элмента нет"); return; }
        pozstnd = int.Parse(poz[1]) - 1; if (pozstnd >= massive.GetLength(1)) { Console.WriteLine("Такого элмента нет"); return; }


    }
    Console.WriteLine();
    Console.WriteLine($"искомый элемент : {massive[pozstr, pozstnd]} ");
    Console.WriteLine();
}
void FillRoundOMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 10);
            Console.Write(" " + massive[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void MiddleofStands(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(1); i++) { Console.Write(" | "); }
    Console.WriteLine();
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            sum += massive[j, i];
        }
        Console.Write($" {Math.Round(sum = sum / massive.GetLength(0), 0)} ");
    }
}
FillDoubleMassive(mass);
ChooseTheElementMassive(mass); */
/* FillRoundOMassive(mass);
MiddleofStands(mass);
 */



void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void CountFrequency(int[,] arr, int element)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[i, j] == element) counter++;
        }

    }
    Console.WriteLine($"{element} встречается {counter} раз");
}
bool CheckArray(int[,] arr, int idx, int elem)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (counter==idx) return true;
            if (arr[i, j] == elem) return false;
            counter++;
        }
    }
    return true;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
int counter=0;
foreach (int elem in array)
{
    if (CheckArray(array, counter, elem)) CountFrequency(array, elem);
    counter++;
}