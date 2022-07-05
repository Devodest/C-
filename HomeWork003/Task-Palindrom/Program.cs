/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
 */

Console.WriteLine("введите пятизначное число");
int n = int.Parse(Console.ReadLine());
//int n = new Random().Next(10000, 100000);
//Console.WriteLine(n); 

int a = n / 10000;
int b = (n / 1000) % 10;
int c = (n % 100) / 10;
int d = n % 10;

if (n < 10000 || n > 100000){
    Console.WriteLine("Число меньше или больше пятизначного, введите другое число.");
}
else if (a == d && b == c)
{
    Console.WriteLine("Yes");
} else Console.WriteLine("No");
 