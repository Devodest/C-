Console.WriteLine("Введите сколько строк");
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
}
void ChooseTheElementMassive(double[,] massive)
{
    int pozstr = 0;
    int pozstnd = 0;
    Console.WriteLine("Задайте номер элемента Порядковый или Позиционный");
    string temp = Console.ReadLine(); // Если написали строкой номер. Например 15 
    int temp1 = 0;
    if (int.TryParse(temp, out temp1))   // Преобразуем temp из стринга в биты, Что такое out temp1?
    {
        if (!(temp1 == 0)) // Сравниваем. Если temp1 не равен 0
        {
            if (temp1 > (massive.GetLength(0) * massive.GetLength(1))) /* умножаем и получаем кол-во элементов*/ { Console.WriteLine("Такого элмента нет"); return; } // вовзращаем число, если оно не входит в рамки массива
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
ChooseTheElementMassive(mass);
/* FillRoundOMassive(mass);
MiddleofStands(mass);
 */