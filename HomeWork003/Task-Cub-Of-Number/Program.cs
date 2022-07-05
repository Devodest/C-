 /* Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число N");
double N = double.Parse(Console.ReadLine());
double i = 1;
while (i <= N)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}