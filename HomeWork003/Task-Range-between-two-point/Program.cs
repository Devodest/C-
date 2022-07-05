/* Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
 */

Console.WriteLine("Введите ккординаты первой точки - х");
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

Console.WriteLine(Math.Round(distance, 2));