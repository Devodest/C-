/* int n = new Random().Next(100, 1000);

Console.WriteLine(n);

int c1 = n / 100; // 1 цифра
int c2 = n / 10 % 10; // 2 цифра
int c3 = n % 10; // 3 цифра

Console.WriteLine($"2 цифра - {c2}.  Первая и 3 цифра, без 2 цифры: {c1}{c3}"); */


/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
 */

/* int a = new Random().Next(100, 1000);
int b = new Random().Next(100, 1000); */

/* Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No, mod " + a % b);

 */

 /* int a = new Random().Next(100, 1000);

 Console.WriteLine(a);
 string str = a.ToString();
 Console.WriteLine(str[0]);
 Console.WriteLine(str[2]);
 */

 /* 4. Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и
23.
 */

 /* int a = new Random().Next(100, 1000); */
/*  int a = int.Parse(Console.ReadLine());
 if (a % 7 == 0 && a % 23 == 0)
 {
     Console.WriteLine("Yes");
 }
 else Console.WriteLine("No"); */


/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
 */

/* int a = int.Parse(Console.ReadLine()); */
/* int a = new Random().Next(1, 1000000);
Console.WriteLine(a);
if (a < 100)
{
Console.WriteLine($"Нет третьего числа");
}
else 
{
    while (a >= 1000)
    {
        a /= 10;
    }
}
Console.WriteLine(a %= 10);
 */

 