/* Задача 62: Заполните спирально массив 4 на 4. */


Console.Clear();
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] CreateSnakeArray(int rows, int colums)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int gran = rows;

    int[,] mass = new int[rows, colums];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = colums * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dy;
        row += dx;

    }
    return mass;
}

Console.WriteLine("Введите кол-во строк в массиве");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве");
int colums = int.Parse(Console.ReadLine());
int[,] array = new int[rows, colums];

int[,] mass = CreateSnakeArray(rows, colums);
PrintArray(mass);

