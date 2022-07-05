Console.WriteLine("Введите кол-во строк в массиве");
int rows = int.Parse(Console.ReadLine());
int[] mas = new int[rows];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(1, 10);
    Console.Write(mas[i] + " ");
}


int temp = 0;
for (int i = 0; i < mas.Length; i++)
    for (int j = 0; j < mas.Length-1; j++)
        if (mas[j] < mas[j + 1])
        {
            temp = mas[j];
            mas[j] = mas[j + 1];
            mas[j + 1] = temp;
        }
        Console.WriteLine();
Console.WriteLine("Отсортированный список:");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i]+ " ");
}
