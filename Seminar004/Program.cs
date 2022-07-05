/* : Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
 */

/* Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
if (A < 0)
{
    Console.WriteLine("Нужно ввести положительное число");
    return;
}
int sum = 0;
for (int i = 0; i <= A; i++)
{
    sum += i;
}
Console.WriteLine(sum);
 */


/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
 */

/* Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int i = 0;
while (num > 0)
{
    i++;
    num /= 10;
}
Console.WriteLine("Количество цифр введенного числа : {0}", i);
*/


/* int digits(int num)
{
    int i = 0;

    while (num > 0)
    {
        num /= 10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(digits(num)); */


/* int fact(int a)
{
    int result = 1;
    for (int i = 1; i <= a; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(fact(num)); */

/* Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
 */

void print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}


int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}


print(array);