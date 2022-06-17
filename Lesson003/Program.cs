/*  Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

/* Console.Clear();
Console.WriteLine("Введите х");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("1 плоскость");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2 плоскость");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3 плоскость");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4 плоскость");
}
else Console.WriteLine("Не принадлежит плоскости"); */

/* Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */


/* Console.Clear();
Console.WriteLine("Введите № плоскости от 1 до 4");
int numPlane = int.Parse(Console.ReadLine());

if (numPlane == 1){
    Console.WriteLine("x от 1 до +∞, y от 1 до +∞");
}
else if (numPlane == 2){
    Console.WriteLine("x от -1 до -∞, y от 1 до +∞");
}
else if (numPlane == 3){
    Console.WriteLine("x от -1 до -∞, y от -1 до -∞");
}
else if (numPlane == 4){
    Console.WriteLine("x от -1 до -∞, y от 1 до +∞");
}
else Console.WriteLine("Ввели не правильный номер четверти"); */

/* 
Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
 */


/* Console.Clear();
Console.WriteLine("Введите ккординаты первой точки - х");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ккординаты первой точки -  y");
double Y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите ккординаты второй точки - х");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ккординаты второй точки -  y");
double Y2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));

Console.WriteLine(Math.Round(distance, 2));
 */

/*  Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

/* Console.WriteLine("Введите число N");
double N = double.Parse(Console.ReadLine());
double i = 1;
while (i <= N)
{
    Console.WriteLine(Math.Pow(i,2));
    i++;
} */

