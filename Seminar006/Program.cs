
/* Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

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
    Console.WriteLine();
}



Console.WriteLine("Введите колличество цифр в массиве");
int[] myArr = CreatRandomArray(int.Parse(Console.ReadLine()));
 PrintArr(myArr);
 */
/*for (int i = 0; i < myArr.Length/2; i++)
{
    int save = myArr[i];
    myArr[i] = myArr[myArr.Length-1-i];
    myArr[myArr.Length-1-i] = save;
    
}

PrintArr(myArr); */



/* Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины. */
/* 5 7 8
7 < 5+8
5 < 7+8
8 < 5+7 */

/* Console.WriteLine("Введите первую длинну стороны треугольника");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую длинну стороны треугольника");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью длинну стороны треугольника");
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Данный треугольник существует");
} else 
    Console.WriteLine("Данного треугольника не существует"); */

/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */



/* Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int ost = 0;
string result = string.Empty;

while (a > 0)
{
    ost = a % 2;
    a = a / 2;
    result = ost + result;
}
 Console.Write(result);
 */

/* void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите десятичное число: ");
int num10 = int.Parse(Console.ReadLine());
int tmp = num10;
int count = 0;

while (num10 !=0)
{    
    num10 = num10 / 2;
    count++;   
}

Console.WriteLine(count);
int [] num10ar = new int [count];

for (int i=count-1; i>=0; i--)
{
    num10ar[i] = (tmp % 2);
    tmp = tmp / 2;    
}

PrintArray(num10ar); */


/* Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */


/* void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число для которого будет построен ряд Фибоначчи: ");
int fiblim = int.Parse(Console.ReadLine());
int [] fib = new int [fiblim];
PrintArray(fib);
fib[0]=0;
fib[1]=1;

for (int i=2; i<fiblim; i++)
{
    fib[i]=fib[i-2]+fib[i-1];
}
PrintArray(fib); */


/*  Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. 
 */


int[] CreatRandomArray(int length)
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
    Console.WriteLine();
}
Console.WriteLine("Введите колличество цифр в массиве");
int[] myArr = CreatRandomArray(int.Parse(Console.ReadLine()));

int[] myArr2 = new int[myArr.Length];
for (int i = 0; i < myArr2.Length; i++)
{
    myArr2[i] = myArr[i];

}

int[] myArr3 = myArr;


PrintArr(myArr);
PrintArr(myArr2);
PrintArr(myArr3);
myArr[0] = 53;
PrintArr(myArr);
PrintArr(myArr2);
PrintArr(myArr3);

