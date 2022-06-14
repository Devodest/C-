/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
 */

/* Console.WriteLine("введите пятизначное число");
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
 */
/* Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
 */

/* Console.WriteLine("Введите ккординаты первой точки - х");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ккординаты первой точки -  y");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ккординаты первой точки -  z");
double Z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите ккординаты второй точки - х");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ккординаты второй точки -  y");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ккординаты второй точки -  z");
double Z2 = double.Parse(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));

Console.WriteLine(Math.Round(distance, 2)); */

 /* Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125 */

/* Console.WriteLine("Введите число N");
double N = double.Parse(Console.ReadLine());
double i = 1;
while (i <= N)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
} */