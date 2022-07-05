
using System.Reflection.Metadata;
/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

/* int[] massiv = new int[12];


void fillArray01(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

fillArray(massiv);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] > 0)
    {
        sumPos += massiv[i];
    }
    else
    {
        sumNeg += massiv[i];
    }
}

Console.WriteLine("Положительные: = " + sumPos);
Console.WriteLine("Отрицательные: = " + sumNeg);

Print(massiv);
 */

/* Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */


/* void FillArray(int[] arr)
{
    Console.Write("Заданные элементы: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
        Console.Write($"Index {i} = {arr[i]} ");
    }

    Console.WriteLine();
}
void PrintArrOnNeg(int[] arr)
{
Console.Write("Заменённые элементы: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
    Console.Write($" Index {i} = {arr[i]} ");
}
}

int[] mass = new int[4];
FillArray(mass);
PrintArrOnNeg(mass);
 */

/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве. */

/* int[] createRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] myArr = createRandomArray(5);
PrintArr(myArr);

Console.WriteLine();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

bool find = false;
for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] == n)
    {
        find = true;
        break;
    }

}
if (find)
{
    Console.WriteLine("Это число есть ");
}
else
{
    Console.WriteLine("Этого числа нету");
} */
/* int[] createRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] myArr = createRandomArray(5);
PrintArr(myArr);

Console.WriteLine();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if (Array.Exists(myArr, i => i == n))
{
    Console.WriteLine("Это число есть ");
}
else
{
    Console.WriteLine("Этого числа нету");
} */

/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


/* int[] CreateRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 300);
    }
    return arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] myArr = CreateRandomArray(123);
PrintArr(myArr);
Console.WriteLine();

int sumIndex = 0;
for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] >= 10 && myArr[i] <= 99)
    {
        sumIndex++;
    }
}
Console.WriteLine("Коллчисево чисел в отрезке [10, 99]: "+ sumIndex);
 */

/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


/* int[] CreatRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.WriteLine("Введите колличество цифр в массиве");
int[] myArr = CreatRandomArray(int.Parse(Console.ReadLine()));
PrintArr(myArr);
Console.WriteLine();

int[] tmp = myArr;
List<int> res = new List<int>();
int index = 0;
while (true)
{
    int first = tmp[0];
    int last = tmp[tmp.Length - 1];
    Console.WriteLine($"{index} Элемент {first}");
    Console.WriteLine($"{myArr.Length-index} Элемент {last}");
    int mult = first * last;
    Console.WriteLine("Произведение " + mult);
    res.Add(mult);
    tmp = tmp.Skip(1).Take(tmp.Length - 2).ToArray();
    if (tmp.Length == 1)
    {
        res.Add(tmp[0]);
    }
    if (tmp.Length < 2)
    {
        break;
    }
    index++;
}
Console.WriteLine();
Console.WriteLine("[{0}]", string.Join(", ", res.ToArray())); */