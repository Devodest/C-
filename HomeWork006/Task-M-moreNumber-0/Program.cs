/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
void CreateRandomArray(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 300);
    }
}
void InputNumbersN(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = double.Parse(Console.ReadLine());
    }
}


Console.WriteLine("Введите кол-во столбцов в массике");
int n = int.Parse(Console.ReadLine());
double[] mass = new double[n];
CreateRandomArray(mass);
PrintArr(mass);
InputNumbersN(mass);

double count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);

